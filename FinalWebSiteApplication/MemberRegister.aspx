﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberRegister.aspx.cs" Inherits="FinalWebSiteApplication.MemberRegister1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>
        Member Registration page
    </h1>
    <p>
        Enter the Username: 
        <asp:TextBox ID="Username" runat="server"></asp:TextBox>
        </p>
    <p>
        Enter your password: <%--<input id="Password1" type="password" />--%>
    <asp:TextBox AutoCompleteType="Disabled" TextMode="Password" ID="Password1" runat="server"></asp:TextBox>
    </p>
    <p>
        Enter your password again:
    <asp:TextBox AutoCompleteType="Disabled"  TextMode="Password" ID="Password2" runat="server"></asp:TextBox>
    </p>
    <p>

        Errors:
        <asp:Label ID="ErrorLabel" runat="server"></asp:Label>

    </p>
    <p>
        Click the button to finish Registration:
    <asp:Button ID="Register" runat="server" Text="Register" OnClick="Register_Click" />
    </p>
    <p>
        Have a member account? <a runat="server" href="~/MemberLogin">Log in as a Member</a>.
    </p>
    <p>
        Want to return to the public page? <a runat="server" href="~/Default">Click here</a>.
    </p>
    <p>
        Forgot your Password? <a runat="server" href="~/ForgotID">Click here</a>.
    </p>
    </form>
</body>
</html>
