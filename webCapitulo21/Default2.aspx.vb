
Partial Class Default2
    Inherits System.Web.UI.Page
    Private dbContexto As New dbBancosDataContextDataContext

    Sub MostrarCuentas()
        'se crea una variable BuscaCuentas que carga la consulta
        'LINQ desde el contexto tbCuentas
        'fi ltrada por el campo ClienteID sea igual a lo digitado por
        'el usuario en TextBox1.Text
        'Luego se redefi ne la consulta LINQ mediante Select New
        'y se agregan los campos personalizados de la consulta.
        Dim Buscacuentas = From Cuentas In dbContexto.tbCuentas
                           Where Cuentas.ClienteID = TextBox1.Text
                           Order By Cuentas.Fecha_Apertura Descending
                           Select New _
                           With {Cuentas.CuentaID,
                           Cuentas.Fecha_Apertura,
                           Cuentas.Sueldo}
        'Si se encontraron registros en tbCuentas se muestran
        If Buscacuentas.Count > 0 Then
            GridView1.DataSource = Buscacuentas
            GridView1.DataBind()
        Else
            'De lo contrario se muestra el cliente pero no las cuentas que no tiene.
            Response.Write("<script>alert('Cliente Existe, pero no tiene cuentas abiertas!')</script>")
            GridView1.DataSource = Nothing
            GridView1.DataBind()
        End If
    End Sub
    Protected Sub btnConsultar_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles btnConsultar.Click
        Try
            Dim BuscaCliente = (From Clientes In dbContexto.tbClientes
                                Where Clientes.ClienteID = TextBox1.Text).ToList()(0)
            'Carga los TextBox respectivos en caso de que haya una vinculación objetos del modelo
            'con datos de la base de datos con la que se vincula
            Label3.Text = BuscaCliente.Nombre & Space(1) & BuscaCliente.Apellidos
            MostrarCuentas()
        Catch ex As Exception
            Response.Write("<script>alert('Número de cliente No encontrado!')</script>")
        End Try
    End Sub


End Class
