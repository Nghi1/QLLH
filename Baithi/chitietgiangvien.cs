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
    public partial class chitietgiangvien : Form
    {
        private List<Giangvien> DanhsachGiangvien = new List<Giangvien>();
        private DataTable tbOrder2;
        string fileBinarygiangvien = @"giaovien.dat";
        public chitietgiangvien()
        {
            InitializeComponent();
        }

        private void magiangvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void chitietgiangvien_Load(object sender, EventArgs e)
        {
            tbOrder2 = new DataTable();
            tbOrder2.Columns.Add("STT");
            tbOrder2.Columns.Add("Mã giảng viên");
            tbOrder2.Columns.Add("Tên giảng viên");
            tbOrder2.Columns.Add("Chuyên ngành");
            tbOrder2.Columns.Add("Trình độ");
            tbOrder2.Columns.Add("Lớp đang giảng");
            dataGridView2.DataSource = tbOrder2;
            if (File.Exists(fileBinarygiangvien) == true)
            {
                using (Stream stream = File.Open(fileBinarygiangvien, FileMode.Open))
                {
                    var bformatter = new BinaryFormatter();
                    DanhsachGiangvien = (List<Giangvien>)bformatter.Deserialize(stream);

                    foreach (Giangvien i in DanhsachGiangvien)
                    {
                        DataRow Y = tbOrder2.NewRow();
                        Y["Mã giảng viên"] = i.MaGiangvien;
                        Y["Tên giảng viên"] = i.TenGiangvien;
                        Y["Chuyên ngành"] = i.ChuyenNganh;
                        Y["Trình độ"] = i.TrinhDo;
                        Y["Lớp đang giảng"] = i.LopDangGiang;
                        tbOrder2.Rows.Add(Y);
                    }
                }
            }
        }

        private void themGV_Click(object sender, EventArgs e)
        {
            int STT = tbOrder2.Rows.Count + 1;
            DataRow r = tbOrder2.NewRow();
            r["STT"] = STT;
            r["Mã giảng viên"] = magiangvien.Text;
            r["Tên giảng viên"] = tengiangvien.Text;
            r["Chuyên ngành"] = chuyennganh.Text;
            r["Trình độ"] = trinhdo.Text;
            r["Lớp đang giảng"] = lopdanggiang.Text;
            tbOrder2.Rows.Add(r);
            Giangvien Giangvien = new Giangvien(magiangvien.Text, tengiangvien.Text, chuyennganh.Text, lopdanggiang.Text, trinhdo.Text);
            DanhsachGiangvien.Add(Giangvien);
            using (Stream stream = File.Open(fileBinarygiangvien, FileMode.Create))
            {
                var bformatter = new BinaryFormatter();
                bformatter.Serialize(stream, DanhsachGiangvien);
            }
        }

        private void suaGV_Click(object sender, EventArgs e)
        {
            int select = dataGridView2.CurrentCell.RowIndex;
            tbOrder2.Rows[select]["Mã Giảng Viên"] = magiangvien.Text;
            tbOrder2.Rows[select]["Tên Giảng Viên"] = tengiangvien.Text;
            tbOrder2.Rows[select]["Chuyên Ngành"] = chuyennganh.Text;
            tbOrder2.Rows[select]["Trình Độ"] = trinhdo.Text;
            tbOrder2.Rows[select]["Lớp Đang Giảng"] = lopdanggiang.Text;
            DanhsachGiangvien[select].MaGiangvien = magiangvien.Text;
            DanhsachGiangvien[select].TenGiangvien = tengiangvien.Text;
            DanhsachGiangvien[select].ChuyenNganh = chuyennganh.Text;
            DanhsachGiangvien[select].TrinhDo = trinhdo.Text;
            DanhsachGiangvien[select].LopDangGiang = lopdanggiang.Text;
            using (Stream stream = File.Open(fileBinarygiangvien, FileMode.Create))
            {
                var bformatter = new BinaryFormatter();
                bformatter.Serialize(stream, DanhsachGiangvien);
            }
        }

        private void xoaGV_Click(object sender, EventArgs e)
        {
            int n = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows.RemoveAt(n);
            int a = tbOrder2.Rows.Count;
            for (int i = 0; i < a; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = i + 1;
            }
            DanhsachGiangvien.RemoveAt(n);
            using (Stream stream = File.Open(fileBinarygiangvien, FileMode.Create))
            {
                var bformatter = new BinaryFormatter();
                bformatter.Serialize(stream, DanhsachGiangvien);
            }
        }

        private void thoat_2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void butlh_Click(object sender, EventArgs e)
        {
            Form1 Ct = new Form1();
            Ct.ShowDialog();
        }

        private void butgv_Click(object sender, EventArgs e)
        {
        }

        private void butsv_Click(object sender, EventArgs e)
        {
            chitietsinhvien Ct = new chitietsinhvien();
            Ct.ShowDialog();
        }
    }
}
