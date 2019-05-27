<<<<<<< HEAD
﻿using qldademo.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace qldademo.QLNhanSu
{
    public partial class DanhSachHeSoLuong : System.Web.UI.Page
    {
        public HeSoLuongNhanVienController controller_HSLuongNhanVien { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

=======
﻿using qldademo.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace qldademo.QLNhanSu
{
    public partial class DanhSachHeSoLuong : System.Web.UI.Page
    {
        public HeSoLuongNhanVienController controller_HSLuongNhanVien { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

>>>>>>> sda
        private void LoadForm()
        {
            //goi hàm tu controller
            if (controller_HSLuongNhanVien == null)
                controller_HSLuongNhanVien = new HeSoLuongNhanVienController();
            grdHeSoLuong.DataSource = controller_HSLuongNhanVien.HienThiDanhSachHSLuongNhanVien();
            grdHeSoLuong.DataBind();

<<<<<<< HEAD
        }

        private void BindFormInputData()
        {
            // query 1 row từ key của mã HS luong lấy duoc từ index change

        }
        protected void grdHeSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grdHeSoLuong_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }
    }
=======
        }

        private void BindFormInputData()
        {
            // query 1 row từ key của mã HS luong lấy duoc từ index change

        }
        protected void grdHeSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grdHeSoLuong_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }
    }
>>>>>>> sda
}