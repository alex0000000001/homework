using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace homework
{
    public partial class FrmCategoryProducts : Form
    {
        public FrmCategoryProducts()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;

        private void FrmCategoryProducts_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            conn.Open();
            SqlCommand command2 = new SqlCommand("Select CategoryName from Categories", conn);
            SqlDataReader dataReader1 = command2.ExecuteReader();
            while (dataReader1.Read())
            {
                string y = $"{dataReader1["CategoryName"]}";
                comboBox1.Items.Add(y);
            }
            conn.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("CategoryID\tProductName\tunitPrice");
                //string r = (comboBox1.SelectedIndex+1).ToString();
                string y = comboBox1.Text;
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();
                SqlCommand command = new SqlCommand("Select * from Categories join Products on Categories.CategoryID = Products.CategoryID Where Categories.CategoryName='"+y+"'",conn);
                SqlDataReader dataReader = command.ExecuteReader();

                
                while (dataReader.Read())
                {
                    string s = $"{dataReader["CategoryID"]}{dataReader["ProductName"],40} \t{dataReader["unitPrice"]:C2}";
                    this.listBox1.Items.Add(s);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("CategoryID\tProductName\tunitPrice");
                //string r = (comboBox1.SelectedIndex+1).ToString();
                string y = comboBox1.Text;
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();
                SqlCommand command = new SqlCommand("Select * from Categories join Products on Categories.CategoryID = Products.CategoryID Where Categories.CategoryName='" + y + "'", conn);
                SqlDataReader dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                    string s = $"{dataReader["CategoryID"]}{dataReader["ProductName"],40} \t{dataReader["unitPrice"]:C2}";
                    this.listBox1.Items.Add(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
