<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UserPanel.Panel.Login1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login_container" style="bottom: 600px">
        <div class="login_header blue_lgel">
            <ul class="login_branding">
                <li>
                    <div class="logo_small">
                        <img src="images/logo-bingo.png" width="99" height="35" alt="bingo">
                    </div>
                    <span>All Purpose Responsive Admin Template</span>
                </li>
                <li class="right go_to"><a href="#" title="Go to Main Site" class="home">Go To Main Site</a></li>
            </ul>
        </div>
        <div class="block_container blue_d">
            <div class="block_form">
                <ul>
                    <li class="login_user">
                        <asp:TextBox runat="server" ID="txtEposta" name="" value="E-posta" type="text"  />
                    </li>
                    <li class="login_pass">
                        <asp:TextBox runat="server" ID="txtPassword" type="password" value="123456"/>
                    </li>
                </ul>
                <asp:Button runat="server" ID="btnLogin" OnClick="btnLogin_Click" class="login_btn blue_lgel" Text="Giriş Yap" type="submit" />
            </div>
            <ul class="login_opt_link">
                <li><a href="ForgotPassword.aspx">Forgot Password?</a></li>
                <li class="remember_me right">
                    <input name="" class="rem_me" type="checkbox" value="checked">
                    Remember Me</li>
            </ul>
        </div>
    </div>
</asp:Content>
