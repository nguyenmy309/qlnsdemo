using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class NgachInfo
    {
        #region Ham Tao       
        public NgachInfo()
        {
        }

        public NgachInfo(String maNgach, String tenNgach)
        {
            MaNgach = maNgach;
            TenNgach = tenNgach;
           
        }

       
        #endregion

        #region MANGACH
        private String m_MANGACH;
        public String MaNgach
        {
            get { return m_MANGACH; }
            set { m_MANGACH = value; }
        }
        #endregion

        #region TENNGACH
        private String m_TENNGACH;
        public String TenNgach
        {
            get { return m_TENNGACH; }
            set { m_TENNGACH = value; }
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
