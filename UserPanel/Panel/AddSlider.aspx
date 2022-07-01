<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/Main.Master" AutoEventWireup="true" CodeBehind="AddSlider.aspx.cs" Inherits="UserPanel.Panel.AddSlider" %>

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
                                        <label class="field_title">Görsel Adı</label>

                                        <div class="form_input">
                                            <asp:TextBox type="text" TabIndex="1" class="limiter" ID="txtName" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </li>
                                <li>
                                    <div class="form_grid_12">
                                        <label class="field_title">Görsel Uzantısı</label>

                                        <div class="form_input">
                                            <asp:FileUpload ID="imgSlider" runat="server" />
                                        </div>
                                    </div>
                                </li>
                                <li>
                                    <div class="form_grid_12">
                                        <label class="field_title">Link</label>
                                        <div class="form_input">
                                            <asp:TextBox type="text" TabIndex="1" class="limiter" ID="txtLink" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </li>
                            </ul>
                            <div class="form_grid_12">
                                <asp:Button runat="server" ID="btnAdd" Text="Ekle" OnClick="btnAdd_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
