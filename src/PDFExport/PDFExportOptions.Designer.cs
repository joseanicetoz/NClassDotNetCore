namespace PDFExport
{
  partial class PDFExportOptions
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
      if(disposing && (components != null))
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
            this.lblTop = new System.Windows.Forms.Label();
            this.chkSelectedOnly = new System.Windows.Forms.CheckBox();
            this.grpMargin = new System.Windows.Forms.GroupBox();
            this.numBottom = new System.Windows.Forms.NumericUpDown();
            this.numRight = new System.Windows.Forms.NumericUpDown();
            this.numLeft = new System.Windows.Forms.NumericUpDown();
            this.lblBottom = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.numTop = new System.Windows.Forms.NumericUpDown();
            this.lblRight = new System.Windows.Forms.Label();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.grpMargin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTop)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTop
            // 
            this.lblTop.Location = new System.Drawing.Point(33, 55);
            this.lblTop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(93, 15);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "Top";
            this.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkSelectedOnly
            // 
            this.chkSelectedOnly.AutoSize = true;
            this.chkSelectedOnly.Location = new System.Drawing.Point(14, 14);
            this.chkSelectedOnly.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkSelectedOnly.Name = "chkSelectedOnly";
            this.chkSelectedOnly.Size = new System.Drawing.Size(183, 19);
            this.chkSelectedOnly.TabIndex = 1;
            this.chkSelectedOnly.Text = "Export only selected elements";
            this.chkSelectedOnly.UseVisualStyleBackColor = true;
            // 
            // grpMargin
            // 
            this.grpMargin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMargin.Controls.Add(this.numBottom);
            this.grpMargin.Controls.Add(this.numRight);
            this.grpMargin.Controls.Add(this.numLeft);
            this.grpMargin.Controls.Add(this.lblBottom);
            this.grpMargin.Controls.Add(this.lblLeft);
            this.grpMargin.Controls.Add(this.numTop);
            this.grpMargin.Controls.Add(this.lblRight);
            this.grpMargin.Controls.Add(this.cboUnit);
            this.grpMargin.Controls.Add(this.lblUnit);
            this.grpMargin.Controls.Add(this.lblTop);
            this.grpMargin.Location = new System.Drawing.Point(14, 40);
            this.grpMargin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpMargin.Name = "grpMargin";
            this.grpMargin.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpMargin.Size = new System.Drawing.Size(319, 170);
            this.grpMargin.TabIndex = 2;
            this.grpMargin.TabStop = false;
            this.grpMargin.Text = "Margin";
            // 
            // numBottom
            // 
            this.numBottom.Location = new System.Drawing.Point(133, 134);
            this.numBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numBottom.Name = "numBottom";
            this.numBottom.Size = new System.Drawing.Size(56, 23);
            this.numBottom.TabIndex = 2;
            // 
            // numRight
            // 
            this.numRight.Location = new System.Drawing.Point(238, 92);
            this.numRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numRight.Name = "numRight";
            this.numRight.Size = new System.Drawing.Size(56, 23);
            this.numRight.TabIndex = 2;
            // 
            // numLeft
            // 
            this.numLeft.Location = new System.Drawing.Point(54, 92);
            this.numLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numLeft.Name = "numLeft";
            this.numLeft.Size = new System.Drawing.Size(56, 23);
            this.numLeft.TabIndex = 2;
            // 
            // lblBottom
            // 
            this.lblBottom.Location = new System.Drawing.Point(33, 136);
            this.lblBottom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(93, 15);
            this.lblBottom.TabIndex = 0;
            this.lblBottom.Text = "Bottom";
            this.lblBottom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLeft
            // 
            this.lblLeft.Location = new System.Drawing.Point(2, 95);
            this.lblLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(47, 15);
            this.lblLeft.TabIndex = 0;
            this.lblLeft.Text = "Left";
            this.lblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numTop
            // 
            this.numTop.Location = new System.Drawing.Point(133, 53);
            this.numTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numTop.Name = "numTop";
            this.numTop.Size = new System.Drawing.Size(56, 23);
            this.numTop.TabIndex = 2;
            // 
            // lblRight
            // 
            this.lblRight.Location = new System.Drawing.Point(135, 95);
            this.lblRight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(93, 15);
            this.lblRight.TabIndex = 0;
            this.lblRight.Text = "Right";
            this.lblRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dot",
            "pixel",
            "inch"});
            this.cboUnit.Location = new System.Drawing.Point(202, 22);
            this.cboUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(103, 23);
            this.cboUnit.TabIndex = 1;
            // 
            // lblUnit
            // 
            this.lblUnit.Location = new System.Drawing.Point(15, 25);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(180, 15);
            this.lblUnit.TabIndex = 0;
            this.lblUnit.Text = "Unit";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(245, 218);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(88, 27);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Location = new System.Drawing.Point(151, 218);
            this.cmdOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(88, 27);
            this.cmdOK.TabIndex = 3;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // PDFExportOptions
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(347, 255);
            this.ControlBox = false;
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.grpMargin);
            this.Controls.Add(this.chkSelectedOnly);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PDFExportOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PDF Export Options";
            this.Shown += new System.EventHandler(this.PDFExportOptions_Shown);
            this.grpMargin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTop;
    private System.Windows.Forms.CheckBox chkSelectedOnly;
    private System.Windows.Forms.GroupBox grpMargin;
    private System.Windows.Forms.ComboBox cboUnit;
    private System.Windows.Forms.Label lblUnit;
    private System.Windows.Forms.NumericUpDown numTop;
    private System.Windows.Forms.NumericUpDown numBottom;
    private System.Windows.Forms.NumericUpDown numRight;
    private System.Windows.Forms.NumericUpDown numLeft;
    private System.Windows.Forms.Label lblBottom;
    private System.Windows.Forms.Label lblRight;
    private System.Windows.Forms.Label lblLeft;
    private System.Windows.Forms.Button cmdCancel;
    private System.Windows.Forms.Button cmdOK;
  }
}