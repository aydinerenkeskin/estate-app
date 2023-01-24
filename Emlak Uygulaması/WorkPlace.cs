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
    public partial class WorkPlace : Form
    {

        private static string myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        private const string SelectQuery = "Select * from companys ORDER BY id ASC";
        private const string InsertQuery = "Insert Into companys(company_name, company_person, adress, number,fax) Values (@companyName, @companyPerson, @adress, @number,@fax)";
        private const string UpdateQuery = "Update companys set company_name=@companyName, company_person=@companyPerson, adress=@adress, number=@number,fax=@fax where id=@id";
        private const string DeleteQuery = "Delete from companys where id=@id";


 
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
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["id"].Visible = false;
                    dataGridView1.Columns["company_name"].HeaderText = "Firma Adı";
                    dataGridView1.Columns["company_person"].HeaderText = "Firma Yetkilisi";
                    dataGridView1.Columns["adress"].HeaderText = "Adres";
                    dataGridView1.Columns["number"].HeaderText = "Numara";
                    dataGridView1.Columns["Fax"].HeaderText = "Fax";

                }
                con.Close();
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

            }
        }

        public void clearData()
        {
            txtId.Text = "";
            txtCompanyName.Text = "";
            txtCompanyPerson.Text = "";
            txtAdress.Text = "";
            txtNumber.Text = "";
            txtFax.Text = "";
        }
        public WorkPlace()
        {
            InitializeComponent();
            reloadData();
            txtId.Hide();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            reloadData();
        }

      

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCompanyName.Text != String.Empty && txtCompanyPerson.Text != String.Empty && txtAdress.Text != String.Empty && txtNumber.Text != String.Empty && txtFax.Text != String.Empty)
            {

                using (NpgsqlConnection con = new NpgsqlConnection(myConn))
                {
                    con.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(InsertQuery, con))
                    {
                        command.Parameters.AddWithValue("@companyName", txtCompanyName.Text);
                        command.Parameters.AddWithValue("@companyPerson", txtCompanyPerson.Text);
                        command.Parameters.AddWithValue("@adress", txtAdress.Text);
                        command.Parameters.AddWithValue("@number", txtNumber.Text);
                        command.Parameters.AddWithValue("@fax", txtFax.Text);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Başarılı bir firma Eklediniz");
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCompanyName.Text != String.Empty && txtCompanyPerson.Text != String.Empty && txtAdress.Text != String.Empty && txtNumber.Text != String.Empty && txtFax.Text != String.Empty)
            {

                using (NpgsqlConnection con = new NpgsqlConnection(myConn))
                {
                    con.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(UpdateQuery, con))
                    {
                        command.Parameters.AddWithValue("@companyName", txtCompanyName.Text);
                        command.Parameters.AddWithValue("@companyPerson", txtCompanyPerson.Text);
                        command.Parameters.AddWithValue("@adress", txtAdress.Text);
                        command.Parameters.AddWithValue("@number", txtNumber.Text);
                        command.Parameters.AddWithValue("@fax", txtFax.Text);
                        command.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Başarılı bir firma Güncellediniz");
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

        private void btnDelete_Click(object sender, EventArgs e)
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

                MessageBox.Show("Başarılı bir şirket Sildiniz");
                clearData();
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtCompanyName.Text = row.Cells["company_name"].Value.ToString();
                txtCompanyPerson.Text = row.Cells["company_person"].Value.ToString();
                txtAdress.Text = row.Cells["adress"].Value.ToString();
                txtNumber.Text = row.Cells["number"].Value.ToString();
                txtFax.Text = row.Cells["fax"].Value.ToString();
                txtId.Text = row.Cells["id"].Value.ToString();
            }
        }
    }
}
