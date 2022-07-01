<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/Main.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="UserPanel.Panel.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
     <div id="content">
        <div class="grid_container">
            <div class="grid_12 full_block">
				<div class="widget_wrap">
					<div class="widget_top">
						<span class="h_icon list"></span>
						<h6>Form Elements</h6>
					</div>
					<div class="widget_content">
						<div id="signupform" autocomplete="off" method="get" action="#" class="form_container left_label">
							<ul>
								<li>
								<div class="form_grid_12">
									<label class="field_title" id="lfirstname" for="firstname">Adı</label>
									<div class="form_input">
										<asp:TextBox runat="server" ID="txtName" name="firstname" type="text" value="" maxlength="100" class="large"/>
									</div>
								</div>
								</li>
								<li>
								<div class="form_grid_12">
									<label class="field_title" id="llastname" for="lastname">Soyadı</label>
									<div class="form_input">
										<asp:TextBox runat="server" ID="txtSurname" name="lastname" type="text" value="" maxlength="100" class="large"/>
									</div>
								</div>
								</li>
								<li>
								<div class="form_grid_12">
									<label class="field_title" id="lemail" for="email">E-mail</label>
									<div class="form_input">
										<asp:TextBox runat="server" ID="txtEposta" name="email" type="text" value="" maxlength="150" class="large"/>
									</div>
								</div>
								</li>								
								<li>
								<div class="form_grid_12">
									<label class="field_title" id="lpassword" for="password">Şifre</label>
									<div class="form_input">
										<asp:TextBox runat="server" ID="txtPassword" name="password" type="password" maxlength="50" value="" class="large"/>
									</div>
								</div>
								</li>
								<li>
								<div class="form_grid_12">
									<div class="form_input">
										<asp:Button runat="server" ID="btnEdit" OnClick="btnEdit_Click" name="signup" type="submit" class="btn_small btn_blue" Text="Kaydet"/>
									</div>
								</div>
								</li>
							</ul>
						</div>
					</div>
				</div>
			</div>
			</div>
	</div>
</asp:Content>
