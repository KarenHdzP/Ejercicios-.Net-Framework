Partial Class _Default
    Inherits System.Web.UI.Page

    Private dbContexto As New dbBancosDataContextDataContext
    Sub LimpiarCajasTexto()
        Apellidos.Text = ""
        Nombre.Text = ""
        Direccion.Text = ""
        Telefono.Text = ""
        Apellidos.Focus()
    End Sub
    Sub HabilitarNuevo()
        btnAgregar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        LimpiarCajasTexto()
    End Sub
    Sub HabilitarExistente()
        btnAgregar.Enabled = False
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
    End Sub
    Sub DesHabilitarBotones()
        btnAgregar.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        LimpiarCajasTexto()
    End Sub
    Protected Sub btnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim Clientes = New tbClientes
        Clientes.ClienteID = ClienteID.Text
        Clientes.Apellidos = Apellidos.Text
        Clientes.Nombre = Nombre.Text
        Clientes.Direccion = Direccion.Text
        Clientes.Telefono = Telefono.Text
        dbContexto.tbClientes.InsertOnSubmit(Clientes)
        dbContexto.SubmitChanges()
        DesHabilitarBotones()
    End Sub
    Protected Sub btnConsultar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Try
            Dim BuscaCliente = (From Clientes In dbContexto.tbClientes
                                Where Clientes.ClienteID = ClienteID.Text).ToList()(0)
            'Carga los TextBox respectivos en caso de que haya una vinculación objetos 
            'del modelo ‘con datos de la base de datos con la que se vincula
            Apellidos.Text = BuscaCliente.Apellidos
            Nombre.Text = BuscaCliente.Nombre
            Direccion.Text = BuscaCliente.Direccion
            Telefono.Text = BuscaCliente.Telefono
            HabilitarExistente()
        Catch ex As Exception
            Response.Write("<script>alert('Número de cliente No encontrado!')</script>")
            'Permite que se hagan los cambios en el contexto de conexión
            HabilitarNuevo()
        End Try
    End Sub
    Protected Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminaCliente = (From clientes In dbContexto.tbClientes Where clientes.ClienteID = ClienteID.Text).ToList()(0)
        'se elimina el registro del contexto y de su referencia en la base de datos relacional
        dbContexto.tbClientes.DeleteOnSubmit(eliminaCliente)
        dbContexto.SubmitChanges()
        DesHabilitarBotones()
    End Sub
    Protected Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim modificaCliente = (From _clientes In dbContexto.tbClientes Where _clientes.ClienteID = ClienteID.Text Select _clientes).Single
        'se modifica el cliente en el contexto de datos y en su referencia de la base de datos relacional.
        modificaCliente.Apellidos = Apellidos.Text
        modificaCliente.Nombre = Nombre.Text
        modificaCliente.Direccion = Direccion.Text
        modificaCliente.Telefono = Telefono.Text
        dbContexto.SubmitChanges()
        DesHabilitarBotones()
    End Sub

End Class
