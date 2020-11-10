using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mispisit_test
{
    public partial class Form3 : Form
    {
        int a;
        public Form3 (int n_RightAnswers, string UserName)
        {
            a = n_RightAnswers;
            InitializeComponent();
            label2.Text = UserName;
            label1.Text = "Всего вопросов: " + "20" + "\nПравильных ответов: " + a;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form2"].Close();
            this.Close();
        }
    }
}
