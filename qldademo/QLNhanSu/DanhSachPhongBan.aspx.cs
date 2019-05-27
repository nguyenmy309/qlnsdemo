using qldademo.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using qldademo.BusinessObject;

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
            grdViewPhongBan.DataSource = controller_PhongBan.HienThiDanhSachPhongBan();
            grdViewPhongBan.DataBind();

        }
        private void BindForm(string mangach)
        {
            if (controller_PhongBan == null)
                controller_PhongBan = new PhongBanController();
            PhongBanInfo recordPhongBan = controller_PhongBan.HienThiRecordPhongBan(mangach);
            //bind text to form
            txtMaPhongBan.Text = recordPhongBan.MaPhong;
            txtTenPhongBan.Text = recordPhongBan.TenPhong;
            TxtSoNhanVien.Text = recordPhongBan.SoNhanVien.ToString();
            TxtGhiChu.Text = recordPhongBan.GhiChu;
        }

        protected void grdViewPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["rowIndexInt"] = grdViewPhongBan.SelectedIndex;
            GridViewRow row = grdViewPhongBan.SelectedRow;
            string mangach = row.Cells[1].Text.ToString();//cot dau tien 1 chính là mã ngach trên grid
                                                          // chu' y' so 1 va` so 0, so' 0 co the dai dien cho cột chữ Select
            BindForm(mangach);
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;

        }
    }
}