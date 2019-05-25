<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DanhSachNgachLuong.aspx.cs" Inherits="qldademo.QLNhanSu.DanhSachNgachLuong" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div>
        <table>
            <tr>
                <td>Mã ngạch lương</td>
                <td>
                    <asp:TextBox runat="server" ID="txtMaNgachLuong"></asp:TextBox>
                </td>
                <td>Tên ngạch</td>
                <td>
                    <asp:TextBox runat="server" ID="txtTenNgach"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtIsAddNew" Visible="false"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button runat="server" ID="btnThemMoi" Text="Thêm Mới" OnClick="btnThemMoi_Click"/>
                </td>
                <td>
                    <asp:Button runat="server" ID="btnHuy" Text="Hủy" OnClick="btnHuy_Click"/>
                </td>
                <td>
                    <asp:Button runat="server" ID="btnLuu" Text="Lưu Lại" OnClick="btnLuu_Click"/>
                </td>
                <td>
                    <asp:Button runat="server" ID="btnXoa" Text="Xóa" OnClick="btnXoa_Click"/>
                </td>
                
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="lblThongBao" Text=""></asp:Label>
                </td>
            </tr>
                
        </table>

    </div>
        <div>
            &nbsp;<br />
        </div>
        Danh sách ngạch lương
        <div>
            <asp:GridView runat="server" ID="grdNgachLuong" AutoGenerateSelectButton="True"
                OnSelectedIndexChanged="grdNgachLuong_SelectedIndexChanged" >

            </asp:GridView>
            
        </div>
    <div>
    </div>
</asp:Content>
