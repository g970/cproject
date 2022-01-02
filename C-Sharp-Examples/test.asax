<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <form id="Form1" runat="server">
        <table>
            <tr>
                <td>User:</td><td><asp:TextBox ID="user" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Password:</td><td><br /><asp:textbox TextMode="password" id="pass" runat="server" /></td>
            </tr>
            <tr>
                <td><asp:button Text="Login" runat="server" id="btn" onClick="submit"/></td>
            </tr>
        </table>
    </form>
</asp:Content>
