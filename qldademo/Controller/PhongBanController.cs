using qldademo.Datalayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace qldademo.Controller
{
    public class PhongBanController
    {
        public PhongBanData data_NhanVien { get; set; }

        public DataTable tableNhanVien { get; set; }

        public DataTable HienThiDanhSachPhongBan()
        {
            if (data_NhanVien == null)
            {
                data_NhanVien = new PhongBanData();
            }
            tableNhanVien = data_NhanVien.lay_dsPhongBan();

            return tableNhanVien;
        }
    }
}