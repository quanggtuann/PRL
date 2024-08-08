using BUS.Services;
using DAL.Models;
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
    public partial class SanPhamForms : Form
    {
        Guid idNV;
        List<SanPham> sanphams;
        SanPhamsv _sv;
        HoaDonsv _hoaDonsv;
        HDCTsv _hDCTsv=new HDCTsv();
        public int currenBill = -1;

        public SanPhamForms(Guid idNV)
        {
           
            _hoaDonsv = new HoaDonsv();
            _sv = new SanPhamsv();
            sanphams = _sv.GetAll();
            InitializeComponent();
            this.idNV = idNV;
        }



        public void loadsptopannel(int page)
        {
            tlp_SanPham.Controls.Clear();
            int numberpage = (int)Math.Ceiling((decimal)sanphams.Count / 4);
            if (page < 1 || page > numberpage) return;
            else
            {
                if (page * 4 - 4 < sanphams.Count)
                {
                    Panel s1 = createpanelsp(sanphams[page * 4 - 4]);

                    tlp_SanPham.Controls.Add(s1, 0, 0);

                }
                if (page * 4 - 3 < sanphams.Count)
                {
                    Panel s2 = createpanelsp(sanphams[page * 4 - 3]);

                    tlp_SanPham.Controls.Add(s2, 0, 1);
                }
                if (page * 4 - 2 < sanphams.Count)
                {
                    Panel s3 = createpanelsp(sanphams[page * 4 - 2]);

                    tlp_SanPham.Controls.Add(s3, 1, 0);

                }
                if (page * 4 - 1 < sanphams.Count)
                {
                    Panel s4 = createpanelsp(sanphams[page * 4 - 1]);

                    tlp_SanPham.Controls.Add(s4, 1, 1);

                }

            }
        }
        private void btnshowsp_Click(object sender, EventArgs e)
        {


            tlp_SanPham.Controls.Clear();
            tlp_SanPham.ColumnCount = 2;
            tlp_SanPham.RowCount = 2;
            loadsptopannel(Convert.ToInt32(lb_page.Text));

        }
        public Panel createpanelsp(SanPham sp)
        {
            Panel p = new Panel(); p.Size = new Size(595, 400);
            p.Name = sp.IdSanPham.ToString();
            PictureBox ptb = new PictureBox(); ptb.Size = new Size(300, 297);
            ptb.Image = Image.FromFile(sp.Img);
            ptb.Location = new Point(14, 12);
            ptb.SizeMode = PictureBoxSizeMode.StretchImage;

            Label lbten = new Label();
            lbten.Text = "Tên sản phẩm";
            lbten.Location = new Point(335, 20);
            Label lbtenvalua = new Label();
            lbtenvalua.Text = sp.TenSanPham;
            lbtenvalua.Location = new Point(335, 50);

            Label lbhang = new Label();
            lbhang.Text = "Hãng:";
            lbhang.Location = new Point(335, 80);
            Label lbhangvalue = new Label();
            lbhangvalue.Text = sp.HangSanXuat;
            lbhangvalue.Location = new Point(335, 100);

            Label lbgia = new Label();
            lbgia.Text = "Giá Sản Phẩm";
            lbgia.Location = new Point(335, 130);
            Label lbgiavalua = new Label();
            lbgiavalua.Text = sp.Gia + "";
            lbgiavalua.Location = new Point(335, 150);
            lbgiavalua.Name = "giaban";

            Label lbsoluong = new Label();
            lbsoluong.Text = "Số Lượng SP";
            lbsoluong.Location = new Point(335, 180);
            Label lbsoluongvalue = new Label();
            lbsoluongvalue.Text = sp.SoLuong + "";
            lbsoluongvalue.Location = new Point(335, 200);
            lbsoluongvalue.Name = "soluong";

            Label lbmua = new Label();
            lbmua.Text = "Số Lượng Mua";
            lbmua.Location = new Point(335, 232);

            Button Btnmua = new Button();
            Btnmua.Location = new Point(442, 263);
            Btnmua.Size = new Size(83, 39);
            Btnmua.Text = "Mua";

            Btnmua.MouseClick += Btnmua_MouseClick;

            TextBox tbsoluong = new TextBox();
            tbsoluong.PlaceholderText = "Nhập Giá";
            tbsoluong.Location = new Point(332, 268);
            tbsoluong.Size = new Size(83, 39);
            tbsoluong.Name = "tbsoluong";
            p.Controls.Add(ptb);
            p.Controls.Add(lbten);
            p.Controls.Add(lbtenvalua);
            p.Controls.Add(lbhang);
            p.Controls.Add(lbhangvalue);
            p.Controls.Add(lbgia);
            p.Controls.Add(lbgiavalua);
            p.Controls.Add(lbsoluong);
            p.Controls.Add(lbsoluongvalue);
            p.Controls.Add(lbmua);
            p.Controls.Add(Btnmua);
            p.Controls.Add(tbsoluong);
            return p;
        }

        private void Btnmua_MouseClick(object? sender, MouseEventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                Panel p = (Panel)b.Parent;
                TextBox t = p.Controls["tbsoluong"] as TextBox;
                Label gia = p.Controls["giaban"] as Label;
                int soluongmua = Convert.ToInt32(t.Text);
                decimal giaban = Convert.ToDecimal(gia.Text);
                Label soluong = p.Controls["soluong"] as Label;
                int soluongcon = Convert.ToInt32(soluong.Text);
                if (soluongmua > soluongcon) MessageBox.Show("Đã vượt quá số sản phẩm hiện có");
                else if (currenBill == -1)
                {
                    MessageBox.Show("bạn chưa chọn hóa đơn để mua");
                }
                else
                {
                    MessageBox.Show("Bạn Muốn Mua Sản Phẩm Id: " + p.Name + " số lượng:" + t.Text + " vào hóa đơn" + currenBill);

                    int IdHoaDon = currenBill;
                    int IdSanPham = Convert.ToInt32(p.Name);
                    int SoLuongSanPham = soluongmua;
                    decimal Gia = giaban;
                    int TrangThai = 1;
                    _hDCTsv.Create(SoLuongSanPham, IdSanPham, IdHoaDon, Gia );
                    dgvHDCT.DataSource= _hDCTsv.GetALLByHD(currenBill);
                  
                }
            }
            catch
            {
                MessageBox.Show("vui lòng nhập số lượng sản phẩm");
            }
        }




        private void lbnext_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_page.Text) < (int)Math.Ceiling((decimal)sanphams.Count / 4))
            {
                lb_page.Text = Convert.ToInt32(lb_page.Text) + 1 + "";
                loadsptopannel(Convert.ToInt32(lb_page.Text));
            }

        }

        private void lb_back_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_page.Text) > 1)
            {
                lb_page.Text = Convert.ToInt32(lb_page.Text) - 1 + "";
                loadsptopannel(Convert.ToInt32(lb_page.Text));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnquanlisp_Click(object sender, EventArgs e)
        {
            tlp_SanPham.Controls.Clear();
            SanPhamCT sanPhamCT = new SanPhamCT();
            sanPhamCT.TopLevel = false;
            tlp_SanPham.ColumnCount = 1;
            tlp_SanPham.RowCount = 1;
            sanPhamCT.FormBorderStyle = FormBorderStyle.None;
            tlp_SanPham.Controls.Add(sanPhamCT);
            sanPhamCT.Show();

        }

        private void lb_page_Click(object sender, EventArgs e)
        {

        }

        private void pnnextsp_Paint(object sender, PaintEventArgs e)
        {


        }
        public void loadhoadon()
        {
            var allHD = _hoaDonsv.Getall();
            dgvhoadon.DataSource = allHD;
        }
        private void btntaohoadon_Click(object sender, EventArgs e)
        {
            _hoaDonsv.Create(idNV, "0987654321");
            loadhoadon();

        }

        private void dgvhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvhoadon.Rows[e.RowIndex];
            currenBill = (int)row.Cells[0].Value;
            MessageBox.Show(currenBill.ToString());

        }

        private void SanPhamForms_Load(object sender, EventArgs e)
        {
            loadhoadon();
        }
    }

}
