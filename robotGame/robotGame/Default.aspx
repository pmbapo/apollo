<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="robotGame._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET!
    </h2>
    <p>
        To learn more about ASP.NET visit <a href="http://www.asp.net" title="ASP.NET Website">www.asp.net</a>.
    </p>
    <p>
        You can also find <a href="http://go.microsoft.com/fwlink/?LinkID=152368&amp;clcid=0x409"
            title="MSDN ASP.NET Docs">documentation on ASP.NET at MSDN</a>.
    </p>
    <asp:TextBox ID="TextBox1" runat="server" Height="188px" Rows="50" 
        Width="297px" ontextchanged="TextBox1_TextChanged" style="margin-top: 0px" 
        TextMode="MultiLine"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="LoadRobots" 
        onclick="Button1_Click" />
    <asp:TextBox ID="TextBox3" runat="server" Height="166px" Width="210px"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" Text="Play" onclick="Button2_Click" />
    <asp:TextBox ID="TextBox2" runat="server" Height="183px" Rows="50" 
        style="margin-top: 0px" TextMode="MultiLine" Width="228px" 
        ontextchanged="TextBox2_TextChanged"></asp:TextBox>
</asp:Content>
