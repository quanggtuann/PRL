namespace PRL
{
    partial class login
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
            txtuser = new TextBox();
            txtpass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            chhienthi = new CheckBox();
            btndangnhap = new Button();
            SuspendLayout();
            // 
            // txtuser
            // 
            txtuser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtuser.Location = new Point(207, 34);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(458, 34);
            txtuser.TabIndex = 0;
            // 
            // txtpass
            // 
            txtpass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtpass.Location = new Point(207, 106);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(458, 34);
            txtpass.TabIndex = 1;
            txtpass.TextChanged += txtpass_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(65, 34);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(65, 112);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // chhienthi
            // 
            chhienthi.AutoSize = true;
            chhienthi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chhienthi.Location = new Point(207, 197);
            chhienthi.Name = "chhienthi";
            chhienthi.Size = new Size(202, 32);
            chhienthi.TabIndex = 4;
            chhienthi.Text = "hiển thị mật khẩu";
            chhienthi.UseVisualStyleBackColor = true;
            chhienthi.CheckedChanged += chhienthi_CheckedChanged;
            // 
            // btndangnhap
            // 
            btndangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btndangnhap.Location = new Point(207, 273);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(161, 50);
            btndangnhap.TabIndex = 5;
            btndangnhap.Text = "Login";
            btndangnhap.UseVisualStyleBackColor = true;
            btndangnhap.Click += btndangnhap_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(876, 476);
            Controls.Add(btndangnhap);
            Controls.Add(chhienthi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtuser;
        private TextBox txtpass;
        private Label label1;
        private Label label2;
        private CheckBox chhienthi;
        private Button btndangnhap;
    }
}