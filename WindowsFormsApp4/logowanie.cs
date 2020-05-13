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
    public partial class logowanie : UserControl
    {
        public logowanie()
        {
            InitializeComponent();
        }

        private void logowanie_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\Data.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("Select COUNT(*) FROM [dbo].[Table] where [username]='" + login.text + "' and [password]='" + password.text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() != "0")
            {
                this.Hide();
                Form1 ss = new Form1();
                //Historia ss = new Historia();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Login lub hasło niepoprawne"); 
            }
             

        }

        private void wyjdz_Click(object sender, EventArgs e)
        {
             
        }

        private void password_OnTextChange(object sender, EventArgs e)
        {

        }
    }
}
