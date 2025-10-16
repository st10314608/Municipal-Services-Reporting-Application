using System.Windows.Forms;

namespace Municipal_Services_Reporting_Application
{
    public partial class ServiceStatusForm : Form
    {
        public ServiceStatusForm()
        {
            InitializeComponent();
            new Controllers.ServiceStatusController(this);
        }
    }
}
