﻿using homework.Properties;
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
            for(int i = 0; i <= files.Length - 1; i++)
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
                 

            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.BackgroundImage = ((PictureBox)sender).Image;
            f.BackgroundImageLayout = ImageLayout.Stretch;
            f.Show();
        }

        private void FlowLayoutPanel3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void X_Click(object sender, EventArgs e)
        {
            
        }
        PictureBox pictureBox = new PictureBox();
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            //this.openFileDialog1.Filter = "";
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
               
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = 200;
                pictureBox.Height = 160;
                pictureBox.Image = Image.FromFile(this.openFileDialog1.FileName);
                this.flowLayoutPanel3.Controls.Add(pictureBox);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(listBox2.SelectedValue.ToString()); // 錯誤 todo
            try
            {
                if (comboBox1.Text == null)
                {

                    MessageBox.Show("請選擇城市");
                    
                }
                else
                {
                    SqlConnection conn = null;
                    byte[] bytes;
                    using (conn = new SqlConnection(Settings.Default.PhotoConnectionString))
                    {
                        SqlCommand command = new SqlCommand();
                        command.Connection = conn;
                        command.CommandText = "Insert into Photos(cityID,photo) values(@cityID,@photo)";

                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        this.pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        bytes = ms.GetBuffer();

                        command.Parameters.Add("@cityID", SqlDbType.Int).Value = int.Parse(textBox1.Text);
                        command.Parameters.Add("@photo", SqlDbType.Image).Value = bytes;
                        conn.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("圖片加入成功");
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_MyAlbum_Load(object sender, EventArgs e)
        {

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
                        //listBox2.Items.Add(x);
                    }
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
                   // listBox2.Items.Add($"{dataReader1["CityId"]}");
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
    }
}
