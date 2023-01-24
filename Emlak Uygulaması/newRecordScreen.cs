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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Emlak_Uygulaması
{
    public partial class newRecordScreen : Form
    {

        private static string myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        private const string buildingQuery = "Select * from buildings WHERE in_use IS FALSE OR in_use IS NULL ORDER BY id ASC";
        private const string companyQuery = "Select * from companys ORDER BY id ASC";
        private const string InsertBuildingCompany = "Insert Into estatebuildings(company_id,building_id) Values (@companyId, @buildingId)";
        public static string buildingId = "";
        public static string companyId = "";


        public void clearData()
        {
            txtBuildingId.Text = "";
            txtEstateId.Text = "";
        }



        public newRecordScreen()
        {
            InitializeComponent();
            txtBuildingId.ReadOnly = true;
            txtEstateId.ReadOnly = true;
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
                command.CommandText = companyQuery;
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
            }

            using (NpgsqlConnection con = new NpgsqlConnection(myConn))
            {
                con.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = buildingQuery;
                NpgsqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView2.DataSource = dt;
                    dataGridView2.Columns["id"].Visible = false;
                    dataGridView2.Columns["building_type"].HeaderText = "Bina Tipi";
                    dataGridView2.Columns["warming_type"].HeaderText = "Isınma Tipi";
                    dataGridView2.Columns["room_count"].HeaderText = "Oda Sayısı";
                    dataGridView2.Columns["floor_count"].HeaderText = "Kat Sayısı";
                    dataGridView2.Columns["adress"].HeaderText = "Adres";
                    dataGridView2.Columns["contact"].HeaderText = "İletişim";
                    dataGridView2.Columns["in_use"].HeaderText = "Kullanım Durumu";
                    dataGridView2.Columns["rent_type"].HeaderText = "Kiralama Tipi";

                }
                con.Close();
            }
        }

        private void txtSearchEstate_TextChanged(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(myConn))
            {
                con.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from companys where company_name like '" + txtSearchEstate.Text + "%' or adress like '" + txtSearchEstate.Text + "%'";
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
            }
        }

        private void txtSearchBuilding_TextChanged(object sender, EventArgs e)
        {
           
            using (NpgsqlConnection con = new NpgsqlConnection(myConn))
            {
                con.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from buildings where in_use IS FALSE and adress like '" + txtSearchBuilding.Text + "%'";
                NpgsqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView2.DataSource = dt;
                    dataGridView2.Columns["id"].Visible = false;
                    dataGridView2.Columns["building_type"].HeaderText = "Bina Tipi";
                    dataGridView2.Columns["warming_type"].HeaderText = "Isınma Tipi";
                    dataGridView2.Columns["room_count"].HeaderText = "Oda Sayısı";
                    dataGridView2.Columns["floor_count"].HeaderText = "Kat Sayısı";
                    dataGridView2.Columns["adress"].HeaderText = "Adres";
                    dataGridView2.Columns["contact"].HeaderText = "İletişim";
                    dataGridView2.Columns["in_use"].HeaderText = "Kullanım Durumu";
                    dataGridView2.Columns["rent_type"].HeaderText = "Kiralama Tipi";

                }
                con.Close();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtEstateId.Text = row.Cells["id"].Value.ToString();
            }

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                txtBuildingId.Text = row.Cells["id"].Value.ToString();
            }
        }

        private void assignBuilding_Click(object sender, EventArgs e)
        {
            if (txtEstateId.Text != String.Empty && txtEstateId.Text != String.Empty)
            {

                using (NpgsqlConnection con = new NpgsqlConnection(myConn))
                {
                    con.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(InsertBuildingCompany, con))
                    {
                        command.Parameters.AddWithValue("@companyId", Convert.ToInt32(txtEstateId.Text));
                        command.Parameters.AddWithValue("@buildingId", Convert.ToInt32(txtBuildingId.Text));
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Başarılı bir yapı Eklediniz");
                    clearData();
                    reloadData();
                    con.Close();
                }

            }
            else
            {
                MessageBox.Show("Lütfen Emlak veya Bina Seçiniz");
            }


        }

        private void assignCustomer_Click(object sender, EventArgs e)
        {

            if(txtBuildingId.Text != String.Empty && txtEstateId.Text != String.Empty)
            {
                buildingId = txtBuildingId.Text;
                companyId = txtEstateId.Text;
                AssignCustomer assignCustomer = new AssignCustomer();
                assignCustomer.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Bina ve Müşteri Seçimi Yapınız");
            }
   
        }

  
    }
    }

