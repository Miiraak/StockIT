namespace StockIT
{
    internal class DataManagment
    {
        [Serializable]
        public class InventoryItem
        {
            public string? Site { get; set; }
            public string? Room { get; set; }
            public string? Name { get; set; }
            public string? Model { get; set; }
            public string? ServiceTag { get; set; }
            public string? IP { get; set; }
            public string? ETH { get; set; }
            public string? Username { get; set; }
            public string? SuiteOffice { get; set; }
            public string? OS { get; set; }
            public string? Admin { get; set; }
            public string? VDI { get; set; }
            public string? WinUpdate { get; set; }
            public string? Chrome { get; set; }
            public string? Adobe { get; set; }
            public string? Teams { get; set; }
            public string? AV { get; set; }
        }


        public static void DataGridViewSave(DataGridView dataGridView)
        {
            List<InventoryItem> inventoryItems = [];

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                InventoryItem item = new()
                {
                    Site = row.Cells["DeviceSite"].Value?.ToString(),
                    Room = row.Cells["DeviceRoom"].Value?.ToString(),
                    Name = row.Cells["DeviceName"].Value?.ToString(),
                    Model = row.Cells["DeviceModel"].Value?.ToString(),
                    ServiceTag = row.Cells["DeviceServiceTag"].Value?.ToString(),
                    IP = row.Cells["DeviceIP"].Value?.ToString(),
                    ETH = row.Cells["DeviceETH"].Value?.ToString(),
                    Username = row.Cells["DeviceUsername"].Value?.ToString(),
                    SuiteOffice = row.Cells["DeviceOfficeSuite"].Value?.ToString(),
                    OS = row.Cells["DeviceOS"].Value?.ToString(),
                    Admin = row.Cells["DeviceAdmin"].FormattedValue?.ToString(),
                    VDI = row.Cells["DeviceVDI"].FormattedValue?.ToString(),
                    WinUpdate = row.Cells["DeviceWinUpdate"].FormattedValue?.ToString(),
                    Chrome = row.Cells["DeviceChrome"].FormattedValue?.ToString(),
                    Adobe = row.Cells["DeviceAdobe"].FormattedValue?.ToString(),
                    Teams = row.Cells["DeviceTeams"].FormattedValue?.ToString(),
                    AV = row.Cells["DeviceAV"].FormattedValue?.ToString()
                };

                inventoryItems.Add(item);
            }

            using FileStream fs = new("D_DB.bin", FileMode.Create, FileAccess.Write);
            using BinaryWriter writer = new(fs);

            foreach (var item in inventoryItems)
            {
                writer.Write(item.Site ?? string.Empty);
                writer.Write(item.Room ?? string.Empty);
                writer.Write(item.Name ?? string.Empty);
                writer.Write(item.Model ?? string.Empty);
                writer.Write(item.ServiceTag ?? string.Empty);
                writer.Write(item.IP ?? string.Empty);
                writer.Write(item.ETH ?? string.Empty);
                writer.Write(item.Username ?? string.Empty);
                writer.Write(item.SuiteOffice ?? string.Empty);
                writer.Write(item.OS ?? string.Empty);
                writer.Write(item.Admin ?? string.Empty);
                writer.Write(item.VDI ?? string.Empty);
                writer.Write(item.WinUpdate ?? string.Empty);
                writer.Write(item.Chrome ?? string.Empty);
                writer.Write(item.Adobe ?? string.Empty);
                writer.Write(item.Teams ?? string.Empty);
                writer.Write(item.AV ?? string.Empty);
            }

        }

        public static void LoadFromDataBase(DataGridView dataGridView)
        {
            List<InventoryItem> inventoryItems = [];

            using (FileStream fs = new("D_DB.bin", FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new(fs))
            {
                while (fs.Position < fs.Length)
                {
                    InventoryItem item = new()
                    {
                        Site = reader.ReadString() ?? string.Empty,
                        Room = reader.ReadString() ?? string.Empty,
                        Name = reader.ReadString() ?? string.Empty,
                        Model = reader.ReadString() ?? string.Empty,
                        ServiceTag = reader.ReadString() ?? string.Empty,
                        IP = reader.ReadString() ?? string.Empty,
                        ETH = reader.ReadString() ?? string.Empty,
                        Username = reader.ReadString() ?? string.Empty,
                        SuiteOffice = reader.ReadString() ?? string.Empty,
                        OS = reader.ReadString() ?? string.Empty,
                        Admin = reader.ReadString() ?? string.Empty,
                        VDI = reader.ReadString() ?? string.Empty,
                        WinUpdate = reader.ReadString() ?? string.Empty,
                        Chrome = reader.ReadString() ?? string.Empty,
                        Adobe = reader.ReadString() ?? string.Empty,
                        Teams = reader.ReadString() ?? string.Empty,
                        AV = reader.ReadString() ?? string.Empty
                    };

                    inventoryItems.Add(item);
                }
            }

            dataGridView.Rows.Clear();
            foreach (var item in inventoryItems)
            {
                dataGridView.Rows.Add(item.Site,
                                      item.Room,
                                      item.Name,
                                      item.Model,
                                      item.ServiceTag,
                                      item.IP,
                                      item.ETH,
                                      item.Username,
                                      item.SuiteOffice,
                                      item.OS,
                                      item.Admin,
                                      item.VDI,
                                      item.WinUpdate,
                                      item.Chrome,
                                      item.Adobe,
                                      item.Teams,
                                      item.AV
                                      );
            }

        }
    }
}
