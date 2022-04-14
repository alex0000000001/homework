using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
    public partial class Frm_CityPhoto : Form
    {
        public Frm_CityPhoto()
        {
            InitializeComponent();
            this.city123TableAdapter1.Fill(this.cityDataSet1.City123);
            for(int i = 0; i <= cityDataSet1.City123.Rows.Count-1; i++)
            {
                LinkLabel x = new LinkLabel();
                string y = $"{ cityDataSet1.City123[i][1]}";
                x.Text = y;
                x.Top = 30 * i;
                x.Left = 5;
                x.Tag = i;
                this.panel1.Controls.Add(x);
                x.Click += X_Click;
            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(((LinkLabel)sender).Text+ " - " + ((LinkLabel)sender).Tag);
            LinkLabel x = sender as LinkLabel;
            if(x!= null)
            {
                // MessageBox.Show(x.Text + " - " + x.Tag);
                string cityN = x.Text;
                //this.city123TableAdapter1.FillBywhereCityname(this.cityDataSet1.City123,cityN);
                this.city123TableAdapter1.FillByTest(this.cityDataSet1.City123, cityN);
                this.dataGridView1.DataSource = this.cityDataSet1.City123;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmShow frmShow = new FrmShow();
            frmShow.Show();
        }
    }
}
