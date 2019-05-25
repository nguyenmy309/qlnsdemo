using qldademo.Datalayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TT_GDTX_ANGIANG.BusinessObject;

namespace qldademo.Controller
{
    public class NgachLuongController
    {
        public NgachLuongData data_NgachLuong { get; set; }

        public DataTable tableNgachLuong { get; set; }

        public NgachInfo recordNgachLuong { get; set; }

        public DataTable HienThiDanhSachNgachLuong()
        {
            if (data_NgachLuong == null)
            {
                data_NgachLuong = new NgachLuongData();
            }
            tableNgachLuong = data_NgachLuong.lay_dsNgachLuong();

            return tableNgachLuong;
        }

        public NgachInfo HienThiRecordNgachLuong(string maNgach)
        {
            if (data_NgachLuong == null)
            {
                data_NgachLuong = new NgachLuongData();
            }
            recordNgachLuong = data_NgachLuong.LayRecordHSLuong(maNgach);

            return recordNgachLuong;
        }

        #region tạo mã ngạch mới kế tiếp trong DB theo chuẩn NGxyz
        public string TaoMoiMaNgachLuong()
        {
            string txtMaNN = string.Empty;
            tableNgachLuong = data_NgachLuong.lay_dsNgachLuong();
            bool b = true;
            int i = 0;
            int t = 1;
            if (tableNgachLuong.Rows.Count == 0)
            {
                return txtMaNN = "NG1";                
            }
            while (b)
            {
                string s1 = string.Concat("NG", t.ToString());
                if (tableNgachLuong.Rows[i][0].ToString() == s1)
                {
                    t++;
                    i = 0;
                    continue;
                }
                if (i == (tableNgachLuong.Rows.Count - 1))
                {
                    txtMaNN = s1;
                    b = false;
                }
                i++;
            }
            return txtMaNN;
        }
        #endregion

        #region Add()
        public bool AddNew(NgachInfo info)
        {
            DataRow row = tableNgachLuong.NewRow();
            row["MANGACH"] = info.MaNgach;
            row["TENNGACH"] = info.TenNgach;
            
            tableNgachLuong.Rows.Add(row);
            if (this.data_NgachLuong.Update())
            {
                return true;
            }
            else
            {
                tableNgachLuong.Rows.Remove(row);
                return false;
            }
        }
        #endregion

        #region Update()
        public bool Update(NgachInfo info, int index)
        {
            // this.Table.Rows[index]["MAHV"] = info.MaHocVan;
            this.tableNgachLuong.Rows[index]["TENNGACH"] = info.TenNgach;


            return this.data_NgachLuong.Update();
        }
        #endregion

        #region Delete()
        public bool Delete(int index)
        {

            this.tableNgachLuong.Rows[index].Delete();

            return this.data_NgachLuong.Update();
        }
        #endregion
    }
}