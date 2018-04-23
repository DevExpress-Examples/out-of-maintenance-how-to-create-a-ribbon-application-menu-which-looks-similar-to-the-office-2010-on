using System;
using System.Drawing;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraNavBar.ViewInfo;

namespace Office2010StyleApplicationMenu
{
    public partial class ApplicationButtonDropDownControl : XtraUserControl
    {
        public ApplicationButtonDropDownControl()
        {
            InitializeComponent();
        }

		private void ApplicationButtonDropDownControl_Load(object sender, EventArgs e)
		{
			navBarControl1.View = new CustomNavPaneViewInfoRegistrator();
		}
    }

	public class CustomNavPaneViewInfoRegistrator : SkinNavigationPaneViewInfoRegistrator
	{
		public override string ViewName
		{
			get
			{
				return "CustomNavPaneView";
			}
		}
		public override NavBarViewInfo CreateViewInfo(NavBarControl navBar)
		{
			return new CustomNavPaneViewInfo(navBar);
		}
	}

	public class CustomNavPaneViewInfo : SkinNavigationPaneViewInfo
	{
		public CustomNavPaneViewInfo(NavBarControl navBar)
			: base(navBar)
		{
		}
		protected override NavigationPaneHeaderPainter CreateNavPaneHeaderPainter()
		{
			return new CustomNavPaneHeaderPainter(this);
		}
	}

	public class CustomNavPaneHeaderPainter : SkinNavigationPaneHeaderPainter
	{
		public CustomNavPaneHeaderPainter(NavigationPaneViewInfo navPAneVi)
			: base(navPAneVi)
		{
		}
		public override Rectangle CalcObjectMinBounds(ObjectInfoArgs e)
		{
			return Rectangle.Empty;
		}
	}
}
