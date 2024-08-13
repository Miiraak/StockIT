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
            dataGridViewDevice = new DataGridView();
            DeviceSite = new DataGridViewTextBoxColumn();
            DeviceRoom = new DataGridViewTextBoxColumn();
            DeviceName = new DataGridViewTextBoxColumn();
            DeviceModel = new DataGridViewTextBoxColumn();
            DeviceServiceTag = new DataGridViewTextBoxColumn();
            DeviceIP = new DataGridViewTextBoxColumn();
            DeviceETHport = new DataGridViewTextBoxColumn();
            DeviceUsername = new DataGridViewTextBoxColumn();
            DeviceOfficeSuite = new DataGridViewTextBoxColumn();
            DeviceOSVersion = new DataGridViewTextBoxColumn();
            DeviceAdminPW = new DataGridViewCheckBoxColumn();
            DeviceVDI = new DataGridViewCheckBoxColumn();
            DeviceWinUpdate = new DataGridViewCheckBoxColumn();
            DeviceChrome = new DataGridViewCheckBoxColumn();
            DeviceAdobe = new DataGridViewCheckBoxColumn();
            DeviceNewTeams = new DataGridViewCheckBoxColumn();
            DeviceAV = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDevice).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDevice
            // 
            dataGridViewDevice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDevice.Columns.AddRange(new DataGridViewColumn[] { DeviceSite, DeviceRoom, DeviceName, DeviceModel, DeviceServiceTag, DeviceIP, DeviceETHport, DeviceUsername, DeviceOfficeSuite, DeviceOSVersion, DeviceAdminPW, DeviceVDI, DeviceWinUpdate, DeviceChrome, DeviceAdobe, DeviceNewTeams, DeviceAV });
            dataGridViewDevice.Dock = DockStyle.Fill;
            dataGridViewDevice.Location = new Point(0, 0);
            dataGridViewDevice.Name = "dataGridViewDevice";
            dataGridViewDevice.Size = new Size(902, 394);
            dataGridViewDevice.TabIndex = 0;
            // 
            // DeviceSite
            // 
            DeviceSite.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DeviceSite.FillWeight = 20F;
            DeviceSite.HeaderText = "Site";
            DeviceSite.MinimumWidth = 100;
            DeviceSite.Name = "DeviceSite";
            // 
            // DeviceRoom
            // 
            DeviceRoom.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DeviceRoom.FillWeight = 10F;
            DeviceRoom.HeaderText = "Room";
            DeviceRoom.MinimumWidth = 50;
            DeviceRoom.Name = "DeviceRoom";
            // 
            // DeviceName
            // 
            DeviceName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DeviceName.FillWeight = 20F;
            DeviceName.HeaderText = "Workstation";
            DeviceName.MinimumWidth = 120;
            DeviceName.Name = "DeviceName";
            // 
            // DeviceModel
            // 
            DeviceModel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DeviceModel.FillWeight = 40F;
            DeviceModel.HeaderText = "Model";
            DeviceModel.MinimumWidth = 150;
            DeviceModel.Name = "DeviceModel";
            // 
            // DeviceServiceTag
            // 
            DeviceServiceTag.HeaderText = "Service Tag";
            DeviceServiceTag.MinimumWidth = 100;
            DeviceServiceTag.Name = "DeviceServiceTag";
            // 
            // DeviceIP
            // 
            DeviceIP.HeaderText = "IP";
            DeviceIP.MinimumWidth = 100;
            DeviceIP.Name = "DeviceIP";
            // 
            // DeviceETHport
            // 
            DeviceETHport.HeaderText = "ETH";
            DeviceETHport.MinimumWidth = 70;
            DeviceETHport.Name = "DeviceETHport";
            DeviceETHport.Width = 70;
            // 
            // DeviceUsername
            // 
            DeviceUsername.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DeviceUsername.HeaderText = "Username";
            DeviceUsername.MinimumWidth = 100;
            DeviceUsername.Name = "DeviceUsername";
            // 
            // DeviceOfficeSuite
            // 
            DeviceOfficeSuite.HeaderText = "Office suite";
            DeviceOfficeSuite.MinimumWidth = 100;
            DeviceOfficeSuite.Name = "DeviceOfficeSuite";
            DeviceOfficeSuite.Resizable = DataGridViewTriState.True;
            DeviceOfficeSuite.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // DeviceOSVersion
            // 
            DeviceOSVersion.HeaderText = "OS";
            DeviceOSVersion.MinimumWidth = 120;
            DeviceOSVersion.Name = "DeviceOSVersion";
            DeviceOSVersion.Resizable = DataGridViewTriState.True;
            DeviceOSVersion.SortMode = DataGridViewColumnSortMode.NotSortable;
            DeviceOSVersion.Width = 120;
            // 
            // DeviceAdminPW
            // 
            DeviceAdminPW.HeaderText = "Admin ?";
            DeviceAdminPW.MinimumWidth = 70;
            DeviceAdminPW.Name = "DeviceAdminPW";
            DeviceAdminPW.Width = 70;
            // 
            // DeviceVDI
            // 
            DeviceVDI.HeaderText = "VDI ?";
            DeviceVDI.MinimumWidth = 70;
            DeviceVDI.Name = "DeviceVDI";
            DeviceVDI.Width = 70;
            // 
            // DeviceWinUpdate
            // 
            DeviceWinUpdate.HeaderText = "Update ?";
            DeviceWinUpdate.MinimumWidth = 70;
            DeviceWinUpdate.Name = "DeviceWinUpdate";
            DeviceWinUpdate.Width = 70;
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
            // DeviceAdobe
            // 
            DeviceAdobe.HeaderText = "Adobe ?";
            DeviceAdobe.MinimumWidth = 70;
            DeviceAdobe.Name = "DeviceAdobe";
            DeviceAdobe.Width = 70;
            // 
            // DeviceNewTeams
            // 
            DeviceNewTeams.HeaderText = "Teams ?";
            DeviceNewTeams.MinimumWidth = 70;
            DeviceNewTeams.Name = "DeviceNewTeams";
            DeviceNewTeams.Width = 70;
            // 
            // DeviceAV
            // 
            DeviceAV.HeaderText = "Antivirus ?";
            DeviceAV.MinimumWidth = 70;
            DeviceAV.Name = "DeviceAV";
            DeviceAV.Width = 70;
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

        private DataGridView dataGridViewDevice;
        private DataGridViewTextBoxColumn DeviceSite;
        private DataGridViewTextBoxColumn DeviceRoom;
        private DataGridViewTextBoxColumn DeviceName;
        private DataGridViewTextBoxColumn DeviceModel;
        private DataGridViewTextBoxColumn DeviceServiceTag;
        private DataGridViewTextBoxColumn DeviceIP;
        private DataGridViewTextBoxColumn DeviceETHport;
        private DataGridViewTextBoxColumn DeviceUsername;
        private DataGridViewTextBoxColumn DeviceOfficeSuite;
        private DataGridViewTextBoxColumn DeviceOSVersion;
        private DataGridViewCheckBoxColumn DeviceAdminPW;
        private DataGridViewCheckBoxColumn DeviceVDI;
        private DataGridViewCheckBoxColumn DeviceWinUpdate;
        private DataGridViewCheckBoxColumn DeviceChrome;
        private DataGridViewCheckBoxColumn DeviceAdobe;
        private DataGridViewCheckBoxColumn DeviceNewTeams;
        private DataGridViewCheckBoxColumn DeviceAV;
    }
}
