﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentListUI.aspx.cs" Inherits="WebApplication2.StudentListUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style2 {
            width: 314px;
        }
        .auto-style1 {
            text-align: center;
            width: 394px;
        }
        .auto-style4 {
            width: 314px;
            text-align: right;
        }
        .auto-style3 {
            width: 394px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style1">Student Information Management</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="firstNameTextBox" autocomplete="off" runat="server" Width="379px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="lastNameTextBox" autocomplete="off" runat="server" Width="379px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label3" runat="server" Text="User Name"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="userNameTextBox" autocomplete="off" runat="server" Width="379px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label4" runat="server" Text="Reg No"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="regNoTextBox" autocomplete="off" runat="server" Width="379px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="emailTextBox" autocomplete="off" runat="server" Width="379px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label6" runat="server" Text="Age"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="ageTextBox" autocomplete="off" runat="server" Width="379px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="messageLabel" runat="server" ></asp:Label>
                        <br />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:ListBox ID="studentListBox" runat="server" Height="143px" Width="407px"></asp:ListBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        <div>
        </div>
    </form>
</body>
</html>
