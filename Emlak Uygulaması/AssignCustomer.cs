using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak_Uygulaması
{
    public partial class AssignCustomer : Form
    {
        private static string myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        private const string customerQuery = "Select * from customers ORDER BY id ASC";
        private const string InsertCustomerBuilding = "Insert Into estatecustomers(company_id,building_id,customer_id) Values (@companyId, @buildingId,@customerId)";
        private const string UpdateQuery = "Update buildings set in_use=@inUse  where id=@Id";
        public static string customerId = "";
        public AssignCustomer()
        {
            InitializeComponent();
            reloadData();
        }

        public void reloadData()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(myConn))
            {
                con.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = customerQuery;
                NpgsqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["id"].Visible = false;
                    dataGridView1.Columns["name"].HeaderText = "Müşteri Adı";
                    dataGridView1.Columns["surname"].HeaderText = "Müşteri Soyadı";
                    dataGridView1.Columns["email"].HeaderText = "Adres";
                    dataGridView1.Columns["phone_number"].HeaderText = "Numara";

                }
                con.Close();
            }
        }

        private void AssignCustomer_Load(object sender, EventArgs e)
        {
            lblBuilding.Text = newRecordScreen.buildingId;
            lblCompany.Text = newRecordScreen.companyId;
            txtCustomer.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(myConn))
            {
                con.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from customers where email like '" + txtCustomerSearch.Text + "%' ";
                NpgsqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["id"].Visible = false;
                    dataGridView1.Columns["name"].HeaderText = "Müşteri Adı";
                    dataGridView1.Columns["surname"].HeaderText = "Müşteri Soyadı";
                    dataGridView1.Columns["email"].HeaderText = "Adres";
                    dataGridView1.Columns["phone_number"].HeaderText = "Numara";

                }
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtCustomer.Text = row.Cells["id"].Value.ToString();
                customerId = txtCustomer.Text;
            }
        }

        private void newRecord_Click(object sender, EventArgs e)
        {
            if(txtCustomer.Text != String.Empty)
            {
               
                    using (NpgsqlConnection con = new NpgsqlConnection(myConn))
                    {
                        con.Open();
                        using (NpgsqlCommand command = new NpgsqlCommand(InsertCustomerBuilding, con))
                        {
                            command.Parameters.AddWithValue("@companyId", Convert.ToInt32(lblCompany.Text));
                            command.Parameters.AddWithValue("@buildingId", Convert.ToInt32(lblBuilding.Text));
                            command.Parameters.AddWithValue("@customerId", Convert.ToInt32(txtCustomer.Text));
                        command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Başarılı bir kayıt oluşturdunuz");
                        reloadData();
                        con.Close();
                    }

                using (NpgsqlConnection con = new NpgsqlConnection(myConn))
                {
                    con.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(UpdateQuery, con))
                    {
                        command.Parameters.AddWithValue("@inUse", true);
                        command.Parameters.AddWithValue("@Id", Convert.ToInt32(lblBuilding.Text));
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Başarılı bir kayıt oluşturdunuz");
                    reloadData();
                    con.Close();
                }

                MessageBox.Show("Bina Durumu Güncellendi");



            }
            else
            {
                MessageBox.Show("Lütfen müşteri seçim yapınız");
            }
        }

        private void checkCustomer_Click(object sender, EventArgs e)
        {
           if(customerId != String.Empty)
            {
                CheckCustomer checkCustomer = new CheckCustomer();
                checkCustomer.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Müşteri Seçimi Yapınız");
            }
        }
    }
}
