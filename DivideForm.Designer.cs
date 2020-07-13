namespace Kids
{
    partial class DivideForm
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
            this.btNext = new System.Windows.Forms.Button();
            this.btDone = new System.Windows.Forms.Button();
            this.btCheckResult = new System.Windows.Forms.Button();
            this.lbLeftNum = new System.Windows.Forms.Label();
            this.lbDivide = new System.Windows.Forms.Label();
            this.lbRightNum = new System.Windows.Forms.Label();
            this.lbEqual = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lbNoti = new System.Windows.Forms.Label();
            this.lbQuestionNumber = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.btCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btBack.Location = new System.Drawing.Point(23, 397);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(110, 41);
            this.btBack.TabIndex = 0;
            this.btBack.Text = "BACK";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btNext
            // 
            this.btNext.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btNext.Location = new System.Drawing.Point(680, 397);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(99, 41);
            this.btNext.TabIndex = 1;
            this.btNext.Text = "NEXT";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btDone
            // 
            this.btDone.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btDone.Location = new System.Drawing.Point(652, 397);
            this.btDone.Name = "btDone";
            this.btDone.Size = new System.Drawing.Size(113, 41);
            this.btDone.TabIndex = 2;
            this.btDone.Text = "MENU";
            this.btDone.UseVisualStyleBackColor = true;
            this.btDone.Click += new System.EventHandler(this.btDone_Click);
            // 
            // btCheckResult
            // 
            this.btCheckResult.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCheckResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btCheckResult.Location = new System.Drawing.Point(334, 397);
            this.btCheckResult.Name = "btCheckResult";
            this.btCheckResult.Size = new System.Drawing.Size(114, 41);
            this.btCheckResult.TabIndex = 3;
            this.btCheckResult.Text = "RESULT";
            this.btCheckResult.UseVisualStyleBackColor = true;
            this.btCheckResult.Click += new System.EventHandler(this.btCheckResult_Click);
            // 
            // lbLeftNum
            // 
            this.lbLeftNum.AutoSize = true;
            this.lbLeftNum.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLeftNum.ForeColor = System.Drawing.Color.Teal;
            this.lbLeftNum.Location = new System.Drawing.Point(12, 110);
            this.lbLeftNum.Name = "lbLeftNum";
            this.lbLeftNum.Size = new System.Drawing.Size(147, 119);
            this.lbLeftNum.TabIndex = 4;
            this.lbLeftNum.Text = "10";
            // 
            // lbDivide
            // 
            this.lbDivide.AutoSize = true;
            this.lbDivide.BackColor = System.Drawing.Color.Transparent;
            this.lbDivide.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDivide.Location = new System.Drawing.Point(219, 110);
            this.lbDivide.Name = "lbDivide";
            this.lbDivide.Size = new System.Drawing.Size(91, 119);
            this.lbDivide.TabIndex = 5;
            this.lbDivide.Text = "/";
            // 
            // lbRightNum
            // 
            this.lbRightNum.AutoSize = true;
            this.lbRightNum.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRightNum.ForeColor = System.Drawing.Color.Purple;
            this.lbRightNum.Location = new System.Drawing.Point(301, 110);
            this.lbRightNum.Name = "lbRightNum";
            this.lbRightNum.Size = new System.Drawing.Size(147, 119);
            this.lbRightNum.TabIndex = 6;
            this.lbRightNum.Text = "10";
            // 
            // lbEqual
            // 
            this.lbEqual.AutoSize = true;
            this.lbEqual.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEqual.Location = new System.Drawing.Point(489, 114);
            this.lbEqual.Name = "lbEqual";
            this.lbEqual.Size = new System.Drawing.Size(98, 119);
            this.lbEqual.TabIndex = 7;
            this.lbEqual.Text = "=";
            this.lbEqual.Click += new System.EventHandler(this.lbEqual_Click);
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbInput.Location = new System.Drawing.Point(593, 107);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(195, 126);
            this.tbInput.TabIndex = 8;
            // 
            // lbNoti
            // 
            this.lbNoti.AutoSize = true;
            this.lbNoti.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNoti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbNoti.Location = new System.Drawing.Point(89, 250);
            this.lbNoti.Name = "lbNoti";
            this.lbNoti.Size = new System.Drawing.Size(0, 27);
            this.lbNoti.TabIndex = 9;
            // 
            // lbQuestionNumber
            // 
            this.lbQuestionNumber.AutoSize = true;
            this.lbQuestionNumber.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbQuestionNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbQuestionNumber.Location = new System.Drawing.Point(287, 397);
            this.lbQuestionNumber.Name = "lbQuestionNumber";
            this.lbQuestionNumber.Size = new System.Drawing.Size(0, 27);
            this.lbQuestionNumber.TabIndex = 10;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbName.Location = new System.Drawing.Point(23, 13);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 27);
            this.lbName.TabIndex = 11;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbScore.Location = new System.Drawing.Point(23, 62);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(0, 27);
            this.lbScore.TabIndex = 12;
            // 
            // btCheck
            // 
            this.btCheck.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btCheck.Location = new System.Drawing.Point(625, 250);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(113, 47);
            this.btCheck.TabIndex = 13;
            this.btCheck.Text = "CHECK";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // DivideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbQuestionNumber);
            this.Controls.Add(this.lbNoti);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lbEqual);
            this.Controls.Add(this.lbRightNum);
            this.Controls.Add(this.lbDivide);
            this.Controls.Add(this.lbLeftNum);
            this.Controls.Add(this.btCheckResult);
            this.Controls.Add(this.btDone);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DivideForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math for Kids";
            this.Load += new System.EventHandler(this.DivideForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btDone;
        private System.Windows.Forms.Button btCheckResult;
        private System.Windows.Forms.Label lbLeftNum;
        private System.Windows.Forms.Label lbDivide;
        private System.Windows.Forms.Label lbRightNum;
        private System.Windows.Forms.Label lbEqual;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lbNoti;
        private System.Windows.Forms.Label lbQuestionNumber;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Button btCheck;
    }
}