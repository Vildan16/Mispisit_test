using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace Mispisit_test
{
    public partial class Form4 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.protocolTableAdapter.Fill(this.main_dbDataSet.Protocol);
            connectionString = ConfigurationManager.ConnectionStrings["Mispisit_test.Properties.Settings.Main_dbConnectionString"].ConnectionString;
            ShowSB();
        }

        private void protocolBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.protocolBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.main_dbDataSet);

        }

        private void protocolBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.protocolBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.main_dbDataSet);

        }

        private void ShowSB()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Protocol", connection))
            {
                DataTable ProtocolTable = new DataTable();
                adapter.Fill(ProtocolTable);

                int[] arr = ProtocolTable.AsEnumerable().Select(d => d.Field<int>("score")).ToArray();
                double SB = 0;
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                double p = 1.0 / arr.Length;
                double M = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    M += arr[i] * p;
                }
                double Dispers = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    Dispers = ((arr[i] - M) * (arr[i] - M)) * p;
                }
                SB = Convert.ToDouble(sum) / Convert.ToDouble(arr.Length);
                label_SB.Text = "Средний балл: " + Math.Round(SB, 2) + "\nДисперсия: " + Math.Round(Dispers, 2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 newForm5 = new Form5();
            newForm5.Show();
        }
    }
}
