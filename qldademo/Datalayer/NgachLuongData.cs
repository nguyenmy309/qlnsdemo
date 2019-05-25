using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TT_GDTX_ANGIANG.BusinessObject;

namespace qldademo.Datalayer
{
    public class NgachLuongData
    {
        public DataService Service { get; set; }

        #region lay_dsNgachLuong
        public DataTable lay_dsNgachLuong()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From NGACH");
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region lay_1 record-NgachLuong
        public NgachInfo LayRecordHSLuong(string maNgach)
        {
            if (this.Service == null)
            {
                this.Service = new DataService();
            }
            SqlCommand cmd = new SqlCommand("Select * From [NGACH] Where MANGACH = @MA_NGACH");
            cmd.Parameters.Add("MA_NGACH", SqlDbType.VarChar).Value = maNgach;
            this.Service.Load(cmd);            
            //su dung constructor
            return new NgachInfo(maNgach, this.Service.Rows[0]["TENNGACH"].ToString()   );
        }

        #endregion

        #region Update()
        public bool Update()
        {
            return Service.Update();
        }
        #endregion
    }
}