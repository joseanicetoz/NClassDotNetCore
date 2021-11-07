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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lnkHomepage = new System.Windows.Forms.LinkLabel();
            this.lnkEmail = new System.Windows.Forms.LinkLabel();
            this.picEmail = new System.Windows.Forms.PictureBox();
            this.picHomepage = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTranslator = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnkIcons = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnkLicense = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lnkGitHub = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHomepage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(91, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(346, 65);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "NClass vX.X";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(484, 319);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 27);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Location = new System.Drawing.Point(98, 77);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(246, 15);
            this.lblCopyright.TabIndex = 9;
            this.lblCopyright.Text = "Copyright (C) 2006-2009 Balazs Tihanyi";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkHomepage
            // 
            this.lnkHomepage.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnkHomepage.AutoSize = true;
            this.lnkHomepage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkHomepage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkHomepage.LinkColor = System.Drawing.Color.Black;
            this.lnkHomepage.Location = new System.Drawing.Point(61, 179);
            this.lnkHomepage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkHomepage.Name = "lnkHomepage";
            this.lnkHomepage.Size = new System.Drawing.Size(148, 15);
            this.lnkHomepage.TabIndex = 7;
            this.lnkHomepage.TabStop = true;
            this.lnkHomepage.Text = "Original NClass homepage";
            this.lnkHomepage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkHomepage.VisitedLinkColor = System.Drawing.Color.Black;
            this.lnkHomepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHomepage_LinkClicked);
            // 
            // lnkEmail
            // 
            this.lnkEmail.AccessibleName = "";
            this.lnkEmail.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnkEmail.AutoSize = true;
            this.lnkEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkEmail.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkEmail.LinkColor = System.Drawing.Color.Black;
            this.lnkEmail.Location = new System.Drawing.Point(61, 137);
            this.lnkEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkEmail.Name = "lnkEmail";
            this.lnkEmail.Size = new System.Drawing.Size(204, 15);
            this.lnkEmail.TabIndex = 6;
            this.lnkEmail.TabStop = true;
            this.lnkEmail.Text = "Balazs Tihanyi\'s email on Sourceforge";
            this.lnkEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkEmail.VisitedLinkColor = System.Drawing.Color.Black;
            this.lnkEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEmail_LinkClicked);
            // 
            // picEmail
            // 
            this.picEmail.Image = global::NClass.GUI.Properties.Resources.Mail;
            this.picEmail.Location = new System.Drawing.Point(11, 127);
            this.picEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picEmail.Name = "picEmail";
            this.picEmail.Size = new System.Drawing.Size(37, 37);
            this.picEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picEmail.TabIndex = 10;
            this.picEmail.TabStop = false;
            // 
            // picHomepage
            // 
            this.picHomepage.Image = global::NClass.GUI.Properties.Resources.Web;
            this.picHomepage.Location = new System.Drawing.Point(13, 170);
            this.picHomepage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picHomepage.Name = "picHomepage";
            this.picHomepage.Size = new System.Drawing.Size(35, 35);
            this.picHomepage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picHomepage.TabIndex = 11;
            this.picHomepage.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblStatus.Location = new System.Drawing.Point(379, 21);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(193, 15);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = ".NET Core version";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTranslator
            // 
            this.lblTranslator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTranslator.AutoSize = true;
            this.lblTranslator.Location = new System.Drawing.Point(14, 325);
            this.lblTranslator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTranslator.Name = "lblTranslator";
            this.lblTranslator.Size = new System.Drawing.Size(58, 15);
            this.lblTranslator.TabIndex = 13;
            this.lblTranslator.Text = "Translator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lnkIcons
            // 
            this.lnkIcons.AutoSize = true;
            this.lnkIcons.Location = new System.Drawing.Point(61, 219);
            this.lnkIcons.Name = "lnkIcons";
            this.lnkIcons.Size = new System.Drawing.Size(88, 15);
            this.lnkIcons.TabIndex = 15;
            this.lnkIcons.TabStop = true;
            this.lnkIcons.Text = "Icons by Icons8";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 211);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lnkLicense);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblCopyright);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(586, 111);
            this.panel1.TabIndex = 17;
            // 
            // lnkLicense
            // 
            this.lnkLicense.AutoSize = true;
            this.lnkLicense.Location = new System.Drawing.Point(526, 36);
            this.lnkLicense.Name = "lnkLicense";
            this.lnkLicense.Size = new System.Drawing.Size(46, 15);
            this.lnkLicense.TabIndex = 20;
            this.lnkLicense.TabStop = true;
            this.lnkLicense.Text = "License";
            this.lnkLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(13, 252);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // lnkGitHub
            // 
            this.lnkGitHub.AutoSize = true;
            this.lnkGitHub.Location = new System.Drawing.Point(61, 260);
            this.lnkGitHub.Name = "lnkGitHub";
            this.lnkGitHub.Size = new System.Drawing.Size(194, 15);
            this.lnkGitHub.TabIndex = 18;
            this.lnkGitHub.TabStop = true;
            this.lnkGitHub.Text = "This project\'s homepage on GitHub";
            // 
            // AboutDialog
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(586, 360);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lnkGitHub);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lnkIcons);
            this.Controls.Add(this.lblTranslator);
            this.Controls.Add(this.picHomepage);
            this.Controls.Add(this.picEmail);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lnkHomepage);
            this.Controls.Add(this.lnkEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About NClass";
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHomepage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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