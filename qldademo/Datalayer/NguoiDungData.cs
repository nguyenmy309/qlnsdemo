using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace qldademo.Datalayer
{
    public class NguoiDungData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsNguoiDung()
        public DataTable lay_dsNguoiDung()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From NGUOIDUNG");
            Service.Load(cmd);
            return Service;
        }
        #endregion

        //#region Update()
        //public bool Update()
        //{
        //    return Service.Update();
        //}
        //#endregion

        #region lay_TenDangNhap()
        public DataTable lay_TenDangNhap(String username)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From  NGUOIDUNG Where TENDN = @ten";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ten", SqlDbType.VarChar).Value = username;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region lay_MatKhau()
        public DataTable lay_MatKhau(String matkhau)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From  NGUOIDUNG Where MATKHAU = @pass";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = matkhau;
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region DoiMatKhau()
        public DataTable DoiMatKhau(String matkhau_old, String matkhau_new)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Update NGUOIDUNG Set MATKHAU = @new Where MATKHAU=@old";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("old", SqlDbType.VarChar).Value = matkhau_old;
            cmd.Parameters.Add("new", SqlDbType.VarChar).Value = matkhau_new;
            Service.Load(cmd);
            return Service;
        }
        #endregion        
    }
}