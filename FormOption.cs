using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kids
{
    public partial class FormPlus : Form
    {
        Menu menu = new Menu();
        

        public FormPlus()
        {
            InitializeComponent();
            lbScore.Text = menu.ScoreShow();

            btResetScore.Select();
                
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MultiForm multiForm = new MultiForm();
            multiForm.Show();
            this.Hide();
        }

        private void FormPlus_Load(object sender, EventArgs e)
        {
            lbName.Text = menu.NameShow();
            lbScore.Text = menu.ScoreShow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MinusForm minusForm = new MinusForm();
            minusForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu menuForm = new Menu();
            menuForm.Show();
        }

        private void btQuit_Click(object sender, EventArgs e)
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

        private void btPlus_Click(object sender, EventArgs e)
        {
            PlusForm plusForm = new PlusForm();

            plusForm.Show();

            this.Hide();
        }

        private void btResetScore_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();

            result = MessageBox.Show("Are You Sure?", "Reset Score", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            while (true)
            {
                if (result == DialogResult.OK)
                {
                    menu.resetScore();
                    lbScore.Text = menu.ScoreShow();
                    break;
                }
                else
                {
                    break;
                }
            }
        }

        private void btDivide_Click(object sender, EventArgs e)
        {
            DivideForm divideForm = new DivideForm();

            divideForm.Show();
            this.Hide();
        }

        private void btCummulative_Click(object sender, EventArgs e)
        {
            CummuForm cummuForm = new CummuForm();
            cummuForm.Show();
            this.Hide();
        }
    }
}
