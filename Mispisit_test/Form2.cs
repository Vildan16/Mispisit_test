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

namespace Mispisit_test
{
    public partial class Form2 : Form
    {
        string connectionString;
        SqlConnection connection;
        Dictionary<string, string> questions_dict;
        List<string> questions_list;
        static Random rnd = new Random();
        int n_Questions = 20;
        int n_Answers = 1;
        int n_RightAnswers = 0;

        public Form2(string UserName)
        {
            InitializeComponent();
            label1.Text = UserName;

            connectionString = ConfigurationManager.ConnectionStrings["Mispisit_test.Properties.Settings.Main_dbConnectionString"].ConnectionString;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            FillMassive();
            ShowQuestion();
        }
        private void FillMassive()
        {
            using (connection = new SqlConnection(connectionString))
            using(SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Questions", connection))
            {
                DataTable QuestionsTable = new DataTable();
                adapter.Fill(QuestionsTable);

                questions_dict = QuestionsTable.AsEnumerable().ToDictionary<DataRow, string, string>(row => row[1].ToString(), row => row[2].ToString());
                questions_list = questions_dict.Keys.ToList(); 
            }
        }

        private void ShowQuestion()
        {
            int r = rnd.Next(questions_list.Count);
            label_questions.Text = questions_list[r];
            questions_list.RemoveAt(r);
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == questions_dict[label_questions.Text])
            {
                n_RightAnswers++;
            }
            n_Answers++;
            textBox1.Clear();
            if (n_Answers <= n_Questions)
            {
                ShowQuestion();
            }
            else
            {
                AddProtocol(label1.Text, n_RightAnswers);
                Form3 newForm3 = new Form3(n_RightAnswers, label1.Text);
                newForm3.Show();
            }
        }

        private void AddProtocol(string secName, int score)
        {
            string query = "INSERT INTO Protocol (secName, date, score) VALUES (@secName, @date, @score)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                
                command.Parameters.AddWithValue("@secName", label1.Text);
                command.Parameters.AddWithValue("@date", DateTime.Now);
                command.Parameters.AddWithValue("@score", n_RightAnswers * 5);
                
                command.ExecuteNonQuery();
            }
        }
    }
}
