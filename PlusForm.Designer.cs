namespace Kids
{
    partial class PlusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btBack = new System.Windows.Forms.Button();
            this.lbLeftNum = new System.Windows.Forms.Label();
            this.lbPlus = new System.Windows.Forms.Label();
            this.lbRightNum = new System.Windows.Forms.Label();
            this.lbEqual = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btCheck = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.lbNoti = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbQuestionNumber = new System.Windows.Forms.Label();
            this.btDone = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.btCheckResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btBack.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btBack.Location = new System.Drawing.Point(55, 373);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(116, 46);
            this.btBack.TabIndex = 0;
            this.btBack.Text = "BACK";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // lbLeftNum
            // 
            this.lbLeftNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbLeftNum.AutoSize = true;
            this.lbLeftNum.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLeftNum.ForeColor = System.Drawing.Color.Green;
            this.lbLeftNum.Location = new System.Drawing.Point(24, 111);
            this.lbLeftNum.Name = "lbLeftNum";
            this.lbLeftNum.Size = new System.Drawing.Size(147, 119);
            this.lbLeftNum.TabIndex = 1;
            this.lbLeftNum.Text = "10";
            this.lbLeftNum.Click += new System.EventHandler(this.lbLeftNum_Click);
            // 
            // lbPlus
            // 
            this.lbPlus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPlus.AutoSize = true;
            this.lbPlus.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPlus.Location = new System.Drawing.Point(157, 111);
            this.lbPlus.Name = "lbPlus";
            this.lbPlus.Size = new System.Drawing.Size(102, 119);
            this.lbPlus.TabIndex = 2;
            this.lbPlus.Text = "+";
            // 
            // lbRightNum
            // 
            this.lbRightNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRightNum.AutoSize = true;
            this.lbRightNum.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRightNum.ForeColor = System.Drawing.Color.Navy;
            this.lbRightNum.Location = new System.Drawing.Point(285, 111);
            this.lbRightNum.Name = "lbRightNum";
            this.lbRightNum.Size = new System.Drawing.Size(147, 119);
            this.lbRightNum.TabIndex = 3;
            this.lbRightNum.Text = "10";
            // 
            // lbEqual
            // 
            this.lbEqual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEqual.AutoSize = true;
            this.lbEqual.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEqual.Location = new System.Drawing.Point(438, 111);
            this.lbEqual.Name = "lbEqual";
            this.lbEqual.Size = new System.Drawing.Size(98, 119);
            this.lbEqual.TabIndex = 4;
            this.lbEqual.Text = "=";
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbInput.ForeColor = System.Drawing.Color.Olive;
            this.tbInput.Location = new System.Drawing.Point(555, 108);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(184, 126);
            this.tbInput.TabIndex = 5;
            this.tbInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbInput.Enter += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btCheck
            // 
            this.btCheck.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCheck.ForeColor = System.Drawing.Color.Red;
            this.btCheck.Location = new System.Drawing.Point(592, 260);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(135, 53);
            this.btCheck.TabIndex = 6;
            this.btCheck.Text = "CHECK";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // btNext
            // 
            this.btNext.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btNext.Location = new System.Drawing.Point(604, 373);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(135, 46);
            this.btNext.TabIndex = 7;
            this.btNext.Text = "NEXT";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // lbNoti
            // 
            this.lbNoti.AutoSize = true;
            this.lbNoti.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNoti.ForeColor = System.Drawing.Color.Red;
            this.lbNoti.Location = new System.Drawing.Point(104, 277);
            this.lbNoti.Name = "lbNoti";
            this.lbNoti.Size = new System.Drawing.Size(0, 23);
            this.lbNoti.TabIndex = 8;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbScore.Location = new System.Drawing.Point(55, 61);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(0, 30);
            this.lbScore.TabIndex = 9;
            // 
            // lbQuestionNumber
            // 
            this.lbQuestionNumber.AutoSize = true;
            this.lbQuestionNumber.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbQuestionNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbQuestionNumber.Location = new System.Drawing.Point(315, 373);
            this.lbQuestionNumber.Name = "lbQuestionNumber";
            this.lbQuestionNumber.Size = new System.Drawing.Size(0, 27);
            this.lbQuestionNumber.TabIndex = 10;
            this.lbQuestionNumber.UseWaitCursor = true;
            // 
            // btDone
            // 
            this.btDone.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDone.ForeColor = System.Drawing.Color.Fuchsia;
            this.btDone.Location = new System.Drawing.Point(592, 373);
            this.btDone.Name = "btDone";
            this.btDone.Size = new System.Drawing.Size(135, 46);
            this.btDone.TabIndex = 11;
            this.btDone.Text = "MENU";
            this.btDone.UseVisualStyleBackColor = true;
            this.btDone.Click += new System.EventHandler(this.btDone_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbName.Location = new System.Drawing.Point(55, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 27);
            this.lbName.TabIndex = 12;
            // 
            // btCheckResult
            // 
            this.btCheckResult.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCheckResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btCheckResult.Location = new System.Drawing.Point(306, 373);
            this.btCheckResult.Name = "btCheckResult";
            this.btCheckResult.Size = new System.Drawing.Size(126, 46);
            this.btCheckResult.TabIndex = 14;
            this.btCheckResult.Text = "RESULT";
            this.btCheckResult.UseVisualStyleBackColor = true;
            this.btCheckResult.Click += new System.EventHandler(this.btCheckResult_Click);
            // 
            // PlusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCheckResult);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btDone);
            this.Controls.Add(this.lbQuestionNumber);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbNoti);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lbEqual);
            this.Controls.Add(this.lbRightNum);
            this.Controls.Add(this.lbPlus);
            this.Controls.Add(this.lbLeftNum);
            this.Controls.Add(this.btBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PlusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math for Kids";
            this.Load += new System.EventHandler(this.PlusForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label lbLeftNum;
        private System.Windows.Forms.Label lbPlus;
        private System.Windows.Forms.Label lbRightNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Label lbNoti;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbQuestionNumber;
        private System.Windows.Forms.Button btDone;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbEqual;
        private System.Windows.Forms.Button btCheckResult;
    }
}