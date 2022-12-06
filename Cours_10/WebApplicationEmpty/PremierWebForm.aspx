<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PremierWebForm.aspx.cs" Inherits="WebApplicationEmpty.PremierWebForm" %>

<!DOCTYPE html>
<%--<html>
    <head>
        <title>Sample Web Page</title>
    </head>
    <body>
        <h1>Sample Web Page Heading</h1>
        <p>This is a sample web page.</p>
    </body>
</html>--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
     <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin: 3px">
         <asp:Label ID="Label1" runat="server" 
           Text="Taper quelque chose ici :" />
          <br />
          <asp:TextBox ID="TextBox1" runat="server" />
          <asp:Button ID="Button1" runat="server" Text="Button" 
             OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>

