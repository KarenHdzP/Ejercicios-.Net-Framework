<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
    <span class="nuevoEstilo2">Hola</span><br />
    <br />
    <br />
    <script>
        alert('Hola Mundo');
        var nombreCompleto = 'Enrique Gómez Jiménez';
        var edad = 99;
        var estatura = 1.88;
        var casado = true;
        document.write(nombreCompleto);
        document.write('<br>'); //Hace el salto de línea
        document.write(edad);
        document.write('<br>');
        document.write(estatura);
        document.write('<br>');
        document.write(casado);
    </script>

    <p class="nuevoEstilo1">
        Hola Amigos
    </p>
</body>
</html>
