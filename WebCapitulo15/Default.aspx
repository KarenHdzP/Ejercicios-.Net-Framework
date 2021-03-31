<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            text-align: right;
            border-style: solid;
            border-width: 2px;
            padding: 1px 4px;
            width: 827px;
        }
        .auto-style4 {
            border-style: solid;
            border-width: 2px;
            padding: 1px 4px;
            text-align: right;
            height: 26px;
            width: 827px;
        }
        .auto-style5 {
            border-style: solid;
            border-width: 2px;
            padding: 1px 4px;
            height: 26px;
            width: 1269px;
        }
        .auto-style6 {
            width: 35px;
        }
        .auto-style7 {
            height: 26px;
            width: 35px;
        }
        .auto-style12 {
            text-align: right;
        }
        .auto-style13 {
            margin-left: 17px;
        }
        .auto-style15 {
            text-align: right;
            width: 827px;
            border-style: solid;
            border-width: 2px;
        }
        .auto-style17 {
            border-style: solid;
            border-width: 2px;
            padding: 1px 4px;
            width: 1269px;
        }
        .auto-style18 {
            text-align: right;
            height: 26px;
            width: 266px;
        }
        .auto-style19 {
            text-align: right;
            width: 266px;
        }
        .auto-style21 {
            border-style: solid;
            border-width: 1px;
            padding: 1px 4px;
        }
        .auto-style22 {
            width: 266px;
        }
        .auto-style23 {
            border-style: none;
            padding: 1px;
        }
        .auto-style24 {
            text-align: right;
            padding: 1px 4px;
            width: 827px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1" style="margin-right">
            <tr>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style3">Cuenta Cliente:</td>
                <td class="auto-style17">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            </tr>
            <tr>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style3">&nbsp; Nombre Cliente:</td>
                <td class="auto-style17">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style15">Dirección Cliente:</td>
                <td class="auto-style17">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style4">Teléfono Cliente:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style12" colspan="2">
                    <asp:Button ID="btnIncluirTabla" runat="server" Height="30px" Text="Incluir Tabla" Width="126px" />
                </td>
                <td colspan="2">
                    <asp:Button ID="btnGenerarXML" runat="server" Height="30px" Text="Generar XML" Width="98px" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnCargarXML" runat="server" Height="30px" Text="Cargar XML" Width="110px" />
&nbsp;&nbsp;
                    <asp:Button ID="btnDesplegarXML" runat="server" Height="31px" Text="Desplegar XML" Width="103px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style24"><span class="auto-style23">&nbsp;&nbsp;&nbsp;&nbsp;

                    </span>

                    <asp:Table ID="Table1" runat="server" Height="152px" CssClass="auto-style21" 
                        GridLines="Horizontal" Width="700px">
                    </asp:Table>

                </td>
                <td colspan="2">
                    <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None"
                         BorderWidth="1px" CellPadding="3" CssClass="auto-style13" GridLines="Vertical" Width="525px">
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#0000A9" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#000065" />
                    </asp:GridView>
                </td>
            </tr>
            </table>
    
    </div>
    </form>
</body>
</html>
