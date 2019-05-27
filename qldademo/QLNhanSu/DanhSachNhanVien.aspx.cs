using qldademo.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace qldademo.QLNhanSu
{
    public partial class DanhSachNhanVien : System.Web.UI.Page
    {
        public NhanVienController controller_NhanVien { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void LoadForm()
        {
            //goi hàm tu controller
            if (controller_NhanVien == null)
                controller_NhanVien = new NhanVienController();
            grdViewDSNhanVien.DataSource = controller_NhanVien.HienThiDanhSachNhanVien();
<<<<<<< HEAD
            grdViewDSNhanVien.DataBind();

        }

=======
            grdViewDSNhanVien.DataBind();

        }

>>>>>>> sda
    }
}