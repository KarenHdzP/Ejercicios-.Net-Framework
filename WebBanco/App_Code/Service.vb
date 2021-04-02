Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Public Class Service
    Inherits System.Web.Services.WebService
    'ConfigurationManager podemos obtener la cadena de conexión
    'dbConnBancoKHP que se configuró en el archivo Web.config
    Dim strConn$ = ConfigurationManager.ConnectionStrings("dbBancoKHP").ConnectionString
    Public objConn As New Data.SqlClient.SqlConnection(strConn)
    <WebMethod()>
    Public Function HelloWorld() As String
        Return "Hola a todos"
    End Function
    'nuevo
    <WebMethod()>
    Public Function Sumar(ByVal numero1%, ByVal numero2%) As Integer
        Return (numero1 + numero2) * 10
    End Function
    <WebMethod()>
    Sub ConnTest()
        'administrar debajo
        'objConn.Open()
        MsgBox("State >" & objConn.State & "<")
        If (objConn.State = Data.ConnectionState.Closed) Then
            objConn.Open()
            MsgBox("La BD cerrada ahora esta abierta state >" & objConn.State & "<")
            If (objConn.State = Data.ConnectionState.Open) Then
                objConn.Close()
                MsgBox("La BD abierta ahora esta cerrada")
            End If
        ElseIf (objConn.State = Data.ConnectionState.Open) Then
            objConn.Close()
            MsgBox("La BD abierta ahora esta cerrada")
        End If
        MsgBox("state >" & objConn.State & "<")
    End Sub
    <WebMethod()>
    Public Sub ValidaUsuario(ByVal argUsuario$, ByVal argClave$, ByRef dst As Data.DataSet)
        'Comprueba datos de entrada y estado de la conexion
        MsgBox("1:" & argUsuario$ & vbCrLf & "2:" & argClave$ & vbCrLf & "dB Conn state >" & objConn.State & "<")

        'Establecemos un objeto DataAdapter que nos conectará con la fuente de datos
        Dim dataAdapt As New Data.SqlClient.SqlDataAdapter

        'Establecemos un objeto command
        Dim cmdParametrizado As Data.SqlClient.SqlCommand
        'Declaramos variables de tipo parámetro que utilizaremos para enviar parámetros 
        'al procedimiento almacenado ValidarUsuario que guardamos en la base de datos
        Dim prmUsuario As Data.SqlClient.SqlParameter
        Dim prmClave As Data.SqlClient.SqlParameter

        'Invocamos el procedimiento almacenado y lo vinculamos al objeto command
        cmdParametrizado = New Data.SqlClient.SqlCommand("ValidarUsuario", objConn)
        'Le indicamos al objeto que su tipo es procedimiento almacenado
        cmdParametrizado.CommandType = Data.CommandType.StoredProcedure
        'Agregamos al comand el parámetro prmUsuario
        prmUsuario = cmdParametrizado.Parameters.Add("@prmClienteID", Data.SqlDbType.Char)
        'Confi guramos que el parámetro sea de tipo entrada
        prmUsuario.Direction = Data.ParameterDirection.Input
        'Le asignamos al parámetro el valor pasado a través de argUsuario
        prmUsuario.Value = argUsuario
        prmClave = cmdParametrizado.Parameters.Add("@prmPassword", Data.SqlDbType.Char)
        prmClave.Direction = Data.ParameterDirection.Input
        prmClave.Value = argClave
        'Conectamos el adaptador de datos a la fuente de datos mediante el command
        dataAdapt = New Data.SqlClient.SqlDataAdapter(cmdParametrizado)
        'Llenamos con datos o no el DataSet que vincula el DataAdapter
        dataAdapt.Fill(dst)
    End Sub

    <WebMethod()>
    Function ActualizaCliente(ByVal argClienteID$, ByVal argApellidos$, ByVal argNombre$, ByVal argDireccion$, ByVal argTelefono$, ByVal argEmail$,
ByVal TipoActualiza%) As Boolean
        Dim cmdParametrizado As Data.SqlClient.SqlCommand
        Dim prmClienteID As Data.SqlClient.SqlParameter
        Dim prmApellidos As Data.SqlClient.SqlParameter

        Dim prmNombre As Data.SqlClient.SqlParameter
        Dim prmDireccion As Data.SqlClient.SqlParameter
        Dim prmTelefono As Data.SqlClient.SqlParameter
        Dim prmEmail As Data.SqlClient.SqlParameter
        Try
            If TipoActualiza = 1 Then 'Modifica el registro del cliente
                cmdParametrizado = New Data.SqlClient.SqlCommand("EditarCliente", objConn)
            Else 'Ingresa información de un nuevo cliente
                cmdParametrizado = New Data.SqlClient.SqlCommand("CrearCliente", objConn)
            End If
            cmdParametrizado.CommandType = Data.CommandType.StoredProcedure
            prmClienteID = cmdParametrizado.Parameters.Add("@prmClienteID", Data.SqlDbType.Char)
            prmClienteID.Direction = Data.ParameterDirection.Input
            prmClienteID.Value = argClienteID
            prmApellidos = cmdParametrizado.Parameters.Add("@prmApellidos", Data.SqlDbType.VarChar)
            prmApellidos.Direction = Data.ParameterDirection.Input
            prmApellidos.Value = argApellidos
            prmNombre = cmdParametrizado.Parameters.Add("@prmNombre", Data.SqlDbType.VarChar)
            prmNombre.Direction = Data.ParameterDirection.Input
            prmNombre.Value = argNombre
            prmDireccion = cmdParametrizado.Parameters.Add("@prmDireccion", Data.SqlDbType.VarChar)
            prmDireccion.Direction = Data.ParameterDirection.Input
            prmDireccion.Value = argDireccion
            prmTelefono = cmdParametrizado.Parameters.Add("@prmTelefono", Data.SqlDbType.VarChar)
            prmTelefono.Direction = Data.ParameterDirection.Input
            prmTelefono.Value = argTelefono
            prmEmail = cmdParametrizado.Parameters.Add("@prmEmail", Data.SqlDbType.VarChar)
            prmEmail.Direction = Data.ParameterDirection.Input
            prmEmail.Value = argEmail
            If objConn.State = Data.ConnectionState.Closed Then objConn.Open()
            cmdParametrizado.ExecuteNonQuery()
            Return True
            If objConn.State = Data.ConnectionState.Open Then objConn.Close()

        Catch ex As Exception
            Return False
        End Try
    End Function
    <WebMethod()>
    Function AgregarMovimiento(ByVal argOperacionID%, ByVal argTipoMovID$, ByVal argClaseMovID$, ByVal argClienteID$, ByVal argCuentaID$, ByVal argFecha_Movimiento As DateTime, ByVal argMonto_Movimiento As Double, ByVal argDetalle_Movimiento$) As Boolean
        Dim cmdParametrizado As Data.SqlClient.SqlCommand
        Dim OperacionID As Data.SqlClient.SqlParameter
        Dim TipoMovID As Data.SqlClient.SqlParameter
        Dim ClaseMovID As Data.SqlClient.SqlParameter
        Dim ClienteID As Data.SqlClient.SqlParameter
        Dim CuentaID As Data.SqlClient.SqlParameter
        Dim Fecha_Movimiento As Data.SqlClient.SqlParameter
        Dim Monto_Movimiento As Data.SqlClient.SqlParameter
        Dim Detalle_Movimiento As Data.SqlClient.SqlParameter
        Try
            cmdParametrizado = New Data.SqlClient.SqlCommand("IngresarMovimiento", objConn)
            cmdParametrizado.CommandType = Data.CommandType.StoredProcedure
            OperacionID = cmdParametrizado.Parameters.Add("@prmOperacionID", Data.SqlDbType.Int)
            OperacionID.Direction = Data.ParameterDirection.Input
            OperacionID.Value = argOperacionID
            TipoMovID = cmdParametrizado.Parameters.Add("@prmTipoMovID", Data.SqlDbType.Char)
            TipoMovID.Direction = Data.ParameterDirection.Input
            TipoMovID.Value = argTipoMovID
            ClaseMovID = cmdParametrizado.Parameters.Add("@prmClaseMovID", Data.SqlDbType.Char)
            ClaseMovID.Direction = Data.ParameterDirection.Input
            ClaseMovID.Value = argClaseMovID
            ClienteID = cmdParametrizado.Parameters.Add("@prmClienteID", Data.SqlDbType.Char)
            ClienteID.Direction = Data.ParameterDirection.Input
            ClienteID.Value = argClienteID
            CuentaID = cmdParametrizado.Parameters.Add("@prmCuentaID", Data.SqlDbType.Char)
            CuentaID.Direction = Data.ParameterDirection.Input
            CuentaID.Value = argCuentaID
            Fecha_Movimiento = cmdParametrizado.Parameters.Add("@prmFecha_Movimiento", Data.SqlDbType.DateTime)
            Fecha_Movimiento.Direction = Data.ParameterDirection.Input
            Fecha_Movimiento.Value = argFecha_Movimiento
            Monto_Movimiento = cmdParametrizado.Parameters.Add("@prmMonto_Movimiento", Data.SqlDbType.Decimal)
            Monto_Movimiento.Direction = Data.ParameterDirection.Input
            Monto_Movimiento.Value = argMonto_Movimiento
            Detalle_Movimiento = cmdParametrizado.Parameters.Add("@prmDetalle_Movimiento", Data.SqlDbType.VarChar)
            Detalle_Movimiento.Direction = Data.ParameterDirection.Input
            Detalle_Movimiento.Value = argDetalle_Movimiento
            If objConn.State = Data.ConnectionState.Closed Then objConn.Open()
            cmdParametrizado.ExecuteNonQuery()
            Return True
            If objConn.State = Data.ConnectionState.Open Then objConn.Close()
        Catch ex As Exception
            Return False
        End Try
    End Function
    <WebMethod()>
    Function EliminarCliente(ByVal argClienteID$, ByRef msgError$) As Boolean
        Dim cmdParametrizado As Data.SqlClient.SqlCommand
        Dim prmCliente As Data.SqlClient.SqlParameter
        Try
            cmdParametrizado = New Data.SqlClient.SqlCommand("BorrarCliente", objConn)
            cmdParametrizado.CommandType = Data.CommandType.StoredProcedure
            prmCliente = cmdParametrizado.Parameters.Add("@prmClienteID", Data.SqlDbType.Char)
            prmCliente.Direction = Data.ParameterDirection.Input
            prmCliente.Value = argClienteID
            If objConn.State = Data.ConnectionState.Closed Then objConn.Open()
            cmdParametrizado.ExecuteNonQuery()
            If objConn.State = Data.ConnectionState.Open Then objConn.Close()
            msgError = ""
            Return True
        Catch ex As Exception
            msgError = ex.Message
            Return False
        End Try
    End Function
    <WebMethod()>
    Sub ObtenerDatos(ByVal cSQL As String, ByRef ds As Data.DataSet)
        Try
            'Declara un DataAdapter para efectos de conectarse al origen de datos
            'de acuerdo a lo solicitado en cSQL para ejecutar en el origen de datos
            'confi gurado en objConn
            Dim da As New Data.SqlClient.SqlDataAdapter(cSQL, objConn)
            da.Fill(ds, "KHPtbClientes")
        Catch
        End Try
    End Sub
    <WebMethod()> Function ActualizarDatos(ByVal cSQL As String, ByRef msgError$) As Boolean
        Try
            Dim objConn As New Data.SqlClient.SqlConnection(strConn)
            Dim cmd As New Data.SqlClient.SqlCommand(cSQL, objConn)
            If objConn.State = Data.ConnectionState.Closed Then objConn.Open()
            cmd.ExecuteNonQuery()
            If objConn.State = Data.ConnectionState.Open Then objConn.Close()
            msgError = ""
            Return True
        Catch ex As Exception
            msgError = ex.Message
            Return False
        End Try
    End Function
End Class