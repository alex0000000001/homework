
namespace homework
{
    partial class FrmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomers));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ImageList2 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largerIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dESCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 48);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 25);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(44, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Country:";
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextMenuStrip2;
            this.listView1.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(47, 103);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1124, 686);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "FLGGERM.ICO");
            this.ImageList1.Images.SetKeyName(1, "CTRCAN.ICO");
            this.ImageList1.Images.SetKeyName(2, "CTRFRAN.ICO");
            this.ImageList1.Images.SetKeyName(3, "CTRGERM.ICO");
            this.ImageList1.Images.SetKeyName(4, "CTRITALY.ICO");
            this.ImageList1.Images.SetKeyName(5, "CTRJAPAN.ICO");
            this.ImageList1.Images.SetKeyName(6, "CTRMEX.ICO");
            this.ImageList1.Images.SetKeyName(7, "CTRSKOR.ICO");
            this.ImageList1.Images.SetKeyName(8, "CTRSPAIN.ICO");
            this.ImageList1.Images.SetKeyName(9, "CTRUK.ICO");
            this.ImageList1.Images.SetKeyName(10, "CTRUSA.ICO");
            this.ImageList1.Images.SetKeyName(11, "FLGASTRL.ICO");
            this.ImageList1.Images.SetKeyName(12, "FLGAUSTA.ICO");
            this.ImageList1.Images.SetKeyName(13, "FLGBELG.ICO");
            this.ImageList1.Images.SetKeyName(14, "FLGBRAZL.ICO");
            this.ImageList1.Images.SetKeyName(15, "FLGCAN.ICO");
            this.ImageList1.Images.SetKeyName(16, "FLGDEN.ICO");
            this.ImageList1.Images.SetKeyName(17, "FLGFIN.ICO");
            this.ImageList1.Images.SetKeyName(18, "FLGFRAN.ICO");
            // 
            // ImageList2
            // 
            this.ImageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList2.ImageStream")));
            this.ImageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList2.Images.SetKeyName(0, "FLGGERM.ICO");
            this.ImageList2.Images.SetKeyName(1, "CTRCAN.ICO");
            this.ImageList2.Images.SetKeyName(2, "CTRFRAN.ICO");
            this.ImageList2.Images.SetKeyName(3, "CTRGERM.ICO");
            this.ImageList2.Images.SetKeyName(4, "CTRITALY.ICO");
            this.ImageList2.Images.SetKeyName(5, "CTRJAPAN.ICO");
            this.ImageList2.Images.SetKeyName(6, "CTRMEX.ICO");
            this.ImageList2.Images.SetKeyName(7, "CTRSKOR.ICO");
            this.ImageList2.Images.SetKeyName(8, "CTRSPAIN.ICO");
            this.ImageList2.Images.SetKeyName(9, "CTRUK.ICO");
            this.ImageList2.Images.SetKeyName(10, "CTRUSA.ICO");
            this.ImageList2.Images.SetKeyName(11, "FLGASTRL.ICO");
            this.ImageList2.Images.SetKeyName(12, "FLGAUSTA.ICO");
            this.ImageList2.Images.SetKeyName(13, "FLGBELG.ICO");
            this.ImageList2.Images.SetKeyName(14, "FLGBRAZL.ICO");
            this.ImageList2.Images.SetKeyName(15, "FLGCAN.ICO");
            this.ImageList2.Images.SetKeyName(16, "FLGDEN.ICO");
            this.ImageList2.Images.SetKeyName(17, "FLGFIN.ICO");
            this.ImageList2.Images.SetKeyName(18, "FLGFRAN.ICO");
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem,
            this.largerIconToolStripMenuItem,
            this.smallIconToolStripMenuItem,
            this.orderByToolStripMenuItem,
            this.groupToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(164, 124);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.detailsToolStripMenuItem.Text = "Details View";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // largerIconToolStripMenuItem
            // 
            this.largerIconToolStripMenuItem.Name = "largerIconToolStripMenuItem";
            this.largerIconToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.largerIconToolStripMenuItem.Text = "Larger Icon";
            this.largerIconToolStripMenuItem.Click += new System.EventHandler(this.largerIconToolStripMenuItem_Click);
            // 
            // smallIconToolStripMenuItem
            // 
            this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.smallIconToolStripMenuItem.Text = "Small Icon";
            this.smallIconToolStripMenuItem.Click += new System.EventHandler(this.smallIconToolStripMenuItem_Click);
            // 
            // orderByToolStripMenuItem
            // 
            this.orderByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aSCToolStripMenuItem,
            this.dESCToolStripMenuItem});
            this.orderByToolStripMenuItem.Name = "orderByToolStripMenuItem";
            this.orderByToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.orderByToolStripMenuItem.Text = "Order by";
            // 
            // aSCToolStripMenuItem
            // 
            this.aSCToolStripMenuItem.Name = "aSCToolStripMenuItem";
            this.aSCToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.aSCToolStripMenuItem.Text = "ASC";
            this.aSCToolStripMenuItem.Click += new System.EventHandler(this.aSCToolStripMenuItem_Click);
            // 
            // dESCToolStripMenuItem
            // 
            this.dESCToolStripMenuItem.Name = "dESCToolStripMenuItem";
            this.dESCToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.dESCToolStripMenuItem.Text = "DESC";
            this.dESCToolStripMenuItem.Click += new System.EventHandler(this.dESCToolStripMenuItem_Click);
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.groupToolStripMenuItem.Text = "Group";
            this.groupToolStripMenuItem.Click += new System.EventHandler(this.groupToolStripMenuItem_Click);
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 823);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "FrmCustomers";
            this.Text = "FrmCustomers";
            this.Load += new System.EventHandler(this.FrmCustomers_Load);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.ImageList ImageList2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largerIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dESCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
    }
}