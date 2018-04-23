namespace Office2010StyleApplicationMenu
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
			this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
			this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
			this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
			this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
			this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
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
			// pictureEdit1
			// 
			this.pictureEdit1.EditValue = global::Q258082.Properties.Resources.DocumentIcon;
			this.pictureEdit1.Location = new System.Drawing.Point(168, 18);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.AllowFocused = false;
			this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit1.Size = new System.Drawing.Size(100, 96);
			this.pictureEdit1.TabIndex = 1;
			// 
			// pictureEdit2
			// 
			this.pictureEdit2.EditValue = global::Q258082.Properties.Resources.DocumentIcon;
			this.pictureEdit2.Location = new System.Drawing.Point(318, 18);
			this.pictureEdit2.Name = "pictureEdit2";
			this.pictureEdit2.Properties.AllowFocused = false;
			this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit2.Size = new System.Drawing.Size(100, 96);
			this.pictureEdit2.TabIndex = 2;
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
			this.labelControl1.Appearance.Options.UseForeColor = true;
			this.labelControl1.Location = new System.Drawing.Point(341, 120);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(57, 13);
			this.labelControl1.TabIndex = 3;
			this.labelControl1.Text = "Document 2";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
			this.labelControl2.Appearance.Options.UseForeColor = true;
			this.labelControl2.Location = new System.Drawing.Point(189, 120);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(57, 13);
			this.labelControl2.TabIndex = 4;
			this.labelControl2.Text = "Document 1";
			// 
			// ApplicationButtonDropDownControl
			// 
			this.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.pictureEdit2);
			this.Controls.Add(this.pictureEdit1);
			this.Controls.Add(this.navBarControl1);
			this.Name = "ApplicationButtonDropDownControl";
			this.Size = new System.Drawing.Size(534, 418);
			this.Load += new System.EventHandler(this.ApplicationButtonDropDownControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
		private DevExpress.XtraNavBar.NavBarItem navBarItem3;
		private DevExpress.XtraNavBar.NavBarItem navBarItem4;
    }
}
