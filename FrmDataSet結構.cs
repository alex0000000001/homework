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
    public partial class FrmDataSet結構 : Form
    {
        public FrmDataSet結構()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.categoriesTableAdapter1.Fill(this.nwDataSet1.Categories);
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.customersTableAdapter1.Fill(this.nwDataSet1.Customers);

            dataGridView4.DataSource = this.nwDataSet1.Categories;
            dataGridView5.DataSource = this.nwDataSet1.Products;
            dataGridView6.DataSource = this.nwDataSet1.Customers;

            listBox2.Items.Clear();
            for (int i = 0; i <= this.nwDataSet1.Tables.Count - 1; i++)
            {
                DataTable table = this.nwDataSet1.Tables[i];
                this.listBox2.Items.Add(table.TableName);

                string s = "";

                for (int column = 0; column <= table.Columns.Count - 1; column++)
                {
                    s += $"{table.Columns[column].ColumnName,-60}";
                }
                this.listBox2.Items.Add(s);

                for (int row = 0; row <= table.Rows.Count - 1; row++)
                {
                    string y = "";
                    for (int a = 0; a <= table.Columns.Count - 1; a++)
                    {
                        y += $"{table.Rows[row][a],-60}";
                    }
                    this.listBox2.Items.Add(y);
                }
                this.listBox2.Items.Add("===========================================");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // 弱型別
            MessageBox.Show(nwDataSet1.Products.Rows[0][1].ToString());
            MessageBox.Show(nwDataSet1.Products.Rows[0]["ProductName"].ToString());
            // 強型別
            MessageBox.Show(nwDataSet1.Products[0].ProductName);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.nwDataSet1.Products.WriteXml("Products.XML", XmlWriteMode.WriteSchema);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.nwDataSet1.Products.Clear();
            this.nwDataSet1.Products.ReadXml("Products.XML");
            this.dataGridView5.DataSource = nwDataSet1.Products;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel1Collapsed = !this.splitContainer2.Panel1Collapsed;
        }
    }
}
