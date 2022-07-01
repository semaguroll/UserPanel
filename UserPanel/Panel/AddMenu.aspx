<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/Main.Master" AutoEventWireup="true" CodeBehind="AddMenu.aspx.cs" Inherits="UserPanel.Panel.AddMenu" %>

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
                                            <asp:TextBox type="text" TabIndex="1" class="limiter" ID="txtUstID" runat="server"></asp:TextBox>
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
                                            <asp:Button runat="server" ID="btnAdd" Text="Ekle" OnClick="btnAdd_Click" />
                                        </div>
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div style="height: 50px"></div>
                <div class="widget_content">
                    <table class="display data_tbl_search">
                        <thead>
                            <tr>
                                <th>ID</th>
                                <th>Menü</th>
                                <th>Üst Menü ID</th>
                                <th>Route</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="DataList1" runat="server">
                                <ItemTemplate>
                                    <tr class="gradeX">
                                        <td><%#Eval("M_Id")%></td>
                                        <td><%#Eval("MenuAdi")%></td>
                                        <td><%#Eval("UstMenuID")%></td>
                                        <td class="center"><%#Eval("Route")%></td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                    <div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

