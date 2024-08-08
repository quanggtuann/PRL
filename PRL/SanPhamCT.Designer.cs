namespace PRL
{
    partial class SanPhamCT
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
            dgvsanpham = new DataGridView();
            ptbsanpham = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            rdodaquasudung = new RadioButton();
            rdolikenew = new RadioButton();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            txtid = new TextBox();
            txtten = new TextBox();
            txthang = new TextBox();
            txtCpu = new TextBox();
            txtram = new TextBox();
            txtrom = new TextBox();
            txtgpu = new TextBox();
            txtmanhinh = new TextBox();
            txtpin = new TextBox();
            txtgia = new TextBox();
            txtsoluong = new TextBox();
            btnadd = new Button();
            button2 = new Button();
            button3 = new Button();
            txttimsp = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvsanpham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbsanpham).BeginInit();
            SuspendLayout();
            // 
            // dgvsanpham
            // 
            dgvsanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvsanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsanpham.Location = new Point(15, 485);
            dgvsanpham.Margin = new Padding(4, 3, 4, 3);
            dgvsanpham.Name = "dgvsanpham";
            dgvsanpham.RowHeadersWidth = 51;
            dgvsanpham.RowTemplate.Height = 29;
            dgvsanpham.Size = new Size(1118, 439);
            dgvsanpham.TabIndex = 0;
            dgvsanpham.CellClick += dgvsanpham_CellClick;
            // 
            // ptbsanpham
            // 
            ptbsanpham.BackColor = SystemColors.Info;
            ptbsanpham.Location = new Point(13, 110);
            ptbsanpham.Margin = new Padding(4, 3, 4, 3);
            ptbsanpham.Name = "ptbsanpham";
            ptbsanpham.Size = new Size(254, 241);
            ptbsanpham.TabIndex = 1;
            ptbsanpham.TabStop = false;
            ptbsanpham.Click += ptbsanpham_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.GradientInactiveCaption;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(737, 59);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(93, 23);
            label7.TabIndex = 8;
            label7.Text = "Màn Hình:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.GradientInactiveCaption;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(737, 10);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(49, 23);
            label8.TabIndex = 9;
            label8.Text = "GPU:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.GradientInactiveCaption;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(737, 118);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(40, 23);
            label9.TabIndex = 10;
            label9.Text = "Pin:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.GradientInactiveCaption;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(737, 274);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(88, 23);
            label10.TabIndex = 11;
            label10.Text = "Số lượng:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.GradientInactiveCaption;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(737, 205);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(41, 23);
            label11.TabIndex = 12;
            label11.Text = "Giá:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.GradientInactiveCaption;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(737, 362);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(100, 23);
            label12.TabIndex = 13;
            label12.Text = "Trạng Thái:";
            // 
            // rdodaquasudung
            // 
            rdodaquasudung.AutoSize = true;
            rdodaquasudung.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            rdodaquasudung.Location = new Point(850, 324);
            rdodaquasudung.Margin = new Padding(4, 3, 4, 3);
            rdodaquasudung.Name = "rdodaquasudung";
            rdodaquasudung.Size = new Size(213, 27);
            rdodaquasudung.TabIndex = 14;
            rdodaquasudung.TabStop = true;
            rdodaquasudung.Text = "Hàng Đã Qua Sử Dụng";
            rdodaquasudung.UseVisualStyleBackColor = true;
            // 
            // rdolikenew
            // 
            rdolikenew.AutoSize = true;
            rdolikenew.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            rdolikenew.Location = new Point(850, 378);
            rdolikenew.Margin = new Padding(4, 3, 4, 3);
            rdolikenew.Name = "rdolikenew";
            rdolikenew.Size = new Size(150, 27);
            rdolikenew.TabIndex = 15;
            rdolikenew.TabStop = true;
            rdolikenew.Text = "LikeNew 100%";
            rdolikenew.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.GradientInactiveCaption;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(290, 14);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(33, 23);
            label13.TabIndex = 2;
            label13.Text = "ID:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.GradientInactiveCaption;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(290, 63);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(47, 23);
            label14.TabIndex = 3;
            label14.Text = "Tên :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.GradientInactiveCaption;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(290, 122);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(134, 23);
            label15.TabIndex = 4;
            label15.Text = "Hãng Sản Xuất:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = SystemColors.GradientInactiveCaption;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(290, 197);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(48, 23);
            label16.TabIndex = 5;
            label16.Text = "CPU:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = SystemColors.GradientInactiveCaption;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(290, 278);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(54, 23);
            label17.TabIndex = 6;
            label17.Text = "RAM:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = SystemColors.GradientInactiveCaption;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(290, 363);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(55, 23);
            label18.TabIndex = 7;
            label18.Text = "ROM:";
            // 
            // txtid
            // 
            txtid.Location = new Point(465, 14);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(231, 30);
            txtid.TabIndex = 16;
            // 
            // txtten
            // 
            txtten.Location = new Point(465, 63);
            txtten.Name = "txtten";
            txtten.Size = new Size(231, 30);
            txtten.TabIndex = 17;
            // 
            // txthang
            // 
            txthang.Location = new Point(465, 122);
            txthang.Name = "txthang";
            txthang.Size = new Size(231, 30);
            txthang.TabIndex = 18;
            // 
            // txtCpu
            // 
            txtCpu.Location = new Point(465, 190);
            txtCpu.Name = "txtCpu";
            txtCpu.Size = new Size(231, 30);
            txtCpu.TabIndex = 19;
            // 
            // txtram
            // 
            txtram.Location = new Point(465, 275);
            txtram.Name = "txtram";
            txtram.Size = new Size(231, 30);
            txtram.TabIndex = 20;
            // 
            // txtrom
            // 
            txtrom.Location = new Point(465, 354);
            txtrom.Name = "txtrom";
            txtrom.Size = new Size(231, 30);
            txtrom.TabIndex = 21;
            // 
            // txtgpu
            // 
            txtgpu.Location = new Point(850, 7);
            txtgpu.Name = "txtgpu";
            txtgpu.Size = new Size(283, 30);
            txtgpu.TabIndex = 22;
            // 
            // txtmanhinh
            // 
            txtmanhinh.Location = new Point(850, 58);
            txtmanhinh.Name = "txtmanhinh";
            txtmanhinh.Size = new Size(283, 30);
            txtmanhinh.TabIndex = 23;
            // 
            // txtpin
            // 
            txtpin.Location = new Point(850, 110);
            txtpin.Name = "txtpin";
            txtpin.Size = new Size(283, 30);
            txtpin.TabIndex = 24;
            // 
            // txtgia
            // 
            txtgia.Location = new Point(850, 201);
            txtgia.Name = "txtgia";
            txtgia.Size = new Size(283, 30);
            txtgia.TabIndex = 25;
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(850, 266);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(283, 30);
            txtsoluong.TabIndex = 26;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(541, 436);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(94, 29);
            btnadd.TabIndex = 27;
            btnadd.Text = "ADD";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // button2
            // 
            button2.Location = new Point(692, 436);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 28;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(834, 436);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 29;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = true;
            // 
            // txttimsp
            // 
            txttimsp.Location = new Point(28, 436);
            txttimsp.Name = "txttimsp";
            txttimsp.PlaceholderText = "Nhập để tìm kiếm";
            txttimsp.Size = new Size(445, 30);
            txttimsp.TabIndex = 31;
            txttimsp.TextChanged += txttimsp_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 25);
            label1.TabIndex = 32;
            label1.Text = "CHI TIẾT SẢN PHẨM";
            // 
            // SanPhamCT
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1234, 925);
            Controls.Add(label1);
            Controls.Add(txttimsp);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnadd);
            Controls.Add(txtsoluong);
            Controls.Add(txtgia);
            Controls.Add(txtpin);
            Controls.Add(txtmanhinh);
            Controls.Add(txtgpu);
            Controls.Add(txtrom);
            Controls.Add(txtram);
            Controls.Add(txtCpu);
            Controls.Add(txthang);
            Controls.Add(txtten);
            Controls.Add(txtid);
            Controls.Add(rdolikenew);
            Controls.Add(rdodaquasudung);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(ptbsanpham);
            Controls.Add(dgvsanpham);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SanPhamCT";
            Text = "SanPhamCT";
            Load += SanPhamCT_Load;
            ((System.ComponentModel.ISupportInitialize)dgvsanpham).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbsanpham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvsanpham;
        private PictureBox ptbsanpham;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private RadioButton rdodaquasudung;
        private RadioButton rdolikenew;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox txtid;
        private TextBox txtten;
        private TextBox txthang;
        private TextBox txtCpu;
        private TextBox txtram;
        private TextBox txtrom;
        private TextBox txtgpu;
        private TextBox txtmanhinh;
        private TextBox txtpin;
        private TextBox txtgia;
        private TextBox txtsoluong;
        private Button btnadd;
        private Button button2;
        private Button button3;
        private TextBox txttimsp;
        private Label label1;
    }
}