using qldademo.Datalayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using qldademo.BusinessObject;
using System.Web.UI.WebControls;

namespace qldademo.Controller
{
    public class PhongBanController
    {
        //public PhongBanData data_PhongBan { get; set; }
        private PhongBanData m_dataPhongBan;
        public PhongBanData data_PhongBan
        {
            get { return m_dataPhongBan; }
            set { m_dataPhongBan = value; }
        }

        public DataTable tablePhongBan { get; set; }

        public PhongBanInfo recordPhongBan { get; set; }

        public DataTable HienThiDanhSachPhongBan()
        {
            if (data_PhongBan == null)
            {
                data_PhongBan = new PhongBanData();
            }
            tablePhongBan = data_PhongBan.lay_dsPhongBan();

            return tablePhongBan;
        }

        public PhongBanInfo HienThiRecordPhongBan(string maPB)
        {
            //if (this.data_PhongBan == null)
            //{
            //    this.data_PhongBan = new PhongBanData();
            //}
            //return this.data_PhongBan.GetPhongBan(maPB);
            if (data_PhongBan == null)
            {
                data_PhongBan = new PhongBanData();
            }
            recordPhongBan = data_PhongBan.GetPhongBan(maPB);

            return recordPhongBan;
        }
        public void HienThiInfo(TextBox txtMaPH, TextBox txtTenPH, TextBox txtSONHANVIEN, TextBox txtGhiChu, PhongBanInfo info)
        {
            txtMaPH.Text = info.MaPhong;
            txtTenPH.Text = info.TenPhong;
            txtSONHANVIEN.Text = info.SoNhanVien.ToString();
            txtGhiChu.Text = info.GhiChu;
        }
    }
}