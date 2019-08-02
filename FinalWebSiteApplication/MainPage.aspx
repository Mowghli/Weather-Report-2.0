<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="FinalWebSiteApplication.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Public Page</h1>
    <p>
        To login to your Member page, please <a runat="server" href="~/MemberLogin">click here</a>
    </p>
    <p>
        Not a Member? To register, <a runat="server" href="~/MemberRegister">click here</a>
    </p>
    <p>
        To login to your Staff page, please <a runat="server" href="~/StaffLogin">click here</a>
    </p>
    </form>
</body>
</html>
