<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="SubastaHolandesa.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>CONFIGURACION</h1>
        <table style="width: 600px;">
            <tr>
                <td>Cant Vehiculos</td>
                <td>
                    <input id="Text1" type="text" /></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Tiempo total</td>
                <td>
                    <input id="Text2" type="text" /></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Efectivo minimo</td>
                <td>
                    <input id="Text3" type="text" /></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Efectivo maximo</td>
                <td>
                    <input id="Text4" type="text" /></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Enviar" /></td>
            </tr>            
        </table>
    </div>
    </form>
</body>
</html>
