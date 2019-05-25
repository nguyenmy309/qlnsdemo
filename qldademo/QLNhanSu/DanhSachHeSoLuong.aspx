<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DanhSachHeSoLuong.aspx.cs" Inherits="qldademo.QLNhanSu.DanhSachHeSoLuong" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>Mã hệ số lương</td>
                <td>
                    <asp:TextBox runat="server" ID="txtMaHeSoLuong"></asp:TextBox>
                </td>
                <td>Tên ngạch</td>
                <td>
                    <asp:TextBox runat="server" ID="txtTenNgach"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td>Tên bậc</td>
                <td>
                    <asp:TextBox runat="server" ID="txtTenBac"></asp:TextBox>
                </td>
                <td>Hệ số lương</td>
                <td>
                    <asp:TextBox runat="server" ID="txtHeSoLuong"></asp:TextBox>
                </td>
            </tr>
        </table>

    </div>
        <div>
            &nbsp;<br />
        </div>
        <div>
            <asp:GridView runat="server" ID="grdHeSoLuong" OnSelectedIndexChanged="grdHeSoLuong_SelectedIndexChanged" OnSelectedIndexChanging="grdHeSoLuong_SelectedIndexChanging">

            </asp:GridView>
            
        </div>
    </form>
</body>
</html>
