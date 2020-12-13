<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="welcomeadmin.aspx.cs" Inherits="UI.welcomeadmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <div>
       <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <table>
        <tr>
            <td>
                <asp:button runat="server" text="View list" OnClick="Unnamed1_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:button runat="server" text="logout" OnClick="Unnamed2_Click1" />
            </td>
        </tr>
        
    </table>
   </div>
    
</asp:Content>
