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
            Display();
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
            conn.Open();
            SqlCommand sqlc = new SqlCommand("DELETE FROM Mobiles WHERE (Phone = '" + textBox2.Text + "')", conn);

            sqlc.ExecuteNonQuery();
            Display();
            conn.Close();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sqlc = new SqlCommand("INSERT INTO Mobiles(Name, Phone, Email, Category) " +
                "VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "')", conn);

            sqlc.ExecuteNonQuery();
            Display();
            conn.Close();
          
        }

        void Display()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Mobiles", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                var n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();

            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sqlc = new SqlCommand(@"UPDATE Mobiles SET Name = '" + textBox1.Text + "' , Phone = '" + textBox2.Text + "', Email = '" + textBox3.Text + "', Category = '" + comboBox1.Text + "'WHERE (Phone = '" + textBox2.Text + "')", conn);
            sqlc.ExecuteNonQuery();
            conn.Close();
            Display();
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

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

      
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Mobiles WHERE Phone LIKE ('" + textBox4.Text + "%') or (Name LIKE '%" + textBox4.Text + "%')", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                var n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();

            }
           
        }
    }
}
