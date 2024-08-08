using BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class login : Form
    {
        public login()
        {
            _sv = new Nhanviensv();

            InitializeComponent();
        }
        Nhanviensv _sv;
        private void chhienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (chhienthi.Checked)
            {
                txtpass.PasswordChar = '\0';

            }
            else { txtpass.PasswordChar = '*'; }
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string username=txtuser.Text;
            string password=txtpass.Text;
            if(_sv.login(username, password)=="0")
            {
                MessageBox.Show("Đăng Nhập thất bại sai thông tin");
            }else if(_sv.login(username,password)=="1")
            {
                MessageBox.Show("Đăng Nhập thất bại trùng thông tin");
            }else
            {
                Guid idNV = Guid.Parse(_sv.login(username, password));
                SanPhamForms fps = new SanPhamForms(idNV);
                this.Hide();
                fps.ShowDialog();
                this.Show();
                fps.FormClosed += Fps_FormClosed;
            }
        }

        private void Fps_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.ShowDialog();
        }

        private void Fsp_FormClosed(object? sender, FormClosedEventArgs e)
        {
            
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
