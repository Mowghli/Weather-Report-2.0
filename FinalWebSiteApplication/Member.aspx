<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="FinalWebSiteApplication.Member1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <h1>
        Members Only page
    </h1>

    <p>
        To return to the Public page, <a runat="server" href="~/Default">click here</a>.
    </p>
    <p>
        To sign out, click the button: <asp:Button ID="Signout" runat="server" Text="Sign Out" OnClick="Signout_Click" />
    </p>
    </form>
</body>
</html>
