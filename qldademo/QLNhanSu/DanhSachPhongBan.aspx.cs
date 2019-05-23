using qldademo.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace qldademo.QLNhanSu
{
    public partial class DanhSachPhongBan : System.Web.UI.Page
    {
        public PhongBanController controller_PhongBan { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void LoadForm()
        {
            //goi hàm tu controller
            if (controller_PhongBan == null)
                controller_PhongBan = new PhongBanController();
            grdViewDSNhanVien.DataSource = controller_PhongBan.HienThiDanhSachPhongBan();
            grdViewDSNhanVien.DataBind();

        }
    }
}