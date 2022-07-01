<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/Main.Master" AutoEventWireup="true" CodeBehind="UpdateMenu.aspx.cs" Inherits="UserPanel.Panel.UpdateMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                            <asp:Label runat="server" ID="lbldeneme"></asp:Label>
                            <ul>
                                <li>
                                    <div class="form_grid_12">
                                        <label class="field_title">Menü Adı</label>

                                        <div class="form_input">
                                            <asp:TextBox type="text" TabIndex="1" class="limiter" ID="txtMenu" runat="server"></asp:TextBox>
                                        </div>
                                        </div>
                                </li>
                                <li>
                                    <div class="form_grid_12">
                                        <label class="field_title">Üst Menü ID</label>
                                        <div class="form_input">
                                             <asp:TextBox type="text" TabIndex="1" class="limiter" ID="txtUstMenu" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </li>
                                <li>
                                    <div class="form_grid_12">
                                        <label class="field_title">Route</label>
                                        <div class="form_input">
                                            <asp:TextBox type="text" TabIndex="1" class="limiter" ID="txtRoute" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </li>
                                <li>
                                    <div class="form_grid_12">
                                        <div class="form_input">
                                          <asp:Button runat="server" id="btnUpdate" Text="Güncelle"  OnClick="btnUpdate_Click" />
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
