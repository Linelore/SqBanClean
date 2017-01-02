using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> banList;

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = null;
                banList = new List<string>();
                openFileDialog1.ShowDialog();

                //Writes banlist file to list
                string line;
                System.IO.StreamReader file =
                   new System.IO.StreamReader(openFileDialog1.FileName);
                while ((line = file.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        banList.Add(line);
                    }
                }
                file.Close();

                updateScreen();
            }
            catch{ }
            
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            try
            {

                seperateLines();

                recursiveRemover();

                if (removeExpiredCheckBox.Checked == true)
                {
                    removeTempBans();
                }

                if (addDateCheckBox.Checked == true)
                {
                    addDate();
                }

                updateScreen();
            }
            catch
            {
                richTextBox1.Text = "ERROR";
            }
            
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (settingsPanel.Visible == false)
            {
                settingsPanel.Visible = true;
            }
            else
            {
                settingsPanel.Visible = false;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            for (int a = 0; banList.Count() > a; a++)
            {
                System.IO.File.WriteAllLines(openFileDialog1.FileName, banList);
            }
        }

        private void recursiveRemover()
        {
            for (int a = 0; banList.Count() > a; a++)
            {
                char[] c = banList[a].ToCharArray();
                if (c[18] == '0')
                {
                    string keep = banList[a];
                    banList.RemoveAt(a);
                    recursiveRemover();
                    banList.Add(keep);
                }
                else
                {
                    banList.RemoveAt(a);
                    recursiveRemover();
                }
            }
        }

        private void seperateLines()
        {
            //Splits bans that are on the same line
            for (int a = 0; banList.Count() > a; a++)
            {
                if (Regex.Matches(banList[a], "76561").Count > 1)
                {
                    string[] s = Regex.Split(banList[a], "76561");

                    for (int b = 0; s.Length > b; b++)
                    {
                        if (s[b] != "")
                        {
                            banList.Add("76561" + s[b]);
                        }
                    }

                    banList.RemoveAt(a);
                }
            }
        }

        private void removeTempBans()
        {
            //removes expired tempbans
            for (int a = 0; banList.Count() > a; a++)
            {
                char[] c = banList[a].ToCharArray();
                if (c[18] != '0')
                {
                    string[] sa = Regex.Split(banList[a], ":");
                    string s = sa[1].Remove(10);

                    double t = DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

                    if (Convert.ToInt32(s) < t)
                    {
                        banList.RemoveAt(a);
                        a = a - 1;
                    }
                }
            }
        }

        private void addDate()
        {
            //adds date of expirey to ban
            for (int a = 0; banList.Count() > a; a++)
            {
                char[] c = banList[a].ToCharArray();
                if (c[18] != '0')
                {
                    string[] sa = Regex.Split(banList[a], ":");
                    string s = sa[1].Remove(10);

                    if (c[c.Length - 1] != '#')
                    {
                        var banExpireDate = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(Convert.ToDouble(s));
                        banList[a] = banList[a] + " #" + banExpireDate.ToUniversalTime().ToString("yy/MM/dd/HH:mm:ss") + "#";
                    }


                }
            }
        }

        private void updateScreen()
        {
            richTextBox1.Text = null;
            for (int a = 0; banList.Count() > a; a++)
            {
                richTextBox1.Text = richTextBox1.Text + banList[a] + "\n";
            }
        }

        private void removeExpiredCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
