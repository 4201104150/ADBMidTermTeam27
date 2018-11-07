using MidTerm2016;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADBTeam27_DB4O
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataHelper.DBFileName = "QLMonHocdb.yab";
            Khoa khoa = new Khoa("KKK", "dsa", "sadad", "dagda");
            DataHelper.AddKhoa(khoa);
            MonHoc montr = new MonHoc(1, "sấ", "addas", khoa, null, 2);
            DataHelper.AddMonHoc(montr);
            MonHoc mon = new MonHoc(2, "ltdt", "đã qua", khoa, null, 2);
            DataHelper.AddMonHoc(mon);

            grvKhoa.DataSource = null;
            grvKhoa.DataSource = DataHelper.GetListKhoa<Khoa>();
            grvMonHoc.DataSource = null;
            grvMonHoc.DataSource = DataHelper.GetListMonHoc<MonHoc>();
        }

        private void btnAddKhoa_Click(object sender, EventArgs e)
        {
            Khoa khoaz = new Khoa(txtMaKhoa.Text, txtTenKhoa.Text, txtDiaChi.Text, txtSDT.Text);
            DataHelper.AddKhoa(khoaz);
            grvKhoa.DataSource = DataHelper.GetListKhoa<Khoa>();
        }
        private void txtMH_MaMHTruoc_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            Khoa khoaz = DataHelper.selectKhoa(txtMH_MaKhoa.Text);
            MonHoc monHoc = DataHelper.selectMonHoc(int.Parse(txtMH_MaMHTruoc.Text));
            MonHoc monHocz = new MonHoc(int.Parse(txtMaMonHoc.Text),txtTenMon.Text,txtMoTa.Text,khoaz,monHoc,double.Parse(txtSoTinChi.Text));
            DataHelper.AddMonHoc(monHocz);
            grvMonHoc.DataSource = DataHelper.GetListMonHoc<MonHoc>();
        }
    }
}
