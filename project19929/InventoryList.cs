using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project19929
{
    public partial class InventoryList : Form
    {
        public InventoryList()
        {
            InitializeComponent();
            ShowFood();
        }

        private void ShowFood()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = "select * from FoodTBL";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(SDA);
                var ds = new DataSet();
                SDA.Fill(ds);
                dagview.DataSource = ds.Tables[0];
                con.Close();
            }
        }


    }
}
