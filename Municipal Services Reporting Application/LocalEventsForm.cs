using System.Windows.Forms;

namespace Municipal_Services_Reporting_Application
{
    public partial class LocalEventsForm : Form
    {
        public LocalEventsForm()
        {
            InitializeComponent();
            new Controllers.LocalEventsController(this);
        }
    }
}

