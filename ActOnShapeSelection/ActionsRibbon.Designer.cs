namespace ActOnShapeSelection
{
    partial class ActionsRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public ActionsRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl1 = this.Factory.CreateRibbonDialogLauncher();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnRed = this.Factory.CreateRibbonToggleButton();
            this.btnGreen = this.Factory.CreateRibbonToggleButton();
            this.btnBlue = this.Factory.CreateRibbonToggleButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "Actions";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.DialogLauncher = ribbonDialogLauncherImpl1;
            this.group1.Items.Add(this.btnRed);
            this.group1.Items.Add(this.btnGreen);
            this.group1.Items.Add(this.btnBlue);
            this.group1.Label = "Colors";
            this.group1.Name = "group1";
            this.group1.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.group1_DialogLauncherClick);
            // 
            // btnRed
            // 
            this.btnRed.Label = "Red";
            this.btnRed.Name = "btnRed";
            this.btnRed.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnRed_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Label = "Green";
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Label = "Blue";
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnBlue_Click);
            // 
            // ActionsRibbon
            // 
            this.Name = "ActionsRibbon";
            this.RibbonType = "Microsoft.Visio.Drawing";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.ActionsRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton btnRed;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton btnGreen;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton btnBlue;
    }

    partial class ThisRibbonCollection
    {
        internal ActionsRibbon ActionsRibbon
        {
            get { return this.GetRibbon<ActionsRibbon>(); }
        }
    }
}
