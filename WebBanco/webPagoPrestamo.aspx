<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="webPagoPrestamo.aspx.vb" Inherits="webPagoPrestamo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style18 {
            width: 169%;
        height: 378px;
    }
        .auto-style27 {
            height: 26px;
            width: 10px;
        }
        .auto-style28 {
            width: 10px;
        }
        .auto-style31 {
            height: 26px;
            width: 28px;
        }
        .auto-style32 {
            width: 28px;
        }
        .auto-style33 {
            width: 4px;
        }
        .auto-style34 {
            width: 4px;
            height: 26px;
        }
        .auto-style35 {
            width: 125px;
        }
        .auto-style36 {
            width: 125px;
            height: 26px;
        }
        .auto-style37 {
            width: 10px;
            height: 34px;
        }
        .auto-style38 {
            width: 125px;
            height: 34px;
        }
        .auto-style39 {
            width: 4px;
            height: 34px;
        }
        .auto-style40 {
            width: 28px;
            height: 34px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style18">
        <tr>
            <td class="auto-style37"></td>
            <td class="auto-style38">
                Número de Cliente:</td>
            <td class="auto-style39">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style40"></td>
        </tr>
        <tr>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style35">
                Nombre del Cliente</td>
            <td class="auto-style33">
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style32">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style35">
                Número Operación:</td>
            <td class="auto-style33">
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style32">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style27"></td>
            <td class="auto-style36">Clase Movimiento:</td>
            <td class="auto-style34">
                <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="Clase Movimiento:">
                </asp:DropDownList>
            </td>
            <td class="auto-style31"></td>
        </tr>
        <tr>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style35">
                Tipo Moviento:</td>
            <td class="auto-style33">&nbsp;</td>
            <td class="auto-style32">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style35">Cuentas del Ciente:</td>
            <td class="auto-style33">&nbsp;</td>
            <td class="auto-style32">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style35">Monto a Pagar:</td>
            <td class="auto-style33">&nbsp;</td>
            <td class="auto-style32">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style35">Detalle de Movimiento:</td>
            <td class="auto-style33">&nbsp;</td>
            <td class="auto-style32">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style35">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td class="auto-style32">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style35">&nbsp;</td>
            <td class="auto-style33">
                <asp:Button ID="Button1" runat="server" Text="Button" Width="130px" />
            </td>
            <td class="auto-style32">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

