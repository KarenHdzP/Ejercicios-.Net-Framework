<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        ClienteID:
        <asp:TextBox ID="ClienteID" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" Width="99px" />
        <br />
        <br />
        Apellidos:
        <asp:TextBox ID="Apellidos" runat="server" Height="16px" Width="388px"></asp:TextBox>
        <br />
        <br />
        Nombre:&nbsp;&nbsp;
        <asp:TextBox ID="Nombre" runat="server" Height="16px" Width="388px"></asp:TextBox>
        <br />
        <br />
        Direccion:
        <asp:TextBox ID="Direccion" runat="server" Height="69px" Width="383px"></asp:TextBox>
        <br />
        <br />
        Telefono:
        <asp:TextBox ID="Telefono" runat="server" Width="226px"></asp:TextBox>
        <br />
        <br />
&nbsp;<asp:Button ID="btnAgregar" runat="server" Text="Agregar" Width="104px" Enabled="False" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnModificar" runat="server" Text="Modificar" Width="94px" Enabled="False"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" Width="95px" Enabled="False"/>
        <br />
    
    </div>
    </form>
</body>
</html>
