'------------------------------------------------------------------------------
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
Partial Public Class ExpedientesDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Definiciones de métodos de extensibilidad"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InserttbExpediente(instance As tbExpediente)
    End Sub
  Partial Private Sub UpdatetbExpediente(instance As tbExpediente)
    End Sub
  Partial Private Sub DeletetbExpediente(instance As tbExpediente)
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
	
	Public ReadOnly Property tbExpediente() As System.Data.Linq.Table(Of tbExpediente)
		Get
			Return Me.GetTable(Of tbExpediente)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tbExpediente")>  _
Partial Public Class tbExpediente
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ExpedienteID As Integer
	
	Private _Apellidos As String
	
	Private _Nombre As String
	
	Private _Provincia As String
	
	Private _Atendido As Boolean
	
    #Region "Definiciones de métodos de extensibilidad"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnExpedienteIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnExpedienteIDChanged()
    End Sub
    Partial Private Sub OnApellidosChanging(value As String)
    End Sub
    Partial Private Sub OnApellidosChanged()
    End Sub
    Partial Private Sub OnNombreChanging(value As String)
    End Sub
    Partial Private Sub OnNombreChanged()
    End Sub
    Partial Private Sub OnProvinciaChanging(value As String)
    End Sub
    Partial Private Sub OnProvinciaChanged()
    End Sub
    Partial Private Sub OnAtendidoChanging(value As Boolean)
    End Sub
    Partial Private Sub OnAtendidoChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ExpedienteID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ExpedienteID() As Integer
		Get
			Return Me._ExpedienteID
		End Get
		Set
			If ((Me._ExpedienteID = value)  _
						= false) Then
				Me.OnExpedienteIDChanging(value)
				Me.SendPropertyChanging
				Me._ExpedienteID = value
				Me.SendPropertyChanged("ExpedienteID")
				Me.OnExpedienteIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Apellidos", DbType:="VarChar(100) NOT NULL", CanBeNull:=false)>  _
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
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Nombre", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
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
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Provincia", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Provincia() As String
		Get
			Return Me._Provincia
		End Get
		Set
			If (String.Equals(Me._Provincia, value) = false) Then
				Me.OnProvinciaChanging(value)
				Me.SendPropertyChanging
				Me._Provincia = value
				Me.SendPropertyChanged("Provincia")
				Me.OnProvinciaChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Atendido", DbType:="Bit NOT NULL")>  _
	Public Property Atendido() As Boolean
		Get
			Return Me._Atendido
		End Get
		Set
			If ((Me._Atendido = value)  _
						= false) Then
				Me.OnAtendidoChanging(value)
				Me.SendPropertyChanging
				Me._Atendido = value
				Me.SendPropertyChanged("Atendido")
				Me.OnAtendidoChanged
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
