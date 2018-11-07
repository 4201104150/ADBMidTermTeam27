using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db4objects.Db4o;
using Db4objects.Db4o.NativeQueries;
using Db4objects.Db4o.Instrumentation;
using Cecil.FlowAnalysis;
using Mono.Cecil;
using Db4objects.Db4o.Linq;
using MidTerm2016;

namespace ADBTeam27_DB4O
{
    class DataHelper
    {
        public static string DBFileName { get; set; }
        public static void AddKhoa(Object oj)
        {
            IObjectContainer db = Db4oEmbedded.OpenFile(DBFileName);
            db.Store(oj);
            db.Close();
        }
        public static List<T> GetListKhoa<T>()
        {
            List<T> resutls = new List<T>();
            IObjectContainer db = Db4oEmbedded.OpenFile(DBFileName);

            Khoa template = new Khoa(null, null, null,null);
            IObjectSet resutlList = db.QueryByExample(template);
            foreach (T obj in resutlList)
            {
                resutls.Add(obj);
            }
            db.Close();
            return resutls;
        }
        public static void AddMonHoc(Object oj)
        {
            IObjectContainer db = Db4oEmbedded.OpenFile(DBFileName);
            db.Store(oj);
            db.Close();
        }
        public static List<T> GetListMonHoc<T>()
        {
            List<T> resutls = new List<T>();
            IObjectContainer db = Db4oEmbedded.OpenFile(DBFileName);

            Khoa khoaz = new Khoa(null, null, null, null);
            MonHoc monHocz = new MonHoc(0,null,null,null,null,0);
            MonHoc mon = new MonHoc(0, null, null, khoaz, monHocz, 0.0);
            IObjectSet resutlList = db.QueryByExample(mon);
            foreach (T obj in resutlList)
            {
                resutls.Add(obj);
            }
            db.Close();
            return resutls;
        }
        public static Khoa selectKhoa(string s)
        {
            IObjectContainer db = Db4oEmbedded.OpenFile(DBFileName);
            Khoa result = (from Khoa p in db where p.MaKhoa.StartsWith(s) select p).SingleOrDefault();
            Khoa course = new Khoa(result.MaKhoa, result.TenKhoa,result.DiaChi,result.DienThoai);
            return course;
        }
        public static MonHoc selectMonHoc(int s)
        {
            IObjectContainer db = Db4oEmbedded.OpenFile(DBFileName);
            MonHoc result = (from MonHoc p in db where p.MaMH==s select p).SingleOrDefault();
            MonHoc course = new MonHoc(result.MaMH, result.TenMon, result.MoTa, result.KhoaQuanLy,result.MonDieuKien,result.SoTinChi);
            return course;
        }
    }
}
