﻿using System;
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
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Form2 newForm = new Form2(textBox1.Text);
                newForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите фамилию!");
            }
        }
    }
}
