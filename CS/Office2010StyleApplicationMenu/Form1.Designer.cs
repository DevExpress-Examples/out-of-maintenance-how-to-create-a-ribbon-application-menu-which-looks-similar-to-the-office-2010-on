namespace Office2010StyleApplicationMenu
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
			this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.barLinkContainerItem1 = new DevExpress.XtraBars.BarLinkContainerItem();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
			((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbon
			// 
			this.ribbon.ApplicationButtonText = null;
			// 
			// 
			// 
			this.ribbon.ExpandCollapseItem.Id = 0;
			this.ribbon.ExpandCollapseItem.Name = "";
			this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barLinkContainerItem1,
            this.barButtonItem1});
			this.ribbon.Location = new System.Drawing.Point(0, 0);
			this.ribbon.MaxItemId = 2;
			this.ribbon.Name = "ribbon";
			this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
			this.ribbon.SelectedPage = this.ribbonPage1;
			this.ribbon.Size = new System.Drawing.Size(938, 144);
			// 
			// barLinkContainerItem1
			// 
			this.barLinkContainerItem1.Caption = "barLinkContainerItem1";
			this.barLinkContainerItem1.Id = 0;
			this.barLinkContainerItem1.Name = "barLinkContainerItem1";
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Caption = "barButtonItem1";
			this.barButtonItem1.Id = 1;
			this.barButtonItem1.Name = "barButtonItem1";
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "ribbonPage1";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "ribbonPageGroup1";
			// 
			// defaultLookAndFeel1
			// 
			this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(938, 564);
			this.Controls.Add(this.ribbon);
			this.Name = "Form1";
			this.Ribbon = this.ribbon;
			this.Text = "Form1";
			
			((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarLinkContainerItem barLinkContainerItem1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;

    }
}

