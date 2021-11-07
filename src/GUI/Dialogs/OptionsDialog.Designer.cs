namespace NClass.GUI.Dialogs
{
	sealed partial class OptionsDialog
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabOptions = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.chkRememberOpenProjects = new System.Windows.Forms.CheckBox();
            this.lblRequiresRestart = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.btnClearRecents = new System.Windows.Forms.Button();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.grpDiagram = new System.Windows.Forms.GroupBox();
            this.panelClearType = new System.Windows.Forms.Panel();
            this.chkClearTypeForImages = new System.Windows.Forms.CheckBox();
            this.radClearTypeNever = new System.Windows.Forms.RadioButton();
            this.radClearTypeAlways = new System.Windows.Forms.RadioButton();
            this.radClearTypeWhenZoomed = new System.Windows.Forms.RadioButton();
            this.lblUseClearType = new System.Windows.Forms.Label();
            this.panelChevron = new System.Windows.Forms.Panel();
            this.lblShowChevron = new System.Windows.Forms.Label();
            this.radChevronAsNeeded = new System.Windows.Forms.RadioButton();
            this.radChevronNever = new System.Windows.Forms.RadioButton();
            this.radChevronAlways = new System.Windows.Forms.RadioButton();
            this.chkUsePrecisionSnapping = new System.Windows.Forms.CheckBox();
            this.tabStyle = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.stylePropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.cboStyles = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabOptions.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.grpDiagram.SuspendLayout();
            this.panelClearType.SuspendLayout();
            this.panelChevron.SuspendLayout();
            this.tabStyle.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(100, 3);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 29);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.AutoSize = true;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(4, 3);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 29);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tabOptions
            // 
            this.tabOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOptions.Controls.Add(this.tabGeneral);
            this.tabOptions.Controls.Add(this.tabStyle);
            this.tabOptions.Location = new System.Drawing.Point(14, 14);
            this.tabOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabOptions.Multiline = true;
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedIndex = 0;
            this.tabOptions.Size = new System.Drawing.Size(607, 566);
            this.tabOptions.TabIndex = 4;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.grpGeneral);
            this.tabGeneral.Controls.Add(this.grpDiagram);
            this.tabGeneral.Location = new System.Drawing.Point(4, 24);
            this.tabGeneral.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabGeneral.Size = new System.Drawing.Size(599, 538);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // grpGeneral
            // 
            this.grpGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGeneral.Controls.Add(this.chkRememberOpenProjects);
            this.grpGeneral.Controls.Add(this.lblRequiresRestart);
            this.grpGeneral.Controls.Add(this.lblLanguage);
            this.grpGeneral.Controls.Add(this.btnClearRecents);
            this.grpGeneral.Controls.Add(this.cboLanguage);
            this.grpGeneral.Location = new System.Drawing.Point(7, 7);
            this.grpGeneral.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpGeneral.Size = new System.Drawing.Size(583, 151);
            this.grpGeneral.TabIndex = 0;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // chkRememberOpenProjects
            // 
            this.chkRememberOpenProjects.AutoSize = true;
            this.chkRememberOpenProjects.Location = new System.Drawing.Point(10, 85);
            this.chkRememberOpenProjects.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkRememberOpenProjects.Name = "chkRememberOpenProjects";
            this.chkRememberOpenProjects.Size = new System.Drawing.Size(193, 19);
            this.chkRememberOpenProjects.TabIndex = 5;
            this.chkRememberOpenProjects.Text = "Remember last opened projects";
            this.chkRememberOpenProjects.UseVisualStyleBackColor = true;
            // 
            // lblRequiresRestart
            // 
            this.lblRequiresRestart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRequiresRestart.Enabled = false;
            this.lblRequiresRestart.Location = new System.Drawing.Point(7, 47);
            this.lblRequiresRestart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequiresRestart.Name = "lblRequiresRestart";
            this.lblRequiresRestart.Size = new System.Drawing.Size(569, 50);
            this.lblRequiresRestart.TabIndex = 4;
            this.lblRequiresRestart.Text = "Changing the language requires application restart.";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(7, 23);
            this.lblLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(62, 15);
            this.lblLanguage.TabIndex = 0;
            this.lblLanguage.Text = "Language:";
            // 
            // btnClearRecents
            // 
            this.btnClearRecents.AutoSize = true;
            this.btnClearRecents.Location = new System.Drawing.Point(10, 112);
            this.btnClearRecents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClearRecents.Name = "btnClearRecents";
            this.btnClearRecents.Size = new System.Drawing.Size(142, 29);
            this.btnClearRecents.TabIndex = 3;
            this.btnClearRecents.Text = "Clear recent files list";
            this.btnClearRecents.UseVisualStyleBackColor = true;
            this.btnClearRecents.Click += new System.EventHandler(this.btnClearRecents_Click);
            // 
            // cboLanguage
            // 
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Location = new System.Drawing.Point(78, 20);
            this.cboLanguage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(244, 23);
            this.cboLanguage.TabIndex = 1;
            // 
            // grpDiagram
            // 
            this.grpDiagram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDiagram.Controls.Add(this.panelClearType);
            this.grpDiagram.Controls.Add(this.panelChevron);
            this.grpDiagram.Controls.Add(this.chkUsePrecisionSnapping);
            this.grpDiagram.Location = new System.Drawing.Point(7, 165);
            this.grpDiagram.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpDiagram.Name = "grpDiagram";
            this.grpDiagram.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpDiagram.Size = new System.Drawing.Size(583, 364);
            this.grpDiagram.TabIndex = 1;
            this.grpDiagram.TabStop = false;
            this.grpDiagram.Text = "Diagram";
            // 
            // panelClearType
            // 
            this.panelClearType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClearType.Controls.Add(this.chkClearTypeForImages);
            this.panelClearType.Controls.Add(this.radClearTypeNever);
            this.panelClearType.Controls.Add(this.radClearTypeAlways);
            this.panelClearType.Controls.Add(this.radClearTypeWhenZoomed);
            this.panelClearType.Controls.Add(this.lblUseClearType);
            this.panelClearType.Location = new System.Drawing.Point(10, 173);
            this.panelClearType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelClearType.Name = "panelClearType";
            this.panelClearType.Size = new System.Drawing.Size(566, 184);
            this.panelClearType.TabIndex = 10;
            // 
            // chkClearTypeForImages
            // 
            this.chkClearTypeForImages.AutoSize = true;
            this.chkClearTypeForImages.Location = new System.Drawing.Point(14, 104);
            this.chkClearTypeForImages.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkClearTypeForImages.Name = "chkClearTypeForImages";
            this.chkClearTypeForImages.Size = new System.Drawing.Size(251, 19);
            this.chkClearTypeForImages.TabIndex = 13;
            this.chkClearTypeForImages.Text = "In exported images (disables transparency)";
            this.chkClearTypeForImages.UseVisualStyleBackColor = true;
            // 
            // radClearTypeNever
            // 
            this.radClearTypeNever.AutoSize = true;
            this.radClearTypeNever.Location = new System.Drawing.Point(14, 77);
            this.radClearTypeNever.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radClearTypeNever.Name = "radClearTypeNever";
            this.radClearTypeNever.Size = new System.Drawing.Size(56, 19);
            this.radClearTypeNever.TabIndex = 12;
            this.radClearTypeNever.TabStop = true;
            this.radClearTypeNever.Text = "Never";
            this.radClearTypeNever.UseVisualStyleBackColor = true;
            // 
            // radClearTypeAlways
            // 
            this.radClearTypeAlways.AutoSize = true;
            this.radClearTypeAlways.Location = new System.Drawing.Point(14, 24);
            this.radClearTypeAlways.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radClearTypeAlways.Name = "radClearTypeAlways";
            this.radClearTypeAlways.Size = new System.Drawing.Size(62, 19);
            this.radClearTypeAlways.TabIndex = 11;
            this.radClearTypeAlways.TabStop = true;
            this.radClearTypeAlways.Text = "Always";
            this.radClearTypeAlways.UseVisualStyleBackColor = true;
            // 
            // radClearTypeWhenZoomed
            // 
            this.radClearTypeWhenZoomed.AutoSize = true;
            this.radClearTypeWhenZoomed.Location = new System.Drawing.Point(14, 51);
            this.radClearTypeWhenZoomed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radClearTypeWhenZoomed.Name = "radClearTypeWhenZoomed";
            this.radClearTypeWhenZoomed.Size = new System.Drawing.Size(138, 19);
            this.radClearTypeWhenZoomed.TabIndex = 10;
            this.radClearTypeWhenZoomed.TabStop = true;
            this.radClearTypeWhenZoomed.Text = "When zoomed in/out";
            this.radClearTypeWhenZoomed.UseVisualStyleBackColor = true;
            // 
            // lblUseClearType
            // 
            this.lblUseClearType.AutoSize = true;
            this.lblUseClearType.Location = new System.Drawing.Point(-4, 0);
            this.lblUseClearType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUseClearType.Name = "lblUseClearType";
            this.lblUseClearType.Size = new System.Drawing.Size(80, 15);
            this.lblUseClearType.TabIndex = 9;
            this.lblUseClearType.Text = "Use ClearType";
            // 
            // panelChevron
            // 
            this.panelChevron.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChevron.Controls.Add(this.lblShowChevron);
            this.panelChevron.Controls.Add(this.radChevronAsNeeded);
            this.panelChevron.Controls.Add(this.radChevronNever);
            this.panelChevron.Controls.Add(this.radChevronAlways);
            this.panelChevron.Location = new System.Drawing.Point(10, 57);
            this.panelChevron.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelChevron.Name = "panelChevron";
            this.panelChevron.Size = new System.Drawing.Size(566, 103);
            this.panelChevron.TabIndex = 9;
            // 
            // lblShowChevron
            // 
            this.lblShowChevron.AutoSize = true;
            this.lblShowChevron.Location = new System.Drawing.Point(-4, 0);
            this.lblShowChevron.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShowChevron.Name = "lblShowChevron";
            this.lblShowChevron.Size = new System.Drawing.Size(124, 15);
            this.lblShowChevron.TabIndex = 1;
            this.lblShowChevron.Text = "Show chevron button:";
            // 
            // radChevronAsNeeded
            // 
            this.radChevronAsNeeded.AutoSize = true;
            this.radChevronAsNeeded.Location = new System.Drawing.Point(14, 51);
            this.radChevronAsNeeded.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radChevronAsNeeded.Name = "radChevronAsNeeded";
            this.radChevronAsNeeded.Size = new System.Drawing.Size(133, 19);
            this.radChevronAsNeeded.TabIndex = 2;
            this.radChevronAsNeeded.TabStop = true;
            this.radChevronAsNeeded.Text = "When mouse hovers";
            this.radChevronAsNeeded.UseVisualStyleBackColor = true;
            // 
            // radChevronNever
            // 
            this.radChevronNever.AutoSize = true;
            this.radChevronNever.Location = new System.Drawing.Point(14, 77);
            this.radChevronNever.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radChevronNever.Name = "radChevronNever";
            this.radChevronNever.Size = new System.Drawing.Size(56, 19);
            this.radChevronNever.TabIndex = 4;
            this.radChevronNever.TabStop = true;
            this.radChevronNever.Text = "Never";
            this.radChevronNever.UseVisualStyleBackColor = true;
            // 
            // radChevronAlways
            // 
            this.radChevronAlways.AutoSize = true;
            this.radChevronAlways.Location = new System.Drawing.Point(14, 24);
            this.radChevronAlways.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radChevronAlways.Name = "radChevronAlways";
            this.radChevronAlways.Size = new System.Drawing.Size(62, 19);
            this.radChevronAlways.TabIndex = 3;
            this.radChevronAlways.TabStop = true;
            this.radChevronAlways.Text = "Always";
            this.radChevronAlways.UseVisualStyleBackColor = true;
            // 
            // chkUsePrecisionSnapping
            // 
            this.chkUsePrecisionSnapping.AutoSize = true;
            this.chkUsePrecisionSnapping.Location = new System.Drawing.Point(10, 25);
            this.chkUsePrecisionSnapping.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkUsePrecisionSnapping.Name = "chkUsePrecisionSnapping";
            this.chkUsePrecisionSnapping.Size = new System.Drawing.Size(148, 19);
            this.chkUsePrecisionSnapping.TabIndex = 0;
            this.chkUsePrecisionSnapping.Text = "Use precision snapping";
            this.chkUsePrecisionSnapping.UseVisualStyleBackColor = true;
            // 
            // tabStyle
            // 
            this.tabStyle.Controls.Add(this.tableLayoutPanel1);
            this.tabStyle.Location = new System.Drawing.Point(4, 24);
            this.tabStyle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabStyle.Name = "tabStyle";
            this.tabStyle.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabStyle.Size = new System.Drawing.Size(375, 482);
            this.tabStyle.TabIndex = 1;
            this.tabStyle.Text = "Style";
            this.tabStyle.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.stylePropertyGrid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboStyles, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLoad, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(367, 476);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(83, 444);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 29);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // stylePropertyGrid
            // 
            this.stylePropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.stylePropertyGrid, 3);
            this.stylePropertyGrid.Location = new System.Drawing.Point(4, 3);
            this.stylePropertyGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stylePropertyGrid.Name = "stylePropertyGrid";
            this.stylePropertyGrid.Size = new System.Drawing.Size(359, 406);
            this.stylePropertyGrid.TabIndex = 0;
            this.stylePropertyGrid.ToolbarVisible = false;
            this.stylePropertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.stylePropertyGrid_PropertyValueChanged);
            // 
            // cboStyles
            // 
            this.cboStyles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cboStyles, 3);
            this.cboStyles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStyles.FormattingEnabled = true;
            this.cboStyles.Location = new System.Drawing.Point(4, 415);
            this.cboStyles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboStyles.Name = "cboStyles";
            this.cboStyles.Size = new System.Drawing.Size(359, 23);
            this.cboStyles.TabIndex = 1;
            this.cboStyles.SelectedIndexChanged += new System.EventHandler(this.cboStyles_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.AutoSize = true;
            this.btnLoad.Location = new System.Drawing.Point(179, 444);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(88, 29);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(275, 444);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 29);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(429, 581);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(192, 35);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // OptionsDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(635, 631);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tabOptions);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(417, 608);
            this.Name = "OptionsDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.tabOptions.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpDiagram.ResumeLayout(false);
            this.grpDiagram.PerformLayout();
            this.panelClearType.ResumeLayout(false);
            this.panelClearType.PerformLayout();
            this.panelChevron.ResumeLayout(false);
            this.panelChevron.PerformLayout();
            this.tabStyle.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TabControl tabOptions;
		private System.Windows.Forms.TabPage tabGeneral;
		private System.Windows.Forms.GroupBox grpGeneral;
		private System.Windows.Forms.Label lblLanguage;
		private System.Windows.Forms.Button btnClearRecents;
		private System.Windows.Forms.ComboBox cboLanguage;
		private System.Windows.Forms.GroupBox grpDiagram;
		private System.Windows.Forms.RadioButton radChevronNever;
		private System.Windows.Forms.RadioButton radChevronAlways;
		private System.Windows.Forms.RadioButton radChevronAsNeeded;
		private System.Windows.Forms.Label lblShowChevron;
		private System.Windows.Forms.CheckBox chkUsePrecisionSnapping;
		private System.Windows.Forms.TabPage tabStyle;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.PropertyGrid stylePropertyGrid;
		private System.Windows.Forms.ComboBox cboStyles;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label lblRequiresRestart;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Panel panelClearType;
		private System.Windows.Forms.RadioButton radClearTypeNever;
		private System.Windows.Forms.RadioButton radClearTypeAlways;
		private System.Windows.Forms.RadioButton radClearTypeWhenZoomed;
		private System.Windows.Forms.Label lblUseClearType;
		private System.Windows.Forms.Panel panelChevron;
		private System.Windows.Forms.CheckBox chkRememberOpenProjects;
		private System.Windows.Forms.CheckBox chkClearTypeForImages;



	}
}