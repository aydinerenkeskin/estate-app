using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace Emlak_Uygulaması
{
    public partial class CustomerScreen : Form
    {

        private static string myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        private const string SelectQuery = "Select * from customers ORDER BY id ASC";
        private const string InsertQuery = "Insert Into customers(name, surname, email, phone_number) Values (@customerName, @customerSurname, @customerEmail, @customerPhoneNumber)";
        private const string UpdateQuery = "Update customers set name=@customerName, surname=@customerSurname, email=@customerEmail, phone_number=@customerPhoneNumber where id=@id";
        private const string DeleteQuery = "Delete from customers where id=@id";

    
        public void reloadData()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(myConn))
            {
                con.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = SelectQuery;
                NpgsqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridViewCustomer.DataSource = dt;
                    dataGridViewCustomer.Columns["id"].Visible = false;
                    dataGridViewCustomer.Columns["name"].HeaderText = "Müşteri Adı";
                    dataGridViewCustomer.Columns["surname"].HeaderText = "Müşteri Soyadı";
                    dataGridViewCustomer.Columns["email"].HeaderText = "Adres";
                    dataGridViewCustomer.Columns["phone_number"].HeaderText = "Numara";
                }
                con.Close();
                btnCustomerAdd.Enabled = true;
                btnUpdateCustomer.Enabled = false;
                btnCustomerDelete.Enabled = false;
            }
        }

        public void clearData()
        {
            txtId.Text = "";
            txtCustomerName.Text = "";
            txtCustomerSurname.Text = "";
            txtCustomerEmail.Text = "";
            txtCustomerPhone.Text = "";
        }
        public CustomerScreen()
        {
            InitializeComponent();
            txtId.Hide();
            btnUpdateCustomer.Enabled = false;
            btnCustomerDelete.Enabled = false;
            reloadData();
        }
        
        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {

            if(txtCustomerName.Text != String.Empty && txtCustomerSurname.Text != String.Empty && txtCustomerEmail.Text != String.Empty && txtCustomerPhone.Text != String.Empty)
            {

                using(NpgsqlConnection con = new NpgsqlConnection(myConn))
                {
                    con.Open();
                    using(NpgsqlCommand command = new NpgsqlCommand(InsertQuery,con))
                    {
                        command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
                        command.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
                        command.Parameters.AddWithValue("@customerEmail", txtCustomerEmail.Text);
                        command.Parameters.AddWithValue("@customerPhoneNumber", txtCustomerPhone.Text);
                       
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Başarılı bir müşteri Eklediniz");
                    clearData();
                    reloadData();
                    con.Close();
                }

            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurun");
            }

        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdateCustomer.Enabled = true;
            btnCustomerDelete.Enabled = true;
            btnCustomerAdd.Enabled = false;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewCustomer.Rows[e.RowIndex];
                txtCustomerName.Text = row.Cells["name"].Value.ToString();
                txtCustomerSurname.Text = row.Cells["surname"].Value.ToString();
                txtCustomerEmail.Text = row.Cells["email"].Value.ToString();
                txtCustomerPhone.Text = row.Cells["phone_number"].Value.ToString();
                txtId.Text = row.Cells["id"].Value.ToString();
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {

            using (NpgsqlConnection con = new NpgsqlConnection(myConn))
            {
                con.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(UpdateQuery, con))
                {
                    command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
                    command.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
                    command.Parameters.AddWithValue("@customerEmail", txtCustomerEmail.Text);
                    command.Parameters.AddWithValue("@customerPhoneNumber", txtCustomerPhone.Text);
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                    command.ExecuteNonQuery();
                    reloadData();
                }

                MessageBox.Show("Başarılı bir müşteri Güncellediniz");
                clearData();
                con.Close();
            }
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(myConn))
            {
                con.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(DeleteQuery, con))
                {
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                    command.ExecuteNonQuery();
                    reloadData();
                }

                MessageBox.Show("Başarılı bir müşteri Sildiniz");
                clearData();
                con.Close();
            }
        }
    }
}
