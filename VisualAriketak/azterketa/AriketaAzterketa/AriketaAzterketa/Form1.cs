using AriketaAzterketa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AriketaAzterketa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            using (var db = new SalmentaDbContext())
            {
                var botoaData = db.Botoa
                    .Include("Errezeta")
                    .Where(b => b.Urtea == comboBox1.Text)
                    .GroupBy(b => b.Errezeta.Izena)
                    .ToDictionary(g => g.Key, g => g.Count());

                if (botoaData != null)
                {
                    if (botoaData.Count > 0)
                    {
                        var kontrolak = userControl11.Controls.OfType<Chart>();
                        foreach (var kontrola in kontrolak)
                        {
                            kontrola.DataSource = botoaData;
                            kontrola.Series[0].YValueMembers = "Value";
                            kontrola.Series[0].XValueMember = "Key";
                            kontrola.DataBind();
                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new SalmentaDbContext())
            {
                var botoaData = db.Botoa
                    .Include("Errezeta")
                    .Where(b => b.Urtea == comboBox1.Text)
                    .GroupBy(b => b.Errezeta.Izena)
                    .ToDictionary(g => g.Key, g => g.Count());

                if (botoaData != null)
                {
                    if (botoaData.Count > 0)
                    {
                        var kontrolak = userControl11.Controls.OfType<Chart>();
                        foreach (var kontrola in kontrolak)
                        {
                            kontrola.DataSource = botoaData;
                            kontrola.Series[0].YValueMembers = "Value";
                            kontrola.Series[0].XValueMember = "Key";
                            kontrola.DataBind();
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mezua = "";
            int ondo = 0;
            //nan balidatu 9 karakter direla
            if (this.NANtextbox.Text.Length < 9)
            {
                mezua = mezua + " Nan-ak ez du 9 karaktere.";
            }
            else
            {
                ondo++;
            }
            //izen eta ezizena hutsik ez daudela balidatu
            if (this.IzenaTextBox.Text.Equals(""))
            {
                mezua = mezua + " Izena hutsik dago.";

            }
            else
            {
                ondo++;
            }
            if (this.EzizenaTextBox.Text.Equals(""))
            {
                mezua = mezua + " Ezizena hutsik dago.";
            }
            else
            {
                ondo++;
            }
            //Emaila ez dagoela hutsik eta gutxienez @ bat duela balidatu
            if (this.EmailaTextBox.Text.Equals(""))
            {
                mezua = mezua + " Emaila hutsik dago.";
            }
            else
            {
                if (!this.EmailaTextBox.Text.Contains("@"))
                {
                    mezua = mezua + " Emailak ez du formatu egokia.";
                }
                else
                {
                    ondo++;
                }
            }
            //errezeta id ez dagoela hutsik eta zenbakia dela balidatu
            if (this.ErrezataIDTextBox.Text.Equals(""))
            {
                mezua = mezua + " Errezeta Id-a hutsik dago.";
            }
            else
            {
                try
                {
                    int ErrezetaId = Int32.Parse(this.ErrezataIDTextBox.Text);
                    ondo++;
                }
                catch (Exception)
                { mezua = mezua + " Errezeta Id-a ez da zenbakia."; }
            }
            if (ondo == 5)            //balidazioa ondo = izena + ,zure botoa jaso dugu, eskerrik asko.
            {
                mezua = this.IzenaTextBox.Text + ", zure botoa jaso dugu, eskerrik asko.";
            }
            MessageBox.Show(mezua);
            
        }
    }
}
