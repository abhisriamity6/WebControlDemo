<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebControl.aspx.cs" Inherits="WebControlDemo.WebControl" %>

<!DOCTYPE html>
<html>
<head>
<title > Currency Converter</title>
</head>
<body>
<form runat = "server">
<div>
Convert: &nbsp;
<input type = "text" ID = "US" runat = "server" value=" 0" />
&nbsp; U.S. dollars to Euros.
<br /> <br />
<input type = "submit" value = "OK" ID = "Convert" runat = "server"
OnServerClick = "Convert_ServerClick" />
<br /> <br />
<p style = "font-weight: bold" ID = "Result" runat = "server" > </p>
</div>
</form>
</body>
</html>