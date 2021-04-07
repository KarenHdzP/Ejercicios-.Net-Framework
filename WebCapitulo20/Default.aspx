<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Página sin título</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
                        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div>
                    <span id="filter">
                        <br />
                        <br />
                        Seleccione el filtrado de datos:
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true">
                        <asp:ListItem Text="No Atendidos" Value="False" />
                        <asp:ListItem Text="Atendidos" Value="True" />
                    </asp:DropDownList>
                        <br />
                        <br />
                        <asp:ListView ID="ListView1" runat="server" DataKeyNames="ExpedienteID" DataSourceID="LinqDataSource1" InsertItemPosition="LastItem">
                            <AlternatingItemTemplate>
                                <tr style="background-color: #FAFAD2;color: #284775;">
                                    <td>
                                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Eliminar" />
                                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Editar" />
                                    </td>
                                    <td>
                                        <asp:Label ID="ExpedienteIDLabel" runat="server" Text='<%# Eval("ExpedienteID") %>' />
                                    </td>
                                    <td>
                                        <asp:Label ID="ApellidosLabel" runat="server" Text='<%# Eval("Apellidos") %>' />
                                    </td>
                                    <td>
                                        <asp:Label ID="NombreLabel" runat="server" Text='<%# Eval("Nombre") %>' />
                                    </td>
                                    <td>
                                        <asp:Label ID="ProvinciaLabel" runat="server" Text='<%# Eval("Provincia") %>' />
                                    </td>
                                    <td>
                                        <asp:CheckBox ID="AtendidoCheckBox" runat="server" Checked='<%# Eval("Atendido") %>' Enabled="false" />
                                    </td>
                                </tr>
                            </AlternatingItemTemplate>
                            <EditItemTemplate>
                                <tr style="background-color: #FFCC66;color: #000080;">
                                    <td>
                                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Actualizar" />
                                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" />
                                    </td>
                                    <td>
                                        <asp:Label ID="ExpedienteIDLabel1" runat="server" Text='<%# Eval("ExpedienteID") %>' />
                                    </td>
                                    <td>
                                        <asp:TextBox ID="ApellidosTextBox" runat="server" Text='<%# Bind("Apellidos") %>' />
                                    </td>
                                    <td>
                                        <asp:TextBox ID="NombreTextBox" runat="server" Text='<%# Bind("Nombre") %>' />
                                    </td>
                                    <td>
                                        <asp:TextBox ID="ProvinciaTextBox" runat="server" Text='<%# Bind("Provincia") %>' />
                                    </td>
                                    <td>
                                        <asp:CheckBox ID="AtendidoCheckBox" runat="server" Checked='<%# Bind("Atendido") %>' />
                                    </td>
                                </tr>
                            </EditItemTemplate>
                            <EmptyDataTemplate>
                                <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                                    <tr>
                                        <td>No se han devuelto datos.</td>
                                    </tr>
                                </table>
                            </EmptyDataTemplate>
                            <InsertItemTemplate>
                                <tr style="">
                                    <td>
                                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" />
                                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Borrar" />
                                    </td>
                                    <td>&nbsp;</td>
                                    <td>
                                        <asp:TextBox ID="ApellidosTextBox" runat="server" Text='<%# Bind("Apellidos") %>' />
                                    </td>
                                    <td>
                                        <asp:TextBox ID="NombreTextBox" runat="server" Text='<%# Bind("Nombre") %>' />
                                    </td>
                                    <td>
                                        <asp:TextBox ID="ProvinciaTextBox" runat="server" Text='<%# Bind("Provincia") %>' />
                                    </td>
                                    <td>
                                        <asp:CheckBox ID="AtendidoCheckBox" runat="server" Checked='<%# Bind("Atendido") %>' />
                                    </td>
                                </tr>
                            </InsertItemTemplate>
                            <ItemTemplate>
                                <tr style="background-color: #FFFBD6;color: #333333;">
                                    <td>
                                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Eliminar" />
                                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Editar" />
                                    </td>
                                    <td>
                                        <asp:Label ID="ExpedienteIDLabel" runat="server" Text='<%# Eval("ExpedienteID") %>' />
                                    </td>
                                    <td>
                                        <asp:Label ID="ApellidosLabel" runat="server" Text='<%# Eval("Apellidos") %>' />
                                    </td>
                                    <td>
                                        <asp:Label ID="NombreLabel" runat="server" Text='<%# Eval("Nombre") %>' />
                                    </td>
                                    <td>
                                        <asp:Label ID="ProvinciaLabel" runat="server" Text='<%# Eval("Provincia") %>' />
                                    </td>
                                    <td>
                                        <asp:CheckBox ID="AtendidoCheckBox" runat="server" Checked='<%# Eval("Atendido") %>' Enabled="false" />
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <LayoutTemplate>
                                <table runat="server">
                                    <tr runat="server">
                                        <td runat="server">
                                            <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                                <tr runat="server" style="background-color: #FFFBD6;color: #333333;">
                                                    <th runat="server"></th>
                                                    <th runat="server">ExpedienteID</th>
                                                    <th runat="server">Apellidos</th>
                                                    <th runat="server">Nombre</th>
                                                    <th runat="server">Provincia</th>
                                                    <th runat="server">Atendido</th>
                                                </tr>
                                                <tr id="itemPlaceholder" runat="server">
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr runat="server">
                                        <td runat="server" style="text-align: center;background-color: #FFCC66;font-family: Verdana, Arial, Helvetica, sans-serif;color: #333333;">
                                            <asp:DataPager ID="DataPager1" runat="server">
                                                <Fields>
                                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                                                </Fields>
                                            </asp:DataPager>
                                        </td>
                                    </tr>
                                </table>
                            </LayoutTemplate>
                            <SelectedItemTemplate>
                                <tr style="background-color: #FFCC66;font-weight: bold;color: #000080;">
                                    <td>
                                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Eliminar" />
                                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Editar" />
                                    </td>
                                    <td>
                                        <asp:Label ID="ExpedienteIDLabel" runat="server" Text='<%# Eval("ExpedienteID") %>' />
                                    </td>
                                    <td>
                                        <asp:Label ID="ApellidosLabel" runat="server" Text='<%# Eval("Apellidos") %>' />
                                    </td>
                                    <td>
                                        <asp:Label ID="NombreLabel" runat="server" Text='<%# Eval("Nombre") %>' />
                                    </td>
                                    <td>
                                        <asp:Label ID="ProvinciaLabel" runat="server" Text='<%# Eval("Provincia") %>' />
                                    </td>
                                    <td>
                                        <asp:CheckBox ID="AtendidoCheckBox" runat="server" Checked='<%# Eval("Atendido") %>' Enabled="false" />
                                    </td>
                                </tr>
                            </SelectedItemTemplate>
                    </asp:ListView>
                    </span>
                    <br />
                    <br />
                    <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
                        ContextTypeName="ExpedientesDataContext" 
                        EnableDelete="True" 
                        EnableInsert="True" 
                        EnableUpdate="True" 
                        EntityTypeName="" 
                        TableName="tbExpediente"
                        AutoGenerateWhereClause="True">
                        <WhereParameters>
                            <asp:ControlParameter
                                Name="Atendido"
                                ControlID="DropDownList1"
                                Type="Boolean" />
                        </WhereParameters>
                    </asp:LinqDataSource>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
