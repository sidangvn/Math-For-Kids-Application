namespace Kids
{
    partial class MinusForm
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
            this.lbLeftNum = new System.Windows.Forms.Label();
            this.lbMinus = new System.Windows.Forms.Label();
            this.lbRightNum = new System.Windows.Forms.Label();
            this.lbEqual = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btCheck = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbNoti = new System.Windows.Forms.Label();
            this.btCheckResult = new System.Windows.Forms.Button();
            this.btDone = new System.Windows.Forms.Button();
            this.lbQuestionNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btBack.Location = new System.Drawing.Point(30, 385);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(120, 53);
            this.btBack.TabIndex = 0;
            this.btBack.Text = "BACK";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btNext
            // 
            this.btNext.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btNext.Location = new System.Drawing.Point(645, 385);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(120, 53);
            this.btNext.TabIndex = 0;
            this.btNext.Text = "NEXT";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // lbLeftNum
            // 
            this.lbLeftNum.AutoSize = true;
            this.lbLeftNum.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLeftNum.ForeColor = System.Drawing.Color.Green;
            this.lbLeftNum.Location = new System.Drawing.Point(30, 119);
            this.lbLeftNum.Name = "lbLeftNum";
            this.lbLeftNum.Size = new System.Drawing.Size(147, 119);
            this.lbLeftNum.TabIndex = 1;
            this.lbLeftNum.Text = "10";
            this.lbLeftNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbMinus
            // 
            this.lbMinus.AutoSize = true;
            this.lbMinus.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMinus.Location = new System.Drawing.Point(175, 119);
            this.lbMinus.Name = "lbMinus";
            this.lbMinus.Size = new System.Drawing.Size(90, 119);
            this.lbMinus.TabIndex = 2;
            this.lbMinus.Text = "-";
            // 
            // lbRightNum
            // 
            this.lbRightNum.AutoSize = true;
            this.lbRightNum.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRightNum.ForeColor = System.Drawing.Color.Maroon;
            this.lbRightNum.Location = new System.Drawing.Point(281, 119);
            this.lbRightNum.Name = "lbRightNum";
            this.lbRightNum.Size = new System.Drawing.Size(147, 119);
            this.lbRightNum.TabIndex = 3;
            this.lbRightNum.Text = "10";
            // 
            // lbEqual
            // 
            this.lbEqual.AutoSize = true;
            this.lbEqual.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEqual.Location = new System.Drawing.Point(454, 119);
            this.lbEqual.Name = "lbEqual";
            this.lbEqual.Size = new System.Drawing.Size(98, 119);
            this.lbEqual.TabIndex = 4;
            this.lbEqual.Text = "=";
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbInput.Location = new System.Drawing.Point(577, 116);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(175, 126);
            this.tbInput.TabIndex = 5;
            // 
            // btCheck
            // 
            this.btCheck.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btCheck.Location = new System.Drawing.Point(612, 256);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(110, 45);
            this.btCheck.TabIndex = 6;
            this.btCheck.Text = "CHECK";
            this.btCheck.UseVisualStyleBackColor = true;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbName.Location = new System.Drawing.Point(30, 13);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 27);
            this.lbName.TabIndex = 7;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbScore.Location = new System.Drawing.Point(30, 62);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(0, 27);
            this.lbScore.TabIndex = 8;
            // 
            // lbNoti
            // 
            this.lbNoti.AutoSize = true;
            this.lbNoti.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNoti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbNoti.Location = new System.Drawing.Point(67, 274);
            this.lbNoti.Name = "lbNoti";
            this.lbNoti.Size = new System.Drawing.Size(0, 27);
            this.lbNoti.TabIndex = 9;
            // 
            // btCheckResult
            // 
            this.btCheckResult.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCheckResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btCheckResult.Location = new System.Drawing.Point(341, 385);
            this.btCheckResult.Name = "btCheckResult";
            this.btCheckResult.Size = new System.Drawing.Size(117, 53);
            this.btCheckResult.TabIndex = 10;
            this.btCheckResult.Text = "RESULT";
            this.btCheckResult.UseVisualStyleBackColor = true;
            this.btCheckResult.Click += new System.EventHandler(this.btCheckResult_Click);
            // 
            // btDone
            // 
            this.btDone.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btDone.Location = new System.Drawing.Point(645, 385);
            this.btDone.Name = "btDone";
            this.btDone.Size = new System.Drawing.Size(120, 53);
            this.btDone.TabIndex = 11;
            this.btDone.Text = "DONE";
            this.btDone.UseVisualStyleBackColor = true;
            this.btDone.Click += new System.EventHandler(this.btDone_Click);
            // 
            // lbQuestionNumber
            // 
            this.lbQuestionNumber.AutoSize = true;
            this.lbQuestionNumber.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbQuestionNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbQuestionNumber.Location = new System.Drawing.Point(411, 385);
            this.lbQuestionNumber.Name = "lbQuestionNumber";
            this.lbQuestionNumber.Size = new System.Drawing.Size(0, 27);
            this.lbQuestionNumber.TabIndex = 12;
            // 
            // MinusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 458);
            this.Controls.Add(this.lbQuestionNumber);
            this.Controls.Add(this.btDone);
            this.Controls.Add(this.btCheckResult);
            this.Controls.Add(this.lbNoti);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lbEqual);
            this.Controls.Add(this.lbRightNum);
            this.Controls.Add(this.lbMinus);
            this.Controls.Add(this.lbLeftNum);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btBack);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MinusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math for Kids";
            this.Load += new System.EventHandler(this.MinusForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Label lbLeftNum;
        private System.Windows.Forms.Label lbMinus;
        private System.Windows.Forms.Label lbRight;
        private System.Windows.Forms.Label lbEqual;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbNoti;
        private System.Windows.Forms.Button btCheckResult;
        private System.Windows.Forms.Button btDone;
        private System.Windows.Forms.Label lbQuestionNumber;
        private System.Windows.Forms.Label lbRightNum;
    }
}