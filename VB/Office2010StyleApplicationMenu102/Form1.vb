Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars.Ribbon

Namespace Office2010StyleApplicationMenu102
	Partial Public Class Form1
		Inherits RibbonForm
		Public Sub New()
			InitializeComponent()
			ribbon.ApplicationButtonDropDownControl = New ApplicationButtonDropDownControl()
		End Sub
	End Class
End Namespace
