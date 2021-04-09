﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="dbExpediente")>  _
Partial Public Class dbBancosDataContextDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Definiciones de métodos de extensibilidad"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InserttbClientes(instance As tbClientes)
    End Sub
  Partial Private Sub UpdatetbClientes(instance As tbClientes)
    End Sub
  Partial Private Sub DeletetbClientes(instance As tbClientes)
    End Sub
  Partial Private Sub InserttbCuentas(instance As tbCuentas)
    End Sub
  Partial Private Sub UpdatetbCuentas(instance As tbCuentas)
    End Sub
  Partial Private Sub DeletetbCuentas(instance As tbCuentas)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("dbExpedienteConnectionString").ConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property tbClientes() As System.Data.Linq.Table(Of tbClientes)
		Get
			Return Me.GetTable(Of tbClientes)
		End Get
	End Property
	
	Public ReadOnly Property tbCuentas() As System.Data.Linq.Table(Of tbCuentas)
		Get
			Return Me.GetTable(Of tbCuentas)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tbClientes")>  _
Partial Public Class tbClientes
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ClienteID As Integer
	
	Private _Apellidos As String
	
	Private _Nombre As String
	
	Private _Direccion As String
	
	Private _Telefono As System.Nullable(Of Integer)
	
	Private _Clave As String
	
    #Region "Definiciones de métodos de extensibilidad"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnClienteIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnClienteIDChanged()
    End Sub
    Partial Private Sub OnApellidosChanging(value As String)
    End Sub
    Partial Private Sub OnApellidosChanged()
    End Sub
    Partial Private Sub OnNombreChanging(value As String)
    End Sub
    Partial Private Sub OnNombreChanged()
    End Sub
    Partial Private Sub OnDireccionChanging(value As String)
    End Sub
    Partial Private Sub OnDireccionChanged()
    End Sub
    Partial Private Sub OnTelefonoChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnTelefonoChanged()
    End Sub
    Partial Private Sub OnClaveChanging(value As String)
    End Sub
    Partial Private Sub OnClaveChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ClienteID", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property ClienteID() As Integer
		Get
			Return Me._ClienteID
		End Get
		Set
			If ((Me._ClienteID = value)  _
						= false) Then
				Me.OnClienteIDChanging(value)
				Me.SendPropertyChanging
				Me._ClienteID = value
				Me.SendPropertyChanged("ClienteID")
				Me.OnClienteIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Apellidos", DbType:="NChar(10)")>  _
	Public Property Apellidos() As String
		Get
			Return Me._Apellidos
		End Get
		Set
			If (String.Equals(Me._Apellidos, value) = false) Then
				Me.OnApellidosChanging(value)
				Me.SendPropertyChanging
				Me._Apellidos = value
				Me.SendPropertyChanged("Apellidos")
				Me.OnApellidosChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Nombre", DbType:="NChar(10)")>  _
	Public Property Nombre() As String
		Get
			Return Me._Nombre
		End Get
		Set
			If (String.Equals(Me._Nombre, value) = false) Then
				Me.OnNombreChanging(value)
				Me.SendPropertyChanging
				Me._Nombre = value
				Me.SendPropertyChanged("Nombre")
				Me.OnNombreChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Direccion", DbType:="NChar(10)")>  _
	Public Property Direccion() As String
		Get
			Return Me._Direccion
		End Get
		Set
			If (String.Equals(Me._Direccion, value) = false) Then
				Me.OnDireccionChanging(value)
				Me.SendPropertyChanging
				Me._Direccion = value
				Me.SendPropertyChanged("Direccion")
				Me.OnDireccionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Telefono", DbType:="Int")>  _
	Public Property Telefono() As System.Nullable(Of Integer)
		Get
			Return Me._Telefono
		End Get
		Set
			If (Me._Telefono.Equals(value) = false) Then
				Me.OnTelefonoChanging(value)
				Me.SendPropertyChanging
				Me._Telefono = value
				Me.SendPropertyChanged("Telefono")
				Me.OnTelefonoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Clave", DbType:="NChar(10)")>  _
	Public Property Clave() As String
		Get
			Return Me._Clave
		End Get
		Set
			If (String.Equals(Me._Clave, value) = false) Then
				Me.OnClaveChanging(value)
				Me.SendPropertyChanging
				Me._Clave = value
				Me.SendPropertyChanged("Clave")
				Me.OnClaveChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tbCuentas")>  _
Partial Public Class tbCuentas
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _CuentaID As Integer
	
	Private _ClienteID As String
	
	Private _Fecha_Apertura As String
	
	Private _Fecha_Cierre As String
	
	Private _Sueldo As String
	
    #Region "Definiciones de métodos de extensibilidad"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnCuentaIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnCuentaIDChanged()
    End Sub
    Partial Private Sub OnClienteIDChanging(value As String)
    End Sub
    Partial Private Sub OnClienteIDChanged()
    End Sub
    Partial Private Sub OnFecha_AperturaChanging(value As String)
    End Sub
    Partial Private Sub OnFecha_AperturaChanged()
    End Sub
    Partial Private Sub OnFecha_CierreChanging(value As String)
    End Sub
    Partial Private Sub OnFecha_CierreChanged()
    End Sub
    Partial Private Sub OnSueldoChanging(value As String)
    End Sub
    Partial Private Sub OnSueldoChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CuentaID", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property CuentaID() As Integer
		Get
			Return Me._CuentaID
		End Get
		Set
			If ((Me._CuentaID = value)  _
						= false) Then
				Me.OnCuentaIDChanging(value)
				Me.SendPropertyChanging
				Me._CuentaID = value
				Me.SendPropertyChanged("CuentaID")
				Me.OnCuentaIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ClienteID", DbType:="NChar(10)")>  _
	Public Property ClienteID() As String
		Get
			Return Me._ClienteID
		End Get
		Set
			If (String.Equals(Me._ClienteID, value) = false) Then
				Me.OnClienteIDChanging(value)
				Me.SendPropertyChanging
				Me._ClienteID = value
				Me.SendPropertyChanged("ClienteID")
				Me.OnClienteIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Fecha_Apertura", DbType:="NChar(10)")>  _
	Public Property Fecha_Apertura() As String
		Get
			Return Me._Fecha_Apertura
		End Get
		Set
			If (String.Equals(Me._Fecha_Apertura, value) = false) Then
				Me.OnFecha_AperturaChanging(value)
				Me.SendPropertyChanging
				Me._Fecha_Apertura = value
				Me.SendPropertyChanged("Fecha_Apertura")
				Me.OnFecha_AperturaChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Fecha_Cierre", DbType:="NChar(10)")>  _
	Public Property Fecha_Cierre() As String
		Get
			Return Me._Fecha_Cierre
		End Get
		Set
			If (String.Equals(Me._Fecha_Cierre, value) = false) Then
				Me.OnFecha_CierreChanging(value)
				Me.SendPropertyChanging
				Me._Fecha_Cierre = value
				Me.SendPropertyChanged("Fecha_Cierre")
				Me.OnFecha_CierreChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Sueldo", DbType:="NChar(10)")>  _
	Public Property Sueldo() As String
		Get
			Return Me._Sueldo
		End Get
		Set
			If (String.Equals(Me._Sueldo, value) = false) Then
				Me.OnSueldoChanging(value)
				Me.SendPropertyChanging
				Me._Sueldo = value
				Me.SendPropertyChanged("Sueldo")
				Me.OnSueldoChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
