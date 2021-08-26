using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLBanHangK63.Model;

namespace QLBanHangK63.Controller
{
    public class CHang
    {
        DataAccess da = new DataAccess();

        // Select by ID
        public MHang SelectByID(int id)
        {
            String tenProcedure = "spTimHangTheoID";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("id", id));
            DataTable tb = da.Read(tenProcedure, dsThamSo);
            if (tb != null && tb.Rows.Count > 0)
            {
                MHang m = new MHang();
                m.ID = int.Parse(tb.Rows[0]["ID"].ToString());
                m.Ma = tb.Rows[0]["Ma"].ToString();
                m.Ten = tb.Rows[0]["Ten"].ToString();
                m.MoTa = tb.Rows[0]["MoTa"].ToString();
                m.DVT = tb.Rows[0]["DVT"].ToString();
                m.MaPhanLoai = tb.Rows[0]["MaPhanLoai"].ToString();
                m.DonGia = int.Parse(tb.Rows[0]["DonGia"].ToString());
                m.SoLuong = int.Parse(tb.Rows[0]["SoLuong"].ToString());
                return m;
            }
            else
                return null;
        }

        // Select by Ma
        public MHang SelectByMa(String ma)
        {
            String tenProcedure = "spTimHangTheoMa";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            DataTable tb = da.Read(tenProcedure, dsThamSo);
            if (tb != null && tb.Rows.Count > 0)
            {
                MHang m = new MHang();
                m.ID = int.Parse(tb.Rows[0]["ID"].ToString());
                m.Ma = tb.Rows[0]["Ma"].ToString();
                m.Ten = tb.Rows[0]["Ten"].ToString();
                m.MoTa = tb.Rows[0]["MoTa"].ToString();
                m.DVT = tb.Rows[0]["DVT"].ToString();
                m.MaPhanLoai = tb.Rows[0]["MaPhanLoai"].ToString();
                m.DonGia = int.Parse(tb.Rows[0]["DonGia"].ToString());
                m.SoLuong = int.Parse(tb.Rows[0]["SoLuong"].ToString());
                return m;
            }
            else
                return null;
        }

        // Select by Ten
        public DataTable SelectByTen(String ten)
        {
            String tenProcedure = "spTimHangTheoTen";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ten", ten));
            return da.Read(tenProcedure, dsThamSo);
        }

        public List<MHang> SelectListByTen(String ten)
        {
            String tenProcedure = "spTimHangTheoTen";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ten", ten));
            DataTable tb = da.Read(tenProcedure, dsThamSo);
            List<MHang> ds = new List<MHang>();
            if (tb != null && tb.Rows.Count > 0)
            {
                foreach (DataRow r in tb.Rows)
                {
                    MHang m = new MHang();
                    m.ID = int.Parse(r["ID"].ToString());
                    m.Ma = r["Ma"].ToString();
                    m.Ten = r["Ten"].ToString();
                    m.MoTa = r["MoTa"].ToString();
                    m.DVT = r["DVT"].ToString();
                    m.MaPhanLoai = r["MaPhanLoai"].ToString();
                    m.DonGia = int.Parse(r["DonGia"].ToString());
                    m.SoLuong = int.Parse(r["SoLuong"].ToString());
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }

        public List<MHang> SelectListByMaPhanLoai(String maPhanLoai)
        {
            String tenProcedure = "spTimHangTheoMaPhanLoai";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("maPhanLoai", maPhanLoai));
            DataTable tb = da.Read(tenProcedure, dsThamSo);
            List<MHang> ds = new List<MHang>();
            if (tb != null && tb.Rows.Count > 0)
            {
                foreach (DataRow r in tb.Rows)
                {
                    MHang m = new MHang();
                    m.ID = int.Parse(r["ID"].ToString());
                    m.Ma = r["Ma"].ToString();
                    m.Ten = r["Ten"].ToString();
                    m.MoTa = r["MoTa"].ToString();
                    m.DVT = r["DVT"].ToString();
                    m.MaPhanLoai = r["MaPhanLoai"].ToString();
                    m.DonGia = int.Parse(r["DonGia"].ToString());
                    m.SoLuong = int.Parse(r["SoLuong"].ToString());
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }

        // Insert
        public int Insert(String ma, String ten, String moTa, String dvt, String maPhanLoai, int donGia, int soLuong)
        {
            String tenProcedure = "spThemHang";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            dsThamSo.Add(new SqlParameter("ten", ten));
            dsThamSo.Add(new SqlParameter("ketQua", ketQua));
            dsThamSo.Add(new SqlParameter("moTa", moTa));
            dsThamSo.Add(new SqlParameter("dvt", dvt));
            dsThamSo.Add(new SqlParameter("maPhanLoai", maPhanLoai));
            dsThamSo.Add(new SqlParameter("donGia", donGia));
            dsThamSo.Add(new SqlParameter("soLuong", soLuong));
            da.Write(tenProcedure, dsThamSo);
            return ketQua;
        }

        // Update by ID
        public int UpdateByID(int id, String ten, String moTa, String dvt, String maPhanLoai, int donGia, int soLuong)
        {
            String tenProcedure = "spSuaHangTheoID";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("id", id));
            dsThamSo.Add(new SqlParameter("ten", ten));
            dsThamSo.Add(new SqlParameter("ketQua", ketQua));
            dsThamSo.Add(new SqlParameter("moTa", moTa));
            dsThamSo.Add(new SqlParameter("dvt", dvt));
            dsThamSo.Add(new SqlParameter("maPhanLoai", maPhanLoai));
            dsThamSo.Add(new SqlParameter("donGia", donGia));
            dsThamSo.Add(new SqlParameter("soLuong", soLuong));
            da.Write(tenProcedure, dsThamSo);
            return ketQua;
        }

        // Update by Ma
        public int UpdateByMa(String ma, String ten, String moTa, String dvt, String maPhanLoai, int donGia, int soLuong)
        {
            String tenProcedure = "spSuaHangTheoMa";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            dsThamSo.Add(new SqlParameter("ten", ten));
            dsThamSo.Add(new SqlParameter("ketQua", ketQua));
            dsThamSo.Add(new SqlParameter("moTa", moTa));
            dsThamSo.Add(new SqlParameter("dvt", dvt));
            dsThamSo.Add(new SqlParameter("maPhanLoai", maPhanLoai));
            dsThamSo.Add(new SqlParameter("donGia", donGia));
            dsThamSo.Add(new SqlParameter("soLuong", soLuong));
            da.Write(tenProcedure, dsThamSo);
            return ketQua;
        }

        // Delete by ID
        public int DeleteByID(int id, String ten)
        {
            String tenProcedure = "spXoaHangTheoID";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("id", id));
            dsThamSo.Add(new SqlParameter("ketQua", ketQua));
            da.Write(tenProcedure, dsThamSo);
            return ketQua;
        }

        // Delete by Ma
        public int DeleteByMa(String ma, String ten)
        {
            String tenProcedure = "spXoaHangTheoMa";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            dsThamSo.Add(new SqlParameter("ketQua", ketQua));
            da.Write(tenProcedure, dsThamSo);
            return ketQua;
        }
    }
}
