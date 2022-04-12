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
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        string PriceNumSmall, PriceNumBig;
        string ProductName;

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.bindingSource1.DataSource = this.nwDataSet1.Products;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveFirst();
        }

        private void btnprivious_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveLast();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            lblShow.Text = $"{bindingSource1.Position + 1} / {bindingSource1.Count}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductName = txtProductName.Text;
            this.productsTableAdapter1.FillByKeyWord(this.nwDataSet1.Products,ProductName);
            this.bindingSource1.DataSource = this.nwDataSet1.Products;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;

            lblResult.Text = $"關聯字{ProductName}結果為{bindingSource1.Count}筆";

        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            txtProductName.Text = "請輸入關鍵字";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int PriceNumSmall1, PriceNumBig1;

            PriceNumSmall = txtPriceFrom.Text;
            PriceNumBig = txtPriceEnd.Text;
            if (!String.IsNullOrEmpty(PriceNumSmall) && !String.IsNullOrEmpty(PriceNumBig))
            {
                if (int.TryParse(PriceNumSmall.ToString(), out PriceNumSmall1))
                {
                    if (int.TryParse(PriceNumBig.ToString(), out PriceNumBig1))
                    {

                        this.productsTableAdapter1.FillBySelectPrice(this.nwDataSet1.Products, PriceNumSmall1, PriceNumBig1);
                        this.bindingSource1.DataSource = this.nwDataSet1.Products;
                        this.dataGridView1.DataSource =this.bindingSource1 ;
                        this.bindingNavigator1.BindingSource = this.bindingSource1;
                        lblResult.Text = $"{PriceNumSmall}$到{PriceNumBig}$，結果為{bindingSource1.Count}筆";
                    }
                    else
                    {
                        MessageBox.Show("請輸入數字");
                    }
                }
                else
                {
                    MessageBox.Show("請輸入數字");
                }
            }
            else
            {
                MessageBox.Show("請輸入數字");
            }
        }
    }
}
