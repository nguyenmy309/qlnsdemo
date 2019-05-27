<<<<<<< HEAD
﻿using qldademo.BOject;
using qldademo.Datalayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace qldademo.Controller
{
    public class HeSoLuongNhanVienController
    {
        public HeSoLuongNhanVienData data_HSLuongNhanVien { get; set; }

        public DataTable tableHSLuongNhanVien { get; set; }

=======
﻿using qldademo.BOject;
using qldademo.Datalayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace qldademo.Controller
{
    public class HeSoLuongNhanVienController
    {
        public HeSoLuongNhanVienData data_HSLuongNhanVien { get; set; }

        public DataTable tableHSLuongNhanVien { get; set; }

>>>>>>> sda
        public DataTable HienThiDanhSachHSLuongNhanVien()
        {
            if (data_HSLuongNhanVien == null)
            {
                data_HSLuongNhanVien = new HeSoLuongNhanVienData();
            }
            tableHSLuongNhanVien = data_HSLuongNhanVien.lay_dsHeSoLuongNhanVien();

            return tableHSLuongNhanVien;
<<<<<<< HEAD
        }

        public HeSoLuongNhanVienInfo LayRecordHSLuong(string MaHSLuong)
        {
            //if (this.Service == null)
            //{
            //    this.Service = new DataService();
            //}
            //SqlCommand cmd = new SqlCommand("Select TENBAC From BAC Where MABAC = @ma");
            //cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maBac;
            //this.Service.Load(cmd);

            //return new BacInfo(maBac, this.Service.Rows[0][0].ToString());
            return new HeSoLuongNhanVienInfo();
        }

          
    }
=======
        }

        public HeSoLuongNhanVienInfo LayRecordHSLuong(string MaHSLuong)
        {
            //if (this.Service == null)
            //{
            //    this.Service = new DataService();
            //}
            //SqlCommand cmd = new SqlCommand("Select TENBAC From BAC Where MABAC = @ma");
            //cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = maBac;
            //this.Service.Load(cmd);

            //return new BacInfo(maBac, this.Service.Rows[0][0].ToString());
            return new HeSoLuongNhanVienInfo();
        }

          
    }
>>>>>>> sda
}