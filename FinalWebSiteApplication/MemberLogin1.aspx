<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MemberLogin1.aspx.cs" Inherits="FinalWebSiteApplication.MemberLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
</asp:Content>
