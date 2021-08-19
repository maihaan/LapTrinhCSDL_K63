using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLBanHangK63.Controller
{
    public class CPhanLoai
    {
        DataAccess da = new DataAccess();

        // Select by ID
        public DataTable SelectByID(int id)
        {
            String tenProcedure = "spTimTheoID";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("id", id));
            return da.Read(tenProcedure, dsThamSo);
        }

        // Select by Ma
        public DataTable SelectByMa(String ma)
        {
            String tenProcedure = "spTimTheoMa";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            return da.Read(tenProcedure, dsThamSo);
        }

        // Select by Ten
        public DataTable SelectByTen(String ten)
        {
            String tenProcedure = "spTimTheoTen";
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ten", ten));
            return da.Read(tenProcedure, dsThamSo);
        }

        // Insert
        public int Insert(String ma, String ten)
        {
            String tenProcedure = "spThemPhanLoai";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            dsThamSo.Add(new SqlParameter("ten", ten));
            dsThamSo.Add(new SqlParameter("ketQua", ketQua));
            da.Write(tenProcedure, dsThamSo);
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
            dsThamSo.Add(new SqlParameter("ketQua", ketQua));
            da.Write(tenProcedure, dsThamSo);
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
        public int DeleteByID(int id, String ten)
        {
            String tenProcedure = "spXoaPhanLoaiTheoID";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("id", id));
            dsThamSo.Add(new SqlParameter("ten", ten));
            dsThamSo.Add(new SqlParameter("ketQua", ketQua));
            da.Write(tenProcedure, dsThamSo);
            return ketQua;
        }

        // Delete by Ma
        public int DeleteByMa(String ma, String ten)
        {
            String tenProcedure = "spXoaPhanLoaiTheoMa";
            int ketQua = 0;
            List<SqlParameter> dsThamSo = new List<SqlParameter>();
            dsThamSo.Add(new SqlParameter("ma", ma));
            dsThamSo.Add(new SqlParameter("ten", ten));
            dsThamSo.Add(new SqlParameter("ketQua", ketQua));
            da.Write(tenProcedure, dsThamSo);
            return ketQua;
        }
    }
}
