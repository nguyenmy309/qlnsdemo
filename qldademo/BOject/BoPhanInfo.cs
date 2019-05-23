using System;
using System.Collections.Generic;
using System.Text;

namespace qldademo.BOject
{
    public class BoPhanInfo
    {
        #region Ham Tao       
        public BoPhanInfo()
        {
        }

        public BoPhanInfo(String maDV, String tenDV, PhongBanInfo phongBan, String gChu)
        {
            MaBoPhan = maDV;
            TenBoPhan = tenDV;
            TenPhongBan = phongBan;
            GhiChu = gChu;
        }
        public BoPhanInfo(String maDV, String tenDV)
        {
            MaBoPhan = maDV;
            TenBoPhan = tenDV;
        }
        #endregion

        #region MABP
        private string m_MABP;
        public string MaBoPhan
        {
            get { return m_MABP; }
            set { m_MABP = value; }
        }
        #endregion

        #region TENBP
        private String m_TENBP;
        public String TenBoPhan
        {
            get { return m_TENBP; }
            set { m_TENBP = value; }
        }
        #endregion

        //#region PHONGBAN
        //private PhongBanInfo m_PHONGBAN;
        //public PhongBanInfo PhongBan
        //{
        //    get { return m_PHONGBAN; }
        //    set { m_PHONGBAN = value; }
        //}
        //#endregion

        #region TENPHONGBAN
        private PhongBanInfo m_PHONGBAN;
        public PhongBanInfo TenPhongBan
        {
            get { return m_PHONGBAN; }
            set { m_PHONGBAN = value; }
        }
        #endregion

        #region GHICHU
        private String m_GHICHU;
        public String GhiChu
        {
            get { return m_GHICHU; }
            set { m_GHICHU = value; }
        }
        #endregion
    }
}