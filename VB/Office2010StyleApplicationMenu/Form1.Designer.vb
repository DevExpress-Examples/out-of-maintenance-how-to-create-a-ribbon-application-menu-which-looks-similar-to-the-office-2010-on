Imports Microsoft.VisualBasic
Imports System
Namespace Office2010StyleApplicationMenu
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.ribbon = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.barLinkContainerItem1 = New DevExpress.XtraBars.BarLinkContainerItem()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel()
			CType(Me.ribbon, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbon
			' 
			Me.ribbon.ApplicationButtonText = Nothing
			' 
			' 
			' 
			Me.ribbon.ExpandCollapseItem.Id = 0
			Me.ribbon.ExpandCollapseItem.Name = ""
			Me.ribbon.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbon.ExpandCollapseItem, Me.barLinkContainerItem1, Me.barButtonItem1})
			Me.ribbon.Location = New System.Drawing.Point(0, 0)
			Me.ribbon.MaxItemId = 2
			Me.ribbon.Name = "ribbon"
			Me.ribbon.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
			Me.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
			Me.ribbon.SelectedPage = Me.ribbonPage1
			Me.ribbon.Size = New System.Drawing.Size(938, 144)
			' 
			' barLinkContainerItem1
			' 
			Me.barLinkContainerItem1.Caption = "barLinkContainerItem1"
			Me.barLinkContainerItem1.Id = 0
			Me.barLinkContainerItem1.Name = "barLinkContainerItem1"
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "barButtonItem1"
			Me.barButtonItem1.Id = 1
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "ribbonPage1"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(938, 564)
			Me.Controls.Add(Me.ribbon)
			Me.Name = "Form1"
			Me.Ribbon = Me.ribbon
			Me.Text = "Form1"

			CType(Me.ribbon, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private ribbon As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private barLinkContainerItem1 As DevExpress.XtraBars.BarLinkContainerItem
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem

	End Class
End Namespace

