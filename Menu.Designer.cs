namespace Kids
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lbHello = new System.Windows.Forms.Label();
            this.btNameType = new System.Windows.Forms.Button();
            this.tbNameType = new System.Windows.Forms.TextBox();
            this.btQuit = new System.Windows.Forms.Button();
            this.lbNameShow = new System.Windows.Forms.Label();
            this.btEnter = new System.Windows.Forms.Button();
            this.btChangeName = new System.Windows.Forms.Button();
            this.btLetPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHello
            // 
            this.lbHello.AutoSize = true;
            this.lbHello.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHello.ForeColor = System.Drawing.Color.Magenta;
            this.lbHello.Location = new System.Drawing.Point(500, 44);
            this.lbHello.Name = "lbHello";
            this.lbHello.Size = new System.Drawing.Size(0, 33);
            this.lbHello.TabIndex = 0;
            // 
            // btNameType
            // 
            this.btNameType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btNameType.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btNameType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btNameType.Location = new System.Drawing.Point(507, 30);
            this.btNameType.Name = "btNameType";
            this.btNameType.Size = new System.Drawing.Size(166, 47);
            this.btNameType.TabIndex = 1;
            this.btNameType.Text = "Type Your  Name Here!";
            this.btNameType.UseVisualStyleBackColor = true;
            this.btNameType.Click += new System.EventHandler(this.btNameType_Click);
            // 
            // tbNameType
            // 
            this.tbNameType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNameType.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNameType.ForeColor = System.Drawing.Color.Blue;
            this.tbNameType.Location = new System.Drawing.Point(506, 37);
            this.tbNameType.Name = "tbNameType";
            this.tbNameType.Size = new System.Drawing.Size(167, 31);
            this.tbNameType.TabIndex = 2;
            this.tbNameType.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btQuit
            // 
            this.btQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btQuit.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btQuit.Location = new System.Drawing.Point(650, 390);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(95, 44);
            this.btQuit.TabIndex = 3;
            this.btQuit.Text = "QUIT";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbNameShow
            // 
            this.lbNameShow.AutoSize = true;
            this.lbNameShow.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNameShow.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbNameShow.Location = new System.Drawing.Point(47, 41);
            this.lbNameShow.Name = "lbNameShow";
            this.lbNameShow.Size = new System.Drawing.Size(0, 33);
            this.lbNameShow.TabIndex = 4;
            // 
            // btEnter
            // 
            this.btEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEnter.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btEnter.ForeColor = System.Drawing.Color.Red;
            this.btEnter.Location = new System.Drawing.Point(688, 30);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(91, 47);
            this.btEnter.TabIndex = 5;
            this.btEnter.Text = "Enter";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // btChangeName
            // 
            this.btChangeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btChangeName.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btChangeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btChangeName.Location = new System.Drawing.Point(650, 30);
            this.btChangeName.Name = "btChangeName";
            this.btChangeName.Size = new System.Drawing.Size(127, 47);
            this.btChangeName.TabIndex = 6;
            this.btChangeName.Text = "Change Your Name";
            this.btChangeName.UseVisualStyleBackColor = true;
            this.btChangeName.Click += new System.EventHandler(this.btChangeName_Click);
            // 
            // btLetPlay
            // 
            this.btLetPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btLetPlay.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLetPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btLetPlay.Location = new System.Drawing.Point(306, 390);
            this.btLetPlay.Name = "btLetPlay";
            this.btLetPlay.Size = new System.Drawing.Size(240, 44);
            this.btLetPlay.TabIndex = 7;
            this.btLetPlay.Text = "Let\'s Play";
            this.btLetPlay.UseVisualStyleBackColor = true;
            this.btLetPlay.Click += new System.EventHandler(this.btLetPlay_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLetPlay);
            this.Controls.Add(this.btChangeName);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.lbNameShow);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.tbNameType);
            this.Controls.Add(this.btNameType);
            this.Controls.Add(this.lbHello);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math for Kids";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHello;
        private System.Windows.Forms.Button btNameType;
        private System.Windows.Forms.TextBox tbNameType;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.Label lbNameShow;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.Button btChangeName;
        private System.Windows.Forms.Button btLetPlay;
    }
}

