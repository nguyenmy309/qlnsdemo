using System;
using System.Collections.Generic;
using System.Text;

namespace TT_GDTX_ANGIANG.BusinessObject
{
    public class BacInfo
    {
         #region Constructor
        public BacInfo()
        {
        }


        public BacInfo(String maBac, String bac)
        {
            MaBac = maBac;
            TenBac = bac;

        }

        
        #endregion

        #region MABAC
        private String m_MABAC;
        public String MaBac
        {
            get { return m_MABAC; }
            set { m_MABAC = value; }
        }
        #endregion

        #region BAC
        private String m_BAC;
        public String TenBac
        {
            get { return m_BAC; }
            set { m_BAC = value; }
        }
        #endregion

        
    }
}
