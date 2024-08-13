using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace StockIT
{
    public partial class FormAddDevice : Form
    {
        public string Site { get; private set; }
        public int Room { get; private set; }
        public string Workstation { get; private set; }
        public string Model { get; private set; }
        public string ServiceTag { get; private set; }
        public string IP { get; private set; }
        public string ETH { get; private set; }
        public string Username { get; private set; }
        public string SuiteOffice { get; private set; }
        public string OSVersion { get; private set; }
        public bool Admin { get; private set; }
        public bool VDI { get; private set; }
        public bool WindowsUpdate { get; private set; }
        public bool Chrome { get; private set; }
        public bool Adobe { get; private set; }
        public bool Teams { get; private set; }
        public bool Antivirus { get; private set; }

        public FormAddDevice()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Site = textBoxSite.Text;
            Room = Convert.ToInt32(textBoxOffice.Text);
            Workstation = textBoxWorkstation.Text;
            Model = textBoxModel.Text;
            ServiceTag = textBoxServiceTag.Text;
            IP = textBoxIP.Text;
            ETH = textBoxETH.Text;
            Username = textBoxUsername.Text;
            SuiteOffice = comboBoxMicrosoftSuite.Text;
            OSVersion = comboBoxOSVersion.Text;
            Admin = checkBoxPasswordAdmin.Checked;
            VDI = checkBoxVDI.Checked;
            WindowsUpdate = checkBoxWindowsUpdate.Checked;
            Chrome = checkBoxChromeUpdate.Checked;
            Adobe = checkBoxAdobeUpdate.Checked;
            Teams = checkBoxNewTeams.Checked;
            Antivirus = checkBoxKaspersky.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }
    }
}
