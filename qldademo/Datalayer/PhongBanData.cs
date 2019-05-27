using qldademo.BusinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using qldademo.BusinessObject;

namespace qldademo.Datalayer
{
    public class PhongBanData
    {

        public DataService Service { get; set; }

        #region lay_dsPhongBan()
        public DataTable lay_dsPhongBan()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select MAPB, TENPB, SONHANVIEN, GHICHU From PHONGBAN");
            Service.Load(cmd);
            return Service;
        }
        #endregion
        #region lay_dsNV_co_trong_phongban
        public DataTable LayRecordHSLuong(string maPH)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From NHANVIEN Where PHONGBAN = @ma  ";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maPH;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }


        #endregion
        #region lay_1 record-PhongBan
        public PhongBanInfo GetPhongBan(string maPH)
        {
            if (this.Service == null)
            {
                this.Service = new DataService();
            }
            SqlCommand cmd = new SqlCommand("Select MAPB, TENPB, SONHANVIEN, GHICHU From PHONGBAN Where MAPB = @ma");
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maPH;
            this.Service.Load(cmd);

            return new PhongBanInfo(maPH, this.Service.Rows[0]["TENPB"].ToString());
        }
        #endregion

    }
}