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
    public partial class FrmShow : Form
    {
        public FrmShow()
        {
            InitializeComponent();
        }

        private void photosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.photosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.photosDataSet);

        }

        private void FrmShow_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'photosDataSet.Photos' 資料表。您可以視需要進行移動或移除。
            this.photosTableAdapter.Fill(this.photosDataSet.Photos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {                                           //  檔案路徑
                MessageBox.Show("OK," + this.openFileDialog1.FileName);
                this.photoPictureBox.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Cancel");
            }
        }
    }
}
