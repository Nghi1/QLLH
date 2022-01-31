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
    public partial class Form1 : Form
    {
        private List<Lophoc> Danhsachlop = new List<Lophoc>();
        private DataTable tbOrder1;
        string fileBinarylophoc = @"lophoc.dat";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbOrder1 = new DataTable();
            tbOrder1.Columns.Add("STT");
            tbOrder1.Columns.Add("Mã lớp");
            tbOrder1.Columns.Add("Tên lớp");
            tbOrder1.Columns.Add("Khoa");
            tbOrder1.Columns.Add("Ngành học");
            tbOrder1.Columns.Add("Môn học");
            tbOrder1.Columns.Add("Học kỳ");
            tbOrder1.Columns.Add("Giảng viên");
            tbOrder1.Columns.Add("Số lượng sinh viên");
            dataGridView1.DataSource = tbOrder1;    
            if (File.Exists(fileBinarylophoc) == true)
            {
                using (Stream stream = File.Open(fileBinarylophoc, FileMode.Open))
                {
                    var bformatter = new BinaryFormatter();
                    Danhsachlop = (List<Lophoc>)bformatter.Deserialize(stream);

                    foreach (Lophoc i in Danhsachlop)
                    {
                        DataRow Y = tbOrder1.NewRow();
                        Y["Mã lớp"] = i.MaLop;
                        Y["Tên lớp"] = i.TenLop;
                        Y["Khoa"] = i.Khoa;
                        Y["Ngành học"] = i.NghanhHoc;
                        Y["Môn học"] = i.MonHoc;
                        Y["Học kỳ"] = i.HocKy;
                        Y["Giảng viên"] = i.GiangVien;
                        Y["Số lượng sinh viên"] = i.SoluongSinhvien;
                        tbOrder1.Rows.Add(Y);
                    }
                }
            }
        }

        private void thoat_bt1_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void sua_bt1_Click(object sender, EventArgs e)
        {

        }

        private void malop_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void butlh_Click(object sender, EventArgs e)
        {
        }

        private void butgv_Click(object sender, EventArgs e)
        {
            chitietgiangvien add = new chitietgiangvien();
            add.ShowDialog();
        }

        private void butsv_Click(object sender, EventArgs e)
        {
            chitietsinhvien add = new chitietsinhvien();
            add.ShowDialog();
        }

        private void malop_txt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void chitiet_Click_1(object sender, EventArgs e)
        {
            Chi_tiết Ct = new Chi_tiết();
            Ct.ShowDialog();
        }

        private void them_bt1_Click(object sender, EventArgs e)
        {
            Chi_tiết Ct = new Chi_tiết();
            Ct.ShowDialog();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            Chi_tiết Ct = new Chi_tiết();
            Ct.ShowDialog();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(n);
            int a = tbOrder1.Rows.Count;
            for (int i = 0; i < a; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
            Danhsachlop.RemoveAt(n);
            using (Stream stream = File.Open(fileBinarylophoc, FileMode.Create))
            {
                var bformatter = new BinaryFormatter();
                bformatter.Serialize(stream, Danhsachlop);
            }
        }

        private void rf_Click(object sender, EventArgs e)
        {
            tbOrder1 = new DataTable();
            tbOrder1.Columns.Add("STT");
            tbOrder1.Columns.Add("Mã lớp");
            tbOrder1.Columns.Add("Tên lớp");
            tbOrder1.Columns.Add("Khoa");
            tbOrder1.Columns.Add("Ngành học");
            tbOrder1.Columns.Add("Môn học");
            tbOrder1.Columns.Add("Học kỳ");
            tbOrder1.Columns.Add("Giảng viên");
            tbOrder1.Columns.Add("Số lượng sinh viên");
            dataGridView1.DataSource = tbOrder1;
            if (File.Exists(fileBinarylophoc) == true)
            {
                using (Stream stream = File.Open(fileBinarylophoc, FileMode.Open))
                {
                    var bformatter = new BinaryFormatter();
                    Danhsachlop = (List<Lophoc>)bformatter.Deserialize(stream);

                    foreach (Lophoc i in Danhsachlop)
                    {
                        DataRow Y = tbOrder1.NewRow();
                        Y["Mã lớp"] = i.MaLop;
                        Y["Tên lớp"] = i.TenLop;
                        Y["Khoa"] = i.Khoa;
                        Y["Ngành học"] = i.NghanhHoc;
                        Y["Môn học"] = i.MonHoc;
                        Y["Học kỳ"] = i.HocKy;
                        Y["Giảng viên"] = i.GiangVien;
                        Y["Số lượng sinh viên"] = i.SoluongSinhvien;
                        tbOrder1.Rows.Add(Y);
                    }
                }
            }
        }
    }
}
