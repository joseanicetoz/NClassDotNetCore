namespace PDFExport
{
  partial class PDFExportFinished
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
            this.lblFinished = new System.Windows.Forms.Label();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.pictureBoxPDF = new System.Windows.Forms.PictureBox();
            this.cmdClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFinished
            // 
            this.lblFinished.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFinished.Location = new System.Drawing.Point(77, 14);
            this.lblFinished.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinished.Name = "lblFinished";
            this.lblFinished.Size = new System.Drawing.Size(345, 55);
            this.lblFinished.TabIndex = 0;
            this.lblFinished.Text = "PDF Export is finished. Do you want to open the exported PDF?";
            this.lblFinished.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdOpen
            // 
            this.cmdOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOpen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOpen.Location = new System.Drawing.Point(255, 82);
            this.cmdOpen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(80, 27);
            this.cmdOpen.TabIndex = 1;
            this.cmdOpen.Text = "Open";
            this.cmdOpen.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPDF
            // 
            this.pictureBoxPDF.Image = global::PDFExport.Properties.Resources.Document_pdf_48;
            this.pictureBoxPDF.Location = new System.Drawing.Point(14, 14);
            this.pictureBoxPDF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxPDF.Name = "pictureBoxPDF";
            this.pictureBoxPDF.Size = new System.Drawing.Size(56, 55);
            this.pictureBoxPDF.TabIndex = 2;
            this.pictureBoxPDF.TabStop = false;
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdClose.Location = new System.Drawing.Point(343, 82);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(80, 27);
            this.cmdClose.TabIndex = 1;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            // 
            // PDFExportFinished
            // 
            this.AcceptButton = this.cmdOpen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdClose;
            this.ClientSize = new System.Drawing.Size(436, 123);
            this.ControlBox = false;
            this.Controls.Add(this.cmdOpen);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.pictureBoxPDF);
            this.Controls.Add(this.lblFinished);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PDFExportFinished";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PDF Exporter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPDF)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblFinished;
    private System.Windows.Forms.Button cmdOpen;
    private System.Windows.Forms.PictureBox pictureBoxPDF;
    private System.Windows.Forms.Button cmdClose;
  }
}