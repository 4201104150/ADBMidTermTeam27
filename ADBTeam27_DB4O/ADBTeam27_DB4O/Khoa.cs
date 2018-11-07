using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm2016
{
    [Serializable]
    public class Khoa
    {   
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public override string ToString()
        {
            return TenKhoa;
        }
        public Khoa(string p1, string p2, string p3, string p4)
        {
            this.MaKhoa = p1;
            this.TenKhoa = p2;
            this.DiaChi = p3;
            this.DienThoai = p4;
        }
        public Khoa() { }
    }
}
