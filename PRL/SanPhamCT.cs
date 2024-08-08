using BUS.Services;
using DAL.Models;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
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
    public partial class SanPhamCT : Form
    {
        SanPhamsv _sv;
        int chon = -1;
        public SanPhamCT()
        {
            _sv = new SanPhamsv();
            InitializeComponent();
            ptbsanpham.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void SanPhamCT_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata()
        {
            dgvsanpham.Rows.Clear();

            var alldata = _sv.GetAll();
            dgvsanpham.ColumnCount = 13;
            dgvsanpham.Columns[0].HeaderText = "Id";
            dgvsanpham.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgvsanpham.Columns[2].HeaderText = "Hãng Sản Xuất";
            dgvsanpham.Columns[3].HeaderText = "CPU";
            dgvsanpham.Columns[4].HeaderText = "Ram";
            dgvsanpham.Columns[5].HeaderText = "Rom";
            dgvsanpham.Columns[6].HeaderText = "GPU";
            dgvsanpham.Columns[7].HeaderText = "Màn Hình";
            dgvsanpham.Columns[8].HeaderText = "Pin";
            dgvsanpham.Columns[9].HeaderText = "Giá";
            dgvsanpham.Columns[10].HeaderText = "Số Lượng";
            dgvsanpham.Columns[11].HeaderText = "IMG";
            dgvsanpham.Columns[12].HeaderText = "Trạng Thái";

            foreach (var item in alldata)
            {
                dgvsanpham.Rows.Add(item.IdSanPham, item.TenSanPham, item.HangSanXuat, item.Cpu, item.Ram, item.Rom, item.Gpu, item.ManHinh, item.Pin, item.Gia, item.SoLuong, item.Img, item.TrangThai);

            }
        }
        public void loaddatatimkiem(List<SanPham> sp)
        {
            dgvsanpham.Rows.Clear();

            dgvsanpham.ColumnCount = 13;
            dgvsanpham.Columns[0].HeaderText = "Id";
            dgvsanpham.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgvsanpham.Columns[2].HeaderText = "Hãng Sản Xuất";
            dgvsanpham.Columns[3].HeaderText = "CPU";
            dgvsanpham.Columns[4].HeaderText = "Ram";
            dgvsanpham.Columns[5].HeaderText = "Rom";
            dgvsanpham.Columns[6].HeaderText = "GPU";
            dgvsanpham.Columns[7].HeaderText = "Màn Hình";
            dgvsanpham.Columns[8].HeaderText = "Pin";
            dgvsanpham.Columns[9].HeaderText = "Giá";
            dgvsanpham.Columns[10].HeaderText = "Số Lượng";
            dgvsanpham.Columns[11].HeaderText = "IMG";
            dgvsanpham.Columns[12].HeaderText = "Trạng Thái";

            foreach (var item in sp)
            {
                dgvsanpham.Rows.Add(item.IdSanPham, item.TenSanPham, item.HangSanXuat, item.Cpu, item.Ram, item.Rom, item.Gpu, item.ManHinh, item.Pin, item.Gia, item.SoLuong, item.Img, item.TrangThai);

            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = txtten.Text;
                string hang = txthang.Text;
                string cpu = txtCpu.Text;
                int rom = Convert.ToInt32(txtrom.Text);
                int ram = Convert.ToInt32(txtram.Text);
                string gpu = txtgpu.Text;
                string manhinh = txtmanhinh.Text;
                string pin = txtpin.Text;
                decimal gia = Convert.ToDecimal(txtgia.Text);
                int soluong = Convert.ToInt32(txtsoluong.Text);
                string img = ptbsanpham.ImageLocation;
                bool trangthai = (bool)rdolikenew.Checked;
                if (trangthai == true)
                {
                    rdolikenew.Checked = true;
                }
                else rdodaquasudung.Checked = true;

                SanPham sp = new SanPham()
                {
                    TenSanPham = ten,
                    HangSanXuat = hang,
                    Cpu = cpu,
                    Rom = rom,
                    Ram = ram,
                    Gpu = gpu,
                    ManHinh = manhinh,
                    Pin = pin,
                    Gia = gia,
                    SoLuong = soluong,
                    Img = img,
                    TrangThai = trangthai
                };
                MessageBox.Show(_sv.Create(sp));
                loaddata();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("vui lòng điền đầy đủ thông tin");
            }

        }

        private void ptbsanpham_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            string imgurl = dialog.FileName;
            ptbsanpham.Image = Image.FromFile(imgurl);
            ptbsanpham.ImageLocation = imgurl;
        }

        private void dgvsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvsanpham.Rows[e.RowIndex];
            chon = Convert.ToInt32(row.Cells[0].Value.ToString());
            txtid.Text = row.Cells[0].Value.ToString();
            txtten.Text = row.Cells[1].Value.ToString();
            txthang.Text = row.Cells[2].Value.ToString();
            txtCpu.Text = row.Cells[3].Value.ToString();
            txtrom.Text = row.Cells[4].Value.ToString();
            txtram.Text = row.Cells[5].Value.ToString();
            txtgpu.Text = row.Cells[6].Value.ToString();
            txtmanhinh.Text = row.Cells[7].Value.ToString();
            txtpin.Text = row.Cells[8].Value.ToString();
            txtgia.Text = row.Cells[9].Value.ToString();
            txtsoluong.Text = row.Cells[10].Value.ToString();
            ptbsanpham.Image = Image.FromFile(row.Cells[11].Value.ToString());
            ptbsanpham.ImageLocation = row.Cells[11].Value.ToString();
            var trangthai = (bool)row.Cells[12].Value;
            if (trangthai == true)
            {
                rdolikenew.Checked = true;
            }   
            else rdodaquasudung.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = txtten.Text;
                string hang = txthang.Text;
                var cpu = txtCpu.Text;
                int rom = Convert.ToInt32(txtrom.Text);
                int ram = Convert.ToInt32(txtram.Text);
                var gpu = txtgpu.Text;
                var manhinh = txtmanhinh.Text;
                var pin = txtpin.Text;
                decimal gia = Convert.ToDecimal(txtgia.Text);
                int soluong = Convert.ToInt32(txtsoluong.Text);
                string img = ptbsanpham.ImageLocation;
                var trangthai = rdolikenew.Checked;
                if (trangthai == true)
                {
                    rdolikenew.Checked = true;
                }
                else rdodaquasudung.Checked = true;
                SanPham sp = new SanPham()
                {
                    TenSanPham = ten,
                    HangSanXuat = hang,
                    Cpu = cpu,
                    Rom = rom,
                    Ram = ram,
                    Gpu = gpu,
                    ManHinh = manhinh,
                    Pin = pin,
                    Gia = gia,
                    SoLuong = soluong,
                    Img = img,
                    TrangThai = trangthai,
                };
                MessageBox.Show(_sv.update(sp, chon));
                loaddata();
                Clear();
            }
            catch
            {
                MessageBox.Show("chọn sản phẩm để sửa");

            }

        }




        public void Clear()
        {
            txtid.Text = "";
            txtten.Text = "";
            txthang.Text = "";
            txtCpu.Text = "";
            txtrom.Text = "";
            txtram.Text = "";
            txtgpu.Text = "";
            txtmanhinh.Text = "";
            txtpin.Text = "";
            txtgia.Text = "";
            txtsoluong.Text = "";
            ptbsanpham.Image = null;
        }

        private void txttimsp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var tim = _sv.Timkiem(txttimsp.Text);
                loaddatatimkiem(tim);
                var timid = _sv.Timkiemid(Convert.ToInt32(txttimsp.Text));
                loaddatatimkiem(timid);
            }
            catch
            {
                return;
            }

        }

    }
}
