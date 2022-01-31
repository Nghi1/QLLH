
namespace Baithi
{
    partial class Chi_tiết
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
            this.giangvien = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monhoc = new System.Windows.Forms.TextBox();
            this.soluongsinhvien = new System.Windows.Forms.TextBox();
            this.hocky = new System.Windows.Forms.TextBox();
            this.nganhhoc = new System.Windows.Forms.TextBox();
            this.khoa = new System.Windows.Forms.TextBox();
            this.tenlop = new System.Windows.Forms.TextBox();
            this.ma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.thoat_bt = new System.Windows.Forms.Button();
            this.luu_bt = new System.Windows.Forms.Button();
            this.butsv = new System.Windows.Forms.Button();
            this.butgv = new System.Windows.Forms.Button();
            this.butlh = new System.Windows.Forms.Button();
            this.rf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // giangvien
            // 
            this.giangvien.FormattingEnabled = true;
            this.giangvien.Location = new System.Drawing.Point(143, 231);
            this.giangvien.Name = "giangvien";
            this.giangvien.Size = new System.Drawing.Size(215, 21);
            this.giangvien.TabIndex = 86;
            this.giangvien.SelectedIndexChanged += new System.EventHandler(this.giangvien_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(699, 200);
            this.dataGridView1.TabIndex = 85;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(226, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 18);
            this.label10.TabIndex = 84;
            this.label10.Text = "DANH SÁCH SINH VIÊN THAM GIA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 83;
            this.label9.Text = "Số lượng Sinh viên :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 82;
            this.label8.Text = "Học kỳ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 81;
            this.label7.Text = "Ngành Học :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "Tên Lớp :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "Giảng viên :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Môn học :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Khoa :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Mã lớp :";
            // 
            // monhoc
            // 
            this.monhoc.Location = new System.Drawing.Point(143, 187);
            this.monhoc.Name = "monhoc";
            this.monhoc.Size = new System.Drawing.Size(215, 20);
            this.monhoc.TabIndex = 74;
            // 
            // soluongsinhvien
            // 
            this.soluongsinhvien.Location = new System.Drawing.Point(529, 228);
            this.soluongsinhvien.Name = "soluongsinhvien";
            this.soluongsinhvien.Size = new System.Drawing.Size(215, 20);
            this.soluongsinhvien.TabIndex = 75;
            // 
            // hocky
            // 
            this.hocky.Location = new System.Drawing.Point(529, 187);
            this.hocky.Name = "hocky";
            this.hocky.Size = new System.Drawing.Size(215, 20);
            this.hocky.TabIndex = 73;
            // 
            // nganhhoc
            // 
            this.nganhhoc.Location = new System.Drawing.Point(529, 142);
            this.nganhhoc.Name = "nganhhoc";
            this.nganhhoc.Size = new System.Drawing.Size(215, 20);
            this.nganhhoc.TabIndex = 72;
            // 
            // khoa
            // 
            this.khoa.Location = new System.Drawing.Point(143, 139);
            this.khoa.Name = "khoa";
            this.khoa.Size = new System.Drawing.Size(215, 20);
            this.khoa.TabIndex = 71;
            // 
            // tenlop
            // 
            this.tenlop.Location = new System.Drawing.Point(529, 98);
            this.tenlop.Name = "tenlop";
            this.tenlop.Size = new System.Drawing.Size(215, 20);
            this.tenlop.TabIndex = 70;
            // 
            // ma
            // 
            this.ma.Location = new System.Drawing.Point(143, 92);
            this.ma.Name = "ma";
            this.ma.Size = new System.Drawing.Size(215, 20);
            this.ma.TabIndex = 69;
            this.ma.TextChanged += new System.EventHandler(this.ma_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(265, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "CHI TIẾT LỚP HỌC ";
            // 
            // thoat_bt
            // 
            this.thoat_bt.Location = new System.Drawing.Point(669, 304);
            this.thoat_bt.Name = "thoat_bt";
            this.thoat_bt.Size = new System.Drawing.Size(75, 30);
            this.thoat_bt.TabIndex = 67;
            this.thoat_bt.Text = "Thoát";
            this.thoat_bt.UseVisualStyleBackColor = true;
            this.thoat_bt.Click += new System.EventHandler(this.thoat_bt_Click_1);
            // 
            // luu_bt
            // 
            this.luu_bt.Location = new System.Drawing.Point(588, 304);
            this.luu_bt.Name = "luu_bt";
            this.luu_bt.Size = new System.Drawing.Size(75, 30);
            this.luu_bt.TabIndex = 66;
            this.luu_bt.Text = "Lưu";
            this.luu_bt.UseVisualStyleBackColor = true;
            this.luu_bt.Click += new System.EventHandler(this.luu_bt_Click);
            // 
            // butsv
            // 
            this.butsv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.butsv.Location = new System.Drawing.Point(184, 2);
            this.butsv.Name = "butsv";
            this.butsv.Size = new System.Drawing.Size(82, 26);
            this.butsv.TabIndex = 87;
            this.butsv.Text = "SINH VIÊN";
            this.butsv.UseVisualStyleBackColor = true;
            this.butsv.Click += new System.EventHandler(this.butsv_Click);
            // 
            // butgv
            // 
            this.butgv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.butgv.Location = new System.Drawing.Point(96, 2);
            this.butgv.Name = "butgv";
            this.butgv.Size = new System.Drawing.Size(82, 26);
            this.butgv.TabIndex = 88;
            this.butgv.Text = "GIẢNG VIÊN";
            this.butgv.UseVisualStyleBackColor = true;
            this.butgv.Click += new System.EventHandler(this.butgv_Click);
            // 
            // butlh
            // 
            this.butlh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.butlh.Location = new System.Drawing.Point(8, 2);
            this.butlh.Name = "butlh";
            this.butlh.Size = new System.Drawing.Size(82, 26);
            this.butlh.TabIndex = 89;
            this.butlh.Text = "LỚP HỌC";
            this.butlh.UseVisualStyleBackColor = true;
            this.butlh.Click += new System.EventHandler(this.butlh_Click);
            // 
            // rf
            // 
            this.rf.Location = new System.Drawing.Point(45, 304);
            this.rf.Name = "rf";
            this.rf.Size = new System.Drawing.Size(80, 30);
            this.rf.TabIndex = 90;
            this.rf.Text = "Refresh";
            this.rf.UseVisualStyleBackColor = true;
            this.rf.Click += new System.EventHandler(this.rf_Click);
            // 
            // Chi_tiết
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 597);
            this.Controls.Add(this.rf);
            this.Controls.Add(this.butsv);
            this.Controls.Add(this.butgv);
            this.Controls.Add(this.butlh);
            this.Controls.Add(this.giangvien);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monhoc);
            this.Controls.Add(this.soluongsinhvien);
            this.Controls.Add(this.hocky);
            this.Controls.Add(this.nganhhoc);
            this.Controls.Add(this.khoa);
            this.Controls.Add(this.tenlop);
            this.Controls.Add(this.ma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thoat_bt);
            this.Controls.Add(this.luu_bt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Chi_tiết";
            this.Text = "Chi_tiết";
            this.Load += new System.EventHandler(this.Chi_tiết_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox giangvien;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox monhoc;
        private System.Windows.Forms.TextBox soluongsinhvien;
        private System.Windows.Forms.TextBox hocky;
        private System.Windows.Forms.TextBox nganhhoc;
        private System.Windows.Forms.TextBox khoa;
        private System.Windows.Forms.TextBox tenlop;
        private System.Windows.Forms.TextBox ma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button thoat_bt;
        private System.Windows.Forms.Button luu_bt;
        private System.Windows.Forms.Button butsv;
        private System.Windows.Forms.Button butgv;
        private System.Windows.Forms.Button butlh;
        private System.Windows.Forms.Button rf;
    }
}