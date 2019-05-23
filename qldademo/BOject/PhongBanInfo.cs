using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace qldademo.BOject
{
    public class PhongBanInfo
    {
        #region Constructor
        public PhongBanInfo()
        {
        }

        public PhongBanInfo(string maPH, String tenPH, int soNV, string gChu)
        {
            MaPhong = maPH;
            TenPhong = tenPH;
            SoNhanVien = soNV;
            GhiChu = gChu;
        }

        public PhongBanInfo(string maPH, String tenPH)
        {
            MaPhong = maPH;
            TenPhong = tenPH;
        }
        #endregion

        #region MAPH
        private string m_MAPH;
        public string MaPhong
        {
            get { return m_MAPH; }
            set { m_MAPH = value; }
        }
        #endregion

        #region TENPH
        private String m_TENPH;
        public String TenPhong
        {
            get { return m_TENPH; }
            set { m_TENPH = value; }
        }
        #endregion

        #region SONHANVIEN
        private int m_SONHANVIEN;
        public int SoNhanVien
        {
            get { return m_SONHANVIEN; }
            set { m_SONHANVIEN = value; }
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