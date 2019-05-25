using qldademo.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TT_GDTX_ANGIANG.BusinessObject;

namespace qldademo.QLNhanSu
{
    public partial class DanhSachNgachLuong : System.Web.UI.Page
    {
        public NgachLuongController controller_NgachLuong { get; set; }

        public int SelectedIndex { get; set; }
        public bool IsAddNew { get; set; }  
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            //goi hàm tu controller
            if (controller_NgachLuong == null)
                controller_NgachLuong = new NgachLuongController();
            grdNgachLuong.DataSource = controller_NgachLuong.HienThiDanhSachNgachLuong();
            grdNgachLuong.DataBind();
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            //txtMaNgachLuong.Text = "";
            //txtTenNgach.Text = "";
        }

        private void BindForm(string mangach)
        {
            if (controller_NgachLuong == null)
                controller_NgachLuong = new NgachLuongController();
            NgachInfo recordNgach = controller_NgachLuong.HienThiRecordNgachLuong(mangach);
            //bind text to form
            txtMaNgachLuong.Text = recordNgach.MaNgach;
            txtTenNgach.Text = recordNgach.TenNgach;
        }

        private void ClearFormInput()
        {
            txtMaNgachLuong.Text = "";
            txtTenNgach.Text = "";
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
        }
        protected void grdNgachLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int rowInt = grdNgachLuong.SelectedIndex;
            Session["rowIndexInt"] = grdNgachLuong.SelectedIndex; 
            GridViewRow row = grdNgachLuong.SelectedRow;
            string mangach = row.Cells[1].Text.ToString();//cot dau tien 1 chính là mã ngach trên grid
                                                       // chu' y' so 1 va` so 0, so' 0 co the dai dien cho cột chữ Select
            BindForm(mangach);
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;

        }

        //protected void grdNgachLuong_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        //{
        //    GridViewRow row = grdNgachLuong.SelectedRow;
        //    string mangach = row.Cells[0].Text.ToString();//cot dau tien 0 chính là mã ngach trên grid
        //    BindForm(mangach);
        //}

        

        protected void btnThemMoi_Click(object sender, EventArgs e)
        {
            //query DB để tạo mã ngach mới trên text box
            txtMaNgachLuong.Text = controller_NgachLuong.TaoMoiMaNgachLuong();
            txtTenNgach.Focus();
            txtIsAddNew.Text = "New";
            btnLuu.Enabled = true;  
            //tạo cooki giữ cờ add new
            //HttpCookie cookie_IsAddNew = new HttpCookie("IsAddNew", "New");
            //cookie_IsAddNew.Expires = DateTime.Now.AddDays(0.05); //0.04 ngày , khoảng 1 tiếng
            //Response.Cookies.Add(cookie_donvi);
        }

        protected void btn_Click(object sender, EventArgs e)
        {

        }

        protected void btnLuu_Click(object sender, EventArgs e)
        {
            NgachInfo info = new NgachInfo();
            info.MaNgach = txtMaNgachLuong.Text;
            info.TenNgach = txtTenNgach.Text;
            if (txtIsAddNew.Text.Equals("New"))
            {                
                if (controller_NgachLuong.AddNew(info))
                {                    
                    lblThongBao.Text = "Thêm thành công dữ liệu!";
                    lblThongBao.ForeColor = System.Drawing.Color.Green;
                    txtIsAddNew.Text = "";//reset cờ
                    LoadForm();
                }
            }
            //khi bam' nut' luu lai., mac dinh. no' se thao tac luu           
            else
            {                
                //thuc hien update
                if (Session["rowIndexInt"] != null)
                {
                    if (controller_NgachLuong.Update(info, (int)Session["rowIndexInt"]))
                    {
                        lblThongBao.Text = "Cập nhật thành công dữ liệu!";
                        lblThongBao.ForeColor = System.Drawing.Color.Green;
                        Session["rowIndexInt"] = null; // remove session
                        LoadForm();
                    }
                }

            }
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            if (Session["rowIndexInt"] != null)
            {
                if (controller_NgachLuong.Delete((int)Session["rowIndexInt"]))
                {
                    lblThongBao.Text = "Xóa thành công dữ liệu!";
                    lblThongBao.ForeColor = System.Drawing.Color.Red;
                    Session["rowIndexInt"] = null; // remove session
                    LoadForm();
                }
            }
        }

        protected void btnHuy_Click(object sender, EventArgs e)
        {
            ClearFormInput();
        }
    }
}