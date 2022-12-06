<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BulletList.aspx.cs" Inherits="Cours_09_Exercice03.BulletList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Bullet List Page</title>
</head>
<body>
    <form runat="server">
        <div>
            Bullet List : <br /> <br />

            <asp:BulletedList BulletStyle ="Numbered" DisplayMode="LinkButton" ID="BulletList_1" OnClick="BulletList_1_Click" runat="server">
            </asp:BulletedList>

        </div>
    </form>
</body>
</html>
