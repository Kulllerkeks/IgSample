using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devdeer.IgSample.Ui.Old
{
    using System.Configuration;
    using System.Net.Http;

    using Newtonsoft.Json;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async Task ReloadDataAsync()
        {
            var url = ConfigurationManager.AppSettings.Get("ApiBaseUrl");
            var client = new HttpClient
            {
                BaseAddress = new Uri(url)
            };
            var result = await client.GetAsync("Employee");
            var resultText = await result.Content.ReadAsStringAsync();
            var decoded = JsonConvert.DeserializeObject<IEnumerable<EmployeeEntity>>(resultText);
            employeeGrid.DataSource = decoded;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await ReloadDataAsync();
        }
    }
}
