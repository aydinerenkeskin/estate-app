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
    public partial class EstateCard : Form
    {
        private static string myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        public EstateCard()
        {
            InitializeComponent();
        }

        private void EstateCard_Load(object sender, EventArgs e)
        {
            
            label10.Text = CheckCustomer.companyId;
            label10.Hide();

            using (NpgsqlConnection con = new NpgsqlConnection(myConn))
            {
                con.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from companys where id='" + label10.Text + "'";
                NpgsqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    lblCompanyName.Text = dr["company_name"].ToString();
                    lblCompanyPerson.Text = dr["company_person"].ToString();
                    lblAdress.Text = dr["adress"].ToString();
                    lblNumber.Text = dr["number"].ToString();
                    lblFax.Text = dr["fax"].ToString();
                }
                con.Close();
            }
        }
    }
}
