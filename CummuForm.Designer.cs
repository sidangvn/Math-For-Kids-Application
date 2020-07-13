namespace Kids
{
    partial class CummuForm
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
            this.lbQuestionNumber = new System.Windows.Forms.Label();
            this.lbLeftNum = new System.Windows.Forms.Label();
            this.lbSign = new System.Windows.Forms.Label();
            this.lbRightNum = new System.Windows.Forms.Label();
            this.lbEqual = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btCheck = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbNoti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btBack.Location = new System.Drawing.Point(23, 399);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(108, 39);
            this.btBack.TabIndex = 0;
            this.btBack.Text = "BACK";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btNext
            // 
            this.btNext.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btNext.Location = new System.Drawing.Point(677, 399);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(97, 39);
            this.btNext.TabIndex = 1;
            this.btNext.Text = "NEXT";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btDone
            // 
            this.btDone.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btDone.Location = new System.Drawing.Point(650, 399);
            this.btDone.Name = "btDone";
            this.btDone.Size = new System.Drawing.Size(108, 39);
            this.btDone.TabIndex = 2;
            this.btDone.Text = "MENU";
            this.btDone.UseVisualStyleBackColor = true;
            this.btDone.Click += new System.EventHandler(this.btDone_Click);
            // 
            // btCheckResult
            // 
            this.btCheckResult.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCheckResult.ForeColor = System.Drawing.Color.Olive;
            this.btCheckResult.Location = new System.Drawing.Point(354, 399);
            this.btCheckResult.Name = "btCheckResult";
            this.btCheckResult.Size = new System.Drawing.Size(107, 39);
            this.btCheckResult.TabIndex = 3;
            this.btCheckResult.Text = "RESULT";
            this.btCheckResult.UseVisualStyleBackColor = true;
            this.btCheckResult.Click += new System.EventHandler(this.btCheckResult_Click);
            // 
            // lbQuestionNumber
            // 
            this.lbQuestionNumber.AutoSize = true;
            this.lbQuestionNumber.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbQuestionNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbQuestionNumber.Location = new System.Drawing.Point(285, 399);
            this.lbQuestionNumber.Name = "lbQuestionNumber";
            this.lbQuestionNumber.Size = new System.Drawing.Size(0, 27);
            this.lbQuestionNumber.TabIndex = 4;
            // 
            // lbLeftNum
            // 
            this.lbLeftNum.AutoSize = true;
            this.lbLeftNum.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLeftNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbLeftNum.Location = new System.Drawing.Point(23, 137);
            this.lbLeftNum.Name = "lbLeftNum";
            this.lbLeftNum.Size = new System.Drawing.Size(147, 119);
            this.lbLeftNum.TabIndex = 5;
            this.lbLeftNum.Text = "10";
            // 
            // lbSign
            // 
            this.lbSign.AutoSize = true;
            this.lbSign.BackColor = System.Drawing.Color.Transparent;
            this.lbSign.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSign.Location = new System.Drawing.Point(204, 137);
            this.lbSign.Name = "lbSign";
            this.lbSign.Size = new System.Drawing.Size(102, 119);
            this.lbSign.TabIndex = 6;
            this.lbSign.Text = "+";
            this.lbSign.Click += new System.EventHandler(this.lbSign_Click);
            // 
            // lbRightNum
            // 
            this.lbRightNum.AutoSize = true;
            this.lbRightNum.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRightNum.ForeColor = System.Drawing.Color.Purple;
            this.lbRightNum.Location = new System.Drawing.Point(312, 137);
            this.lbRightNum.Name = "lbRightNum";
            this.lbRightNum.Size = new System.Drawing.Size(147, 119);
            this.lbRightNum.TabIndex = 7;
            this.lbRightNum.Text = "10";
            this.lbRightNum.Click += new System.EventHandler(this.lbRightNum_Click);
            // 
            // lbEqual
            // 
            this.lbEqual.AutoSize = true;
            this.lbEqual.BackColor = System.Drawing.Color.Transparent;
            this.lbEqual.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEqual.Location = new System.Drawing.Point(487, 137);
            this.lbEqual.Name = "lbEqual";
            this.lbEqual.Size = new System.Drawing.Size(98, 119);
            this.lbEqual.TabIndex = 8;
            this.lbEqual.Text = "=";
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbInput.Location = new System.Drawing.Point(581, 137);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(193, 126);
            this.tbInput.TabIndex = 9;
            // 
            // btCheck
            // 
            this.btCheck.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btCheck.Location = new System.Drawing.Point(648, 280);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(110, 46);
            this.btCheck.TabIndex = 10;
            this.btCheck.Text = "CHECK";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.ForeColor = System.Drawing.Color.Green;
            this.lbName.Location = new System.Drawing.Point(23, 13);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 27);
            this.lbName.TabIndex = 11;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbScore.Location = new System.Drawing.Point(23, 66);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(0, 27);
            this.lbScore.TabIndex = 12;
            // 
            // lbNoti
            // 
            this.lbNoti.AutoSize = true;
            this.lbNoti.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNoti.ForeColor = System.Drawing.Color.Purple;
            this.lbNoti.Location = new System.Drawing.Point(63, 260);
            this.lbNoti.Name = "lbNoti";
            this.lbNoti.Size = new System.Drawing.Size(0, 27);
            this.lbNoti.TabIndex = 13;
            // 
            // CummuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbNoti);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lbEqual);
            this.Controls.Add(this.lbRightNum);
            this.Controls.Add(this.lbSign);
            this.Controls.Add(this.lbLeftNum);
            this.Controls.Add(this.lbQuestionNumber);
            this.Controls.Add(this.btCheckResult);
            this.Controls.Add(this.btDone);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CummuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math for Kids";
            this.Load += new System.EventHandler(this.CummuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btDone;
        private System.Windows.Forms.Button btCheckResult;
        private System.Windows.Forms.Label lbQuestionNumber;
        private System.Windows.Forms.Label lbLeftNum;
        private System.Windows.Forms.Label lbSign;
        private System.Windows.Forms.Label lbRightNum;
        private System.Windows.Forms.Label lbEqual;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbNoti;
    }
}