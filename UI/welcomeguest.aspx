<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="welcomeguest.aspx.cs" Inherits="UI.welcomeguest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    <table>
        <tr>
            <td>
                Name
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
          <tr>
            <td>
                Mobile No
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <input 
            </td>
        </tr>
          <tr>
            <td>
                Movie 
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            </td>
        </tr>
          <tr>
            <td>
                No of Tickets
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" AutoPostBack="true"
                     OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox3"
                     ErrorMessage="less than 10" MaximumValue="9" MinimumValue="1" Type="Integer"></asp:RangeValidator>
            </td>
        </tr>
          <tr>
            <td>
                Seat type
            </td>
            <td>
                 <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="true"
                      OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList>
            </td>
        </tr>
          <tr>
            <td>
               Total Amount
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" />
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Book" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
