<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormImage.aspx.cs" Inherits="WebApplicationEmpty.WebFormImage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Exemple image</title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            <h1>Cliquer sur l'image</h1>

            <input type="image" src="button.png" id="ImgButton"
                runat="server" OnServerClick="Convert_ServerClick" /> <br />
            <p id="Result" runat="server" />
        </div>

    </form>
</body>
</html>

