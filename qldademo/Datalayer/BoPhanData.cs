using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using qldademo.BOject;

namespace qldademo.Datalayer
{
    public class BoPhanData
    {
        #region Service
        private DataService m_Service;
        public DataService Service
        {
            get { return m_Service; }
            set { m_Service = value; }
        }
        #endregion

        #region lay_dsBoPhan()
        public DataTable lay_dsBoPhan()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From BOPHAN");
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

        #region GetBoPhan()
        public BoPhanInfo GetBoPhan(string maBP)
        {
            if (this.Service == null)
            {
                this.Service = new DataService();
            }
            SqlCommand cmd = new SqlCommand("Select TENBP From BOPHAN Where MABP = @ma");
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maBP;
            this.Service.Load(cmd);
            if (this.Service.Rows.Count > 0)
            {
                return new BoPhanInfo(maBP, this.Service.Rows[0][0].ToString());
            }
            return new BoPhanInfo(maBP, "");
        }
        #endregion    

        #region KiemTra_Phong
        public DataTable KiemTra_Phong(string phong)
        {
            if (Service == null)
                Service = new DataService();
            String sql = "Select * From BOPHAN Where PHONGBAN = @ma";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = phong;
            cmd.CommandText = sql;
            Service.Load(cmd);
            return Service;
        }
        #endregion       
    }

}