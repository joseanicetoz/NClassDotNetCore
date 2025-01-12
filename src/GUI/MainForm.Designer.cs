using System;
using NClass.DiagramEditor.EventsArgs;

namespace NClass.GUI
{
	sealed partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            statusStrip = new System.Windows.Forms.StatusStrip();
            lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            lblLanguage = new System.Windows.Forms.ToolStripStatusLabel();
            windowClient = new System.Windows.Forms.SplitContainer();
            tabbedWindow = new TabbedWindow();
            toolsPanel = new System.Windows.Forms.SplitContainer();
            modelExplorer = new ModelExplorer.ModelView();
            diagramNavigator = new DiagramNavigator();
            menuStrip = new System.Windows.Forms.MenuStrip();
            mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            mnuNewProject = new System.Windows.Forms.ToolStripMenuItem();
            mnuSepProject = new System.Windows.Forms.ToolStripSeparator();
            mnuNewCSharpDiagram = new System.Windows.Forms.ToolStripMenuItem();
            mnuNewJavaDiagram = new System.Windows.Forms.ToolStripMenuItem();
            mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            mnuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            sepOpenFile = new System.Windows.Forms.ToolStripSeparator();
            mnuRecentFile1 = new System.Windows.Forms.ToolStripMenuItem();
            mnuRecentFile2 = new System.Windows.Forms.ToolStripMenuItem();
            mnuRecentFile3 = new System.Windows.Forms.ToolStripMenuItem();
            mnuRecentFile4 = new System.Windows.Forms.ToolStripMenuItem();
            mnuRecentFile5 = new System.Windows.Forms.ToolStripMenuItem();
            mnuSepOpen = new System.Windows.Forms.ToolStripSeparator();
            mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            mnuSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            mnuSepSaveAll = new System.Windows.Forms.ToolStripSeparator();
            mnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            mnuSepPrint = new System.Windows.Forms.ToolStripSeparator();
            mnuCloseProject = new System.Windows.Forms.ToolStripMenuItem();
            mnuCloseAllProjects = new System.Windows.Forms.ToolStripMenuItem();
            mnuSepClose = new System.Windows.Forms.ToolStripSeparator();
            mnuExport = new System.Windows.Forms.ToolStripMenuItem();
            mnuSepExport = new System.Windows.Forms.ToolStripSeparator();
            mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            mnuUndo = new System.Windows.Forms.ToolStripMenuItem();
            mnuRedo = new System.Windows.Forms.ToolStripMenuItem();
            mnuSepReso = new System.Windows.Forms.ToolStripSeparator();
            mnuCut = new System.Windows.Forms.ToolStripMenuItem();
            mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            mnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            mnuSepDelete = new System.Windows.Forms.ToolStripSeparator();
            mnuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            mnuView = new System.Windows.Forms.ToolStripMenuItem();
            mnuZoom = new System.Windows.Forms.ToolStripMenuItem();
            mnuZoom10 = new System.Windows.Forms.ToolStripMenuItem();
            mnuZoom25 = new System.Windows.Forms.ToolStripMenuItem();
            mnuZoom50 = new System.Windows.Forms.ToolStripMenuItem();
            mnuSep50 = new System.Windows.Forms.ToolStripSeparator();
            mnuZoom100 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            mnuZoom150 = new System.Windows.Forms.ToolStripMenuItem();
            mnuZoom200 = new System.Windows.Forms.ToolStripMenuItem();
            mnuZoom400 = new System.Windows.Forms.ToolStripMenuItem();
            mnuAutoZoom = new System.Windows.Forms.ToolStripMenuItem();
            mnuSepAutoZoom = new System.Windows.Forms.ToolStripSeparator();
            mnuModelExplorer = new System.Windows.Forms.ToolStripMenuItem();
            mnuDiagramNavigator = new System.Windows.Forms.ToolStripMenuItem();
            mnuSepDiagramNavigator = new System.Windows.Forms.ToolStripSeparator();
            mnuCloseAllDocuments = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            mnuPlugins = new System.Windows.Forms.ToolStripMenuItem();
            mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            mnuContents = new System.Windows.Forms.ToolStripMenuItem();
            mnuCheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            mnuSepUpdates = new System.Windows.Forms.ToolStripSeparator();
            mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            standardToolStrip = new System.Windows.Forms.ToolStrip();
            toolNew = new System.Windows.Forms.ToolStripDropDownButton();
            toolNewProject = new System.Windows.Forms.ToolStripMenuItem();
            toolSepProject = new System.Windows.Forms.ToolStripSeparator();
            toolNewCSharpDiagram = new System.Windows.Forms.ToolStripMenuItem();
            toolNewJavaDiagram = new System.Windows.Forms.ToolStripMenuItem();
            toolNewDiagram = new System.Windows.Forms.ToolStripDropDownButton();
            toolOpen = new System.Windows.Forms.ToolStripSplitButton();
            toolRecentFile1 = new System.Windows.Forms.ToolStripMenuItem();
            toolRecentFile2 = new System.Windows.Forms.ToolStripMenuItem();
            toolRecentFile3 = new System.Windows.Forms.ToolStripMenuItem();
            toolRecentFile4 = new System.Windows.Forms.ToolStripMenuItem();
            toolRecentFile5 = new System.Windows.Forms.ToolStripMenuItem();
            toolSave = new System.Windows.Forms.ToolStripButton();
            toolSaveAll = new System.Windows.Forms.ToolStripButton();
            toolPrint = new System.Windows.Forms.ToolStripButton();
            toolSepPrint = new System.Windows.Forms.ToolStripSeparator();
            toolCut = new System.Windows.Forms.ToolStripButton();
            toolCopy = new System.Windows.Forms.ToolStripButton();
            toolPaste = new System.Windows.Forms.ToolStripButton();
            toolSepPaste = new System.Windows.Forms.ToolStripSeparator();
            toolUndo = new System.Windows.Forms.ToolStripButton();
            toolRedo = new System.Windows.Forms.ToolStripButton();
            toolSepRedo = new System.Windows.Forms.ToolStripSeparator();
            toolZoomValue = new System.Windows.Forms.ToolStripLabel();
            toolZoomOut = new System.Windows.Forms.ToolStripButton();
            toolZoom = new ZoomingToolStrip();
            toolZoomIn = new System.Windows.Forms.ToolStripButton();
            toolAutoZoom = new System.Windows.Forms.ToolStripButton();
            toolStripContainer.BottomToolStripPanel.SuspendLayout();
            toolStripContainer.ContentPanel.SuspendLayout();
            toolStripContainer.TopToolStripPanel.SuspendLayout();
            toolStripContainer.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)windowClient).BeginInit();
            windowClient.Panel1.SuspendLayout();
            windowClient.Panel2.SuspendLayout();
            windowClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toolsPanel).BeginInit();
            toolsPanel.Panel1.SuspendLayout();
            toolsPanel.Panel2.SuspendLayout();
            toolsPanel.SuspendLayout();
            menuStrip.SuspendLayout();
            standardToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.BottomToolStripPanel
            // 
            toolStripContainer.BottomToolStripPanel.Controls.Add(statusStrip);
            // 
            // toolStripContainer.ContentPanel
            // 
            toolStripContainer.ContentPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            toolStripContainer.ContentPanel.Controls.Add(windowClient);
            toolStripContainer.ContentPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            toolStripContainer.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            toolStripContainer.ContentPanel.Size = new System.Drawing.Size(1041, 695);
            toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            toolStripContainer.Location = new System.Drawing.Point(0, 0);
            toolStripContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            toolStripContainer.Name = "toolStripContainer";
            toolStripContainer.Size = new System.Drawing.Size(1041, 768);
            toolStripContainer.TabIndex = 0;
            toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            toolStripContainer.TopToolStripPanel.Controls.Add(menuStrip);
            toolStripContainer.TopToolStripPanel.Controls.Add(standardToolStrip);
            // 
            // statusStrip
            // 
            statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblStatus, lblLanguage });
            statusStrip.Location = new System.Drawing.Point(0, 0);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new System.Drawing.Size(1041, 22);
            statusStrip.TabIndex = 0;
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(967, 17);
            lblStatus.Spring = true;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLanguage
            // 
            lblLanguage.ForeColor = System.Drawing.SystemColors.GrayText;
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new System.Drawing.Size(59, 17);
            lblLanguage.Text = "Language";
            lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // windowClient
            // 
            windowClient.BackColor = System.Drawing.SystemColors.Control;
            windowClient.Dock = System.Windows.Forms.DockStyle.Fill;
            windowClient.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            windowClient.Location = new System.Drawing.Point(0, 0);
            windowClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            windowClient.Name = "windowClient";
            // 
            // windowClient.Panel1
            // 
            windowClient.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            windowClient.Panel1.Controls.Add(tabbedWindow);
            windowClient.Panel1.Padding = new System.Windows.Forms.Padding(1);
            windowClient.Panel1MinSize = 200;
            // 
            // windowClient.Panel2
            // 
            windowClient.Panel2.BackColor = System.Drawing.SystemColors.Control;
            windowClient.Panel2.Controls.Add(toolsPanel);
            windowClient.Panel2MinSize = 100;
            windowClient.Size = new System.Drawing.Size(1041, 695);
            windowClient.SplitterDistance = 817;
            windowClient.SplitterWidth = 5;
            windowClient.TabIndex = 0;
            // 
            // tabbedWindow
            // 
            tabbedWindow.BackColor = System.Drawing.SystemColors.AppWorkspace;
            tabbedWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            tabbedWindow.DocumentManager = null;
            tabbedWindow.Location = new System.Drawing.Point(1, 1);
            tabbedWindow.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            tabbedWindow.Name = "tabbedWindow";
            tabbedWindow.Size = new System.Drawing.Size(815, 693);
            tabbedWindow.TabIndex = 0;
            // 
            // toolsPanel
            // 
            toolsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            toolsPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            toolsPanel.Location = new System.Drawing.Point(0, 0);
            toolsPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            toolsPanel.Name = "toolsPanel";
            toolsPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // toolsPanel.Panel1
            // 
            toolsPanel.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            toolsPanel.Panel1.Controls.Add(modelExplorer);
            toolsPanel.Panel1.Padding = new System.Windows.Forms.Padding(1);
            toolsPanel.Panel1MinSize = 100;
            // 
            // toolsPanel.Panel2
            // 
            toolsPanel.Panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            toolsPanel.Panel2.Controls.Add(diagramNavigator);
            toolsPanel.Panel2.Padding = new System.Windows.Forms.Padding(1);
            toolsPanel.Panel2MinSize = 100;
            toolsPanel.Size = new System.Drawing.Size(219, 695);
            toolsPanel.SplitterDistance = 541;
            toolsPanel.SplitterWidth = 5;
            toolsPanel.TabIndex = 0;
            // 
            // modelExplorer
            // 
            modelExplorer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            modelExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            modelExplorer.Font = new System.Drawing.Font("Segoe UI", 9F);
            modelExplorer.ImageIndex = 0;
            modelExplorer.Indent = 22;
            modelExplorer.ItemHeight = 18;
            modelExplorer.LabelEdit = true;
            modelExplorer.Location = new System.Drawing.Point(1, 1);
            modelExplorer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            modelExplorer.Name = "modelExplorer";
            modelExplorer.SelectedImageIndex = 0;
            modelExplorer.ShowRootLines = false;
            modelExplorer.Size = new System.Drawing.Size(217, 539);
            modelExplorer.TabIndex = 0;
            modelExplorer.Workspace = null;
            modelExplorer.DocumentOpening += modelExplorer_DocumentOpening;
            // 
            // diagramNavigator
            // 
            diagramNavigator.BackColor = System.Drawing.SystemColors.Window;
            diagramNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            diagramNavigator.DocumentVisualizer = null;
            diagramNavigator.Location = new System.Drawing.Point(1, 1);
            diagramNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            diagramNavigator.Name = "diagramNavigator";
            diagramNavigator.Size = new System.Drawing.Size(217, 147);
            diagramNavigator.TabIndex = 0;
            diagramNavigator.Text = "diagramNavigator";
            // 
            // menuStrip
            // 
            menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuFile, mnuEdit, mnuView, mnuPlugins, mnuHelp });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new System.Drawing.Size(1041, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuNew, mnuOpen, mnuSepOpen, mnuSave, mnuSaveAs, mnuSaveAll, mnuSepSaveAll, mnuPrint, mnuSepPrint, mnuCloseProject, mnuCloseAllProjects, mnuSepClose, mnuExport, mnuSepExport, mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new System.Drawing.Size(37, 20);
            mnuFile.Text = "&File";
            mnuFile.DropDownOpening += mnuFile_DropDownOpening;
            // 
            // mnuNew
            // 
            mnuNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuNewProject, mnuSepProject, mnuNewCSharpDiagram, mnuNewJavaDiagram });
            mnuNew.Image = Properties.Resources.NewDocument;
            mnuNew.Name = "mnuNew";
            mnuNew.Size = new System.Drawing.Size(165, 22);
            mnuNew.Text = "&New";
            mnuNew.DropDownOpening += mnuNew_DropDownOpening;
            // 
            // mnuNewProject
            // 
            mnuNewProject.Image = Properties.Resources.Project;
            mnuNewProject.Name = "mnuNewProject";
            mnuNewProject.Size = new System.Drawing.Size(143, 22);
            mnuNewProject.Text = "Project";
            mnuNewProject.Click += mnuNewProject_Click;
            // 
            // mnuSepProject
            // 
            mnuSepProject.Name = "mnuSepProject";
            mnuSepProject.Size = new System.Drawing.Size(140, 6);
            // 
            // mnuNewCSharpDiagram
            // 
            mnuNewCSharpDiagram.Name = "mnuNewCSharpDiagram";
            mnuNewCSharpDiagram.Size = new System.Drawing.Size(143, 22);
            mnuNewCSharpDiagram.Text = "&C# diagram";
            mnuNewCSharpDiagram.Visible = false;
            mnuNewCSharpDiagram.Click += mnuNewCSharpDiagram_Click;
            // 
            // mnuNewJavaDiagram
            // 
            mnuNewJavaDiagram.Name = "mnuNewJavaDiagram";
            mnuNewJavaDiagram.Size = new System.Drawing.Size(143, 22);
            mnuNewJavaDiagram.Text = "&Java diagram";
            mnuNewJavaDiagram.Visible = false;
            mnuNewJavaDiagram.Click += mnuNewJavaDiagram_Click;
            // 
            // mnuOpen
            // 
            mnuOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuOpenFile, sepOpenFile, mnuRecentFile1, mnuRecentFile2, mnuRecentFile3, mnuRecentFile4, mnuRecentFile5 });
            mnuOpen.Image = Properties.Resources.Open;
            mnuOpen.Name = "mnuOpen";
            mnuOpen.Size = new System.Drawing.Size(165, 22);
            mnuOpen.Text = "&Open";
            mnuOpen.DropDownOpening += mnuOpen_DropDownOpening;
            // 
            // mnuOpenFile
            // 
            mnuOpenFile.Name = "mnuOpenFile";
            mnuOpenFile.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            mnuOpenFile.Size = new System.Drawing.Size(144, 22);
            mnuOpenFile.Text = "&File...";
            mnuOpenFile.Click += mnuOpenFile_Click;
            // 
            // sepOpenFile
            // 
            sepOpenFile.Name = "sepOpenFile";
            sepOpenFile.Size = new System.Drawing.Size(141, 6);
            // 
            // mnuRecentFile1
            // 
            mnuRecentFile1.Name = "mnuRecentFile1";
            mnuRecentFile1.Size = new System.Drawing.Size(144, 22);
            mnuRecentFile1.Tag = 0;
            mnuRecentFile1.Text = "Recent File 1";
            mnuRecentFile1.Click += OpenRecentFile_Click;
            // 
            // mnuRecentFile2
            // 
            mnuRecentFile2.Name = "mnuRecentFile2";
            mnuRecentFile2.Size = new System.Drawing.Size(144, 22);
            mnuRecentFile2.Tag = 1;
            mnuRecentFile2.Text = "Recent File 2";
            mnuRecentFile2.Click += OpenRecentFile_Click;
            // 
            // mnuRecentFile3
            // 
            mnuRecentFile3.Name = "mnuRecentFile3";
            mnuRecentFile3.Size = new System.Drawing.Size(144, 22);
            mnuRecentFile3.Tag = 2;
            mnuRecentFile3.Text = "Recent File 3";
            mnuRecentFile3.Click += OpenRecentFile_Click;
            // 
            // mnuRecentFile4
            // 
            mnuRecentFile4.Name = "mnuRecentFile4";
            mnuRecentFile4.Size = new System.Drawing.Size(144, 22);
            mnuRecentFile4.Tag = 3;
            mnuRecentFile4.Text = "Recent File 4";
            mnuRecentFile4.Click += OpenRecentFile_Click;
            // 
            // mnuRecentFile5
            // 
            mnuRecentFile5.Name = "mnuRecentFile5";
            mnuRecentFile5.Size = new System.Drawing.Size(144, 22);
            mnuRecentFile5.Tag = 4;
            mnuRecentFile5.Text = "Recent File 5";
            mnuRecentFile5.Click += OpenRecentFile_Click;
            // 
            // mnuSepOpen
            // 
            mnuSepOpen.Name = "mnuSepOpen";
            mnuSepOpen.Size = new System.Drawing.Size(162, 6);
            // 
            // mnuSave
            // 
            mnuSave.Image = Properties.Resources.Save;
            mnuSave.Name = "mnuSave";
            mnuSave.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            mnuSave.Size = new System.Drawing.Size(165, 22);
            mnuSave.Text = "&Save";
            mnuSave.Click += mnuSave_Click;
            // 
            // mnuSaveAs
            // 
            mnuSaveAs.Name = "mnuSaveAs";
            mnuSaveAs.Size = new System.Drawing.Size(165, 22);
            mnuSaveAs.Text = "Save &As...";
            mnuSaveAs.Click += mnuSaveAs_Click;
            // 
            // mnuSaveAll
            // 
            mnuSaveAll.Image = Properties.Resources.SaveAll;
            mnuSaveAll.Name = "mnuSaveAll";
            mnuSaveAll.Size = new System.Drawing.Size(165, 22);
            mnuSaveAll.Text = "Save A&ll Projects";
            mnuSaveAll.Click += mnuSaveAll_Click;
            // 
            // mnuSepSaveAll
            // 
            mnuSepSaveAll.Name = "mnuSepSaveAll";
            mnuSepSaveAll.Size = new System.Drawing.Size(162, 6);
            // 
            // mnuPrint
            // 
            mnuPrint.Image = Properties.Resources.Print;
            mnuPrint.Name = "mnuPrint";
            mnuPrint.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P;
            mnuPrint.Size = new System.Drawing.Size(165, 22);
            mnuPrint.Text = "&Print...";
            mnuPrint.Click += mnuPrint_Click;
            // 
            // mnuSepPrint
            // 
            mnuSepPrint.Name = "mnuSepPrint";
            mnuSepPrint.Size = new System.Drawing.Size(162, 6);
            // 
            // mnuCloseProject
            // 
            mnuCloseProject.Name = "mnuCloseProject";
            mnuCloseProject.Size = new System.Drawing.Size(165, 22);
            mnuCloseProject.Text = "Close Project";
            mnuCloseProject.Click += mnuCloseProject_Click;
            // 
            // mnuCloseAllProjects
            // 
            mnuCloseAllProjects.Name = "mnuCloseAllProjects";
            mnuCloseAllProjects.Size = new System.Drawing.Size(165, 22);
            mnuCloseAllProjects.Text = "Close All Projects";
            mnuCloseAllProjects.Click += mnuCloseAllProjects_Click;
            // 
            // mnuSepClose
            // 
            mnuSepClose.Name = "mnuSepClose";
            mnuSepClose.Size = new System.Drawing.Size(162, 6);
            // 
            // mnuExport
            // 
            mnuExport.Name = "mnuExport";
            mnuExport.Size = new System.Drawing.Size(165, 22);
            mnuExport.Text = "Export";
            mnuExport.Visible = false;
            // 
            // mnuSepExport
            // 
            mnuSepExport.Name = "mnuSepExport";
            mnuSepExport.Size = new System.Drawing.Size(162, 6);
            mnuSepExport.Visible = false;
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4;
            mnuExit.Size = new System.Drawing.Size(165, 22);
            mnuExit.Text = "E&xit";
            mnuExit.Click += mnuExit_Click;
            // 
            // mnuEdit
            // 
            mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuUndo, mnuRedo, mnuSepReso, mnuCut, mnuCopy, mnuPaste, mnuDelete, mnuSepDelete, mnuSelectAll });
            mnuEdit.Name = "mnuEdit";
            mnuEdit.Size = new System.Drawing.Size(39, 20);
            mnuEdit.Text = "&Edit";
            mnuEdit.DropDownClosed += mnuEdit_DropDownClosed;
            mnuEdit.DropDownOpening += mnuEdit_DropDownOpening;
            // 
            // mnuUndo
            // 
            mnuUndo.Enabled = false;
            mnuUndo.Image = Properties.Resources.Undo;
            mnuUndo.Name = "mnuUndo";
            mnuUndo.ShortcutKeyDisplayString = "Ctrl+Z";
            mnuUndo.Size = new System.Drawing.Size(164, 22);
            mnuUndo.Text = "&Undo";
            mnuUndo.Visible = false;
            mnuUndo.Click += mnuUndo_Click;
            // 
            // mnuRedo
            // 
            mnuRedo.Enabled = false;
            mnuRedo.Image = Properties.Resources.Redo;
            mnuRedo.Name = "mnuRedo";
            mnuRedo.ShortcutKeyDisplayString = "Ctrl+Y";
            mnuRedo.Size = new System.Drawing.Size(164, 22);
            mnuRedo.Text = "&Redo";
            mnuRedo.Visible = false;
            mnuRedo.Click += mnuRedo_Click;
            // 
            // mnuSepReso
            // 
            mnuSepReso.Name = "mnuSepReso";
            mnuSepReso.Size = new System.Drawing.Size(161, 6);
            mnuSepReso.Visible = false;
            // 
            // mnuCut
            // 
            mnuCut.Image = Properties.Resources.Cut;
            mnuCut.Name = "mnuCut";
            mnuCut.ShortcutKeyDisplayString = "Ctrl+X";
            mnuCut.Size = new System.Drawing.Size(164, 22);
            mnuCut.Text = "Cu&t";
            mnuCut.Click += mnuCut_Click;
            // 
            // mnuCopy
            // 
            mnuCopy.Image = Properties.Resources.Copy;
            mnuCopy.Name = "mnuCopy";
            mnuCopy.ShortcutKeyDisplayString = "Ctrl+C";
            mnuCopy.Size = new System.Drawing.Size(164, 22);
            mnuCopy.Text = "&Copy";
            mnuCopy.Click += mnuCopy_Click;
            // 
            // mnuPaste
            // 
            mnuPaste.Image = Properties.Resources.Paste;
            mnuPaste.Name = "mnuPaste";
            mnuPaste.ShortcutKeyDisplayString = "Ctrl+V";
            mnuPaste.Size = new System.Drawing.Size(164, 22);
            mnuPaste.Text = "&Paste";
            mnuPaste.Click += mnuPaste_Click;
            // 
            // mnuDelete
            // 
            mnuDelete.Image = Properties.Resources.Delete;
            mnuDelete.Name = "mnuDelete";
            mnuDelete.ShortcutKeyDisplayString = "Del";
            mnuDelete.Size = new System.Drawing.Size(164, 22);
            mnuDelete.Text = "&Delete";
            mnuDelete.Click += mnuDelete_Click;
            // 
            // mnuSepDelete
            // 
            mnuSepDelete.Name = "mnuSepDelete";
            mnuSepDelete.Size = new System.Drawing.Size(161, 6);
            // 
            // mnuSelectAll
            // 
            mnuSelectAll.Name = "mnuSelectAll";
            mnuSelectAll.ShortcutKeyDisplayString = "";
            mnuSelectAll.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A;
            mnuSelectAll.Size = new System.Drawing.Size(164, 22);
            mnuSelectAll.Text = "Select &All";
            mnuSelectAll.Click += mnuSelectAll_Click;
            // 
            // mnuView
            // 
            mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuZoom, mnuAutoZoom, mnuSepAutoZoom, mnuModelExplorer, mnuDiagramNavigator, mnuSepDiagramNavigator, mnuCloseAllDocuments, toolStripSeparator3, mnuOptions });
            mnuView.Name = "mnuView";
            mnuView.Size = new System.Drawing.Size(44, 20);
            mnuView.Text = "&View";
            mnuView.DropDownOpening += mnuView_DropDownOpening;
            // 
            // mnuZoom
            // 
            mnuZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuZoom10, mnuZoom25, mnuZoom50, mnuSep50, mnuZoom100, toolStripSeparator4, mnuZoom150, mnuZoom200, mnuZoom400 });
            mnuZoom.Image = Properties.Resources.Zoom;
            mnuZoom.Name = "mnuZoom";
            mnuZoom.Size = new System.Drawing.Size(180, 22);
            mnuZoom.Text = "&Zoom";
            // 
            // mnuZoom10
            // 
            mnuZoom10.Name = "mnuZoom10";
            mnuZoom10.Size = new System.Drawing.Size(102, 22);
            mnuZoom10.Text = "10%";
            mnuZoom10.Click += mnuZoom10_Click;
            // 
            // mnuZoom25
            // 
            mnuZoom25.Name = "mnuZoom25";
            mnuZoom25.Size = new System.Drawing.Size(102, 22);
            mnuZoom25.Text = "25%";
            mnuZoom25.Click += mnuZoom25_Click;
            // 
            // mnuZoom50
            // 
            mnuZoom50.Name = "mnuZoom50";
            mnuZoom50.Size = new System.Drawing.Size(102, 22);
            mnuZoom50.Text = "50%";
            mnuZoom50.Click += mnuZoom50_Click;
            // 
            // mnuSep50
            // 
            mnuSep50.Name = "mnuSep50";
            mnuSep50.Size = new System.Drawing.Size(99, 6);
            // 
            // mnuZoom100
            // 
            mnuZoom100.Image = Properties.Resources.ActualSize;
            mnuZoom100.Name = "mnuZoom100";
            mnuZoom100.Size = new System.Drawing.Size(102, 22);
            mnuZoom100.Text = "100%";
            mnuZoom100.Click += mnuZoom100_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(99, 6);
            // 
            // mnuZoom150
            // 
            mnuZoom150.Name = "mnuZoom150";
            mnuZoom150.Size = new System.Drawing.Size(102, 22);
            mnuZoom150.Text = "150%";
            mnuZoom150.Click += mnuZoom150_Click;
            // 
            // mnuZoom200
            // 
            mnuZoom200.Name = "mnuZoom200";
            mnuZoom200.Size = new System.Drawing.Size(102, 22);
            mnuZoom200.Text = "200%";
            mnuZoom200.Click += mnuZoom200_Click;
            // 
            // mnuZoom400
            // 
            mnuZoom400.Name = "mnuZoom400";
            mnuZoom400.Size = new System.Drawing.Size(102, 22);
            mnuZoom400.Text = "400%";
            mnuZoom400.Click += mnuZoom400_Click;
            // 
            // mnuAutoZoom
            // 
            mnuAutoZoom.Image = Properties.Resources.AutoZoom;
            mnuAutoZoom.Name = "mnuAutoZoom";
            mnuAutoZoom.Size = new System.Drawing.Size(180, 22);
            mnuAutoZoom.Text = "&Auto Zoom";
            mnuAutoZoom.Click += mnuAutoZoom_Click;
            // 
            // mnuSepAutoZoom
            // 
            mnuSepAutoZoom.Name = "mnuSepAutoZoom";
            mnuSepAutoZoom.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuModelExplorer
            // 
            mnuModelExplorer.Checked = true;
            mnuModelExplorer.CheckOnClick = true;
            mnuModelExplorer.CheckState = System.Windows.Forms.CheckState.Checked;
            mnuModelExplorer.Name = "mnuModelExplorer";
            mnuModelExplorer.Size = new System.Drawing.Size(180, 22);
            mnuModelExplorer.Text = "Model &Explorer";
            mnuModelExplorer.Click += mnuModelExplorer_Click;
            // 
            // mnuDiagramNavigator
            // 
            mnuDiagramNavigator.Checked = true;
            mnuDiagramNavigator.CheckOnClick = true;
            mnuDiagramNavigator.CheckState = System.Windows.Forms.CheckState.Checked;
            mnuDiagramNavigator.Name = "mnuDiagramNavigator";
            mnuDiagramNavigator.Size = new System.Drawing.Size(180, 22);
            mnuDiagramNavigator.Text = "Diagram &Navigator";
            mnuDiagramNavigator.Click += mnuDiagramNavigator_Click;
            // 
            // mnuSepDiagramNavigator
            // 
            mnuSepDiagramNavigator.Name = "mnuSepDiagramNavigator";
            mnuSepDiagramNavigator.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuCloseAllDocuments
            // 
            mnuCloseAllDocuments.Name = "mnuCloseAllDocuments";
            mnuCloseAllDocuments.Size = new System.Drawing.Size(180, 22);
            mnuCloseAllDocuments.Text = "&Close All Documens";
            mnuCloseAllDocuments.Click += mnuCloseAllDocuments_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuOptions
            // 
            mnuOptions.Image = Properties.Resources.Options;
            mnuOptions.Name = "mnuOptions";
            mnuOptions.Size = new System.Drawing.Size(180, 22);
            mnuOptions.Text = "&Options...";
            mnuOptions.Click += mnuOptions_Click;
            // 
            // mnuPlugins
            // 
            mnuPlugins.Enabled = false;
            mnuPlugins.Name = "mnuPlugins";
            mnuPlugins.Size = new System.Drawing.Size(58, 20);
            mnuPlugins.Text = "&Plugins";
            mnuPlugins.Visible = false;
            mnuPlugins.DropDownOpening += mnuPlugins_DropDownOpening;
            // 
            // mnuHelp
            // 
            mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuContents, mnuCheckForUpdates, mnuSepUpdates, mnuAbout });
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new System.Drawing.Size(44, 20);
            mnuHelp.Text = "&Help";
            // 
            // mnuContents
            // 
            mnuContents.Image = Properties.Resources.Help;
            mnuContents.Name = "mnuContents";
            mnuContents.ShortcutKeys = System.Windows.Forms.Keys.F1;
            mnuContents.Size = new System.Drawing.Size(171, 22);
            mnuContents.Text = "&Contents";
            mnuContents.Visible = false;
            mnuContents.Click += mnuContents_Click;
            // 
            // mnuCheckForUpdates
            // 
            mnuCheckForUpdates.Image = Properties.Resources.SearchWeb;
            mnuCheckForUpdates.Name = "mnuCheckForUpdates";
            mnuCheckForUpdates.Size = new System.Drawing.Size(171, 22);
            mnuCheckForUpdates.Text = "Check for &Updates";
            mnuCheckForUpdates.Click += mnuCheckForUpdates_Click;
            // 
            // mnuSepUpdates
            // 
            mnuSepUpdates.Name = "mnuSepUpdates";
            mnuSepUpdates.Size = new System.Drawing.Size(168, 6);
            // 
            // mnuAbout
            // 
            mnuAbout.Name = "mnuAbout";
            mnuAbout.Size = new System.Drawing.Size(171, 22);
            mnuAbout.Text = "&About NClass...";
            mnuAbout.Click += mnuAbout_Click;
            // 
            // standardToolStrip
            // 
            standardToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            standardToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            standardToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            standardToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolNew, toolNewDiagram, toolOpen, toolSave, toolSaveAll, toolPrint, toolSepPrint, toolCut, toolCopy, toolPaste, toolSepPaste, toolUndo, toolRedo, toolSepRedo, toolZoomValue, toolZoomOut, toolZoom, toolZoomIn, toolAutoZoom });
            standardToolStrip.Location = new System.Drawing.Point(3, 24);
            standardToolStrip.Name = "standardToolStrip";
            standardToolStrip.Size = new System.Drawing.Size(523, 27);
            standardToolStrip.TabIndex = 1;
            // 
            // toolNew
            // 
            toolNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolNewProject, toolSepProject, toolNewCSharpDiagram, toolNewJavaDiagram });
            toolNew.Image = Properties.Resources.NewDocument;
            toolNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolNew.Name = "toolNew";
            toolNew.Size = new System.Drawing.Size(33, 24);
            toolNew.DropDownOpening += toolNew_DropDownOpening;
            // 
            // toolNewProject
            // 
            toolNewProject.Image = Properties.Resources.Project;
            toolNewProject.Name = "toolNewProject";
            toolNewProject.Size = new System.Drawing.Size(143, 22);
            toolNewProject.Text = "Project";
            toolNewProject.Click += mnuNewProject_Click;
            // 
            // toolSepProject
            // 
            toolSepProject.Name = "toolSepProject";
            toolSepProject.Size = new System.Drawing.Size(140, 6);
            // 
            // toolNewCSharpDiagram
            // 
            toolNewCSharpDiagram.Enabled = false;
            toolNewCSharpDiagram.Name = "toolNewCSharpDiagram";
            toolNewCSharpDiagram.Size = new System.Drawing.Size(143, 22);
            toolNewCSharpDiagram.Text = "C# diagram";
            toolNewCSharpDiagram.Visible = false;
            toolNewCSharpDiagram.Click += mnuNewCSharpDiagram_Click;
            // 
            // toolNewJavaDiagram
            // 
            toolNewJavaDiagram.Enabled = false;
            toolNewJavaDiagram.Name = "toolNewJavaDiagram";
            toolNewJavaDiagram.Size = new System.Drawing.Size(143, 22);
            toolNewJavaDiagram.Text = "Java diagram";
            toolNewJavaDiagram.Visible = false;
            toolNewJavaDiagram.Click += mnuNewJavaDiagram_Click;
            // 
            // toolNewDiagram
            // 
            toolNewDiagram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolNewDiagram.Image = Properties.Resources.NewDocument;
            toolNewDiagram.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolNewDiagram.Name = "toolNewDiagram";
            toolNewDiagram.Size = new System.Drawing.Size(33, 24);
            toolNewDiagram.Text = "toolStripDropDownButton1";
            // 
            // toolOpen
            // 
            toolOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolRecentFile1, toolRecentFile2, toolRecentFile3, toolRecentFile4, toolRecentFile5 });
            toolOpen.Image = Properties.Resources.Open;
            toolOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolOpen.Name = "toolOpen";
            toolOpen.Size = new System.Drawing.Size(36, 24);
            toolOpen.ButtonClick += mnuOpenFile_Click;
            toolOpen.DropDownOpening += toolOpen_DropDownOpening;
            // 
            // toolRecentFile1
            // 
            toolRecentFile1.Name = "toolRecentFile1";
            toolRecentFile1.Size = new System.Drawing.Size(138, 22);
            toolRecentFile1.Tag = 0;
            toolRecentFile1.Text = "Recent file 1";
            toolRecentFile1.Click += OpenRecentFile_Click;
            // 
            // toolRecentFile2
            // 
            toolRecentFile2.Name = "toolRecentFile2";
            toolRecentFile2.Size = new System.Drawing.Size(138, 22);
            toolRecentFile2.Tag = 1;
            toolRecentFile2.Text = "Recent file 2";
            toolRecentFile2.Click += OpenRecentFile_Click;
            // 
            // toolRecentFile3
            // 
            toolRecentFile3.Name = "toolRecentFile3";
            toolRecentFile3.Size = new System.Drawing.Size(138, 22);
            toolRecentFile3.Tag = 2;
            toolRecentFile3.Text = "Recent file 3";
            toolRecentFile3.Click += OpenRecentFile_Click;
            // 
            // toolRecentFile4
            // 
            toolRecentFile4.Name = "toolRecentFile4";
            toolRecentFile4.Size = new System.Drawing.Size(138, 22);
            toolRecentFile4.Tag = 3;
            toolRecentFile4.Text = "Recent file 4";
            toolRecentFile4.Click += OpenRecentFile_Click;
            // 
            // toolRecentFile5
            // 
            toolRecentFile5.Name = "toolRecentFile5";
            toolRecentFile5.Size = new System.Drawing.Size(138, 22);
            toolRecentFile5.Tag = 4;
            toolRecentFile5.Text = "Recent file 5";
            toolRecentFile5.Click += OpenRecentFile_Click;
            // 
            // toolSave
            // 
            toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolSave.Enabled = false;
            toolSave.Image = Properties.Resources.Save;
            toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolSave.Name = "toolSave";
            toolSave.Size = new System.Drawing.Size(24, 24);
            toolSave.Click += mnuSave_Click;
            // 
            // toolSaveAll
            // 
            toolSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolSaveAll.Enabled = false;
            toolSaveAll.Image = Properties.Resources.SaveAll;
            toolSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolSaveAll.Name = "toolSaveAll";
            toolSaveAll.Size = new System.Drawing.Size(24, 24);
            toolSaveAll.Text = "toolStripButton1";
            // 
            // toolPrint
            // 
            toolPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolPrint.Enabled = false;
            toolPrint.Image = Properties.Resources.Print;
            toolPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolPrint.Name = "toolPrint";
            toolPrint.Size = new System.Drawing.Size(24, 24);
            toolPrint.Click += mnuPrint_Click;
            // 
            // toolSepPrint
            // 
            toolSepPrint.Name = "toolSepPrint";
            toolSepPrint.Size = new System.Drawing.Size(6, 27);
            // 
            // toolCut
            // 
            toolCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolCut.Enabled = false;
            toolCut.Image = Properties.Resources.Cut;
            toolCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolCut.Name = "toolCut";
            toolCut.Size = new System.Drawing.Size(24, 24);
            toolCut.Click += toolCut_Click;
            // 
            // toolCopy
            // 
            toolCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolCopy.Enabled = false;
            toolCopy.Image = Properties.Resources.Copy;
            toolCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolCopy.Name = "toolCopy";
            toolCopy.Size = new System.Drawing.Size(24, 24);
            toolCopy.Click += toolCopy_Click;
            // 
            // toolPaste
            // 
            toolPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolPaste.Enabled = false;
            toolPaste.Image = Properties.Resources.Paste;
            toolPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolPaste.Name = "toolPaste";
            toolPaste.Size = new System.Drawing.Size(24, 24);
            toolPaste.Click += toolPaste_Click;
            // 
            // toolSepPaste
            // 
            toolSepPaste.Name = "toolSepPaste";
            toolSepPaste.Size = new System.Drawing.Size(6, 27);
            // 
            // toolUndo
            // 
            toolUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolUndo.Enabled = false;
            toolUndo.Image = Properties.Resources.Undo;
            toolUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolUndo.Name = "toolUndo";
            toolUndo.Size = new System.Drawing.Size(24, 24);
            toolUndo.Click += toolUndo_Click;
            // 
            // toolRedo
            // 
            toolRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolRedo.Enabled = false;
            toolRedo.Image = Properties.Resources.Redo;
            toolRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolRedo.Name = "toolRedo";
            toolRedo.Size = new System.Drawing.Size(24, 24);
            toolRedo.Click += toolRedo_Click;
            // 
            // toolSepRedo
            // 
            toolSepRedo.Name = "toolSepRedo";
            toolSepRedo.Size = new System.Drawing.Size(6, 27);
            // 
            // toolZoomValue
            // 
            toolZoomValue.AutoSize = false;
            toolZoomValue.Enabled = false;
            toolZoomValue.Name = "toolZoomValue";
            toolZoomValue.Size = new System.Drawing.Size(36, 22);
            toolZoomValue.Text = "100%";
            toolZoomValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolZoomOut
            // 
            toolZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolZoomOut.Enabled = false;
            toolZoomOut.Image = Properties.Resources.ZoomOut;
            toolZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolZoomOut.Name = "toolZoomOut";
            toolZoomOut.Size = new System.Drawing.Size(24, 24);
            toolZoomOut.Click += toolZoomOut_Click;
            // 
            // toolZoom
            // 
            toolZoom.Enabled = false;
            toolZoom.Name = "toolZoom";
            toolZoom.Size = new System.Drawing.Size(100, 24);
            toolZoom.ZoomValueChanged += toolZoom_ZoomValueChanged;
            // 
            // toolZoomIn
            // 
            toolZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolZoomIn.Enabled = false;
            toolZoomIn.Image = Properties.Resources.ZoomIn;
            toolZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolZoomIn.Name = "toolZoomIn";
            toolZoomIn.Size = new System.Drawing.Size(24, 24);
            toolZoomIn.Click += toolZoomIn_Click;
            // 
            // toolAutoZoom
            // 
            toolAutoZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolAutoZoom.Enabled = false;
            toolAutoZoom.Image = Properties.Resources.AutoZoom;
            toolAutoZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolAutoZoom.Name = "toolAutoZoom";
            toolAutoZoom.Size = new System.Drawing.Size(24, 24);
            toolAutoZoom.Click += mnuAutoZoom_Click;
            // 
            // MainForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1041, 768);
            Controls.Add(toolStripContainer);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = menuStrip;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(580, 338);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "NClass";
            Load += MainForm_Load;
            DragDrop += MainForm_DragDrop;
            DragEnter += MainForm_DragEnter;
            KeyDown += MainForm_KeyDown;
            KeyUp += MainForm_KeyUp;
            toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer.BottomToolStripPanel.PerformLayout();
            toolStripContainer.ContentPanel.ResumeLayout(false);
            toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer.TopToolStripPanel.PerformLayout();
            toolStripContainer.ResumeLayout(false);
            toolStripContainer.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            windowClient.Panel1.ResumeLayout(false);
            windowClient.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)windowClient).EndInit();
            windowClient.ResumeLayout(false);
            toolsPanel.Panel1.ResumeLayout(false);
            toolsPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)toolsPanel).EndInit();
            toolsPanel.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            standardToolStrip.ResumeLayout(false);
            standardToolStrip.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStrip standardToolStrip;
		private System.Windows.Forms.ToolStripMenuItem mnuFile;
		private System.Windows.Forms.ToolStripMenuItem mnuNew;
		private System.Windows.Forms.ToolStripMenuItem mnuNewCSharpDiagram;
		private System.Windows.Forms.ToolStripMenuItem mnuNewJavaDiagram;
		private System.Windows.Forms.ToolStripMenuItem mnuOpen;
		private System.Windows.Forms.ToolStripMenuItem mnuOpenFile;
		private System.Windows.Forms.ToolStripSeparator sepOpenFile;
		private System.Windows.Forms.ToolStripMenuItem mnuSave;
		private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
		private System.Windows.Forms.ToolStripSeparator mnuSepSaveAll;
		private System.Windows.Forms.ToolStripMenuItem mnuPrint;
		private System.Windows.Forms.ToolStripSeparator mnuSepPrint;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.ToolStripMenuItem mnuHelp;
		private System.Windows.Forms.ToolStripMenuItem mnuContents;
		private System.Windows.Forms.ToolStripSeparator mnuSepUpdates;
		private System.Windows.Forms.ToolStripMenuItem mnuAbout;
		private System.Windows.Forms.ToolStripMenuItem mnuRecentFile1;
		private System.Windows.Forms.ToolStripSplitButton toolOpen;
		private System.Windows.Forms.ToolStripButton toolSave;
		private System.Windows.Forms.ToolStripSeparator toolSepPrint;
		private System.Windows.Forms.ToolStripMenuItem mnuRecentFile2;
		private System.Windows.Forms.ToolStripMenuItem mnuRecentFile3;
		private System.Windows.Forms.ToolStripMenuItem mnuRecentFile4;
		private System.Windows.Forms.ToolStripMenuItem mnuRecentFile5;
		private System.Windows.Forms.ToolStripMenuItem toolRecentFile1;
		private System.Windows.Forms.ToolStripMenuItem toolRecentFile2;
		private System.Windows.Forms.ToolStripMenuItem toolRecentFile3;
		private System.Windows.Forms.ToolStripMenuItem toolRecentFile4;
		private System.Windows.Forms.ToolStripMenuItem toolRecentFile5;
		private System.Windows.Forms.ToolStripButton toolZoomIn;
		private System.Windows.Forms.ToolStripButton toolZoomOut;
		private System.Windows.Forms.ToolStripButton toolAutoZoom;
		private System.Windows.Forms.ToolStripStatusLabel lblLanguage;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
		private System.Windows.Forms.ToolStripButton toolPrint;
		private System.Windows.Forms.ToolStripMenuItem mnuEdit;
		private System.Windows.Forms.ToolStripMenuItem mnuUndo;
		private System.Windows.Forms.ToolStripMenuItem mnuRedo;
		private System.Windows.Forms.ToolStripSeparator mnuSepReso;
		private System.Windows.Forms.ToolStripMenuItem mnuCut;
		private System.Windows.Forms.ToolStripMenuItem mnuPaste;
		private System.Windows.Forms.ToolStripMenuItem mnuDelete;
		private System.Windows.Forms.ToolStripSeparator mnuSepDelete;
		private System.Windows.Forms.ToolStripMenuItem mnuSelectAll;
		private System.Windows.Forms.ToolStripMenuItem mnuCheckForUpdates;
		private System.Windows.Forms.ToolStripMenuItem mnuPlugins;
		private ZoomingToolStrip toolZoom;
		private System.Windows.Forms.ToolStripLabel toolZoomValue;
		private System.Windows.Forms.ToolStripMenuItem mnuSaveAll;
		private System.Windows.Forms.ToolStripMenuItem mnuCopy;
		private System.Windows.Forms.ToolStripMenuItem mnuView;
		private System.Windows.Forms.ToolStripButton toolCut;
		private System.Windows.Forms.ToolStripButton toolCopy;
		private System.Windows.Forms.ToolStripButton toolPaste;
		private System.Windows.Forms.ToolStripSeparator toolSepRedo;
		private System.Windows.Forms.ToolStripMenuItem mnuZoom;
		private System.Windows.Forms.ToolStripMenuItem mnuAutoZoom;
		private System.Windows.Forms.ToolStripButton toolUndo;
		private System.Windows.Forms.ToolStripButton toolRedo;
		private System.Windows.Forms.ToolStripSeparator toolSepPaste;
		private System.Windows.Forms.SplitContainer windowClient;
		private System.Windows.Forms.SplitContainer toolsPanel;
		private System.Windows.Forms.ToolStripMenuItem mnuModelExplorer;
		private System.Windows.Forms.ToolStripMenuItem mnuDiagramNavigator;
		private NClass.GUI.ModelExplorer.ModelView modelExplorer;
		private NClass.GUI.DiagramNavigator diagramNavigator;
		private TabbedWindow tabbedWindow;
		private System.Windows.Forms.ToolStripMenuItem mnuNewProject;
		private System.Windows.Forms.ToolStripSeparator mnuSepProject;
		private System.Windows.Forms.ToolStripDropDownButton toolNew;
		private System.Windows.Forms.ToolStripMenuItem toolNewProject;
		private System.Windows.Forms.ToolStripSeparator toolSepProject;
		private System.Windows.Forms.ToolStripMenuItem toolNewCSharpDiagram;
		private System.Windows.Forms.ToolStripMenuItem toolNewJavaDiagram;
		private System.Windows.Forms.ToolStripSeparator mnuSepClose;
		private System.Windows.Forms.ToolStripMenuItem mnuCloseProject;
		private System.Windows.Forms.ToolStripMenuItem mnuCloseAllProjects;
		private System.Windows.Forms.ToolStripMenuItem mnuCloseAllDocuments;
		private System.Windows.Forms.ToolStripSeparator mnuSepOpen;
		private System.Windows.Forms.ToolStripSeparator mnuSepAutoZoom;
		private System.Windows.Forms.ToolStripSeparator mnuSepDiagramNavigator;
		private System.Windows.Forms.ToolStripMenuItem mnuZoom10;
		private System.Windows.Forms.ToolStripMenuItem mnuZoom25;
		private System.Windows.Forms.ToolStripMenuItem mnuZoom50;
		private System.Windows.Forms.ToolStripSeparator mnuSep50;
		private System.Windows.Forms.ToolStripMenuItem mnuZoom100;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem mnuZoom150;
		private System.Windows.Forms.ToolStripMenuItem mnuZoom200;
		private System.Windows.Forms.ToolStripMenuItem mnuZoom400;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripDropDownButton toolNewDiagram;
        private System.Windows.Forms.ToolStripButton toolSaveAll;
        private System.Windows.Forms.ToolStripMenuItem mnuExport;
        private System.Windows.Forms.ToolStripSeparator mnuSepExport;
    }
}