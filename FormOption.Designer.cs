namespace Kids
{
    partial class FormPlus
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
            this.btPlus = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btMulti = new System.Windows.Forms.Button();
            this.btDivide = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.btQuit = new System.Windows.Forms.Button();
            this.lbScore = new System.Windows.Forms.Label();
            this.btResetScore = new System.Windows.Forms.Button();
            this.btCummulative = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPlus
            // 
            this.btPlus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btPlus.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btPlus.Location = new System.Drawing.Point(46, 130);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(103, 157);
            this.btPlus.TabIndex = 0;
            this.btPlus.Text = "PLUS";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btMinus
            // 
            this.btMinus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btMinus.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btMinus.Location = new System.Drawing.Point(199, 130);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(103, 157);
            this.btMinus.TabIndex = 0;
            this.btMinus.Text = "MINUS";
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.button2_Click);
            // 
            // btMulti
            // 
            this.btMulti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btMulti.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btMulti.ForeColor = System.Drawing.Color.Green;
            this.btMulti.Location = new System.Drawing.Point(350, 130);
            this.btMulti.Name = "btMulti";
            this.btMulti.Size = new System.Drawing.Size(103, 157);
            this.btMulti.TabIndex = 0;
            this.btMulti.Text = "MULTIPLE";
            this.btMulti.UseVisualStyleBackColor = true;
            this.btMulti.Click += new System.EventHandler(this.button3_Click);
            // 
            // btDivide
            // 
            this.btDivide.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btDivide.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDivide.ForeColor = System.Drawing.Color.Purple;
            this.btDivide.Location = new System.Drawing.Point(502, 130);
            this.btDivide.Name = "btDivide";
            this.btDivide.Size = new System.Drawing.Size(103, 157);
            this.btDivide.TabIndex = 0;
            this.btDivide.Text = "DIVIDE";
            this.btDivide.UseVisualStyleBackColor = true;
            this.btDivide.Click += new System.EventHandler(this.btDivide_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbName.Location = new System.Drawing.Point(58, 25);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 33);
            this.lbName.TabIndex = 1;
            // 
            // btBack
            // 
            this.btBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btBack.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btBack.ForeColor = System.Drawing.Color.Blue;
            this.btBack.Location = new System.Drawing.Point(67, 374);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(155, 53);
            this.btBack.TabIndex = 2;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.button5_Click);
            // 
            // btQuit
            // 
            this.btQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btQuit.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btQuit.ForeColor = System.Drawing.Color.Blue;
            this.btQuit.Location = new System.Drawing.Point(655, 374);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(121, 53);
            this.btQuit.TabIndex = 3;
            this.btQuit.Text = "QUIT";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScore.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbScore.Location = new System.Drawing.Point(58, 62);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(0, 27);
            this.lbScore.TabIndex = 4;
            // 
            // btResetScore
            // 
            this.btResetScore.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btResetScore.ForeColor = System.Drawing.Color.Blue;
            this.btResetScore.Location = new System.Drawing.Point(363, 374);
            this.btResetScore.Name = "btResetScore";
            this.btResetScore.Size = new System.Drawing.Size(127, 53);
            this.btResetScore.TabIndex = 5;
            this.btResetScore.Text = "RESET SCORE";
            this.btResetScore.UseVisualStyleBackColor = true;
            this.btResetScore.Click += new System.EventHandler(this.btResetScore_Click);
            // 
            // btCummulative
            // 
            this.btCummulative.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCummulative.ForeColor = System.Drawing.Color.Goldenrod;
            this.btCummulative.Location = new System.Drawing.Point(655, 130);
            this.btCummulative.Name = "btCummulative";
            this.btCummulative.Size = new System.Drawing.Size(103, 157);
            this.btCummulative.TabIndex = 6;
            this.btCummulative.Text = "ALL";
            this.btCummulative.UseVisualStyleBackColor = true;
            this.btCummulative.Click += new System.EventHandler(this.btCummulative_Click);
            // 
            // FormPlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCummulative);
            this.Controls.Add(this.btResetScore);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btDivide);
            this.Controls.Add(this.btMulti);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.btPlus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPlus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math for Kids";
            this.Load += new System.EventHandler(this.FormPlus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btMulti;
        private System.Windows.Forms.Button btDivide;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Button btResetScore;
        private System.Windows.Forms.Button btCummulative;
    }
}