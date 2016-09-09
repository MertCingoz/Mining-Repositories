using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Odev3
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            datePickerBefore.Format = DateTimePickerFormat.Custom;
            datePickerAfter.Format = DateTimePickerFormat.Custom;
            datePickerBefore.CustomFormat = "yyyy-MM-dd";
            datePickerAfter.CustomFormat = "yyyy-MM-dd";
            btnMatrix.Enabled = false;
            btnVisualize.Enabled = false;
            linkLabel1.Visible = false;
        }

        Dictionary<String, int> Commits = new Dictionary<String, int>();
        Dictionary<String, int[]> matrix = new Dictionary<String, int[]>();
        int[,] adjMatrix;
        bool[] topDev;

        private void btnGit_Click(object sender, EventArgs e)
        {
            label1.Text = "Information:";
            btnCommitter.Enabled = false;
            string repo = txtUrl.Text.Split('/').Last();

            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine("git clone "+txtUrl.Text);
            cmd.StandardInput.WriteLine("git --git-dir " + repo + "/.git log -p --after=\"" + datePickerAfter.Text + "\" --before=\"" + datePickerBefore.Text + "\" >raw.txt");
            cmd.StandardInput.WriteLine("git --git-dir " + repo + "/.git log --pretty=format:\"%an | %cd | %s\" --name-only --after=\"" + datePickerAfter.Text + "\" --before=\"" + datePickerBefore.Text + "\" >log.txt");
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            if (!Directory.Exists(repo))
            {
                MessageBox.Show("Reprository Not Found");
                return;
            }
            label1.Text += "\nData Extracted.";
            btnCommitter.Enabled = true;

            btnMatrix.Enabled = false;
            btnVisualize.Enabled = false;
            linkLabel1.Visible = false;
        }

        private void bntCommitter_Click(object sender, EventArgs e)
        {
            matrix.Clear();
            Commits.Clear();

            if (!File.Exists("log.txt"))
            {
                MessageBox.Show("Data not Found");
                return;
            }
            int commitCount = 0;
            using (var streamReader = File.OpenText("log.txt"))
            {
                var lines = streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string[] split;
                
                foreach (var line in lines)
                {
                    if (line != "")
                    {
                        split = line.Split('|');
                        if (split.Length > 1)
                        {
                            commitCount++;
                            if (Commits.ContainsKey(split[0].Trim()))
                                Commits[split[0].Trim()]++;
                            else
                                Commits.Add(split[0].Trim(), 1);
                        }
                    }
                }
            }
            btnMatrix.Enabled = true;
            btnCommitter.Enabled = false;
            label1.Text += "\nDevelopers count: " + Commits.Count + "\nCommits count: " + commitCount;
            File.WriteAllLines("Commits.txt", Commits.Select(x => "[" + x.Key + " " + x.Value + "]").ToArray());
        }

        private void btnMatrix_Click(object sender, EventArgs e)
        {

            using (var streamReader = File.OpenText("log.txt"))
            {
                var lines = streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string[] split;
                string committer = "";
                foreach (var line in lines)
                {
                    if (line != "")
                    {
                        split = line.Split('|');
                        if (split.Length > 1)
                            committer = split[0].Trim();
                        if (split.Length == 1)
                        {
                            if (matrix.ContainsKey(split[0].Trim()))
                            {
                                int index = GetIndex(committer);
                                if (matrix[split[0].Trim()][index] == 0)
                                    matrix[split[0].Trim()][index]++;
                            }
                            else
                                matrix.Add(split[0].Trim(), new int[Commits.Count]);
                        }
                    }
                }
            }
            btnMatrix.Enabled = false;
            btnVisualize.Enabled = true;
            label1.Text += "\nFile count: " + matrix.Count;
            File.WriteAllLines("Matrix.txt", matrix.Select(x => string.Join(" ", Array.ConvertAll(x.Value, y => y.ToString())) +"\t" + x.Key).ToArray());
        }

        private int GetIndex(string committer)
        {
            for (int i = 0; i < Commits.Count; i++)
            {
                if (Commits.Keys.ElementAt(i) == committer)
                    return i;
            }
            return 0;
        }

        private void btnVisualize_Click(object sender, EventArgs e)
        {
            if (Commits.Count == 0)
                return;
            int maxFile = 0;
            int maxCommit = Commits.Values.Max();
            adjMatrix = new int[Commits.Count, Commits.Count];

            for (int i = 0; i < Commits.Count; i++)
            {
                for (int j = i + 1; j < Commits.Count; j++)
                {
                    int fileCount = 0;
                    for (int k = 0; k < matrix.Count; k++)
                    {
                        if (matrix.ElementAt(k).Value[i] == 1 && matrix.ElementAt(k).Value[j] == 1)
                            fileCount++;

                        if (maxFile < fileCount)
                            maxFile = fileCount;
                    }
                    adjMatrix[i, j] = fileCount;
                }
            }

            writeToJson(maxFile, maxCommit);
            btnVisualize.Enabled = false;
            label1.Text += "\n\nYou can see visualization on firefox.";
            linkLabel1.Text = "visualization\\index.html";
            linkLabel1.Visible = true;
        }

        private void writeToJson(int maxFile, int maxCommit)
        {
            topDev = new bool[Commits.Count];
            string data = "{\n\t\"nodes\": [\n";
            string developers = "";
            string topDevelopers = "";
            string commitCount = "";
            string topCommitCount = "";
            var ordered = Commits.OrderByDescending(x => x.Value);
            for (int i = 0; i < Commits.Count; i++)
            {
                developers += "'" + Commits.ElementAt(i).Key + "',";
                commitCount += Commits.ElementAt(i).Value + ",";
                if (Commits.ElementAt(i).Value > ordered.ElementAt(Convert.ToInt32(Commits.Count * 8 / 10)).Value)
                {
                    topDev[i] = true;
                    topDevelopers += "'" + Commits.ElementAt(i).Key + "',";
                    topCommitCount += Commits.ElementAt(i).Value + ",";
                    data += "\n\t\t{\n";
                    data += "\t\t\t\"name\": \"" + Commits.ElementAt(i).Key + "\",\n";
                    data += "\t\t\t\"artist\": \"" + Commits.ElementAt(i).Value + " Commit\",\n";
                    data += "\t\t\t\"id\": \"" + i + "\",\n";
                    data += "\t\t\t\"playcount\": " + (Commits.ElementAt(i).Value * 50 / maxCommit + 1) + "\n";
                    data += "\t\t},\n";
                }

            }
            data = data.Substring(0, data.Length - 2);
            data += "\t],\n\t\"links\": [\n";

            for (int i = 0; i < Commits.Count; i++)
            {
                for (int j = i + 1; j < Commits.Count; j++)
                {
                    if (adjMatrix[i, j] != 0 && topDev[i] && topDev[j])
                    {
                        data += "\n\t\t{\n";
                        data += "\t\t\t\"source\": \"" + i + "\",\n";
                        data += "\t\t\t\"target\": \"" + j + "\",\n";
                        data += "\t\t\t\"value\": \"" + ((adjMatrix[i, j]) * 10 / maxFile + 1) + "\"\n";
                        data += "\t\t},\n";
                        j++;
                    }
                }
            }

            data = data.Substring(0, data.Length - 2);
            data += "\t]\n}";
            File.WriteAllText("visualization\\data\\data.json", data);


            developers = developers.Substring(0, developers.Length - 1);
            commitCount = commitCount.Substring(0, commitCount.Length - 1);
            File.WriteAllText("visualization\\data\\developers.js", "var data = [{\n\tx: [" + developers + "],\n\ty: [" + commitCount + "],\n\ttype: 'bar'\n}];");

            topDevelopers = topDevelopers.Substring(0, topDevelopers.Length - 1);
            topCommitCount = topCommitCount.Substring(0, topCommitCount.Length - 1);
            File.WriteAllText("visualization\\data\\pie.js", "var data2 = [{\n\tlabels: [" + topDevelopers + "],\n\tvalues: [" + topCommitCount + "],\n\ttype: 'pie'\n}];");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("firefox.exe", Directory.GetCurrentDirectory() + "\\" + linkLabel1.Text);
        }


    }
}
