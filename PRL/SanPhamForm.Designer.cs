namespace PRL
{
    partial class SanPhamForms
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
            btnshowsp = new Button();
            tlp_SanPham = new TableLayoutPanel();
            pnnextsp = new Panel();
            lb_back = new Label();
            lb_page = new Label();
            lbnext = new Label();
            btnquanlisp = new Button();
            grb_hoadon = new GroupBox();
            btntaohoadon = new Button();
            dgvhoadon = new DataGridView();
            grb_hdct = new GroupBox();
            dgvHDCT = new DataGridView();
            pnnextsp.SuspendLayout();
            grb_hoadon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhoadon).BeginInit();
            grb_hdct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHDCT).BeginInit();
            SuspendLayout();
            // 
            // btnshowsp
            // 
            btnshowsp.BackColor = SystemColors.Info;
            btnshowsp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnshowsp.Location = new Point(12, 60);
            btnshowsp.Name = "btnshowsp";
            btnshowsp.Size = new Size(178, 43);
            btnshowsp.TabIndex = 0;
            btnshowsp.Text = "Hiển Thị Sản Phẩm";
            btnshowsp.UseVisualStyleBackColor = false;
            btnshowsp.Click += btnshowsp_Click;
            // 
            // tlp_SanPham
            // 
            tlp_SanPham.BackColor = SystemColors.HighlightText;
            tlp_SanPham.ColumnCount = 2;
            tlp_SanPham.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_SanPham.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_SanPham.Location = new Point(196, 32);
            tlp_SanPham.Name = "tlp_SanPham";
            tlp_SanPham.RowCount = 2;
            tlp_SanPham.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_SanPham.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_SanPham.Size = new Size(1216, 900);
            tlp_SanPham.TabIndex = 1;
            // 
            // pnnextsp
            // 
            pnnextsp.Controls.Add(lb_back);
            pnnextsp.Controls.Add(lb_page);
            pnnextsp.Controls.Add(lbnext);
            pnnextsp.Location = new Point(773, 938);
            pnnextsp.Name = "pnnextsp";
            pnnextsp.Size = new Size(111, 49);
            pnnextsp.TabIndex = 6;
            pnnextsp.Paint += pnnextsp_Paint;
            // 
            // lb_back
            // 
            lb_back.AutoSize = true;
            lb_back.Location = new Point(3, 25);
            lb_back.Name = "lb_back";
            lb_back.Size = new Size(19, 20);
            lb_back.TabIndex = 3;
            lb_back.Text = "<";
            // 
            // lb_page
            // 
            lb_page.AutoSize = true;
            lb_page.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_page.Location = new Point(43, 17);
            lb_page.Name = "lb_page";
            lb_page.Size = new Size(24, 28);
            lb_page.TabIndex = 2;
            lb_page.Text = "1";
            lb_page.Click += lb_page_Click;
            // 
            // lbnext
            // 
            lbnext.AutoSize = true;
            lbnext.Location = new Point(89, 24);
            lbnext.Name = "lbnext";
            lbnext.Size = new Size(19, 20);
            lbnext.TabIndex = 4;
            lbnext.Text = ">";
            lbnext.Click += lbnext_Click;
            // 
            // btnquanlisp
            // 
            btnquanlisp.BackColor = SystemColors.Info;
            btnquanlisp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnquanlisp.Location = new Point(12, 147);
            btnquanlisp.Name = "btnquanlisp";
            btnquanlisp.Size = new Size(178, 43);
            btnquanlisp.TabIndex = 5;
            btnquanlisp.Text = "Sản Phẩm Chi Tiết";
            btnquanlisp.UseVisualStyleBackColor = false;
            btnquanlisp.Click += btnquanlisp_Click;
            // 
            // grb_hoadon
            // 
            grb_hoadon.Controls.Add(btntaohoadon);
            grb_hoadon.Controls.Add(dgvhoadon);
            grb_hoadon.Location = new Point(1430, 32);
            grb_hoadon.Name = "grb_hoadon";
            grb_hoadon.Size = new Size(454, 454);
            grb_hoadon.TabIndex = 7;
            grb_hoadon.TabStop = false;
            grb_hoadon.Text = "Hóa Đơn";
            // 
            // btntaohoadon
            // 
            btntaohoadon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btntaohoadon.ForeColor = SystemColors.ControlText;
            btntaohoadon.Location = new Point(3, 26);
            btntaohoadon.Name = "btntaohoadon";
            btntaohoadon.Size = new Size(109, 39);
            btntaohoadon.TabIndex = 1;
            btntaohoadon.Text = "Tạo Hóa Đơn";
            btntaohoadon.UseVisualStyleBackColor = true;
            btntaohoadon.Click += btntaohoadon_Click;
            // 
            // dgvhoadon
            // 
            dgvhoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhoadon.Location = new Point(3, 71);
            dgvhoadon.Name = "dgvhoadon";
            dgvhoadon.RowHeadersWidth = 51;
            dgvhoadon.RowTemplate.Height = 29;
            dgvhoadon.Size = new Size(448, 380);
            dgvhoadon.TabIndex = 0;
            dgvhoadon.CellClick += dgvhoadon_CellClick;
            // 
            // grb_hdct
            // 
            grb_hdct.Controls.Add(dgvHDCT);
            grb_hdct.Location = new Point(1427, 514);
            grb_hdct.Name = "grb_hdct";
            grb_hdct.Size = new Size(454, 418);
            grb_hdct.TabIndex = 8;
            grb_hdct.TabStop = false;
            grb_hdct.Text = "Sản phẩm trong hóa đơn";
            // 
            // dgvHDCT
            // 
            dgvHDCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHDCT.Location = new Point(6, 26);
            dgvHDCT.Name = "dgvHDCT";
            dgvHDCT.RowHeadersWidth = 51;
            dgvHDCT.RowTemplate.Height = 29;
            dgvHDCT.Size = new Size(442, 386);
            dgvHDCT.TabIndex = 0;
            // 
            // SanPhamForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1924, 1011);
            Controls.Add(pnnextsp);
            Controls.Add(grb_hdct);
            Controls.Add(grb_hoadon);
            Controls.Add(btnquanlisp);
            Controls.Add(tlp_SanPham);
            Controls.Add(btnshowsp);
            Name = "SanPhamForms";
            Text = "SanPhamForm";
            Load += SanPhamForms_Load;
            pnnextsp.ResumeLayout(false);
            pnnextsp.PerformLayout();
            grb_hoadon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvhoadon).EndInit();
            grb_hdct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHDCT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnshowsp;
        private TableLayoutPanel tlp_SanPham;
        private Label lb_page;
        private Label lb_back;
        private Label lbnext;
        private Button btnquanlisp;
        private Panel pnnextsp;
        private GroupBox grb_hoadon;
        private DataGridView dgvhoadon;
        private GroupBox grb_hdct;
        private Button btntaohoadon;
        private DataGridView dgvHDCT;
    }
}