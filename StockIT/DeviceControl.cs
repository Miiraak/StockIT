using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockIT
{
    public partial class DeviceControl : UserControl
    {
        public DeviceControl()
        {
            InitializeComponent();
        }
        public void InsertData()
        {
            using (FormAddDevice form = new())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    dataGridViewDevice.Rows.Add(
                        form.Site,
                        form.Room,
                        form.Workstation,
                        form.Model,
                        form.ServiceTag.ToUpper(),
                        form.IP,
                        form.ETH,
                        form.Username,
                        form.SuiteOffice,
                        form.OSVersion,
                        form.Admin,
                        form.VDI,
                        form.WindowsUpdate,
                        form.Chrome,
                        form.Adobe,
                        form.Teams,
                        form.Antivirus
                        );
                }
            }
        }
    }
}
