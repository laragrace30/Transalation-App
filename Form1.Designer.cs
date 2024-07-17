namespace Transalation_App
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.translate = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.secondLanguage = new Bunifu.Framework.UI.BunifuDropdown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.firstLanguage = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.translate);
            this.bunifuGradientPanel1.Controls.Add(this.textBox2);
            this.bunifuGradientPanel1.Controls.Add(this.secondLanguage);
            this.bunifuGradientPanel1.Controls.Add(this.textBox1);
            this.bunifuGradientPanel1.Controls.Add(this.firstLanguage);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.close);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(78)))), ((int)(((byte)(214)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(78)))), ((int)(((byte)(214)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(77)))), ((int)(((byte)(155)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(886, 420);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(416, 244);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 35);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick_1);
            // 
            // translate
            // 
            this.translate.BackColor = System.Drawing.Color.White;
            this.translate.Location = new System.Drawing.Point(364, 369);
            this.translate.Name = "translate";
            this.translate.Size = new System.Drawing.Size(156, 27);
            this.translate.TabIndex = 8;
            this.translate.Text = "TRANSLATE";
            this.translate.UseVisualStyleBackColor = false;
            this.translate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.translate_MouseClick);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(496, 171);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(350, 175);
            this.textBox2.TabIndex = 6;
            // 
            // secondLanguage
            // 
            this.secondLanguage.BackColor = System.Drawing.Color.Transparent;
            this.secondLanguage.BorderRadius = 3;
            this.secondLanguage.DisabledColor = System.Drawing.Color.Gray;
            this.secondLanguage.ForeColor = System.Drawing.Color.White;
            this.secondLanguage.Items = new string[0];
            this.secondLanguage.Location = new System.Drawing.Point(575, 77);
            this.secondLanguage.Name = "secondLanguage";
            this.secondLanguage.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.secondLanguage.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.secondLanguage.selectedIndex = -1;
            this.secondLanguage.Size = new System.Drawing.Size(193, 35);
            this.secondLanguage.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(35, 171);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 175);
            this.textBox1.TabIndex = 3;
            // 
            // firstLanguage
            // 
            this.firstLanguage.BackColor = System.Drawing.Color.Transparent;
            this.firstLanguage.BorderRadius = 3;
            this.firstLanguage.DisabledColor = System.Drawing.Color.Gray;
            this.firstLanguage.ForeColor = System.Drawing.Color.White;
            this.firstLanguage.Items = new string[0];
            this.firstLanguage.Location = new System.Drawing.Point(116, 77);
            this.firstLanguage.Name = "firstLanguage";
            this.firstLanguage.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.firstLanguage.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.firstLanguage.selectedIndex = -1;
            this.firstLanguage.Size = new System.Drawing.Size(193, 35);
            this.firstLanguage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Heebo", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(380, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Translate";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(836, 21);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(28, 25);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 0;
            this.close.TabStop = false;
            this.close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.close_MouseClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this.firstLanguage;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 25;
            this.bunifuElipse3.TargetControl = this.textBox1;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 30;
            this.bunifuElipse4.TargetControl = this.secondLanguage;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 25;
            this.bunifuElipse5.TargetControl = this.textBox2;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher2
            // 
            this.directorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(886, 420);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuDropdown firstLanguage;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.TextBox textBox2;
        private Bunifu.Framework.UI.BunifuDropdown secondLanguage;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private System.Windows.Forms.Button translate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
    }
}

