using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project19929
{
    public partial class addremove : Form
    {

        public addremove()
        {
            InitializeComponent();
            ShowFood();
        }



        SqlConnection con = DBConnection.GetConnection();

        private void clear()
        {
            FoodName.Text = "";
            FoodCateg.SelectedIndex = -1;
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
                FoodView.DataSource = ds.Tables[0];
                con.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {



            if (FoodName.Text == "" || FoodCateg.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                // Inserts the values from the textbox above to UserTbl
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into FoodTBl (Food,FoodCategory,FDateAdded) values(@F,@FC,@FDA)", con);
                cmd.Parameters.AddWithValue("@F", FoodName.Text);
                cmd.Parameters.AddWithValue("@FC", FoodCateg.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@FDA", FoodDate.Value.Date);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Food added successfully!");
                con.Close();
                ShowFood();
                clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Deletes the user with the specified ID from UserTbl
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM FoodTBL WHERE Food = @F", con);
            cmd.Parameters.AddWithValue("@F", DelVal.Text);
            int rowsDeleted = cmd.ExecuteNonQuery();
            if (rowsDeleted > 0)
            {
                MessageBox.Show("Food data deleted successfully!");
                con.Close();
                ShowFood();
                DelVal.Text = "";
            }
            else
            {
                MessageBox.Show("Food data not found!");
            }
            con.Close();
        }



        private void FoodCateg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(fID.Text);
            if (fID.Text == "")
            {
                MessageBox.Show("Missing ID!");
            }
            else
            {
                // Updates the values from the FoodTBL
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE FoodTBL SET Food=@F,FoodCategory=@FC WHERE Id=@ID", con);
                cmd.Parameters.AddWithValue("@F", FoodName.Text);
                cmd.Parameters.AddWithValue("@FC", FoodCateg.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" updated successfully!");
                con.Close();
                ShowFood();
                clear();
            }
        }

        private void fID_TextChanged(object sender, EventArgs e)
        {
            // Retrieves the values from the FoodTBL table for the specified ID
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Food,FoodCategory FROM FoodTBL WHERE Id=@ID", con);
                int IDZ = Convert.ToInt32(fID.Text);
                cmd.Parameters.AddWithValue("@ID", IDZ);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    FoodName.Text = reader["Food"].ToString();
                    FoodCateg.SelectedItem = reader["FoodCategory"].ToString();
                }
                reader.Close();
                con.Close();


            }
            catch (Exception ex)
            {
                //MessageBox.Show("Invalid Values");
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}

