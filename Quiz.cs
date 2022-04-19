using homework.Properties;
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
    public partial class Quiz : Form
    {
        
        public Quiz()
        {
            InitializeComponent();
            LoadDataToTreeView();
        }

        TreeNode treeNode = null;
        TreeNode treeNodeChild = null;
        private void LoadDataToTreeView()
        {
            SqlConnection conn = null;
            //TreeNode treeNode=null;
            //TreeNode treeNodeChild = null;

            try
            {
                conn = new SqlConnection(Settings.Default.NorthwindConnectionString);
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "Select *  from customers";
                conn.Open();
                
                SqlDataReader dataReader = command.ExecuteReader();
                
                while (dataReader.Read())
                {
                    string country = dataReader["Country"].ToString();
                    string city = dataReader["City"].ToString();

                    if (treeView1.Nodes[country] == null)
                    {
                        //TreeNode newtreeNode = new TreeNode(country);
                        //newtreeNode.Name = country;//關鍵
                        //treeView1.Nodes.Add(newtreeNode);
                        //treeNode = newtreeNode;

                        treeNode = this.treeView1.Nodes.Add(country);
                        treeNode.Name = country; // Name分類???
                    }
                    else
                    {
                        treeNode = this.treeView1.Nodes[country];
                    }
                    int a = 1;
                    if (treeNode.Nodes[city] == null)
                    {
                        
                        treeNodeChild = treeNode.Nodes.Add(city);
                        treeNodeChild.Name = city;
                        
                    }
                    else
                    {
                        treeNodeChild = treeNode.Nodes[city];
                        treeNodeChild.Tag =a+1;

                    }


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                }
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeNodeChild = ((TreeView)sender).SelectedNode;
            //label1.Text= (treeNodeChild.ToString());
            string cityname = treeNodeChild.Name;
            //label1.Text = cityname;

            this.customersTableAdapter1.FillByFindcityname(this.nwDataSet1.Customers,cityname);
            dataGridView1.DataSource = this.nwDataSet1.Customers;
            
            //SqlConnection conn = null;
            //conn = new SqlConnection(Settings.Default.NorthwindConnectionString);
            //SqlCommand command = new SqlCommand();
            //command.Connection = conn;
            //command.CommandText = $"Select *  from customers where city = '{cityname}'";
            //SqlDataReader dataReader = command.ExecuteReader();
            //DataTable dt = dataReader.GetSchemaTable();
            //conn.Open();
        }
    }
}
