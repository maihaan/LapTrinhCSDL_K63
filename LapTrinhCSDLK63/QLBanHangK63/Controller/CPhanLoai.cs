using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLBanHangK63.Model;

namespace QLBanHangK63.Controller
{
    public class CPhanLoai
    {
        DataAccess da = new DataAccess();

        // Select by ID
        public MPhanLoai SelectByID(int id)
        {
            String tenProcedure = "spTimTheoID";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("id", id));
            DataTable tb = da.Read(tenProcedure, dsThamSo);
            if (tb != null && tb.Rows.Count > 0)
            {
                MPhanLoai m = new MPhanLoai();
                m.ID = int.Parse(tb.Rows[0]["ID"].ToString());
                m.Ma = tb.Rows[0]["Ma"].ToString();
                m.Ten = tb.Rows[0]["Ten"].ToString();
                return m;
            }
            else
                return null;
        }

        // Select by Ma
        public MPhanLoai SelectByMa(String ma)
        {
            String tenProcedure = "spTimTheoMa";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            DataTable tb = da.Read(tenProcedure, dsThamSo);
            if (tb != null && tb.Rows.Count > 0)
            {
                MPhanLoai m = new MPhanLoai();
                m.ID = int.Parse(tb.Rows[0]["ID"].ToString());
                m.Ma = tb.Rows[0]["Ma"].ToString();
                m.Ten = tb.Rows[0]["Ten"].ToString();
                return m;
            }
            else
                return null;
        }

        // Select by Ten
        public DataTable SelectByTen(String ten)
        {
            String tenProcedure = "spTimTheoTen";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ten", ten));
            return da.Read(tenProcedure, dsThamSo);
        }

        public List<MPhanLoai> SelectListByTen(String ten)
        {
            String tenProcedure = "spTimTheoTen";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ten", ten));
            DataTable tb = da.Read(tenProcedure, dsThamSo);
            List<MPhanLoai> ds = new List<MPhanLoai>();
            if (tb != null && tb.Rows.Count > 0)
            {
                foreach (DataRow r in tb.Rows)
                {
                    MPhanLoai m = new MPhanLoai();
                    m.ID = int.Parse(r["ID"].ToString());
                    m.Ma = r["Ma"].ToString();
                    m.Ten = r["Ten"].ToString();
                    ds.Add(m);
                }
                return ds;
            }
            else
                return null;
        }

        // Insert
        public int Insert(String ma, String ten)
        {
            String tenProcedure = "spThemPhanLoai";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            dsThamSo.Add(new SqlParameter("ten", ten));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output; 
            dsThamSo.Add(pkq);
            da.Write(tenProcedure, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }

        // Update by ID
        public int UpdateByID(int id, String ten)
        {
            String tenProcedure = "spSuaPhanLoaiTheoID";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("id", id));
            dsThamSo.Add(new SqlParameter("ten", ten));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProcedure, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }

        // Update by Ma
        public int UpdateByMa(String ma, String ten)
        {
            String tenProcedure = "spSuaPhanLoaiTheoMa";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            dsThamSo.Add(new SqlParameter("ten", ten));
            dsThamSo.Add(new SqlParameter("ketQua", ketQua));
            da.Write(tenProcedure, dsThamSo);
            return ketQua;
        }

        // Delete by ID
        public int DeleteByID(int id)
        {
            String tenProcedure = "spXoaPhanLoaiTheoID";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("id", id));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProcedure, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }

        // Delete by Ma
        public int DeleteByMa(String ma)
        {
            String tenProcedure = "spXoaPhanLoaiTheoMa";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            SqlParameter pkq = new SqlParameter("ketQua", ketQua);
            pkq.Direction = ParameterDirection.Output;
            dsThamSo.Add(pkq);
            da.Write(tenProcedure, dsThamSo);
            ketQua = int.Parse(pkq.Value.ToString());
            return ketQua;
        }
    }
}
