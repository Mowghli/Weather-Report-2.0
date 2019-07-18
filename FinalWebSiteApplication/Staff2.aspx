﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Staff2.aspx.cs" Inherits="FinalWebSiteApplication.Staff2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        Staff 2 Home Page
    </h1>
    <p>
        Want to return to the Public page? <a runat="server" href="~/Default">Click here</a>.
    </p>
    <p>
        Want to go to the normal member page? <a runat="server" href="~/Member">Click here</a>.
    </p>
    <p>
        To sign out, click the button: <asp:Button ID="Signout" runat="server" Text="Sign Out" OnClick="Signout_Click" />
    </p>
</asp:Content>
