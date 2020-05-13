using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml.XPath;

namespace WindowsFormsApp4
{
  
    public partial class Aktualny_kurs : UserControl
    {
        
        private void UpdatePrice()
        {
            List<string> files = new List<string>();

            WebClient wc = new WebClient();
            wc.DownloadFile("http://www.nbp.pl/Kursy/xml/dir.txt", "dir.txt");

            StreamReader sr = new StreamReader("dir.txt");
            string line = "";

            while (line != null)
            {
                line = sr.ReadLine();

                if (line != null)
                {
                    if (line.StartsWith("a"))
                    {
                        files.Add(line);
                    }
                }
            }
            
            sr.Close();

            try
            {
                XPathDocument document = new XPathDocument("http://www.nbp.pl/kursy/xml/" + files[files.Count - 1] + ".xml");
                XPathNavigator navigator = document.CreateNavigator();
                XPathNodeIterator iterator;
                iterator = navigator.Select("tabela_kursow");

                foreach (XPathNavigator nav in iterator)
                {
                    bunifuCustomLabel8.Text = nav.SelectSingleNode("data_publikacji").Value;
                    bunifuCustomLabel8.Text = "Data kursu: " + bunifuCustomLabel8.Text;
                }

                iterator = navigator.Select("tabela_kursow/pozycja");

                foreach (XPathNavigator nav in iterator)
                {
                    if (nav.SelectSingleNode("kod_waluty").Value == "USD" || nav.SelectSingleNode("kod_waluty").Value == "EUR" || nav.SelectSingleNode("kod_waluty").Value == "GBP")
                    {
                        if (nav.SelectSingleNode("kod_waluty").Value == "EUR")
                        {
                            label_euro.Text = nav.SelectSingleNode("kurs_sredni").Value + " zł";
                            label_euro.Text = label_euro.Text;
                        }
                        else if (nav.SelectSingleNode("kod_waluty").Value == "USD")
                        {
                            label_usd.Text = nav.SelectSingleNode("kurs_sredni").Value + " zł";
                            label_usd.Text =label_usd.Text;
                        }
                        else
                        {
                            label_gbp.Text = nav.SelectSingleNode("kurs_sredni").Value + " zł";
                            label_gbp.Text = label_gbp.Text;
                        }
                    }
                }
            }
            catch (XPathException ex)
            {
                label_euro.Text = "Błąd. Nie można pobrać kursu walut!";
            }
        }
        public Aktualny_kurs()
        {
            InitializeComponent();
            
            UpdatePrice(); 
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void Aktualny_kurs_Load(object sender, EventArgs e)
        {

        }

        private void label_gbp_Click(object sender, EventArgs e)
        {

        }

        private void label_usd_Click(object sender, EventArgs e)
        {

        }

        private void b_LoadChart_Click(object sender, EventArgs e)
        {
            
            chart1.ChartAreas[0].AxisY.Minimum = 4.2;
            chart1.ChartAreas[0].AxisY.Maximum = 4.4;
            this.chart1.Series["EUR"].Points.AddXY("Styczeń", (4.2954));
            this.chart1.Series["EUR"].Points.AddXY("Luty", (4.305));
            this.chart1.Series["EUR"].Points.AddXY("Marzec", (4.3032));
            this.chart1.Series["EUR"].Points.AddXY("Kwiecień", (4.2992));
            this.chart1.Series["EUR"].Points.AddXY("Maj", (4.2987));
            this.chart1.Series["EUR"].Points.AddXY("Czerwiec", (4.2933));
            this.chart1.Series["EUR"].Points.AddXY("Lipiec", (4.2884));
            this.chart1.Series["EUR"].Points.AddXY("Serpień", (4.2954));
            this.chart1.Series["EUR"].Points.AddXY("Wrzesień", (4.3019));
            this.chart1.Series["EUR"].Points.AddXY("Październik", (4.302));
            this.chart1.Series["EUR"].Points.AddXY("Listopad", (4.3004));
            this.chart1.Series["EUR"].Points.AddXY("Grudzień", (4.298));
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            //chart1.ChartAreas[0].AxisY.Minimum =4;
            //chart1.ChartAreas[0].AxisY.Maximum = 4.6;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b_LoadGBP_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisY.Minimum = 4.8;
            chart1.ChartAreas[0].AxisY.Maximum = 5.0;
            this.chart1.Series["GBP"].Points.AddXY("Styczeń", (4.844));
            this.chart1.Series["GBP"].Points.AddXY("Luty", (4.8885));
            this.chart1.Series["GBP"].Points.AddXY("Marzec", (4.9301));
            this.chart1.Series["GBP"].Points.AddXY("Kwiecień", (4.9402));
            this.chart1.Series["GBP"].Points.AddXY("Maj", (4.9394));
            this.chart1.Series["GBP"].Points.AddXY("Czerwiec", (4.9146));
            this.chart1.Series["GBP"].Points.AddXY("Lipiec", (4.8888));
            this.chart1.Series["GBP"].Points.AddXY("Serpień", (4.8716));
            this.chart1.Series["GBP"].Points.AddXY("Wrzesień", (4.8716));
            this.chart1.Series["GBP"].Points.AddXY("Październik", (4.8761));
            this.chart1.Series["GBP"].Points.AddXY("Listopad", (4.8865));
            this.chart1.Series["GBP"].Points.AddXY("Grudzień", (4.8995));
        }

        private void b_LoadUSD_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisY.Minimum = 3.7;
            chart1.ChartAreas[0].AxisY.Maximum = 3.9;
            this.chart1.Series["USD"].Points.AddXY("Styczeń", (3.7617));
            this.chart1.Series["USD"].Points.AddXY("Luty", (3.781));
            this.chart1.Series["USD"].Points.AddXY("Marzec", (3.7893));
            this.chart1.Series["USD"].Points.AddXY("Kwiecień", (3.7956));
            this.chart1.Series["USD"].Points.AddXY("Maj", (3.8046));
            this.chart1.Series["USD"].Points.AddXY("Czerwiec", (3.8007));
            this.chart1.Series["USD"].Points.AddXY("Lipiec", (3.8));
            this.chart1.Series["USD"].Points.AddXY("Serpień", (3.8136));
            this.chart1.Series["USD"].Points.AddXY("Wrzesień", (3.829));
            this.chart1.Series["USD"].Points.AddXY("Październik", (3.8356));
            this.chart1.Series["USD"].Points.AddXY("Listopad", (3.8391));
            this.chart1.Series["USD"].Points.AddXY("Grudzień", (3.8395));
        }
    }
}
