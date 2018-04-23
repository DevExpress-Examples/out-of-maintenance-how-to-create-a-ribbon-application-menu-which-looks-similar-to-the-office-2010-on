Imports Microsoft.VisualBasic
Imports System
Namespace Office2010StyleApplicationMenu
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
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
			Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
			Me.pictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
			' pictureEdit1
			' 
			Me.pictureEdit1.EditValue = My.Resources.DocumentIcon
			Me.pictureEdit1.Location = New System.Drawing.Point(168, 18)
			Me.pictureEdit1.Name = "pictureEdit1"
			Me.pictureEdit1.Properties.AllowFocused = False
			Me.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pictureEdit1.Size = New System.Drawing.Size(100, 96)
			Me.pictureEdit1.TabIndex = 1
			' 
			' pictureEdit2
			' 
			Me.pictureEdit2.EditValue = My.Resources.DocumentIcon
			Me.pictureEdit2.Location = New System.Drawing.Point(318, 18)
			Me.pictureEdit2.Name = "pictureEdit2"
			Me.pictureEdit2.Properties.AllowFocused = False
			Me.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pictureEdit2.Size = New System.Drawing.Size(100, 96)
			Me.pictureEdit2.TabIndex = 2
			' 
			' labelControl1
			' 
			Me.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black
			Me.labelControl1.Appearance.Options.UseForeColor = True
			Me.labelControl1.Location = New System.Drawing.Point(341, 120)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(57, 13)
			Me.labelControl1.TabIndex = 3
			Me.labelControl1.Text = "Document 2"
			' 
			' labelControl2
			' 
			Me.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black
			Me.labelControl2.Appearance.Options.UseForeColor = True
			Me.labelControl2.Location = New System.Drawing.Point(189, 120)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(57, 13)
			Me.labelControl2.TabIndex = 4
			Me.labelControl2.Text = "Document 1"
			' 
			' ApplicationButtonDropDownControl
			' 
			Me.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.Appearance.Options.UseBackColor = True
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.labelControl2)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.pictureEdit2)
			Me.Controls.Add(Me.pictureEdit1)
			Me.Controls.Add(Me.navBarControl1)
			Me.Name = "ApplicationButtonDropDownControl"
			Me.Size = New System.Drawing.Size(534, 418)
'			Me.Load += New System.EventHandler(Me.ApplicationButtonDropDownControl_Load);
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit
		Private pictureEdit2 As DevExpress.XtraEditors.PictureEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem3 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem4 As DevExpress.XtraNavBar.NavBarItem
	End Class
End Namespace
