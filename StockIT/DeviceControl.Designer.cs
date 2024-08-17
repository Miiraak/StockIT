namespace StockIT
{
    partial class DeviceControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DeviceAV = new DataGridViewCheckBoxColumn();
            DeviceTeams = new DataGridViewCheckBoxColumn();
            DeviceAdobe = new DataGridViewCheckBoxColumn();
            DeviceChrome = new DataGridViewCheckBoxColumn();
            DeviceWinUpdate = new DataGridViewCheckBoxColumn();
            DeviceVDI = new DataGridViewCheckBoxColumn();
            DeviceAdmin = new DataGridViewCheckBoxColumn();
            DeviceOS = new DataGridViewTextBoxColumn();
            DeviceOfficeSuite = new DataGridViewTextBoxColumn();
            DeviceUsername = new DataGridViewTextBoxColumn();
            DeviceETH = new DataGridViewTextBoxColumn();
            DeviceIP = new DataGridViewTextBoxColumn();
            DeviceServiceTag = new DataGridViewTextBoxColumn();
            DeviceModel = new DataGridViewTextBoxColumn();
            DeviceName = new DataGridViewTextBoxColumn();
            DeviceRoom = new DataGridViewTextBoxColumn();
            DeviceSite = new DataGridViewTextBoxColumn();
            dataGridViewDevice = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDevice).BeginInit();
            SuspendLayout();
            // 
            // DeviceAV
            // 
            DeviceAV.HeaderText = "Antivirus ?";
            DeviceAV.MinimumWidth = 70;
            DeviceAV.Name = "DeviceAV";
            DeviceAV.Width = 70;
            // 
            // DeviceTeams
            // 
            DeviceTeams.HeaderText = "Teams ?";
            DeviceTeams.MinimumWidth = 70;
            DeviceTeams.Name = "DeviceTeams";
            DeviceTeams.Width = 70;
            // 
            // DeviceAdobe
            // 
            DeviceAdobe.HeaderText = "Adobe ?";
            DeviceAdobe.MinimumWidth = 70;
            DeviceAdobe.Name = "DeviceAdobe";
            DeviceAdobe.Width = 70;
            // 
            // DeviceChrome
            // 
            DeviceChrome.HeaderText = "Chrome ?";
            DeviceChrome.MinimumWidth = 70;
            DeviceChrome.Name = "DeviceChrome";
            DeviceChrome.Resizable = DataGridViewTriState.True;
            DeviceChrome.SortMode = DataGridViewColumnSortMode.Automatic;
            DeviceChrome.Width = 70;
            // 
            // DeviceWinUpdate
            // 
            DeviceWinUpdate.HeaderText = "Update ?";
            DeviceWinUpdate.MinimumWidth = 70;
            DeviceWinUpdate.Name = "DeviceWinUpdate";
            DeviceWinUpdate.Width = 70;
            // 
            // DeviceVDI
            // 
            DeviceVDI.HeaderText = "VDI ?";
            DeviceVDI.MinimumWidth = 70;
            DeviceVDI.Name = "DeviceVDI";
            DeviceVDI.Width = 70;
            // 
            // DeviceAdmin
            // 
            DeviceAdmin.HeaderText = "Admin ?";
            DeviceAdmin.MinimumWidth = 70;
            DeviceAdmin.Name = "DeviceAdmin";
            DeviceAdmin.Width = 70;
            // 
            // DeviceOS
            // 
            DeviceOS.HeaderText = "OS";
            DeviceOS.MinimumWidth = 120;
            DeviceOS.Name = "DeviceOS";
            DeviceOS.Resizable = DataGridViewTriState.True;
            DeviceOS.SortMode = DataGridViewColumnSortMode.NotSortable;
            DeviceOS.Width = 120;
            // 
            // DeviceOfficeSuite
            // 
            DeviceOfficeSuite.HeaderText = "Office suite";
            DeviceOfficeSuite.MinimumWidth = 100;
            DeviceOfficeSuite.Name = "DeviceOfficeSuite";
            DeviceOfficeSuite.Resizable = DataGridViewTriState.True;
            DeviceOfficeSuite.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // DeviceUsername
            // 
            DeviceUsername.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DeviceUsername.HeaderText = "Username";
            DeviceUsername.MinimumWidth = 100;
            DeviceUsername.Name = "DeviceUsername";
            // 
            // DeviceETH
            // 
            DeviceETH.HeaderText = "ETH";
            DeviceETH.MinimumWidth = 70;
            DeviceETH.Name = "DeviceETH";
            DeviceETH.Width = 70;
            // 
            // DeviceIP
            // 
            DeviceIP.HeaderText = "IP";
            DeviceIP.MinimumWidth = 100;
            DeviceIP.Name = "DeviceIP";
            // 
            // DeviceServiceTag
            // 
            DeviceServiceTag.HeaderText = "Service Tag";
            DeviceServiceTag.MinimumWidth = 100;
            DeviceServiceTag.Name = "DeviceServiceTag";
            // 
            // DeviceModel
            // 
            DeviceModel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DeviceModel.FillWeight = 40F;
            DeviceModel.HeaderText = "Model";
            DeviceModel.MinimumWidth = 150;
            DeviceModel.Name = "DeviceModel";
            // 
            // DeviceName
            // 
            DeviceName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DeviceName.FillWeight = 20F;
            DeviceName.HeaderText = "Workstation";
            DeviceName.MinimumWidth = 120;
            DeviceName.Name = "DeviceName";
            // 
            // DeviceRoom
            // 
            DeviceRoom.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DeviceRoom.FillWeight = 10F;
            DeviceRoom.HeaderText = "Room";
            DeviceRoom.MinimumWidth = 50;
            DeviceRoom.Name = "DeviceRoom";
            // 
            // DeviceSite
            // 
            DeviceSite.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DeviceSite.FillWeight = 20F;
            DeviceSite.HeaderText = "Site";
            DeviceSite.MinimumWidth = 100;
            DeviceSite.Name = "DeviceSite";
            // 
            // dataGridViewDevice
            // 
            dataGridViewDevice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDevice.Columns.AddRange(new DataGridViewColumn[] { DeviceSite, DeviceRoom, DeviceName, DeviceModel, DeviceServiceTag, DeviceIP, DeviceETH, DeviceUsername, DeviceOfficeSuite, DeviceOS, DeviceAdmin, DeviceVDI, DeviceWinUpdate, DeviceChrome, DeviceAdobe, DeviceTeams, DeviceAV });
            dataGridViewDevice.Dock = DockStyle.Fill;
            dataGridViewDevice.Location = new Point(0, 0);
            dataGridViewDevice.Name = "dataGridViewDevice";
            dataGridViewDevice.Size = new Size(902, 394);
            dataGridViewDevice.TabIndex = 0;
            dataGridViewDevice.CellValueChanged += dataGridViewDevice_CellValueChanged;
            dataGridViewDevice.RowsAdded += dataGridViewDevice_RowsAdded;
            dataGridViewDevice.RowsRemoved += dataGridViewDevice_RowsRemoved;
            // 
            // DeviceControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewDevice);
            Name = "DeviceControl";
            Size = new Size(902, 394);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDevice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewCheckBoxColumn DeviceAV;
        private DataGridViewCheckBoxColumn DeviceTeams;
        private DataGridViewCheckBoxColumn DeviceAdobe;
        private DataGridViewCheckBoxColumn DeviceChrome;
        private DataGridViewCheckBoxColumn DeviceWinUpdate;
        private DataGridViewCheckBoxColumn DeviceVDI;
        private DataGridViewCheckBoxColumn DeviceAdmin;
        private DataGridViewTextBoxColumn DeviceOS;
        private DataGridViewTextBoxColumn DeviceOfficeSuite;
        private DataGridViewTextBoxColumn DeviceUsername;
        private DataGridViewTextBoxColumn DeviceETH;
        private DataGridViewTextBoxColumn DeviceIP;
        private DataGridViewTextBoxColumn DeviceServiceTag;
        private DataGridViewTextBoxColumn DeviceModel;
        private DataGridViewTextBoxColumn DeviceName;
        private DataGridViewTextBoxColumn DeviceRoom;
        private DataGridViewTextBoxColumn DeviceSite;
        private DataGridView dataGridViewDevice;
    }
}
