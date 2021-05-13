<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmInicio.aspx.cs" Inherits="Jesus.frmInicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="ButtonCargaDatos" runat="server" OnClick="ButtonCargaDatos_Click" Text="Cargar Datos a DB" />
        <p>
            <asp:TextBox ID="TextBoxID" runat="server" style="margin-bottom: 2px"></asp:TextBox>
            <asp:Button ID="ButtonBuscarID" runat="server" OnClick="ButtonBuscarID_Click" Text="buscar por ID" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="TextBoxNombre" runat="server" Width="410px"></asp:TextBox>
            <asp:Button ID="ButtonBuscarNombre" runat="server" OnClick="ButtonBuscarNombre_Click" Text="buscar por Nombre" />
        </p>
    </form>
</body>
</html>
