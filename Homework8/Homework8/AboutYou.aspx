<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AboutYou.aspx.cs" Inherits="Homework8.AboutYou" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 class="text-center" style="margin-bottom: 20px; color: black">Enter Your Information To Register</h2>
    <div class="container" style="color: black">
        <div class="row">
            <div class="form-group col-md-6">
                <asp:Label ID="lblFirstName" runat="server" CssClass="control-label">First Name:</asp:Label>
                <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-6">
                <asp:Label ID="lblLastName" runat="server" CssClass="control-label">Last Name:</asp:Label>
                <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="form-group col-md-6">
                <asp:Label ID="lblAddress" runat="server" CssClass="control-label">Address:</asp:Label>
                <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-6">
                <asp:Label ID="lblBirthday" runat="server" CssClass="control-label">Birthday:</asp:Label>
                <asp:TextBox ID="txtBirthday" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="form-group col-md-4">
                <asp:Label ID="lblCity" runat="server" CssClass="control-label">City:</asp:Label>
                <asp:TextBox ID="txtCity" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">
                <asp:Label ID="lblState" runat="server" CssClass="control-label">State:</asp:Label>
                <asp:TextBox ID="txtState" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">
                <asp:Label ID="lblZIP" runat="server" CssClass="control-label">ZIP Code:</asp:Label>
                <asp:TextBox ID="txtZIP" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="form-group col-md-6">
                <asp:Label ID="lblEmail" runat="server" CssClass="control-label">E-Mail:</asp:Label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-6">
                <asp:Label ID="lblPhone" runat="server" CssClass="control-label">Phone:</asp:Label>
                <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="form-group col-md-4">
                <asp:Label ID="lblCollege" runat="server" CssClass="control-label">College:</asp:Label>
                <asp:TextBox ID="txtCollege" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">
                <asp:Label ID="lblMajor" runat="server" CssClass="control-label">Major:</asp:Label>
                <asp:TextBox ID="txtMajor" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">
                <asp:Label ID="lblGradDate" runat="server" CssClass="control-label">Expected Graduation Date:</asp:Label>
                <asp:TextBox ID="txtGradDate" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="form-group center-block text-center">
                <label for="comment">Comment:</label>
                <textarea class="form-control" rows="5" id="comment"></textarea>
            </div>
        </div>
        <div class="row">
            <div class="text-center" style="margin-top: 25px">
                <asp:LinkButton ID="btnlogin" CssClass="btn-info btn-lg" runat="server" OnClick="login_Click">Register</asp:LinkButton>
            </div>
        </div>
        <div class="row text-center" style="margin-top: 20px;margin-bottom:100px">
            <asp:Label ID="lblRegister" runat="server" CssClass="control-label" ForeColor="Red"> &nbsp;</asp:Label>
        </div>
    </div>
</asp:Content>
