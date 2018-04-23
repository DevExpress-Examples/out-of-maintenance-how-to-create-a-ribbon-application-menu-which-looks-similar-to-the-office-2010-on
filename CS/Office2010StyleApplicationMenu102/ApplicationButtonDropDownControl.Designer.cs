namespace Office2010StyleApplicationMenu102
{
    partial class ApplicationButtonDropDownControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
			this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
			this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
			this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
			this.galleryControl1 = new DevExpress.XtraBars.Ribbon.GalleryControl();
			this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
			((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).BeginInit();
			this.galleryControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// navBarControl1
			// 
			this.navBarControl1.ActiveGroup = this.navBarGroup1;
			this.navBarControl1.ContentButtonHint = null;
			this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
			this.navBarControl1.HideGroupCaptions = true;
			this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem3,
            this.navBarItem4});
			this.navBarControl1.Location = new System.Drawing.Point(0, 0);
			this.navBarControl1.Name = "navBarControl1";
			this.navBarControl1.NavigationPaneMaxVisibleGroups = 0;
			this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
			this.navBarControl1.OptionsNavPane.ShowExpandButton = false;
			this.navBarControl1.OptionsNavPane.ShowOverflowButton = false;
			this.navBarControl1.OptionsNavPane.ShowOverflowPanel = false;
			this.navBarControl1.OptionsNavPane.ShowSplitter = false;
			this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
			this.navBarControl1.Size = new System.Drawing.Size(139, 418);
			this.navBarControl1.StoreDefaultPaintStyleName = true;
			this.navBarControl1.TabIndex = 0;
			this.navBarControl1.Text = "navBarControl1";
			// 
			// navBarGroup1
			// 
			this.navBarGroup1.Caption = "";
			this.navBarGroup1.Expanded = true;
			this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
			this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4)});
			this.navBarGroup1.Name = "navBarGroup1";
			// 
			// navBarItem3
			// 
			this.navBarItem3.Caption = "navBarItem3";
			this.navBarItem3.Name = "navBarItem3";
			this.navBarItem3.SmallImage = global::Q258082.Properties.Resources.normal;
			// 
			// navBarItem4
			// 
			this.navBarItem4.Caption = "navBarItem4";
			this.navBarItem4.Name = "navBarItem4";
			this.navBarItem4.SmallImage = global::Q258082.Properties.Resources.pressed;
			// 
			// galleryControl1
			// 
			this.galleryControl1.Controls.Add(this.galleryControlClient1);
			this.galleryControl1.DesignGalleryGroupIndex = 0;
			this.galleryControl1.DesignGalleryItemIndex = 0;
			this.galleryControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// galleryControl1
			// 
			this.galleryControl1.Gallery.BackColor = System.Drawing.Color.Transparent;
			galleryItemGroup1.Caption = "Group1";
			galleryItem1.Caption = "Document1";
			galleryItem1.Image = global::Q258082.Properties.Resources.DocumentIcon;
			galleryItem2.Caption = "Document2";
			galleryItem2.Image = global::Q258082.Properties.Resources.DocumentIcon;
			galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2});
			this.galleryControl1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
			this.galleryControl1.Gallery.ImageSize = new System.Drawing.Size(128, 128);
			this.galleryControl1.Gallery.ShowGroupCaption = false;
			this.galleryControl1.Gallery.ShowItemText = true;
			this.galleryControl1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
			this.galleryControl1.Gallery.UseMaxImageSize = true;
			this.galleryControl1.Location = new System.Drawing.Point(139, 0);
			this.galleryControl1.Name = "galleryControl1";
			this.galleryControl1.Size = new System.Drawing.Size(395, 418);
			this.galleryControl1.TabIndex = 1;
			this.galleryControl1.Text = "galleryControl1";
			// 
			// galleryControlClient1
			// 
			this.galleryControlClient1.GalleryControl = this.galleryControl1;
			this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
			this.galleryControlClient1.Size = new System.Drawing.Size(391, 414);
			// 
			// ApplicationButtonDropDownControl
			// 
			this.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.galleryControl1);
			this.Controls.Add(this.navBarControl1);
			this.Name = "ApplicationButtonDropDownControl";
			this.Size = new System.Drawing.Size(534, 418);
			this.Load += new System.EventHandler(this.ApplicationButtonDropDownControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).EndInit();
			this.galleryControl1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

		private DevExpress.XtraNavBar.NavBarControl navBarControl1;
		private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
		private DevExpress.XtraNavBar.NavBarItem navBarItem3;
		private DevExpress.XtraNavBar.NavBarItem navBarItem4;
		private DevExpress.XtraBars.Ribbon.GalleryControl galleryControl1;
		private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
    }
}
