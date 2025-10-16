using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Municipal_Services_Reporting_Application
{
    public partial class ReportIssuesForm : Form
    {
        
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, string lParam);

        private const int EM_SETCUEBANNER = 0x1501; 

        public ReportIssuesForm()
        {
            InitializeComponent();

            
            SetPlaceholder(txtLocation, "Enter the issue location (e.g., street, suburb)");

            
            new Controllers.ReportIssuesController(this);
        }

       
        
 
        private void SetPlaceholder(TextBox tb, string placeholder)
        {
            if (tb == null || string.IsNullOrEmpty(placeholder)) return;
            SendMessage(tb.Handle, EM_SETCUEBANNER, (IntPtr)1, placeholder);
        }
    }
}
