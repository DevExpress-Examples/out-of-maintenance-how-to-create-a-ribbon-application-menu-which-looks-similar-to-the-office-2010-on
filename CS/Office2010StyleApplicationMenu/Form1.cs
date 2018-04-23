using DevExpress.XtraBars.Ribbon;

namespace Office2010StyleApplicationMenu
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            ribbon.ApplicationButtonDropDownControl = new ApplicationButtonDropDownControl();
        }
    }
}
