using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace qldademo.Datalayer
{
    public class PhongBanData
    {

        public DataService Service { get; set; }

        #region lay_dsNhanVien()
        public DataTable lay_dsPhongBan()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select MAPB, TENPB, SONHANVIEN, GHICHU From PHONGBAN");
            Service.Load(cmd);
            return Service;
        }
        #endregion  

    }
}