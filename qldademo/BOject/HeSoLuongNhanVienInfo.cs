using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TT_GDTX_ANGIANG.BusinessObject;

namespace qldademo.BOject
{
    public class HeSoLuongNhanVienInfo
    {
        #region Constructor
        public HeSoLuongNhanVienInfo()
        {
        }

        public HeSoLuongNhanVienInfo(string maHSLuong, NgachInfo ngach, BacInfo bac, float heSoLuong)
        {
            MaHeSoLuong = maHSLuong;
            TenNgach = ngach;
            TenBac = bac;
            HeSoLuong = heSoLuong;

        }

        //public HeSoLuongNhanVienInfo(string maPC, string tenPC)
        //{
        //    MaPhuCap = maPC;
        //    TenPhuCap = tenPC;
        //}
        #endregion

        #region MAHESOLUONG
        private string m_MAHESOLUONG;
        public string MaHeSoLuong
        {
            get { return m_MAHESOLUONG; }
            set { m_MAHESOLUONG = value; }
        }
        #endregion

        #region TENNGACH
        private NgachInfo m_TENNGACH;
        public NgachInfo TenNgach
        {
            get { return m_TENNGACH; }
            set { m_TENNGACH = value; }
        }
        #endregion

        #region TENBAC
        private BacInfo m_TENBAC;
        public BacInfo TenBac
        {
            get { return m_TENBAC; }
            set { m_TENBAC = value; }
        }
        #endregion

        #region HESOLUONG
        private float m_HESOLUONG;
        public float HeSoLuong
        {
            get { return m_HESOLUONG; }
            set { m_HESOLUONG = value; }
        }
        #endregion
    }
}