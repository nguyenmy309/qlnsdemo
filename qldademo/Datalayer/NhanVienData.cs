using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace qldademo.Datalayer
{
    public class NhanVienData
    {
        
        public DataService Service { get; set; }

        #region lay_dsNhanVien()
        public DataTable lay_dsNhanVien()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select MANV, HOTEN, GIOITINH, NGAYSINh, CMND From NHANVIEN");
            Service.Load(cmd);
            return Service;
        }
        #endregion  

    }
}