<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html  PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN” “http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
      <title>UpdatePanel de AJAX con ADO .NET</title>
         <link href="StyleSheet.css" rel="stylesheet" />
    <script runat="server" id="">
        Private dbStrConn$ = ConfigurationManager.ConnectionStrings("dbBancosKHPConnectionString").ConnectionString
        Private objConn As New Data.SqlClient.SqlConnection(dbStrConn)
        Private cSQL As String
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Not Page.IsPostBack Then
                CargarCombo()
            End If
        End Sub
        Sub CargarCombo()
            Dim dst As New Data.DataSet
            cSQL = "SELECT KHPClienteID, KHPApellidos + SPACE(1) + KHPNombre AS Cliente FROM KHPtbClientes"
            Dim data As New Data.SqlClient.SqlDataAdapter(cSQL, objConn)
            data.Fill(dst, "oTabla")
            With DropDownList1
                'origen de datos el DataSet
                .DataSource = dst.Tables(0).DefaultView
                'El valor de datos para utilizar
                .DataValueField = "KHPClienteID"
                'El valor de datos presentados
                .DataTextField = "Cliente"
                .DataBind()
            End With
        End Sub
        Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
            CargarGridView()
        End Sub
        Sub CargarGridView()
            'Declara un DataAdapter para efectos de conectarse al origen de datos
            'de acuerdo a lo solicitado en cSQL para ejecutar en el origen de datos
            'configurado en objConn
            Dim _clienteID As String = Server.HtmlEncode(DropDownList1.Text)
            Dim ds As New Data.DataSet
            cSQL$ = "Select KHPCuentaID As [No Cuenta], KHPFecha_Apertura AS [Fecha Apertura], " &
            "KHPSaldo As [Saldo]From KHPtbCuentas Where KHPClienteID='" & _clienteID & "'"
            Dim da As New Data.SqlClient.SqlDataAdapter(cSQL, objConn)
            da.Fill(ds, "oTabla")
            GridView1.DataSource = ds.Tables(0).DefaultView
            GridView1.DataBind()
        End Sub
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </div>
        <table class="style3">
            <tr>
                <td rowspan="5">&nbsp;</td>
                <td class="style4">
                    <br />
                    <br />
                </td>
                <td rowspan="5">
                    <br />
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            Seleccione el cliente a consultar:<asp:DropDownList ID="DropDownList1"
                                runat="server" CssClass="style2">
                            </asp:DropDownList>
                            <br />
                            <br />
                            Ultima hora de acceso al servidor:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label runat="server" ID="timerLblUpdate1"> <%=DateTime.Now%> </asp:Label>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <br />
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <br />
                            <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow"
                                BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black"
                                GridLines="None" Width="415px">
                                <FooterStyle BackColor="Tan" />
                                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue"
                                    HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                            </asp:GridView>
                            <br />
                            <br />
                            <br />
                            <asp:Button ID="Button1" runat="server" CssClass="style1"
                                Text="Consultar Cuentas" />
                            <br />
                            Ultima hora de acceso al servidor:&nbsp;
                   <asp:Label runat="server" ID="timerLblUpdate2"> <%=DateTime.Now%> </asp:Label>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
                        </Triggers>
                    </asp:UpdatePanel>

                </td>
                <td rowspan="5">&nbsp;</td>
                <td rowspan="5">&nbsp;</td>
            </tr>
            <tr>
                <td class="style4"></td>
            </tr>
            <tr>
                <td class="style4"></td>
            </tr>
            <tr>
                <td class="style4"></td>
            </tr>
            <tr>
                <td class="style4">&nbsp;</td>
            </tr>
            <tr>
                <td rowspan="2">&nbsp;</td>
                <td class="style4">&nbsp;</td>
                <td rowspan="2">&nbsp;</td>
                <td rowspan="2">&nbsp;</td>
                <td rowspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="style4">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
