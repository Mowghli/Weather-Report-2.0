<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="FinalWebSiteApplication.Member" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        Members Only page
    </h1>

    <p>
        To return to the Public page, <a runat="server" href="~/Default">click here</a>.
    </p>
    <p>
        To sign out, click the button: <asp:Button ID="Signout" runat="server" Text="Sign Out" OnClick="Signout_Click" />
    </p>
</asp:Content>
