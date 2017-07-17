<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebControl.aspx.cs" Inherits="WebControlDemo.WebControl" %>

<!DOCTYPE html>
<html>
<head>
<title > Currency Converter</title>
</head>
<body style="height: 349px">
<form runat = "server">
<div style="height: 281px">
Convert: &nbsp;
<input type = "text" ID = "US" runat = "server" value=" 0" />
&nbsp; U.S. dollars to Euros. &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
<select ID = "Currency" runat = "server" onserverchange ="Selection_Changed" />
<br /> <br />

<input type = "submit" value = "OK" ID = "Convert" runat = "server" OnServerClick = "Convert_ServerClick" />
<input type = "submit" value = "Show Graph" ID = "ShowGraph" runat = "server" onserverclick ="ShowGraph_ServerClick" />
<input type = "submit" value = "Hide Graph" ID = "Submit2" runat = "server" onserverclick ="HideGraph_ServerClick" />
<img ID = "Graph" src = "" alt = "Currency Graph" runat = "server" />
<br/> 
<br/>
<p style = "font-weight: bold" ID = "Result" runat = "server" > </p>
</div>
</form>
</body>
</html>