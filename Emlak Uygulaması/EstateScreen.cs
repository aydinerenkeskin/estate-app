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
    public partial class EstateScreen : Form
    {

        private static string myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        private const string SelectQuery = "Select * from buildings ORDER BY id ASC";
        private const string InsertQuery = "Insert Into buildings(rent_type, warming_type,building_Type, room_count, floor_count,adress,contact) Values (@rentType, @warmingType,@buildingType, @roomCount, @floorCount,@adress,@contact)";
        private const string UpdateQuery = "Update buildings set rent_type=@rentType, warming_type=@warmingType,building_type=@buildingType, room_count=@roomCount, floor_count=@floorCount,adress=@adress,contact=@contact where id=@id";
        private const string DeleteQuery = "Delete from buildings where id=@id";

        public void addComboBoxItems()
        {
            comboBox1.Items.Add("Kiralık");
            comboBox1.Items.Add("Satılık");
            comboBox2.Items.Add("Doğalgaz");
            comboBox2.Items.Add("Kömür");
            comboBox2.Items.Add("Elektrik");
            comboBox3.Items.Add("Daire");
            comboBox3.Items.Add("Rezidans");
            comboBox3.Items.Add("Villa");
            comboBox3.Items.Add("Dükkan");
        }
        public void clearData()
        {
            txtId.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            txtBoxRoomCount.Text = "";
            txtBoxFloorCount.Text = "";
            txtAdress.Text = "";
            txtContact.Text = "";
        }


        public EstateScreen()
        {
            InitializeComponent();
            addComboBoxItems();
            reloadData();
            txtId.Hide();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
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
                command.CommandText = SelectQuery;
                NpgsqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["id"].Visible = false;
                    dataGridView1.Columns["building_type"].HeaderText = "Bina Tipi";
                    dataGridView1.Columns["warming_type"].HeaderText = "Isınma Tipi";
                    dataGridView1.Columns["room_count"].HeaderText = "Oda Sayısı";
                    dataGridView1.Columns["floor_count"].HeaderText = "Kat Sayısı";
                    dataGridView1.Columns["adress"].HeaderText = "Adres";
                    dataGridView1.Columns["contact"].HeaderText = "İletişim";
                    dataGridView1.Columns["in_use"].HeaderText = "Kullanım Durumu";
                    dataGridView1.Columns["rent_type"].HeaderText = "Kiralama Tipi";
                }
                con.Close();
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;




            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != String.Empty && comboBox2.Text != String.Empty && txtBoxRoomCount.Text != String.Empty && txtBoxFloorCount.Text != String.Empty && txtAdress.Text != String.Empty && txtContact.Text != String.Empty)
            {

                using (NpgsqlConnection con = new NpgsqlConnection(myConn))
                {
                    con.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(InsertQuery, con))
                    {
                        command.Parameters.AddWithValue("@rentType", comboBox1.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@warmingType", comboBox2.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@buildingType", comboBox3.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@roomCount", txtBoxRoomCount.Text);
                        command.Parameters.AddWithValue("@floorCount", txtBoxFloorCount.Text);
                        command.Parameters.AddWithValue("@adress", txtAdress.Text);
                        command.Parameters.AddWithValue("@contact", txtContact.Text);
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
                MessageBox.Show("Lütfen Tüm Alanları Doldurun");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != String.Empty && comboBox2.Text != String.Empty && txtBoxRoomCount.Text != String.Empty && txtBoxFloorCount.Text != String.Empty && txtAdress.Text != String.Empty && txtContact.Text != String.Empty)
            {

                using (NpgsqlConnection con = new NpgsqlConnection(myConn))
                {
                    con.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(UpdateQuery, con))
                    {
                        command.Parameters.AddWithValue("@rentType", comboBox1.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@warmingType", comboBox2.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@buildingType", comboBox3.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@roomCount", txtBoxRoomCount.Text);
                        command.Parameters.AddWithValue("@floorCount", txtBoxFloorCount.Text);
                        command.Parameters.AddWithValue("@adress", txtAdress.Text);
                        command.Parameters.AddWithValue("@contact", txtContact.Text);
                        command.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Başarılı bir yapı Güncellediniz");
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

                MessageBox.Show("Başarılı bir yapı Sildiniz");
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
                comboBox1.Text = row.Cells["rent_type"].Value.ToString();
                comboBox2.Text = row.Cells["warming_type"].Value.ToString();
                comboBox3.Text = row.Cells["building_type"].Value.ToString();
                txtBoxRoomCount.Text = row.Cells["room_count"].Value.ToString();
                txtBoxFloorCount.Text = row.Cells["floor_count"].Value.ToString();
                txtAdress.Text = row.Cells["adress"].Value.ToString();
                txtContact.Text = row.Cells["contact"].Value.ToString();
                txtId.Text = row.Cells["id"].Value.ToString();
            }
        }
    }
}