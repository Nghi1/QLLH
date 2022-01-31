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
    public partial class chitietsinhvien : Form
    {
        private List<Sinhvien> DanhsachSinhvien = new List<Sinhvien>();
        private DataTable tbOrder3;
        string fileBinarysinhvien = @"sinhvien.dat";
        public chitietsinhvien()
        {
            InitializeComponent();
        }

        private void ma_TextChanged(object sender, EventArgs e)
        {

        }

        private void chitietsinhvien_Load(object sender, EventArgs e)
        {
            tbOrder3 = new DataTable();
            tbOrder3.Columns.Add("STT");
            tbOrder3.Columns.Add("Mã sinh viên");
            tbOrder3.Columns.Add("Họ tên");
            tbOrder3.Columns.Add("Năm sinh");
            tbOrder3.Columns.Add("Địa chỉ");
            tbOrder3.Columns.Add("Ngành học");
            tbOrder3.Columns.Add("Lớp đang học");
            dataGridView3.DataSource = tbOrder3;
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
        }

        private void themSV_Click(object sender, EventArgs e)
        {
            int STT = tbOrder3.Rows.Count + 1;
            DataRow r = tbOrder3.NewRow();
            r["STT"] = STT;
            r["Mã sinh viên"] = ma.Text;
            r["Họ tên"] = ten.Text;
            r["Năm sinh"] = namsinh.Text;
            r["Địa chỉ"] = diachi.Text;
            r["Ngành học"] = nganh.Text;
            r["Lớp đang học"] = lophoc.Text;
            tbOrder3.Rows.Add(r);
            Sinhvien SinhVien = new Sinhvien(ma.Text, ten.Text, namsinh.Text, diachi.Text, nganh.Text, lophoc.Text);
            DanhsachSinhvien.Add(SinhVien);
            using (Stream stream = File.Open(fileBinarysinhvien, FileMode.Create))
            {
                var bformatter = new BinaryFormatter();
                bformatter.Serialize(stream, DanhsachSinhvien);
            }
        }

        private void suaSV_Click(object sender, EventArgs e)
        {
            int select = dataGridView3.CurrentCell.RowIndex;
            tbOrder3.Rows[select]["Mã Sinh Viên"] = ma.Text;
            tbOrder3.Rows[select]["Họ Tên"] = ten.Text;
            tbOrder3.Rows[select]["Năm Sinh"] = namsinh.Text;
            tbOrder3.Rows[select]["Địa Chỉ"] = diachi.Text;
            tbOrder3.Rows[select]["Ngành Học"] = nganh.Text;
            tbOrder3.Rows[select]["Lớp Đang Học"] = lophoc.Text;
            DanhsachSinhvien[select].MaSinhvien = ma.Text;
            DanhsachSinhvien[select].HoTen = ma.Text;
            DanhsachSinhvien[select].NamSinh = namsinh.Text;
            DanhsachSinhvien[select].DiaChi = diachi.Text;
            DanhsachSinhvien[select].NganhHoc = nganh.Text;
            DanhsachSinhvien[select].LopDangHoc = lophoc.Text;
            using (Stream stream = File.Open(fileBinarysinhvien, FileMode.Create))
            {
                var bformatter = new BinaryFormatter();
                bformatter.Serialize(stream, DanhsachSinhvien);
            }
        }

        private void xoaSV_Click(object sender, EventArgs e)
        {
            int n = dataGridView3.CurrentCell.RowIndex;
            dataGridView3.Rows.RemoveAt(n);
            int a = tbOrder3.Rows.Count;
            for (int i = 0; i < a; i++)
            {
                dataGridView3.Rows[i].Cells[0].Value = i + 1;
            }
            DanhsachSinhvien.RemoveAt(n);
            using (Stream stream = File.Open(fileBinarysinhvien, FileMode.Create))
            {
                var bformatter = new BinaryFormatter();
                bformatter.Serialize(stream, DanhsachSinhvien);
            }
        }

        private void thoat_bt3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void butlh_Click(object sender, EventArgs e)
        {
            Form1 add = new Form1();
            add.ShowDialog();
        }

        private void butgv_Click(object sender, EventArgs e)
        {
            chitietgiangvien add = new chitietgiangvien();
            add.ShowDialog();
        }

        private void butsv_Click(object sender, EventArgs e)
        {
        }
    }
}
