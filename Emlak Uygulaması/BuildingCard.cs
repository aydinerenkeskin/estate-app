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
    public partial class BuildingCard : Form
    {
        private static string myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        public BuildingCard()
        {
            InitializeComponent();
        }

        private void BuildingCard_Load(object sender, EventArgs e)
        {
            label10.Text = CheckCustomer.buildingId;
            label10.Hide();

            using (NpgsqlConnection con = new NpgsqlConnection(myConn))
            {
                con.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from buildings where id='" + label10.Text + "'";
                NpgsqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    lblBuildingType.Text = dr["building_type"].ToString();
                    lblWarmingType.Text = dr["warming_type"].ToString();
                    lblRoomCount.Text = dr["room_count"].ToString();
                    lblFloorCount.Text = dr["floor_count"].ToString();
                    lblAdress.Text = dr["adress"].ToString();
                    lblContact.Text = dr["contact"].ToString();
                    lblRentType.Text = dr["rent_type"].ToString();
                }
                con.Close();
            }
        }

        
    }
}
