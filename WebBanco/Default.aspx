<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Etiqueta 1:" CssClass="formatoEtiqueta"></asp:Label>

   
    <asp:TextBox ID="TextBox1" runat="server" CssClass="formatoCajaTexto"></asp:TextBox>

   
    <br />
     <asp:Label ID="Label2" runat="server" Text="Etiqueta 2:" CssClass="formatoEtiqueta"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server" CssClass="formatoCajaTexto"></asp:TextBox>
    <br />
     <asp:Label ID="Label3" runat="server" Text="Etiqueta 3:" CssClass="formatoEtiqueta"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server" CssClass="formatoCajaTexto"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Agregar" CssClass="formatoBoton" />
     <asp:Button ID="Button2" runat="server" Text="Modificar" CssClass="formatoBoton" />
     <asp:Button ID="Button3" runat="server" Text="Eliminar" CssClass="formatoBoton" />
</asp:Content>

