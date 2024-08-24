<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddRotator.aspx.cs" Inherits="GUI.AddRotator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:AdRotator ID="AdRotator1" runat="server" Height="200" Width="200" AdvertisementFile="~/AddRotatorController.xml" Target="_blank"/>
        </div>
    </form>
</body>
</html>
