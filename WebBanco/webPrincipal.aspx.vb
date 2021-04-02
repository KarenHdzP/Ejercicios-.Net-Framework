
Partial Class webPrincipal
    Inherits System.Web.UI.Page

    'Instanciamos el servicio Web wsDatos para utilizar sus métodos Web
    Dim aux As New Service
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Date.Now.Hour > 12 Then
            Page.Title = "Buenas Tardes " & Session("Usuario")
            'Muestra en el formulario el título respectivo.
        Else
            Page.Title = "Buenos días " & Session("Usuario")
        End If
        CargarCuentasCliente()
        CargarDeudasCliente()
    End Sub
    Sub CargarDeudasCliente()
        Try
            Dim dsPrestamos As New Data.DataSet
            aux.ObtenerDatos("Select KHPOperacionID As [Numero Prestamo], KHPFecha_Operacion As [Fecha Operacion], " & "KHPMonto_Operacion As [Saldo] From KHPtbOperaciones Where KHPClienteID='" & Session("IDCliente") & "'", dsPrestamos)
            GridView2.DataSource = dsPrestamos.Tables(0).DefaultView
            GridView2.DataBind()
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Sub CargarCuentasCliente()
        Try
            'Se declara un objeto DataSet
            Dim dsCuentas As New Data.DataSet
            'Se invoca al método ObtenerDatos que pertenece al WebService instanciado en aux.
            'se le pasa por parámetro la cadena SQL que espera y el dataset donde devolverá los datos
            aux.ObtenerDatos("SELECT KHPCuentaID As [Numero Cuenta], KHPFecha_Apertura As [Fecha Apertura], " & "KHPSaldo As [Disponible] FROM KHPtbCuentas WHERE KHPClienteID='" & Session("IDCliente") & "'", dsCuentas)
            'Se carga el GridView con la tabla de datos que se devuelve a través del dataset.
            GridView1.DataSource = dsCuentas.Tables(0).DefaultView
            GridView1.DataBind()
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Protected Sub GridView1_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Unload
        'Si se descarga el GridView procedemos a
        'deshabilitar el botón consultar
        btnConsultarCta.Enabled = False
    End Sub
    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        'Si se selecciona una fi la en el GridView procedemos a habilitar el botón consultar
        btnConsultarCta.Enabled = True
    End Sub
    Protected Sub btnConsultarCta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConsultarCta.Click
        Try
            'Declara una fi la de tipo GridViewRow para tener acceso a una fi la de un Gridview
            Dim Fila As GridViewRow = GridView1.SelectedRow
            'Declara las sesiones necesarias para guardar los datos de las columnas
            'seleccionadas en el GridView
            Session("NumeroCuenta") = Fila.Cells(1).Text 'Texto de la celda en la columna 1.
            Session("FechaCuenta") = Fila.Cells(2).Text 'Texto de la celda en la columna 2.
            Session("MontoCuenta") = Fila.Cells(3).Text 'Texto de la celda en la columna 3.
            'Redirige al formulario Web webConsulta.aspx
            Response.Redirect("webConsultaCuenta.aspx")
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Protected Sub btnPagarPrestamo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPagarPrestamo.Click
        Try
            'Declara una fi la de tipo GridViewRow para tener acceso a una fi la de un Gridview
            Dim Fila As GridViewRow = GridView2.SelectedRow
            'Declara las sesiones necesarias para guardar los datos de las columnas
            'seleccionadas en el GridView
            Session("NumeroCuenta") = Fila.Cells(1).Text
            Session("FechaCuenta") = Fila.Cells(2).Text
            Session("MontoCuenta") = Fila.Cells(3).Text
            'Redirige al formulario webPagoPrestamo.aspx
            Response.Redirect("webPagoPrestamo.aspx")
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Protected Sub GridView2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView2.SelectedIndexChanged
        btnPagarPrestamo.Enabled = True
    End Sub


End Class
