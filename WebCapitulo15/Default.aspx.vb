Imports System.Xml
Partial Class _Default
    Inherits System.Web.UI.Page
    'Se utilizará para cargar los datos provenientes del archivo XML
    Dim dst As New Data.DataSet
    'Se utilizará como documento XML donde se creará el archivo XML
    Dim arbol As New XmlDocument '
    'Se utilizará como nodo del documento (cada registro es un nodo)
    Dim nodo As XmlNode
    Sub CrearTabla()
        'Se procede a llenar una tabla de 10 fi las y 4 celdas
        'cada fila.
        Dim filas As Integer = 10
        Dim celdas As Integer = 4
        'Se crea programáticamente la tabla a utilizar
        Dim j As Integer
        For j = 0 To filas - 1
            'Por cada fi la de la tabla
            'Se crean 4 celdas
            Dim r As New TableRow()
            Dim k As Integer
            For k = 0 To celdas - 1
                Dim c As New TableCell()
                r.Cells.Add(c)
            Next k
            Table1.Rows.Add(r)
        Next j
        Table1.Rows(0).Cells(0).Text = "Cuenta Cliente"
        Table1.Rows(0).Cells(1).Text = "Nombre Cliente"
        Table1.Rows(0).Cells(2).Text = "Dirección Cliente"
        Table1.Rows(0).Cells(3).Text = "Teléfono Cliente"

        If Not Page.IsPostBack Then Session("fila") = 1

    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Se crea el nodo que servirá como nodo raíz del árbol de registros del XML
        nodo = arbol.CreateElement("Clientes")
        'Se agrega el nodo al árbol, que es el documento XML a crear
        arbol.AppendChild(nodo)
        'Se crea una tabla de 10 elementos como ejemplo de creación de registros.
        CrearTabla()
    End Sub
    Protected Sub btnCargarXML_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCargarXML.Click
        Try
            'Se lee un documento XML de nombre Prueba
            'el cual está en el servidor.
            dst.ReadXml(Server.MapPath("Prueba.xml"))
            'se carga el GridView1 con los datos del DataSet
            GridView1.DataSource = dst.Tables(0)
            GridView1.DataBind()
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Protected Sub btnIncluirTabla_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIncluirTabla.Click
        Try

            'Se carga la tabla con los datos de los TextBox
            Dim i = Session("fila")
            Table1.Rows(i).Cells(0).Text = TextBox1.Text
            Table1.Rows(i).Cells(1).Text = TextBox2.Text
            Table1.Rows(i).Cells(2).Text = TextBox3.Text
            Table1.Rows(i).Cells(3).Text = TextBox4.Text
            i = i + 1
            Session("fila") = i
            btnGenerarXML.Enabled = True

            Table1.Rows(0).Cells(0).Text = "Cuenta Cliente"
            Table1.Rows(0).Cells(1).Text = "Nombre Cliente"
            Table1.Rows(0).Cells(2).Text = "Dirección Cliente"
            Table1.Rows(0).Cells(3).Text = "Teléfono Cliente"
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Protected Sub btnGenerarXML_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGenerarXML.Click
        Try
            'Se comienza a conformar el documento XML
            Dim ruta$ = Server.MapPath("Prueba.xml")
            'MsgBox(ruta)
            Dim Escritor As New XmlTextWriter(ruta, Encoding.UTF8)
            Escritor.Formatting = Formatting.Indented
            'Inicia a escribirse el documento XML
            Escritor.WriteStartDocument()
            'Comienza con el objeto de inicio Clientes
            Escritor.WriteStartElement("Clientes")
            Dim f As TableRow
            For Each f In Table1.Rows
                If f.Cells(0).Text <> "" Then
                    Escritor.WriteStartElement("Cliente")
                    Escritor.WriteElementString("Cuenta", f.Cells(0).Text)
                    Escritor.WriteElementString("Nombre", f.Cells(1).Text)
                    Escritor.WriteElementString("Direccion", f.Cells(2).Text)
                    Escritor.WriteElementString("Telefono", f.Cells(3).Text)
                    Escritor.WriteEndElement()
                End If
            Next
            Escritor.Close()
            btnCargarXML.Enabled = True
            Response.Write("<script>alert('El archivo XML fue creado exitosamente!')</script>")
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Protected Sub btnDesplegarXML_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDesplegarXML.Click
        Response.Redirect("webMostrarXML.aspx")
    End Sub
End Class
