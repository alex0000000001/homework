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
using SortOrder = System.Windows.Forms.SortOrder;

namespace homework
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
            this.listView1.View = View.Details;
            LoadCountryToComboBox();
            CreateListViewColumns();
            LoadDataToListView1();

        }




        //1. All Country
        //2. ContextMenuStrip2

        //================================
        //選擇性作業
        //Groups
        //USA (100) 
        //UK (20)

        //this.listview1.visible = false;
        //ListViewItem lvi = this.listView1.Items.Add(dataReader[0].ToString());

        //if (this.listView1.Groups["USA"] == null)
        //{                       {
        //    ListViewGroup group = this.listView1.Groups.Add("USA", "USA"); //Add(string key, string headerText);
        //    group.Tag = 0;
        //    lvi.Group = group; 
        //}
        //else
        //{
        //    ListViewGroup group = this.listView1.Groups["USA"]; 
        //    lvi.Group = group;
        //}

        //this.listView1.Groups["USA"].Tag = 
        //this.listView1.Groups["USA"].Header = 




        private void LoadDataToListView1()
        {
            SqlConnection conn = null;
            using (conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
            {
                SqlCommand Command = new SqlCommand();
                conn.Open();
                Command.CommandText = "Select * from customers";
                
                Command.Connection = conn;
                SqlDataReader DataReader = Command.ExecuteReader();
                Random r = new Random();
                while (DataReader.Read())
                {
                    ListViewItem lvi = this.listView1.Items.Add(DataReader[0].ToString());
                    lvi.ImageIndex = r.Next(0, this.ImageList1.Images.Count);
                   
                    for (int i = 1; i <= DataReader.FieldCount - 1; i++)
                    {
                        if (DataReader.IsDBNull(i))
                        {
                            lvi.SubItems.Add("空值");
                        }
                        else
                        {
                            lvi.SubItems.Add(DataReader[i].ToString());
                        }

                    }
                    string city = DataReader[8].ToString();
                    ListViewGroup group;
                    if (this.listView1.Groups[city] == null)
                    {
                        group = this.listView1.Groups.Add(city, city); // 創組 , 用string key 分辨 
                        lvi.Group = group;
                    }
                    else
                    {
                        group = this.listView1.Groups[city];
                        lvi.Group = group;  // 分組
                                            // group.Tag = group.Items.Count;
                        
                    }
                    //group.Tag = group.Items.Count; 
                    //this.listView1.Groups[city].Tag = group.Tag;
                    group.Header = city.ToString() + "( " + group.Items.Count + " )";

                    if (lvi.Index % 2 == 0)
                    {
                        lvi.BackColor = Color.AliceBlue;
                    }
                    else
                    {
                        lvi.BackColor = Color.LightGreen;
                    }
                }
            }
        }

        private void CreateListViewColumns()
        {
            try
            {
                SqlConnection conn = null;
                using (conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {

                    conn.Open();

                    SqlCommand Command = new SqlCommand("Select * from customers", conn); ;
                    SqlDataReader DataReader = Command.ExecuteReader();
                    DataTable table = DataReader.GetSchemaTable();    //  抓 schema  到table 

                    for (int i = 0; i <= table.Rows.Count - 1; i++)
                    {

                        this.listView1.Columns.Add(table.Rows[i][0].ToString());


                    }
                    this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadCountryToComboBox()
        {
            try
            {
                SqlConnection conn = null;
                using (conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    SqlCommand Command = new SqlCommand("Select distinct country from customers", conn);
                    SqlDataReader DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        this.comboBox1.Items.Add($"{DataReader["country"]}");
                    }
                    this.comboBox1.Items.Add("AllCountry");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.listView1.Items.Clear();
                SqlConnection conn = null;
                using (conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    SqlCommand Command = new SqlCommand();
                    if (this.comboBox1.Text == "AllCountry")
                    {
                        Command.CommandText = "Select * from customers";
                        Command.Connection = conn;
                        SqlDataReader DataReader = Command.ExecuteReader();
                        Random r = new Random();
                        while (DataReader.Read())
                        {
                            ListViewItem lvi = this.listView1.Items.Add(DataReader[0].ToString());
                            lvi.ImageIndex = r.Next(0, this.ImageList1.Images.Count);
                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.AliceBlue;
                            }
                            else
                            {
                                lvi.BackColor = Color.LightGreen;
                            }
                            for (int i = 1; i <= DataReader.FieldCount - 1; i++)
                            {
                                if (DataReader.IsDBNull(i))
                                {
                                    lvi.SubItems.Add("空值");
                                }
                                else
                                {
                                    lvi.SubItems.Add(DataReader[i].ToString());
                                }

                            }
                        }
                    }
                    else
                    {
                        Command.CommandText = $"Select * from customers where Country= '{this.comboBox1.Text}'";
                        Command.Connection = conn;
                        SqlDataReader DataReader = Command.ExecuteReader();
                        Random r = new Random();
                        while (DataReader.Read())
                        {
                            ListViewItem lvi = this.listView1.Items.Add(DataReader[0].ToString());
                            lvi.ImageIndex = r.Next(0, this.ImageList1.Images.Count);
                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.AliceBlue;
                            }
                            else
                            {
                                lvi.BackColor = Color.LightGreen;
                            }
                            for (int i = 1; i <= DataReader.FieldCount - 1; i++)
                            {
                                if (DataReader.IsDBNull(i))
                                {
                                    lvi.SubItems.Add("空值");
                                }
                                else
                                {
                                    lvi.SubItems.Add(DataReader[i].ToString());
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "請選擇國家";
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void largerIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void aSCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Sorting = SortOrder.Ascending;
            listView1.Sort();
            
        }

        private void dESCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Sorting = SortOrder.Descending;
            listView1.Sort();
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            LoadDataToListView1();
        }
    }
}
