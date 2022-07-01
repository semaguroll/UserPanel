<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/Login.Master" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="UserPanel.Panel.ForgotPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="login_page">
	<div class="login_container" style="bottom: 600px">
		<div class="login_header blue_lgel">
			<ul class="login_branding">
				<li>
				<div class="logo_small">
					<img src="images/logo-bingo.png" width="99" height="35" alt="bingo">
				</div>
				<span>All Purpose Responsive Admin Template</span>
				</li>
				<li class="right go_to"><a href="Login.aspx" title="Go to Main Site" class="home">Go To Main Site</a></li>
			</ul>
		</div>
			<div class="forgot_pass">
				<h3 class="blue_d">Forgot Password</h3>
				<ul>
					<li class="user_email">
					<asp:TextBox runat="server" type="text" ID="txtEposta" value="E-posta" />
					</li>
				</ul>
			</div>
			<asp:Button runat="server" class="forgot_btn blue_lgel" Text="Gönder" type="submit" />		
	</div>
</div>
</asp:Content>
