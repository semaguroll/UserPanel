<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/Main.Master" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="UserPanel.Panel.UpdateUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .rightbutton {
            width: 200px;
            float: right;
            margin-right: 100px;
            margin-top: 20px;
            padding: 7px;
            border: outset;
            text-align: center;
            border-color: cornflowerblue;
            color: cornflowerblue;
        }
    </style>
    <div id="content">
        <div class="grid_container">
            <div class="grid_12 full_block">
                <div class="widget_wrap">
                    <div class="widget_top">
                        <span class="h_icon list_image"></span>
                        <h6>Menü Ekle</h6>
                    </div>
                    <div class="widget_content">
                        <div action="#" method="post" class="form_container">
                            <ul>
                                <li>
                                    <div class="form_grid_12">
                                        <label class="field_title">Kullanıcı Adı</label>

                                        <div class="form_input">
                                            <asp:TextBox type="text" TabIndex="1" ID="txtName" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </li>
                                <li>
                                    <div class="form_grid_12">
                                        <label class="field_title">Kullanıcı Soyadı</label>

                                        <div class="form_input">
                                            <asp:TextBox type="text" TabIndex="1" ID="txtSurname" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </li>
                                <li>
                                    <div class="form_grid_12">
                                        <label class="field_title">Eposta</label>

                                        <div class="form_input">
                                            <asp:TextBox type="text" TabIndex="1" ID="txtEposta" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </li>
                                <li>
                                    <div class="form_grid_12">
                                        <label class="field_title">Şifre</label>
                                        <div class="form_input">
                                            <asp:TextBox type="text" TabIndex="1" ID="txtPassword" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </li>                               
                            </ul>
                            <div class="form_grid_12">
                                <a href="Menu.aspx"> <asp:Button runat="server" id="btnUpdate" Text="Güncelle"  OnClick="btnUpdate_Click" /> </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
