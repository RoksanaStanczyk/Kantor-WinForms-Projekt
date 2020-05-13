using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp4
{

    public partial class Historia : UserControl
    {
        List<Transakcja> transakcje = new List<Transakcja>(); 
        public Historia()
        {
            InitializeComponent();
            RefreshList();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Historia_Load_1(object sender, EventArgs e)
        {
           
        }
        public void RefreshList()
        {
            listBox1.Items.Clear();
            SqlConnection con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\Data.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("Select * from [dbo].[Wymiany]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
               
                listBox1.Items.Add(dr["id"].ToString()+". | "+dr["Data"].ToString() + " | "
                    + dr["WalutaZ"].ToString()
                    + " | " + dr["WalutaDo"].ToString()
                    + " | " + dr["WartoscZ"].ToString()
                    + " | " + dr["WartoscDo"].ToString());
            }

        }  

        private void Usuń_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ROKSANA\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;");
            string number = listBox1.SelectedItem.ToString().Substring(0, listBox1.SelectedItem.ToString().IndexOf('.'));
            string comm =
                        $"DELETE FROM Wymiany WHERE Id = {number}";
            //String.Format("{0:0.00}", comm);
            //comm.ToString("0.00"); 
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.InsertCommand = new SqlCommand(comm, con);
                sda.InsertCommand.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
            }
            RefreshList();
        }
    }
}
