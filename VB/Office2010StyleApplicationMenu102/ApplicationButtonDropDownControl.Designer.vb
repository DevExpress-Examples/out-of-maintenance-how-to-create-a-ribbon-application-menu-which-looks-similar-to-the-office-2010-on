Imports Microsoft.VisualBasic
Imports System
Namespace Office2010StyleApplicationMenu102
	Partial Public Class ApplicationButtonDropDownControl
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim galleryItemGroup1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim galleryItem1 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem2 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
			Me.galleryControl1 = New DevExpress.XtraBars.Ribbon.GalleryControl()
			Me.galleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.galleryControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.galleryControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Me.navBarGroup1
			Me.navBarControl1.ContentButtonHint = Nothing
			Me.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup1})
			Me.navBarControl1.HideGroupCaptions = True
			Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() { Me.navBarItem3, Me.navBarItem4})
			Me.navBarControl1.Location = New System.Drawing.Point(0, 0)
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.NavigationPaneMaxVisibleGroups = 0
			Me.navBarControl1.OptionsNavPane.ExpandedWidth = 140
			Me.navBarControl1.OptionsNavPane.ShowExpandButton = False
			Me.navBarControl1.OptionsNavPane.ShowOverflowButton = False
			Me.navBarControl1.OptionsNavPane.ShowOverflowPanel = False
			Me.navBarControl1.OptionsNavPane.ShowSplitter = False
			Me.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
			Me.navBarControl1.Size = New System.Drawing.Size(139, 418)
			Me.navBarControl1.StoreDefaultPaintStyleName = True
			Me.navBarControl1.TabIndex = 0
			Me.navBarControl1.Text = "navBarControl1"
			' 
			' navBarGroup1
			' 
			Me.navBarGroup1.Caption = ""
			Me.navBarGroup1.Expanded = True
			Me.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
			Me.navBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem3), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem4)})
			Me.navBarGroup1.Name = "navBarGroup1"
			' 
			' navBarItem3
			' 
			Me.navBarItem3.Caption = "navBarItem3"
			Me.navBarItem3.Name = "navBarItem3"
			Me.navBarItem3.SmallImage = My.Resources.normal
			' 
			' navBarItem4
			' 
			Me.navBarItem4.Caption = "navBarItem4"
			Me.navBarItem4.Name = "navBarItem4"
			Me.navBarItem4.SmallImage = My.Resources.pressed
			' 
			' galleryControl1
			' 
			Me.galleryControl1.Controls.Add(Me.galleryControlClient1)
			Me.galleryControl1.DesignGalleryGroupIndex = 0
			Me.galleryControl1.DesignGalleryItemIndex = 0
			Me.galleryControl1.Dock = System.Windows.Forms.DockStyle.Fill
			' 
			' galleryControl1
			' 
			Me.galleryControl1.Gallery.BackColor = System.Drawing.Color.Transparent
			galleryItemGroup1.Caption = "Group1"
			galleryItem1.Caption = "Document1"
			galleryItem1.Image = My.Resources.DocumentIcon
			galleryItem2.Caption = "Document2"
			galleryItem2.Image = My.Resources.DocumentIcon
			galleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { galleryItem1, galleryItem2})
			Me.galleryControl1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1})
			Me.galleryControl1.Gallery.ImageSize = New System.Drawing.Size(128, 128)
			Me.galleryControl1.Gallery.ShowGroupCaption = False
			Me.galleryControl1.Gallery.ShowItemText = True
			Me.galleryControl1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
			Me.galleryControl1.Gallery.UseMaxImageSize = True
			Me.galleryControl1.Location = New System.Drawing.Point(139, 0)
			Me.galleryControl1.Name = "galleryControl1"
			Me.galleryControl1.Size = New System.Drawing.Size(395, 418)
			Me.galleryControl1.TabIndex = 1
			Me.galleryControl1.Text = "galleryControl1"
			' 
			' galleryControlClient1
			' 
			Me.galleryControlClient1.GalleryControl = Me.galleryControl1
			Me.galleryControlClient1.Location = New System.Drawing.Point(2, 2)
			Me.galleryControlClient1.Size = New System.Drawing.Size(391, 414)
			' 
			' ApplicationButtonDropDownControl
			' 
			Me.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.Appearance.Options.UseBackColor = True
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.galleryControl1)
			Me.Controls.Add(Me.navBarControl1)
			Me.Name = "ApplicationButtonDropDownControl"
			Me.Size = New System.Drawing.Size(534, 418)
'			Me.Load += New System.EventHandler(Me.ApplicationButtonDropDownControl_Load);
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.galleryControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.galleryControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem3 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem4 As DevExpress.XtraNavBar.NavBarItem
		Private galleryControl1 As DevExpress.XtraBars.Ribbon.GalleryControl
		Private galleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
	End Class
End Namespace
