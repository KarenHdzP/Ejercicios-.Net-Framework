
Partial Class WebInicio
    Inherits System.Web.UI.Page

    'Instanciamos el servicio Web wsDatos para utilizar sus métodos Web
    Dim aux As New Service
    Sub Habilitar(ByVal Valor%)
        'Creamos una variable de tipo menú y con FindControl lo ubicamos en el objeto Master
        Dim menuPrin As Menu = CType(Master.FindControl("Menu1"), Menu)
        'Hacemos que el menú no se vea si la sesión no es válida
        If Valor = 1 Then
            menuPrin.Visible = False
        Else
            menuPrin.Visible = True
        End If
    End Sub
    Protected Sub Page_LoadComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadComplete

        Habilitar(1)
    End Sub


    Protected Sub Login1_Authenticate(sender As Object, e As AuthenticateEventArgs) Handles Login1.Authenticate
        'Creamos un nuevo DataSet
        Dim dstClientes As New Data.DataSet

        MsgBox("1:" + Login1.UserName)
        MsgBox("c:" + Login1.Password)
        'Hacemos un llamado al método Web ValidaUsuario
        aux.ValidaUsuario(Login1.UserName, Login1.Password, dstClientes)
        'Si al menos tenemos un registro
        If dstClientes.Tables(0).Rows.Count > 0 Then
            Habilitar(2)
            'Cargamos variables de sesión, las fi las de ClienteID, Nombre y Apellidos
            Session("IDCliente") = dstClientes.Tables(0).Rows(0).Item(0)
            Session("Usuario") = dstClientes.Tables(0).Rows(0).Item(2) & Space(1) & dstClientes.Tables(0).Rows(0).Item(1)
            'Redireccionamos a webPrincipal si la sessión es válida
            Response.Redirect("webPrincipal.aspx")
        Else
            'Desplegamos un mensaje si la sesión no es válida
            Response.Write("<script>alert('Nombre de Usuario o Contraseña no existe!')</script>")
        End If
    End Sub
End Class
