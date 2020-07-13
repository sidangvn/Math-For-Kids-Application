using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kids
{
    public partial class PlusFromResult : Form
    {
        Menu menu = new Menu();
        FormPlus formOption = new FormPlus();

        public PlusFromResult()
        {
            InitializeComponent();
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

        private void btBack_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();

            result = MessageBox.Show("Are You Sure?", "Go Back", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            while (true)
            {
                if (result == DialogResult.OK)
                {
                    PlusForm plusForm = new PlusForm();
                    plusForm.clearData();
                    formOption.Show();
                    this.Hide();
                    break;
                }
                else
                {
                    break;
                }
            }            
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();

            result = MessageBox.Show("Are You Sure?", "Go Back", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            while (true)
            {
                if (result == DialogResult.OK)
                {
                    PlusForm plusForm = new PlusForm();
                    plusForm.clearData();
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

        private void PlusFromResult_Load(object sender, EventArgs e)
        {
            PlusForm plusForm = new PlusForm();
            lbShowResults.Text = plusForm.outPutHistory();
        }
    }
}
