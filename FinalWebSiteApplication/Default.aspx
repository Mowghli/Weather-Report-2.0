<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FinalWebSiteApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
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

</asp:Content>
