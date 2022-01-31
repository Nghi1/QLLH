using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Baithi
{
    public partial class Chi_tiết : Form
    {
        private DataTable tbOrder1;
        private List<Lophoc> DanhSachlop = new List<Lophoc>();
        string fileBinarylophoc = @"lophoc.dat";
        private List<Giangvien> DanhsachGiangvien = new List<Giangvien>();
        private DataTable tbOrder2;
        string fileBinarygiangvien = @"giaovien.dat";
        private List<Sinhvien> DanhsachSinhvien = new List<Sinhvien>();
        private DataTable tbOrder3;
        string fileBinarysinhvien = @"sinhvien.dat";

        public Chi_tiết()
        {
            InitializeComponent();
        }

        private void Chi_tiết_Load(object sender, EventArgs e)
        {
            tbOrder3 = new DataTable();
            tbOrder3.Columns.Add("STT");
            tbOrder3.Columns.Add("Mã sinh viên");
            tbOrder3.Columns.Add("Họ tên");
            tbOrder3.Columns.Add("Năm sinh");
            tbOrder3.Columns.Add("Địa chỉ");
            tbOrder3.Columns.Add("Ngành học");
            tbOrder3.Columns.Add("Lớp đang học");
            dataGridView1.DataSource = tbOrder3;
            if (File.Exists(fileBinarysinhvien) == true)
            {
                using (Stream stream = File.Open(fileBinarysinhvien, FileMode.Open))
                {
                    var bformatter = new BinaryFormatter();
                    DanhsachSinhvien = (List<Sinhvien>)bformatter.Deserialize(stream);

                    foreach (Sinhvien i in DanhsachSinhvien)
                    {
                        DataRow X = tbOrder3.NewRow();
                        X["Mã sinh viên"] = i.MaSinhvien;
                        X["Họ tên"] = i.HoTen;
                        X["Năm sinh"] = i.NamSinh;
                        X["Địa chỉ"] = i.DiaChi;
                        X["Ngành học"] = i.NganhHoc;
                        X["Lớp đang học"] = i.LopDangHoc.ToString();
                        tbOrder3.Rows.Add(X);
                    }
                }
            }
            using (Stream stream = File.Open(fileBinarylophoc, FileMode.Open))
            {
                var bformatter = new BinaryFormatter();
                DanhSachlop = (List<Lophoc>)bformatter.Deserialize(stream);

                foreach (Lophoc i in DanhSachlop)
                {
                    ma.Text = i.MaLop;
                    khoa.Text = i.Khoa;
                    monhoc.Text = i.MonHoc;
                    giangvien.Text = i.GiangVien;
                    tenlop.Text = i.TenLop;
                    nganhhoc.Text = i.NghanhHoc;
                    hocky.Text = i.HocKy;
                    soluongsinhvien.Text = i.SoluongSinhvien;
                }
            }
            using (Stream stream = File.Open(fileBinarygiangvien, FileMode.Open))
            {
                var bformatter = new BinaryFormatter();
                DanhsachGiangvien = (List<Giangvien>)bformatter.Deserialize(stream);

                foreach (Giangvien i in DanhsachGiangvien)
                {
                    giangvien.Items.Add(i.TenGiangvien);
                }
            }
        }
    

        private void themchitiet_Click(object sender, EventArgs e)
        {
           
        }

        private void suachitiet_Click (object sender, EventArgs e)
        {
            
        }

        private void xoachitiet_Click(object sender, EventArgs e)
        {
            
        }

        private void thoat_bt_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void ma_TextChanged(object sender, EventArgs e)
        {

        }

        private void butlh_Click(object sender, EventArgs e)
        {
            Form1 Ct = new Form1();
            Ct.ShowDialog();
        }

        private void butgv_Click(object sender, EventArgs e)
        {
            chitietgiangvien Ct = new chitietgiangvien();
            Ct.ShowDialog();
        }

        private void butsv_Click(object sender, EventArgs e)
        {
            
            chitietsinhvien Ct = new chitietsinhvien();
            Ct.ShowDialog();
        }

       



        private void luu_bt_Click(object sender, EventArgs e)
        {
        
            Lophoc lop = new Lophoc(ma.Text, tenlop.Text, khoa.Text, nganhhoc.Text, monhoc.Text, hocky.Text, giangvien.Text, soluongsinhvien.Text);
            DanhSachlop.Add(lop);
            using (Stream stream = File.Open(fileBinarylophoc, FileMode.Create))
            {
                var bformatter = new BinaryFormatter();
                bformatter.Serialize(stream, DanhSachlop);
            }
        }

        private void thoat_bt_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giangvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void rf_Click(object sender, EventArgs e)
        {
            tbOrder3 = new DataTable();
            tbOrder3.Columns.Add("STT");
            tbOrder3.Columns.Add("Mã sinh viên");
            tbOrder3.Columns.Add("Họ tên");
            tbOrder3.Columns.Add("Năm sinh");
            tbOrder3.Columns.Add("Địa chỉ");
            tbOrder3.Columns.Add("Ngành học");
            tbOrder3.Columns.Add("Lớp đang học");
            dataGridView1.DataSource = tbOrder3;
            if (File.Exists(fileBinarysinhvien) == true)
            {
                using (Stream stream = File.Open(fileBinarysinhvien, FileMode.Open))
                {
                    var bformatter = new BinaryFormatter();
                    DanhsachSinhvien = (List<Sinhvien>)bformatter.Deserialize(stream);

                    foreach (Sinhvien i in DanhsachSinhvien)
                    {
                        DataRow X = tbOrder3.NewRow();
                        X["Mã sinh viên"] = i.MaSinhvien;
                        X["Họ tên"] = i.HoTen;
                        X["Năm sinh"] = i.NamSinh;
                        X["Địa chỉ"] = i.DiaChi;
                        X["Ngành học"] = i.NganhHoc;
                        X["Lớp đang học"] = i.LopDangHoc.ToString();
                        tbOrder3.Rows.Add(X);
                    }
                }
            }
            using (Stream stream = File.Open(fileBinarygiangvien, FileMode.Open))
            {
                var bformatter = new BinaryFormatter();
                DanhsachGiangvien = (List<Giangvien>)bformatter.Deserialize(stream);

                foreach (Giangvien i in DanhsachGiangvien)
                {
                    giangvien.Items.Add(i.TenGiangvien);
                }
            }
        }
    }
}
