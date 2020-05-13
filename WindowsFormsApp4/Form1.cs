using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //wymiana_walut1.BringToFront();
            //historia1.BringToFront();
            aktualny_kurs2.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //InitializeComponent();
          //  aktualny_kurs2.BringToFront();
         //   wymiana_walut1.BringToFront();
           
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            wymiana_walut1.BringToFront(); 
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            aktualny_kurs2.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            historia1.BringToFront();
            historia1.RefreshList();
        }

        private void Kantor_Click(object sender, EventArgs e)
        {

        }
        void MoveIndicator(Control control)
        {
            indicator.Top = control.Top;
            indicator.Height = control.Height; 
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

       

        private void wymiana_walut1_Load(object sender, EventArgs e)
        {

        }

        private void wymiana_walut1_Load_1(object sender, EventArgs e)
        {

        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wymiana_walut1_Load_2(object sender, EventArgs e)
        {

        }

        private void historia1_Load(object sender, EventArgs e)
        {

        }

        private void wykres_historia1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            wykres_historia1.BringToFront();
            MoveIndicator((Control)sender);
        }
    }
}
