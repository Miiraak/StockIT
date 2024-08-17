namespace StockIT
{
    public partial class DeviceControl : UserControl
    {
        public DeviceControl()
        {
            InitializeComponent();
            DataManagment.LoadFromDataBase(dataGridViewDevice);
        }

        /// <summary>
        /// This method is used to insert data into the DataGridView.
        /// It opens the FormAddDevice form and if the user clicks OK, it adds the data of the properties in FormAddDevice to the DataGridView.
        /// </summary>
        public void InsertData()
        {
            using FormAddDevice form = new();
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

        private void dataGridViewDevice_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataManagment.DataGridViewSave(dataGridViewDevice);
        }

        private void dataGridViewDevice_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DataManagment.DataGridViewSave(dataGridViewDevice);
        }

        private void dataGridViewDevice_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataManagment.DataGridViewSave(dataGridViewDevice);
        }
    }
}
