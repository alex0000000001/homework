using homework.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
    public partial class Frm_MyAlbum : Form
    {
        public Frm_MyAlbum()
        {
            InitializeComponent();

            this.city123TableAdapter1.Fill(this.cityDataSet1.City123);
            for (int i = 0; i <= cityDataSet1.City123.Rows.Count - 1; i++)
            {
                LinkLabel x = new LinkLabel();
                string y = $"{ cityDataSet1.City123[i][1]}";
                x.Text = y;
                x.Top = 60 * i;
                x.Left = 5;
                x.Tag = i;
                this.splitContainer2.Panel1.Controls.Add(x);
                x.Click += X_Click;
            }
            //=================================================
            this.flowLayoutPanel3.AllowDrop = true;
            this.flowLayoutPanel3.DragEnter += FlowLayoutPanel3_DragEnter;
            this.flowLayoutPanel3.DragDrop += FlowLayoutPanel3_DragDrop;
        }




        private void FlowLayoutPanel3_DragDrop(object sender, DragEventArgs e)
        {

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            for (int i = 0; i <= files.Length - 1; i++)
            {
                pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(files[i]);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = 360;
                pictureBox.Height = 240;
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                pictureBox.Padding = new Padding(4, 4, 4, 4);

                pictureBox.Click += PictureBox_Click;
                this.flowLayoutPanel3.Controls.Add(pictureBox);

                SqlConnection conn = null;
                byte[] bytes;

                using (conn = new SqlConnection(Settings.Default.PhotoConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;
                    command.CommandText = "Insert into Photos(cityID,photo) values(@cityID,@photo)";

                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    bytes = ms.GetBuffer();

                    command.Parameters.Add("@cityID", SqlDbType.Int).Value = int.Parse(textBox1.Text);
                    command.Parameters.Add("@photo", SqlDbType.Image).Value = bytes;
                    conn.Open();
                    command.ExecuteNonQuery();
                }

            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            FrmPictureShow f = new FrmPictureShow();
            f.BackgroundImage = ((PictureBox)sender).Image;
            f.BackgroundImageLayout = ImageLayout.Zoom;
            f.Show();
        }

        private void FlowLayoutPanel3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void X_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LinkLabel x = sender as LinkLabel;
            if (x != null)
            {
                string cityN = x.Text;
                ShowImage(cityN);
            }
        }

        private void ShowImage(string CityName)
        {
            try
            {  
                using (SqlConnection conn = new SqlConnection(Settings.Default.PhotoConnectionString))
                {

                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"select Photo from Photos join City123 on Photos.cityid = City123.cityid where CityName='{CityName}'";
                    command.Connection = conn;

                    conn.Open();


                    SqlDataReader dataReader = command.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            pictureBox = new PictureBox();
                            byte[] bytes = (byte[])dataReader["Photo"];
                            System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                            this.flowLayoutPanel1.Controls.Add(pictureBox);
                            this.pictureBox.Image = Image.FromStream(ms);
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox.Width = 240;
                            pictureBox.Height = 180;
                            pictureBox.BorderStyle = BorderStyle.FixedSingle;
                            pictureBox.Padding = new Padding(4, 4, 4, 4);
                            pictureBox.Click += PictureBox_Click;
                            
                        } 
                    }
                    else
                    {
                        MessageBox.Show("No Record");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        PictureBox pictureBox = new PictureBox();
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                if (folder.ShowDialog() == DialogResult.OK)
                {

                this.flowLayoutPanel3.Controls.Clear();

                string[] files = Directory.GetFiles(folder.SelectedPath);

                foreach (string file in files)
                {
                    if (file.EndsWith(".jpg") || file.EndsWith(".png") || file.EndsWith(".jpeg"))
                    {
                        pictureBox = new PictureBox();
                        pictureBox.Image = Image.FromFile(file);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Width = 180;
                        pictureBox.Height = 120;
                        pictureBox.BorderStyle = BorderStyle.FixedSingle;
                        flowLayoutPanel3.Controls.Add(pictureBox);

                        SqlConnection conn = null;
                        byte[] bytes;

                        using (conn = new SqlConnection(Settings.Default.PhotoConnectionString))
                        {
                            SqlCommand command = new SqlCommand();
                            command.Connection = conn;
                            command.CommandText = "Insert into Photos(cityID,photo) values(@cityID,@photo)";

                            System.IO.MemoryStream ms = new System.IO.MemoryStream();
                            pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            bytes = ms.GetBuffer();

                            command.Parameters.Add("@cityID", SqlDbType.Int).Value = int.Parse(textBox1.Text);
                            command.Parameters.Add("@photo", SqlDbType.Image).Value = bytes;
                            conn.Open();
                            command.ExecuteNonQuery();
                        }
                    }
                    else return;

                }
            }
        }


        private void Frm_MyAlbum_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'photosDataSet1.City123' 資料表。您可以視需要進行移動或移除。
            this.city123TableAdapter.Fill(this.photosDataSet1.City123);
            this.photosTableAdapter1.Fill(this.photosDataSet1.Photos);
            try
            {
                SqlConnection conn = null;
                using (conn = new SqlConnection(Settings.Default.PhotoConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;
                    command.CommandText = "Select * from City123";
                    conn.Open();
                    SqlDataReader dataReader1 = command.ExecuteReader();
                    while (dataReader1.Read())
                    {
                        string y = $"{dataReader1["CityName"]}";
                        string x = $"{dataReader1["CityId"]}";
                        comboBox1.Items.Add(y);
                        textBox1.Text = y;
                    }
                    
                }
                comboBox1.SelectedIndex = 0;
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
                SqlConnection conn = null;
                using (conn = new SqlConnection(Settings.Default.PhotoConnectionString))
                {
                    textBox1.Text = "";
                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;
                    command.CommandText = $"Select * from City123 where CityName='{comboBox1.Text}'";
                    conn.Open();
                    SqlDataReader dataReader1 = command.ExecuteReader();
                    dataReader1.Read();
                    textBox1.Text = $"{dataReader1["CityId"]}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmShow frmShow = new FrmShow();
            frmShow.Show();

        }

        private void city123DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string whereCityID = city123DataGridView.CurrentRow.Cells[0].Value.ToString();
            //this.photosTableAdapter1.FillByWhereCityID(photosDataSet1.Photos,int.Parse(whereCityID));
            //photosBindingSource.DataSource = photosDataSet1.Photos;
            //photosDataGridView.DataSource = photosBindingSource.DataSource;
            //photosBindingNavigator.BindingSource =photosBindingSource; 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                photoPictureBox.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }

        private void cityIdTextBox1_TextChanged(object sender, EventArgs e)
        {
            string whereCityID = city123DataGridView.CurrentRow.Cells[0].Value.ToString();
            this.photosTableAdapter1.FillByWhereCityID(photosDataSet1.Photos, int.Parse(whereCityID));
            photosBindingSource.DataSource = photosDataSet1.Photos;
            photosDataGridView.DataSource = photosBindingSource.DataSource;
            photosBindingNavigator.BindingSource = photosBindingSource;
        }
    }
}
