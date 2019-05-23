using qldademo.Datalayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace qldademo.Controller
{
    public class NhanVienController
    {
        public NhanVienData data_NhanVien { get; set; }

        public DataTable tableNhanVien { get; set; }

        public DataTable HienThiDanhSachNhanVien()
        {
            if (data_NhanVien == null)
            {
                data_NhanVien = new NhanVienData();
            }
            tableNhanVien = data_NhanVien.lay_dsNhanVien();

            return tableNhanVien;
        }
    }
}