Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraNavBar.ViewInfo

Namespace Office2010StyleApplicationMenu
	Partial Public Class ApplicationButtonDropDownControl
		Inherits XtraUserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ApplicationButtonDropDownControl_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			navBarControl1.View = New CustomNavPaneViewInfoRegistrator()
		End Sub
	End Class

	Public Class CustomNavPaneViewInfoRegistrator
		Inherits SkinNavigationPaneViewInfoRegistrator
		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "CustomNavPaneView"
			End Get
		End Property
		Public Overrides Function CreateViewInfo(ByVal navBar As NavBarControl) As NavBarViewInfo
			Return New CustomNavPaneViewInfo(navBar)
		End Function
	End Class

	Public Class CustomNavPaneViewInfo
		Inherits SkinNavigationPaneViewInfo
		Public Sub New(ByVal navBar As NavBarControl)
			MyBase.New(navBar)
		End Sub
		Protected Overrides Function CreateNavPaneHeaderPainter() As NavigationPaneHeaderPainter
			Return New CustomNavPaneHeaderPainter(Me)
		End Function
	End Class

	Public Class CustomNavPaneHeaderPainter
		Inherits SkinNavigationPaneHeaderPainter
		Public Sub New(ByVal navPAneVi As NavigationPaneViewInfo)
			MyBase.New(navPAneVi)
		End Sub
		Public Overrides Function CalcObjectMinBounds(ByVal e As ObjectInfoArgs) As Rectangle
			Return Rectangle.Empty
		End Function
	End Class
End Namespace
