using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace qldademo.BOject
{
    public class NguoiDungInfo
    {
        #region Constructor
        public NguoiDungInfo()
        {
        }

        public NguoiDungInfo(string maND, PhongBanInfo phongBan, BoPhanInfo boPhan, string tenDN, string matKhau, string hoTen, string phanQuyen, string gChu)
        {
            MaNguoiDung = maND;
            PhongBan = phongBan;
            BoPhan = boPhan;
            TenDangNhap = tenDN;
            MatKhau = matKhau;
            HoTen = hoTen;
            PhanQuyen = phanQuyen;
            GhiChu = gChu;
        }
        #endregion

        #region MAND
        private string m_MAND;
        public string MaNguoiDung
        {
            get { return m_MAND; }
            set { m_MAND = value; }
        }
        #endregion

        #region PHONGBAN
        private PhongBanInfo m_PHONGBAN;
        public PhongBanInfo PhongBan
        {
            get { return m_PHONGBAN; }
            set { m_PHONGBAN = value; }
        }
        #endregion

        #region BOPHAN
        private BoPhanInfo m_BOPHAN;
        public BoPhanInfo BoPhan
        {
            get { return m_BOPHAN; }
            set { m_BOPHAN = value; }
        }
        #endregion

        #region TENDN
        private string m_TENDN;
        public string TenDangNhap
        {
            get { return m_TENDN; }
            set { m_TENDN = value; }
        }
        #endregion

        #region MATKHAU
        private string m_MATKHAU;
        public string MatKhau
        {
            get { return m_MATKHAU; }
            set { m_MATKHAU = value; }
        }
        #endregion

        #region HOTEN
        private string m_HOTEN;
        public string HoTen
        {
            get { return m_HOTEN; }
            set { m_HOTEN = value; }
        }
        #endregion

        #region PHANQUYEN
        private string m_PHANQUYEN;
        public string PhanQuyen
        {
            get { return m_PHANQUYEN; }
            set { m_PHANQUYEN = value; }
        }
        #endregion

        #region GHICHU
        private string m_GHICHU;
        public string GhiChu
        {
            get { return m_GHICHU; }
            set { m_GHICHU = value; }
        }
        #endregion
    }
}