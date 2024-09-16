using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace preject2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SIAM\\SQLEXPRESS02; Initial Catalog=Project;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into asd values(@Name,@ID,@Salary)",con);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text );
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Salary", float.Parse(textBox3.Text) );
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SIAM\\SQLEXPRESS02;Initial Catalog=Project;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("update asd set Name=@Name, Salary=@Salary where ID=@ID", con);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Salary", float.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully updated");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SIAM\\SQLEXPRESS02;;Initial Catalog=Project;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete asd where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox2.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully deleted");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SIAM\\SQLEXPRESS02;Initial Catalog=Project;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from asd where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox2.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
