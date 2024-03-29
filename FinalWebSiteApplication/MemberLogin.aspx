﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberLogin.aspx.cs" Inherits="FinalWebSiteApplication.MemberLogin1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <h1>
        Member Login Page
    </h1>
    <p>
        Enter the username: <asp:TextBox ID="Username" runat="server"></asp:TextBox>
    </p>
    <p>
        Enter the Password: <asp:TextBox AutoCompleteType="Disabled" TextMode="Password"  ID="Password" runat="server"></asp:TextBox>
        </p>
    <p>
        Errors:
        <asp:Label ID="ErrorLabel" runat="server"></asp:Label>
    </p>
    <p>
        Click the button to Log in:
        <asp:Button ID="Login" runat="server" Text="Login" OnClick="Button1_Click" />
    </p>

    <p>
        New user? <a runat="server" href="~/MemberRegister">Sign up as a Member</a>
    </p>
    <p>
        Want to return to the public page? <a runat="server" href="~/Default">Click here</a>.
    </p>
    </form>
</body>
</html>
