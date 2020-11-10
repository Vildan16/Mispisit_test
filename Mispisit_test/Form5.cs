using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace Mispisit_test
{
    public partial class Form5 : Form
    {
        string connectionString;
        SqlConnection connection;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["Mispisit_test.Properties.Settings.Main_dbConnectionString"].ConnectionString;
            this.protocolTableAdapter.Fill(this.main_dbDataSet.Protocol);
            ShowChart();
        }
        private void ShowChart()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Protocol", connection))
            {
                DataTable ProtocolTable = new DataTable();
                adapter.Fill(ProtocolTable);

                int[] arr = ProtocolTable.AsEnumerable().Select(d => d.Field<int>("score")).ToArray();
                var frequency = arr.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
                for (int i = 0; i < frequency.Count; i++)
                {
                    this.chart1.Series["Series1"].Points.AddXY(frequency.ElementAt(i).Key, frequency.ElementAt(i).Value);
                }

            }
        }
    }
}
