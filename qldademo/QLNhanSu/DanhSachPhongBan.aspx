<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DanhSachPhongBan.aspx.cs" Inherits="qldademo.QLNhanSu.DanhSachPhongBan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <table>
            <tr>
                <td>Mã Phòng Ban</td>
                <td>
                    <asp:TextBox runat="server" ID="txtMaPhongBan"></asp:TextBox>
                </td>
                <td>Tên Phòng Ban</td>
                <td>
                    <asp:TextBox runat="server" ID="txtTenPhongBan"></asp:TextBox>
                </td>
                 <td>Số nhân viên</td>
                <td>
                    <asp:TextBox runat="server" ID="TxtSoNhanVien"></asp:TextBox>
                </td>
                 <td>Ghi Chú</td>
                <td>
                    <asp:TextBox runat="server" ID="TxtGhiChu"></asp:TextBox>
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
                    <asp:Button runat="server" ID="btnThemMoi" Text="Thêm Mới" />
                </td>
                <td>
                    <asp:Button runat="server" ID="btnHuy" Text="Hủy" />
                </td>
                <td>
                    <asp:Button runat="server" ID="btnLuu" Text="Lưu Lại" />
                </td>
                <td>
                    <asp:Button runat="server" ID="btnXoa" Text="Xóa" />
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
     <asp:GridView ID="grdViewPhongBan" runat="server" OnSelectedIndexChanged="grdViewPhongBan_SelectedIndexChanged" AutoGenerateSelectButton="True">
         </asp:GridView>
    </div>
</asp:Content>
