namespace NClass.GUI.Dialogs
{
	partial class AboutDialog
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
			if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
            lblTitle = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            lblCopyright = new System.Windows.Forms.Label();
            lnkHomepage = new System.Windows.Forms.LinkLabel();
            lnkEmail = new System.Windows.Forms.LinkLabel();
            picEmail = new System.Windows.Forms.PictureBox();
            picHomepage = new System.Windows.Forms.PictureBox();
            lblStatus = new System.Windows.Forms.Label();
            lblTranslator = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lnkIcons = new System.Windows.Forms.LinkLabel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            lnkLicense = new System.Windows.Forms.LinkLabel();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            lnkGitHub = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)picEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHomepage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new System.Drawing.Font("Verdana", 28F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(91, 12);
            lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(346, 65);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "NClass vX.X";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnClose.Location = new System.Drawing.Point(484, 319);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(88, 27);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // lblCopyright
            // 
            lblCopyright.Location = new System.Drawing.Point(98, 77);
            lblCopyright.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new System.Drawing.Size(246, 15);
            lblCopyright.TabIndex = 9;
            lblCopyright.Text = "Copyright (C) 2006-2009 Balazs Tihanyi";
            lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkHomepage
            // 
            lnkHomepage.ActiveLinkColor = System.Drawing.Color.Black;
            lnkHomepage.AutoSize = true;
            lnkHomepage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lnkHomepage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            lnkHomepage.LinkColor = System.Drawing.Color.Black;
            lnkHomepage.Location = new System.Drawing.Point(61, 179);
            lnkHomepage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lnkHomepage.Name = "lnkHomepage";
            lnkHomepage.Size = new System.Drawing.Size(148, 15);
            lnkHomepage.TabIndex = 7;
            lnkHomepage.TabStop = true;
            lnkHomepage.Text = "Original NClass homepage";
            lnkHomepage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lnkHomepage.VisitedLinkColor = System.Drawing.Color.Black;
            lnkHomepage.LinkClicked += lnkHomepage_LinkClicked;
            // 
            // lnkEmail
            // 
            lnkEmail.AccessibleName = "";
            lnkEmail.ActiveLinkColor = System.Drawing.Color.Black;
            lnkEmail.AutoSize = true;
            lnkEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lnkEmail.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            lnkEmail.LinkColor = System.Drawing.Color.Black;
            lnkEmail.Location = new System.Drawing.Point(61, 137);
            lnkEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lnkEmail.Name = "lnkEmail";
            lnkEmail.Size = new System.Drawing.Size(204, 15);
            lnkEmail.TabIndex = 6;
            lnkEmail.TabStop = true;
            lnkEmail.Text = "Balazs Tihanyi's email on Sourceforge";
            lnkEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lnkEmail.VisitedLinkColor = System.Drawing.Color.Black;
            lnkEmail.LinkClicked += lnkEmail_LinkClicked;
            // 
            // picEmail
            // 
            picEmail.Image = Properties.Resources.Mail;
            picEmail.Location = new System.Drawing.Point(11, 127);
            picEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            picEmail.Name = "picEmail";
            picEmail.Size = new System.Drawing.Size(37, 37);
            picEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            picEmail.TabIndex = 10;
            picEmail.TabStop = false;
            // 
            // picHomepage
            // 
            picHomepage.Image = Properties.Resources.Web;
            picHomepage.Location = new System.Drawing.Point(13, 170);
            picHomepage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            picHomepage.Name = "picHomepage";
            picHomepage.Size = new System.Drawing.Size(35, 35);
            picHomepage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            picHomepage.TabIndex = 11;
            picHomepage.TabStop = false;
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            lblStatus.Location = new System.Drawing.Point(379, 21);
            lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(193, 15);
            lblStatus.TabIndex = 12;
            lblStatus.Text = ".NET Core version";
            lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTranslator
            // 
            lblTranslator.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblTranslator.AutoSize = true;
            lblTranslator.Location = new System.Drawing.Point(14, 325);
            lblTranslator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTranslator.Name = "lblTranslator";
            lblTranslator.Size = new System.Drawing.Size(58, 15);
            lblTranslator.TabIndex = 13;
            lblTranslator.Text = "Translator";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(8, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(80, 80);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // lnkIcons
            // 
            lnkIcons.AutoSize = true;
            lnkIcons.Location = new System.Drawing.Point(61, 219);
            lnkIcons.Name = "lnkIcons";
            lnkIcons.Size = new System.Drawing.Size(88, 15);
            lnkIcons.TabIndex = 15;
            lnkIcons.TabStop = true;
            lnkIcons.Text = "Icons by Icons8";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(13, 211);
            pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(35, 35);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(lnkLicense);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblCopyright);
            panel1.Controls.Add(lblStatus);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(5);
            panel1.Size = new System.Drawing.Size(586, 111);
            panel1.TabIndex = 17;
            // 
            // lnkLicense
            // 
            lnkLicense.AutoSize = true;
            lnkLicense.Location = new System.Drawing.Point(526, 36);
            lnkLicense.Name = "lnkLicense";
            lnkLicense.Size = new System.Drawing.Size(46, 15);
            lnkLicense.TabIndex = 20;
            lnkLicense.TabStop = true;
            lnkLicense.Text = "License";
            lnkLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(13, 252);
            pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(35, 35);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // lnkGitHub
            // 
            lnkGitHub.AutoSize = true;
            lnkGitHub.Location = new System.Drawing.Point(61, 260);
            lnkGitHub.Name = "lnkGitHub";
            lnkGitHub.Size = new System.Drawing.Size(194, 15);
            lnkGitHub.TabIndex = 18;
            lnkGitHub.TabStop = true;
            lnkGitHub.Text = "This project's homepage on GitHub";
            // 
            // AboutDialog
            // 
            AcceptButton = btnClose;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new System.Drawing.Size(586, 360);
            Controls.Add(pictureBox3);
            Controls.Add(lnkGitHub);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(lnkIcons);
            Controls.Add(lblTranslator);
            Controls.Add(picHomepage);
            Controls.Add(picEmail);
            Controls.Add(btnClose);
            Controls.Add(lnkHomepage);
            Controls.Add(lnkEmail);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutDialog";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "About NClass";
            ((System.ComponentModel.ISupportInitialize)picEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHomepage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblCopyright;
		private System.Windows.Forms.LinkLabel lnkHomepage;
		private System.Windows.Forms.LinkLabel lnkEmail;
		private System.Windows.Forms.PictureBox picEmail;
		private System.Windows.Forms.PictureBox picHomepage;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Label lblTranslator;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnkIcons;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel lnkGitHub;
        private System.Windows.Forms.LinkLabel lnkLicense;
    }
}