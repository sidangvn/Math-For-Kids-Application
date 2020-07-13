namespace Kids
{
    partial class MultiForm
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
            this.btNext = new System.Windows.Forms.Button();
            this.btDone = new System.Windows.Forms.Button();
            this.btCheckResult = new System.Windows.Forms.Button();
            this.lbQuestionNumber = new System.Windows.Forms.Label();
            this.lbLeftNum = new System.Windows.Forms.Label();
            this.lbMulti = new System.Windows.Forms.Label();
            this.lbRightNum = new System.Windows.Forms.Label();
            this.lbEqual = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btCheck = new System.Windows.Forms.Button();
            this.lbNoti = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btNext
            // 
            this.btNext.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btNext.ForeColor = System.Drawing.Color.Blue;
            this.btNext.Location = new System.Drawing.Point(685, 396);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(103, 42);
            this.btNext.TabIndex = 1;
            this.btNext.Text = "NEXT";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btDone
            // 
            this.btDone.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDone.ForeColor = System.Drawing.Color.Blue;
            this.btDone.Location = new System.Drawing.Point(668, 396);
            this.btDone.Name = "btDone";
            this.btDone.Size = new System.Drawing.Size(108, 42);
            this.btDone.TabIndex = 2;
            this.btDone.Text = "MENU";
            this.btDone.UseVisualStyleBackColor = true;
            this.btDone.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // btCheckResult
            // 
            this.btCheckResult.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCheckResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btCheckResult.Location = new System.Drawing.Point(335, 392);
            this.btCheckResult.Name = "btCheckResult";
            this.btCheckResult.Size = new System.Drawing.Size(116, 46);
            this.btCheckResult.TabIndex = 3;
            this.btCheckResult.Text = "RESULT";
            this.btCheckResult.UseVisualStyleBackColor = true;
            this.btCheckResult.Click += new System.EventHandler(this.btChecklResult_Click);
            // 
            // lbQuestionNumber
            // 
            this.lbQuestionNumber.AutoSize = true;
            this.lbQuestionNumber.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbQuestionNumber.ForeColor = System.Drawing.Color.Teal;
            this.lbQuestionNumber.Location = new System.Drawing.Point(320, 396);
            this.lbQuestionNumber.Name = "lbQuestionNumber";
            this.lbQuestionNumber.Size = new System.Drawing.Size(0, 27);
            this.lbQuestionNumber.TabIndex = 4;
            // 
            // lbLeftNum
            // 
            this.lbLeftNum.AutoSize = true;
            this.lbLeftNum.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLeftNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbLeftNum.Location = new System.Drawing.Point(12, 114);
            this.lbLeftNum.Name = "lbLeftNum";
            this.lbLeftNum.Size = new System.Drawing.Size(147, 119);
            this.lbLeftNum.TabIndex = 5;
            this.lbLeftNum.Text = "10";
            // 
            // lbMulti
            // 
            this.lbMulti.AutoSize = true;
            this.lbMulti.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMulti.ForeColor = System.Drawing.Color.Black;
            this.lbMulti.Location = new System.Drawing.Point(165, 147);
            this.lbMulti.Name = "lbMulti";
            this.lbMulti.Size = new System.Drawing.Size(81, 79);
            this.lbMulti.TabIndex = 6;
            this.lbMulti.Text = "x";
            this.lbMulti.Click += new System.EventHandler(this.lbMulti_Click);
            // 
            // lbRightNum
            // 
            this.lbRightNum.AutoSize = true;
            this.lbRightNum.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRightNum.ForeColor = System.Drawing.Color.Olive;
            this.lbRightNum.Location = new System.Drawing.Point(278, 114);
            this.lbRightNum.Name = "lbRightNum";
            this.lbRightNum.Size = new System.Drawing.Size(147, 119);
            this.lbRightNum.TabIndex = 7;
            this.lbRightNum.Text = "10";
            // 
            // lbEqual
            // 
            this.lbEqual.AutoSize = true;
            this.lbEqual.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEqual.Location = new System.Drawing.Point(431, 114);
            this.lbEqual.Name = "lbEqual";
            this.lbEqual.Size = new System.Drawing.Size(98, 119);
            this.lbEqual.TabIndex = 8;
            this.lbEqual.Text = "=";
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbInput.ForeColor = System.Drawing.Color.Purple;
            this.tbInput.Location = new System.Drawing.Point(568, 111);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(208, 126);
            this.tbInput.TabIndex = 9;
            this.tbInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btCheck
            // 
            this.btCheck.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btCheck.Location = new System.Drawing.Point(664, 254);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(112, 43);
            this.btCheck.TabIndex = 10;
            this.btCheck.Text = "CHECK";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbNoti
            // 
            this.lbNoti.AutoSize = true;
            this.lbNoti.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNoti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbNoti.Location = new System.Drawing.Point(81, 254);
            this.lbNoti.Name = "lbNoti";
            this.lbNoti.Size = new System.Drawing.Size(0, 27);
            this.lbNoti.TabIndex = 11;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbName.Location = new System.Drawing.Point(36, 13);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 27);
            this.lbName.TabIndex = 12;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbScore.Location = new System.Drawing.Point(36, 73);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(0, 27);
            this.lbScore.TabIndex = 13;
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btBack.ForeColor = System.Drawing.Color.Blue;
            this.btBack.Location = new System.Drawing.Point(36, 396);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(111, 42);
            this.btBack.TabIndex = 14;
            this.btBack.Text = "BACK";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click_1);
            // 
            // MultiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbNoti);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lbEqual);
            this.Controls.Add(this.lbRightNum);
            this.Controls.Add(this.lbMulti);
            this.Controls.Add(this.lbLeftNum);
            this.Controls.Add(this.lbQuestionNumber);
            this.Controls.Add(this.btCheckResult);
            this.Controls.Add(this.btDone);
            this.Controls.Add(this.btNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MultiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math for Kids";
            this.Load += new System.EventHandler(this.MultiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btDone;
        private System.Windows.Forms.Button btShowResult;
        private System.Windows.Forms.Button btCheckResult;
        private System.Windows.Forms.Label lbQuestionNumber;
        private System.Windows.Forms.Label lbLeft;
        private System.Windows.Forms.Label lbLeftNum;
        private System.Windows.Forms.Label lbMulti;
        private System.Windows.Forms.Label lbRightNum;
        private System.Windows.Forms.Label lbEqual;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Label lbNoti;
        private System.Windows.Forms.Label lnName;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btBack;
    }
}