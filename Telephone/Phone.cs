using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace Telephone
{
    public partial class Phone : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PR6QHBH\\SQLEXPRESS;Initial Catalog=Phone;Integrated Security=True");

        public Phone()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            textBox1.Focus();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            SqlCommand  ->  remove, insert, delete
                SqlDataAdapter -> Select
                SqlDataReader
        }

        private void readButton_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Phone_Load(object sender, EventArgs e)
        {
       
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
