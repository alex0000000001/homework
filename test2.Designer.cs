
namespace homework
{
    partial class test2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cityIDLabel;
            System.Windows.Forms.Label photoIDLabel;
            System.Windows.Forms.Label photoNameLabel;
            System.Windows.Forms.Label photoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test2));
            this.photosDataSet = new homework.PhotosDataSet();
            this.photosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.photosTableAdapter = new homework.PhotosDataSetTableAdapters.PhotosTableAdapter();
            this.tableAdapterManager = new homework.PhotosDataSetTableAdapters.TableAdapterManager();
            this.photosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.photosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cityIDTextBox = new System.Windows.Forms.TextBox();
            this.photoIDTextBox = new System.Windows.Forms.TextBox();
            this.photoNameTextBox = new System.Windows.Forms.TextBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.photosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            cityIDLabel = new System.Windows.Forms.Label();
            photoIDLabel = new System.Windows.Forms.Label();
            photoNameLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingNavigator)).BeginInit();
            this.photosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cityIDLabel
            // 
            cityIDLabel.AutoSize = true;
            cityIDLabel.Location = new System.Drawing.Point(384, 51);
            cityIDLabel.Name = "cityIDLabel";
            cityIDLabel.Size = new System.Drawing.Size(54, 15);
            cityIDLabel.TabIndex = 1;
            cityIDLabel.Text = "City ID:";
            // 
            // photoIDLabel
            // 
            photoIDLabel.AutoSize = true;
            photoIDLabel.Location = new System.Drawing.Point(384, 82);
            photoIDLabel.Name = "photoIDLabel";
            photoIDLabel.Size = new System.Drawing.Size(63, 15);
            photoIDLabel.TabIndex = 3;
            photoIDLabel.Text = "Photo ID:";
            // 
            // photoNameLabel
            // 
            photoNameLabel.AutoSize = true;
            photoNameLabel.Location = new System.Drawing.Point(384, 113);
            photoNameLabel.Name = "photoNameLabel";
            photoNameLabel.Size = new System.Drawing.Size(81, 15);
            photoNameLabel.TabIndex = 5;
            photoNameLabel.Text = "Photo Name:";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(384, 141);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(44, 15);
            photoLabel.TabIndex = 7;
            photoLabel.Text = "Photo:";
            // 
            // photosDataSet
            // 
            this.photosDataSet.DataSetName = "PhotosDataSet";
            this.photosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // photosBindingSource
            // 
            this.photosBindingSource.DataMember = "Photos";
            this.photosBindingSource.DataSource = this.photosDataSet;
            // 
            // photosTableAdapter
            // 
            this.photosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.City123TableAdapter = null;
            this.tableAdapterManager.PhotosTableAdapter = this.photosTableAdapter;
            this.tableAdapterManager.UpdateOrder = homework.PhotosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // photosBindingNavigator
            // 
            this.photosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.photosBindingNavigator.BindingSource = this.photosBindingSource;
            this.photosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.photosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.photosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.photosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.photosBindingNavigatorSaveItem});
            this.photosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.photosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.photosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.photosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.photosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.photosBindingNavigator.Name = "photosBindingNavigator";
            this.photosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.photosBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.photosBindingNavigator.TabIndex = 0;
            this.photosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 24);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // photosBindingNavigatorSaveItem
            // 
            this.photosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.photosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("photosBindingNavigatorSaveItem.Image")));
            this.photosBindingNavigatorSaveItem.Name = "photosBindingNavigatorSaveItem";
            this.photosBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.photosBindingNavigatorSaveItem.Text = "儲存資料";
            this.photosBindingNavigatorSaveItem.Click += new System.EventHandler(this.photosBindingNavigatorSaveItem_Click);
            // 
            // cityIDTextBox
            // 
            this.cityIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photosBindingSource, "CityID", true));
            this.cityIDTextBox.Location = new System.Drawing.Point(471, 48);
            this.cityIDTextBox.Name = "cityIDTextBox";
            this.cityIDTextBox.Size = new System.Drawing.Size(100, 25);
            this.cityIDTextBox.TabIndex = 2;
            // 
            // photoIDTextBox
            // 
            this.photoIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photosBindingSource, "PhotoID", true));
            this.photoIDTextBox.Location = new System.Drawing.Point(471, 79);
            this.photoIDTextBox.Name = "photoIDTextBox";
            this.photoIDTextBox.Size = new System.Drawing.Size(100, 25);
            this.photoIDTextBox.TabIndex = 4;
            // 
            // photoNameTextBox
            // 
            this.photoNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photosBindingSource, "PhotoName", true));
            this.photoNameTextBox.Location = new System.Drawing.Point(471, 110);
            this.photoNameTextBox.Name = "photoNameTextBox";
            this.photoNameTextBox.Size = new System.Drawing.Size(100, 25);
            this.photoNameTextBox.TabIndex = 6;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.photosBindingSource, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(471, 141);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(100, 50);
            this.photoPictureBox.TabIndex = 8;
            this.photoPictureBox.TabStop = false;
            // 
            // photosDataGridView
            // 
            this.photosDataGridView.AutoGenerateColumns = false;
            this.photosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.photosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewImageColumn1});
            this.photosDataGridView.DataSource = this.photosBindingSource;
            this.photosDataGridView.Location = new System.Drawing.Point(0, 51);
            this.photosDataGridView.Name = "photosDataGridView";
            this.photosDataGridView.RowHeadersWidth = 51;
            this.photosDataGridView.RowTemplate.Height = 27;
            this.photosDataGridView.Size = new System.Drawing.Size(300, 220);
            this.photosDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CityID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CityID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PhotoID";
            this.dataGridViewTextBoxColumn2.HeaderText = "PhotoID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PhotoName";
            this.dataGridViewTextBoxColumn3.HeaderText = "PhotoName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Photo";
            this.dataGridViewImageColumn1.HeaderText = "Photo";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // test2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.photosDataGridView);
            this.Controls.Add(cityIDLabel);
            this.Controls.Add(this.cityIDTextBox);
            this.Controls.Add(photoIDLabel);
            this.Controls.Add(this.photoIDTextBox);
            this.Controls.Add(photoNameLabel);
            this.Controls.Add(this.photoNameTextBox);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.photosBindingNavigator);
            this.Name = "test2";
            this.Text = "test2";
            this.Load += new System.EventHandler(this.test2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingNavigator)).EndInit();
            this.photosBindingNavigator.ResumeLayout(false);
            this.photosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PhotosDataSet photosDataSet;
        private System.Windows.Forms.BindingSource photosBindingSource;
        private PhotosDataSetTableAdapters.PhotosTableAdapter photosTableAdapter;
        private PhotosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator photosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton photosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cityIDTextBox;
        private System.Windows.Forms.TextBox photoIDTextBox;
        private System.Windows.Forms.TextBox photoNameTextBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.DataGridView photosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}