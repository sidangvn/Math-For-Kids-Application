﻿namespace Kids
{
    partial class MultiFormResult
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
            this.btMenu = new System.Windows.Forms.Button();
            this.lbShowResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btBack.ForeColor = System.Drawing.Color.Blue;
            this.btBack.Location = new System.Drawing.Point(22, 396);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(110, 42);
            this.btBack.TabIndex = 0;
            this.btBack.Text = "BACK";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btMenu
            // 
            this.btMenu.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btMenu.ForeColor = System.Drawing.Color.Blue;
            this.btMenu.Location = new System.Drawing.Point(684, 396);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(95, 42);
            this.btMenu.TabIndex = 1;
            this.btMenu.Text = "MENU";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // lbShowResults
            // 
            this.lbShowResults.AutoSize = true;
            this.lbShowResults.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbShowResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbShowResults.Location = new System.Drawing.Point(84, 43);
            this.lbShowResults.Name = "lbShowResults";
            this.lbShowResults.Size = new System.Drawing.Size(0, 27);
            this.lbShowResults.TabIndex = 2;
            // 
            // MultiFormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbShowResults);
            this.Controls.Add(this.btMenu);
            this.Controls.Add(this.btBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MultiFormResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math for Kids";
            this.Load += new System.EventHandler(this.MultiFormResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Label lbShowResults;
    }
}