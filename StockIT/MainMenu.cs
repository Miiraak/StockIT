namespace StockIT
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            LoadControl(new OverviewControl());
        }

        /// <summary>
        /// This method is used to load the control in the PanelMenu.
        /// </summary>
        /// <param name="control">is the user control that will be loaded.</param>
        private void LoadControl(UserControl control)
        {
            PanelMenu.Controls.Clear();
            control.Dock = DockStyle.Fill;
            PanelMenu.Controls.Add(control);
        }

        private void ButtonOverview_Click(object sender, EventArgs e)
        {
            LoadControl(new OverviewControl());
            ButtonAdd.Visible = false;
            ButtonEdit.Visible = false;
        }

        private void ButtonDevice_Click(object sender, EventArgs e)
        {
            LoadControl(new DeviceControl());
            ButtonAdd.Visible = true;
            ButtonEdit.Visible = true;
        }

        private void ButtonInventory_Click(object sender, EventArgs e)
        {
            ButtonAdd.Visible = true;
            ButtonEdit.Visible = true;
        }

        // ______________________________________________________________________________________
        // ______________________________________________________________________________________
        // ______________________________________________________________________________________

        /// <summary>
        /// This method is used to export the data actually seen to an Excel file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExcel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method is used to open the options form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOptions_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method is used to add a new row to the table. By completing the form, the data will be added to the table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Controls[0] is DeviceControl)
            {
                DeviceControl deviceControl = (DeviceControl)PanelMenu.Controls[0];
                deviceControl.InsertData();
            }
        }

        /// <summary>
        /// This method is used to edit the selected row from the table. By editing the form, the data will be updated in the table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEdit_Click(object sender, EventArgs e)
        {

        }
    }
}