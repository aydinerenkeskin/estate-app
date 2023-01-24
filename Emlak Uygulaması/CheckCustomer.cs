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
    public partial class CheckCustomer : Form
    {

        private static string myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        public static string buildingId = "";
        public static string companyId = "";

        public CheckCustomer()
        {
            InitializeComponent();
        }



        private void CheckCustomer_Load(object sender, EventArgs e)
        {
            txtCustomer.ReadOnly = true;
            txtBuildingId.ReadOnly = true;
            txtCompanyId.ReadOnly = true;
            txtCustomer.Text = AssignCustomer.customerId;
            using (NpgsqlConnection con = new NpgsqlConnection(myConn))
            {
                con.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "select building_id,company_id from estatecustomers where customer_id='" + txtCustomer.Text + "'";
                NpgsqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["building_id"].HeaderText = "Bina Numarası";
                    dataGridView1.Columns["company_id"].HeaderText = "Firma Numarası";

                }
                con.Close();
            }
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            if(txtCompanyId.Text != String.Empty)
            {
                EstateCard estateCard = new EstateCard();
                estateCard.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Seçim Yapınız");
            }
        }

        private void btnBuilding_Click(object sender, EventArgs e)
        {
            if (txtCompanyId.Text != String.Empty)
            {
                BuildingCard buildingCard = new BuildingCard();
                buildingCard.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Seçim Yapınız");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtBuildingId.Text = row.Cells["building_id"].Value.ToString();
                txtCompanyId.Text = row.Cells["company_id"].Value.ToString();
                buildingId = txtBuildingId.Text;
                companyId = txtCompanyId.Text;
            }
        }
    }
}
