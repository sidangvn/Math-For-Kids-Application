﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Kids
{
    public partial class PlusForm : Form
    {
        Random rand = new Random();
        Menu menu = new Menu();
        PlusFromResult plusFormResult = new PlusFromResult();

        public static List<History> historyClass = new List<History>();

        public int count = 1;

        public class History
        {
            private string Question = "";
            private string Answer;
            private int Index = 1;

            bool Corrected;

            public bool Corrects
            {
                get { return Corrected; }
                set { Corrected = value; }
            }

            public string Questions
            {
                get { return Question; }
                set { Question = value; }
            }

            public string Answers
            {
                get { return Answer; }
                set { Answer = value; }
            }
            public int Indexes
            {
                get { return Index; }
                set { Index = value; }
            }

        }


        public PlusForm()
        {
            InitializeComponent();

            btNext.Enabled = false;
            btDone.Hide();
            btCheckResult.Hide();

            lbName.Text = menu.NameShow();

            countRandom();

            tbInput.Select();
            tbInput.MaxLength = 3;
            tbInput.KeyPress += TextBox1_KeyPress;

            lbScore.Text = menu.ScoreShow();

            lbQuestionNumber.Text = "Question: " + count.ToString() + "/10";
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
            DialogResult res = System.Windows.Forms.MessageBox.Show("Do you want to quit?", "Quit...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return res;
        }

        public void clearData()
        {
            historyClass.Clear();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
                EnterKeyPress();
        }

        public int returnLeftNum()
        {
            return rand.Next(count * 5, count * 10);
        }

        public int returnRightNum()
        {
            return rand.Next(count * 5, count * 10);
        }

        public int returnLeftNum(int num)
        {
            return rand.Next(num * 5, num * 10);
        }

        public int returnRightNum(int num)
        {
            return rand.Next(num * 5, num * 10);
        }

        private void leftNumShow()
        {
            lbLeftNum.Text = returnLeftNum().ToString();
        }

        public void righNumShow()
        {
            lbRightNum.Text = returnRightNum().ToString();
        }

        public void countRandom()
        {
            leftNumShow();
            righNumShow();    
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbLeftNum_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            EnterKeyPress();
        }


        private void EnterKeyPress()
        {
            bool checks = true;
            int answer = 0;
            int left = int.Parse(lbLeftNum.Text);
            int right = int.Parse(lbRightNum.Text);

            bool checker = true;
            while (checker)
            {
                try
                {
                    answer = int.Parse(tbInput.Text);
                }
                catch
                {
                    MessageBox.Show("Number Only!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    checker = true;
                    return;
                }
                checker = false;
            }

            if (answer == (left + right))
            {
                lbNoti.Text = "Congrats! You earned 1 point!";
                menu.setScore(1);
                lbScore.Text = menu.ScoreShow();
            }
            else
            {
                lbNoti.Text = "Sorry! The answer is " + (left + right).ToString() + ". You lost 1 point";
                lbScore.Text = menu.ScoreShow();
                checks = false;
            }

            btCheck.Enabled = false;
            btNext.Enabled = true;
            tbInput.Enabled = false;

            History history = new History();

            history.Questions = left.ToString() + " + " + right.ToString();
            history.Answers = " = " + answer.ToString();
            history.Indexes = count;
            history.Corrects = checks;

            historyClass.Add(history);
        }

        public string outPutHistory()
        {
            string outPut = "Number".PadRight(15) + 
                            "Question".PadRight(15) + 
                            "Your Answer".PadRight(15) + 
                            "Result".PadRight(15) + 
                            System.Environment.NewLine;

            for(int i = 0; i < historyClass.Count; i++)
            {
                outPut += "#" + historyClass[i].Indexes + ": ".PadRight(30) +
                                historyClass[i].Questions.PadRight(30) +
                                historyClass[i].Answers + " ".PadRight(30) +
                                historyClass[i].Corrects +
                                System.Environment.NewLine;
            }

            outPut += System.Environment.NewLine + menu.ScoreShow();

            return outPut;
        }


        private void btBack_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();

            result = MessageBox.Show("Are You Sure?", "Go Back", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            while (true)
            {
                if (result == DialogResult.OK)
                {
                    FormPlus formPlus = new FormPlus();

                    formPlus.Show();
                    this.Hide();
                    break;
                }
                else
                {
                    break;
                }
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            tbInput.Enabled = true;
            lbNoti.Text = "";
            countRandom();
            tbInput.Clear();
            tbInput.Select();
            tbInput.MaxLength = 3;

            btCheck.Enabled = true;
            btNext.Enabled = false;
            count++;

            if (count <= 10)
            {
                lbQuestionNumber.Text = "Question: " + count.ToString() + "/10";
            }

            if(count > 10)
            {
                btCheckResult.Show();
                lbQuestionNumber.Hide();
                btDone.Show();
                btNext.Hide();
                btCheck.Hide();

                lbLeftNum.Text = "FINISHED!";
                lbRightNum.Text = "";
                lbPlus.Text = "";
                lbEqual.Text = "";
                tbInput.Hide();
                lbNoti.Hide();
                btCheckResult.Select();
            }
        }

        private void btDone_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();

            result = MessageBox.Show("Are You Sure?", "Go Back", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            while (true)
            {
                if (result == DialogResult.OK)
                {
                    menu.Show();
                    this.Hide();
                    break;
                }
                else
                {
                    break;
                }
            }

            
        }

        private void PlusForm_Load(object sender, EventArgs e)
        {

        }

        private void btCheckResult_Click(object sender, EventArgs e)
        {
            plusFormResult.Show();
            this.Hide();
        }
    }
}
