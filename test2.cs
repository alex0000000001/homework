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
    public partial class test2 : Form
    {
        public test2()
        {
            InitializeComponent();
        }

        private void photosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.photosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.photosDataSet);

        }

        private void test2_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'photosDataSet.Photos' 資料表。您可以視需要進行移動或移除。
            this.photosTableAdapter.Fill(this.photosDataSet.Photos);

        }
    }
}
