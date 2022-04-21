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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();

            FrmAdventureWork frmAdventureWork = new FrmAdventureWork();
            frmAdventureWork.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frmAdventureWork);
            frmAdventureWork.Dock = DockStyle.Fill;
            frmAdventureWork.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();

            Form1 form1 = new Form1();
            form1.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(form1);
            form1.Dock = DockStyle.Fill;
            form1.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmCategoryProducts frmCategoryProducts = new FrmCategoryProducts();
            frmCategoryProducts.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frmCategoryProducts);
            frmCategoryProducts.Dock = DockStyle.Fill;
            frmCategoryProducts.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmDataSet結構 frmDataSet = new FrmDataSet結構();
            frmDataSet.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frmDataSet);
            frmDataSet.Dock = DockStyle.Fill;
            frmDataSet.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmCustomers frmCustomers = new FrmCustomers();
            frmCustomers.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frmCustomers);
            frmCustomers.Dock = DockStyle.Fill;
            frmCustomers.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_MyAlbum frm_MyAlbum = new Frm_MyAlbum();
            frm_MyAlbum.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm_MyAlbum);
            frm_MyAlbum.Dock = DockStyle.Fill;
            frm_MyAlbum.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Quiz quiz = new Quiz();
            quiz.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(quiz);
            quiz.Dock = DockStyle.Fill;
            quiz.Show();
        }
    }
}
