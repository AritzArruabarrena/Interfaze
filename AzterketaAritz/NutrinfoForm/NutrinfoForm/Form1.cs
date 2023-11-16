using NutrinfoForm.models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NutrinfoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            using (var db = new SalmentaDbContext())
            {
                var data = db.Elikagaia
                    .ToList();

                if (data != null)
                {
                    if (data.Count > 0)
                    {
                        dataGridView1.DataSource = data;
                    }
                }
                }

            }

        


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow lerroa = dataGridView1.SelectedRows[0];
            int aukeratuId = (int)lerroa.Cells["Id"].Value;
            using (var db = new SalmentaDbContext())
            {
                var data2 = db.Informazioa
                       .Include("Osagaia")
                       .Where(i => i.ElikagaiaId == aukeratuId)
                       .GroupBy(b => b.Osagaia.Izena)
                       .ToDictionary(g => g.Key, g => g.Sum(b => b.Kantitatea));
                if (data2 != null)
                {
                    if (data2.Count > 0)
                    {
                        var kontrolak = userControl11.Controls.OfType<Chart>(); foreach (var kontrol in kontrolak)
                        {
                            kontrol.DataSource = data2;
                            kontrol.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                            kontrol.Series[0].YValueMembers = "Value";
                            kontrol.Series[0].XValueMember = "Key";
                            kontrol.DataBind();
                        }
                    }
                }
            }
            {

                if (dataGridView1.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show("Mesedez, elikagai bat aukeratu behar duzu, eta ez gehiago");
            }
            if (dataGridView1.SelectedRows.Count.Equals(2))
            {
                MessageBox.Show("Mesedez, elikagai bat aukeratu behar duzu, eta ez gehiago");
            }
              
            }
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count.Equals(1)) { 
            DataGridViewRow lerroa = dataGridView1.SelectedRows[0];
            int aukeratuId = (int)lerroa.Cells["Id"].Value;

            using (var db = new SalmentaDbContext())
                { 
                var data2 = db.Informazioa
                   .Include("Osagaia")
                   .Where(i => i.ElikagaiaId == aukeratuId)
                   .GroupBy(b => b.Osagaia.Izena)
                   .ToDictionary(g => g.Key, g => g.Sum(b => b.Kantitatea));
                if (data2 != null)
                {
                    if (data2.Count > 0)
                    {
                        var kontrolak = userControl11.Controls.OfType<Chart>(); foreach (var kontrol in kontrolak)
                        {
                            kontrol.DataSource = data2;
                            kontrol.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                            kontrol.Series[0].YValueMembers = "Value";
                            kontrol.Series[0].XValueMember = "Key";
                            kontrol.DataBind();
                        }
                    }
                }
                }
            }
        }
    }
}