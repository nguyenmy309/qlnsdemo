<<<<<<< HEAD
﻿using qldademo.BOject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace qldademo.Datalayer
{
    public class HeSoLuongNhanVienData
    {
        public DataService Service { get; set; }

        #region lay_dsHeSoLuongNhanVien()
        public DataTable lay_dsHeSoLuongNhanVien()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From HESOLUONGNHANVIEN");
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region Lay1RecordHSLuong Show lên phần update-delete()
        public HeSoLuongNhanVienInfo LayRecordHSLuong(string maHSLuong)
        {
            //if (this.Service == null)
            //{
            //    this.Service = new DataService();
            //}
            //SqlCommand cmd = new SqlCommand("Select * From [HESOLUONGNHANVIEN] Where MAHSLUONG = @MAHS");
            //cmd.Parameters.Add("MAHS", SqlDbType.VarChar).Value = maHSLuong;
            //this.Service.Load(cmd);
            //float heSoLuong = 0;
            //float.TryParse(this.Service.Rows[0][0].ToString(), out heSoLuong);
            ////su dung constructor
            //return new HeSoLuongNhanVienInfo(maHSLuong, this.Service.Rows[0][0].ToString(),
            //                                   this.Service.Rows[0][0].ToString(), heSoLuong );
            return new HeSoLuongNhanVienInfo();
        }
        #endregion
    }
=======
﻿using qldademo.BOject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace qldademo.Datalayer
{
    public class HeSoLuongNhanVienData
    {
        public DataService Service { get; set; }

        #region lay_dsHeSoLuongNhanVien()
        public DataTable lay_dsHeSoLuongNhanVien()
        {
            if (Service == null)
                Service = new DataService();
            SqlCommand cmd = new SqlCommand("Select * From HESOLUONGNHANVIEN");
            Service.Load(cmd);
            return Service;
        }
        #endregion

        #region Lay1RecordHSLuong Show lên phần update-delete()
        public HeSoLuongNhanVienInfo LayRecordHSLuong(string maHSLuong)
        {
            //if (this.Service == null)
            //{
            //    this.Service = new DataService();
            //}
            //SqlCommand cmd = new SqlCommand("Select * From [HESOLUONGNHANVIEN] Where MAHSLUONG = @MAHS");
            //cmd.Parameters.Add("MAHS", SqlDbType.VarChar).Value = maHSLuong;
            //this.Service.Load(cmd);
            //float heSoLuong = 0;
            //float.TryParse(this.Service.Rows[0][0].ToString(), out heSoLuong);
            ////su dung constructor
            //return new HeSoLuongNhanVienInfo(maHSLuong, this.Service.Rows[0][0].ToString(),
            //                                   this.Service.Rows[0][0].ToString(), heSoLuong );
            return new HeSoLuongNhanVienInfo();
        }
        #endregion
    }
>>>>>>> sda
}