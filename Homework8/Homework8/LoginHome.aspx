<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="LoginHome.aspx.cs" Inherits="Homework8.LoginHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="form-group col-md-4 col-md-offset-4">
                <label class="control-label">Username:</label>
                <asp:TextBox CssClass="form-control" ID="txtUsername" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="text-center">
                <asp:Label ID="lblWarningUsername" CssClass="control-label" runat="server" ForeColor="Red"></asp:Label>
            </div>
        </div>
        <div class="row">
            <div class="form-group col-md-4 col-md-offset-4">
                <label class="control-label">Password:</label>
                <asp:TextBox CssClass="form-control" ID="txtPassword" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="text-center">
                <asp:Label ID="lblWarningPassword" CssClass="control-label" runat="server" ForeColor="Red"></asp:Label>
            </div>
        </div>
        <div class="row">
            <div class="text-center" style="margin-top:25px">
                <asp:LinkButton ID="login" CssClass="btn-info btn-lg" runat="server" OnClick="login_Click">Login</asp:LinkButton>
            </div>
        </div>
    </div>
</asp:Content>
