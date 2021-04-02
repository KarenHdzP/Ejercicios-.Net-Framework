Partial Class webConsultaCuenta
    Inherits System.Web.UI.Page

    Dim aux As New Service
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Visualiza el nombre completo del usuario en el título de la página.
        Page.Title = "Consulta de Movimientos de una Cuenta de " & Session("Usuario")
        'Carga en las etiquetas correspondientes los valores cargados en las sesiones
        lblNumeroCuenta.Text = Session("NumeroCuenta")
        lblFechaApertura.Text = Session("FechaCuenta")
        lblSaldoActual.Text = Session("MontoCuenta")
    End Sub
    Protected Sub btnConsultar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        CargarMovCuentas() 'Se llama al procedimiento CargarMovCuentas
    End Sub
    Sub CargarMovCuentas()
        Try
            'Asignamos los valores de los componentes Calendar
            'a dos variables de tipo fecha (date)
            Dim Fecha1 As Date = Calendar1.SelectedDate.Date
            Dim Fecha2 As Date = Calendar2.SelectedDate.Date
            'Creamos la sentencia SQL para efectuar la consulta de todas cuentas que pertenecen al cliente actual.
            Dim sql = "SELECT KHPtbMovimientos.KHPOperacionID As [Operacion No], KHPtbClaseMovimientos.KHPDescripcion As [Descripcion]," &
                     "KHPtbMovimientos.KHPCuentaID As [Cuenta No.]," &
                     "KHPtbMovimientos.KHPFecha_Movimiento As [Fecha Movimiento], " &
                     "KHPtbMovimientos.KHPMonto_Movimiento As [Monto Movimiento]," &
                     "KHPtbMovimientos.KHPDetalle_Movimiento As [Detalle Movimiento] " &
                     " FROM KHPtbClaseMovimientos INNER JOIN KHPtbMovimientos ON " &
                     "KHPtbClaseMovimientos.KHPClaseMovID = KHPtbMovimientos.KHPClaseMovID " &
                     " Where (KHPtbMovimientos.KHPCuentaID='" & Session("NumeroCuenta") & "') AND " &
                     "(KHPtbMovimientos.KHPFecha_Movimiento >= CONVERT(DATETIME,'" & Fecha1.Year &
                     "-" & Fecha1.Month & "-" & Fecha1.Day & " 00:00:00'" & ",102))" & " And " &
                     "(KHPtbMovimientos.KHPFecha_Movimiento <=" &
                     "CONVERT(DATETIME,'" & Fecha2.Year & "-" & Fecha2.Month & "-" & Fecha2.Day &
                     " 00:00:00'" & ",102))"
            'Declaramos un DataSet para cargar en él los datos que se generan en la consulta.
            Dim dsMovCuentas As New Data.DataSet
            'Invocamos el método ObtenerDatos de la instancia del servicio Web, cuyos parámetros son la cadena
            'SQL y el DataSet vacío
            aux.ObtenerDatos(sql, dsMovCuentas)
            'Cargamos los datos del DataSet en el GridView
            GridView1.DataSource = dsMovCuentas.Tables(0).DefaultView
            GridView1.DataBind()
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
End Class
