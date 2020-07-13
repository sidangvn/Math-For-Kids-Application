using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kids
{
    public partial class Menu : Form
    {       
        private static string filePath = @"C:\MathForKids\Name.txt";
        private static string filePathScore = @"C:\MathForKids\Score.txt";

        private static string NameUser = "";

        private static int Score = 0;

        public Menu()
        {
            InitializeComponent();
            tbNameType.Hide();
            btEnter.Hide();
            btChangeName.Hide();

            if(!Directory.Exists(@"C:\MathForKids"))
            {
                Directory.CreateDirectory(@"C:\MathForKids");
            }

            if (File.Exists(filePath))
            {
                StreamReader nameRead = new StreamReader(filePath);
                NameUser = nameRead.ReadLine();
                nameRead.Close();
            }

            if (!File.Exists(filePathScore))
            {
                FileStream fs = File.Create(@"C:\MathForKids\Score.txt");
                fs.Close();

            }

            lbNameShow.Text = NameShow();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private DialogResult PreClosingConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show("Do you want to quit?", "Quit...", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            return res;
        }

        private void btNameType_Click(object sender, EventArgs e)
        {
           

            FileStream fs = File.Create(@"C:\MathForKids\Name.txt");
            fs.Close();

            StreamWriter nameWrite = new StreamWriter(filePath);
            nameWrite.Write("There");
            nameWrite.Close();

            btNameType.Hide();
            tbNameType.Show();
            btEnter.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (PreClosingConfirmation() == DialogResult.Yes)
                {
                    Dispose(true);
                    this.Close();
                    Environment.Exit(0);
                    break;
                }
                else
                {
                    break;
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            StreamWriter nameWrite = new StreamWriter(filePath);
            nameWrite.Write(tbNameType.Text);
            nameWrite.Close();

            StreamReader nameRead = new StreamReader(filePath);
            NameUser = nameRead.ReadLine();
            nameRead.Close();

            lbNameShow.Text = NameShow();

            btEnter.Hide();
            tbNameType.Hide();
            btChangeName.Show();  
        }

        private void btChangeName_Click(object sender, EventArgs e)
        {
            tbNameType.Show();
            btEnter.Show();
            btChangeName.Hide();
        }

        private void btLetPlay_Click(object sender, EventArgs e)
        {
            NameUser = tbNameType.Text;
            FormPlus formPlus = new FormPlus();

            this.Hide();
            formPlus.Show();
        }

        public string NameShow()
        {
            return ("Hi! " + NameUser);
        }

        public void setScore(int val)
        {
            if (val == 1)
            {
                Score += val;
            }
            else
            {
                Score -= 1;
            }

            if (Score < 0)
            {
                Score = 0;
            }
            
            StreamWriter nameWrite = new StreamWriter(filePathScore);
            nameWrite.Write(Score);
            nameWrite.Close();
        }

        public string ScoreShow()
        {
            return ("Your Score: " + Score.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            resetScore();
        }

        public void resetScore()
        {
            if (File.Exists(filePathScore))
            {
                Score = 0;

                StreamWriter nameWrite = new StreamWriter(filePathScore);
                nameWrite.Write(Score);
                nameWrite.Close();
            }
            MessageBox.Show("Done!", "Reset Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
