using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
    public partial class FrmAdventureWork : Form
    {
        public FrmAdventureWork()
        {
            InitializeComponent();
        }
        DateTime a1 =DateTime.Now;
        DateTime a2 =DateTime.Now;
        DateTime last =Convert.ToDateTime("2013-12-31");

        private void button3_Click(object sender, EventArgs e)
        {
            this.productPhotoTableAdapter1.Fill(this.adDateSet1.ProductPhoto);
            this.bindingSource1.DataSource = this.adDateSet1.ProductPhoto;
            this.dataGridView1.DataSource = this.bindingSource1;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            a1 = dateTimePicker1.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            a2 = dateTimePicker2.Value;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            label4.Text = $"{bindingSource1.Position + 1} / {bindingSource1.Count}";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveFirst();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MovePrevious();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveNext();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveLast();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            this.productPhotoTableAdapter1.FillByDatetime(this.adDateSet1.ProductPhoto, a1, a2);

            this.bindingSource1.DataSource = this.adDateSet1.ProductPhoto;

            this.dataGridView1.DataSource = this.bindingSource1;
            bindingNavigator1.BindingSource =this.bindingSource1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal y = Convert.ToDecimal(comboBox1.SelectedItem);
            this.productPhotoTableAdapter1.FillByYearsssssssssssssssssss(this.adDateSet1.ProductPhoto, y);
            dataGridView1.DataSource = this.adDateSet1.ProductPhoto;

        }

        SqlConnection conn = null;
        private void FrmAdventureWork_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=AdventureWorks2019;Integrated Security=True");
            conn.Open();
            SqlCommand command2 = new SqlCommand("select distinct datepart(yyyy,ModifiedDate) as '123' from Production.ProductPhoto order by '123' ", conn);
            SqlDataReader dataReader1 = command2.ExecuteReader();
            while (dataReader1.Read())
            {
                string y = $"{dataReader1["123"]}";
                comboBox1.Items.Add(y);
            }
            conn.Close();

        }
    }
}
