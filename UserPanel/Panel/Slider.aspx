<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/Main.Master" AutoEventWireup="true" CodeBehind="Slider.aspx.cs" Inherits="UserPanel.Panel.Slider" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <style>
        .rightbutton {
            width: 200px;
            float: right;
            margin-right: 60px;
            margin-top: 20px;
            padding: 7px;
            border: outset;
            text-align: center;
            border-color: cornflowerblue;
            color: cornflowerblue;
        }
    </style>
    <div>
        <div id="actionsBox" class="actionsBox">
            <div id="actionsBoxMenu" class="menu">
                <span id="cntBoxMenu">0</span>
                <a class="button box_action">Archive</a>
                <a class="button box_action">Delete</a>
                <a id="toggleBoxMenu" class="open"></a>
                <a id="closeBoxMenu" class="button t_close">X</a>
            </div>
            <div class="submenu">
                <a class="first box_action">Move...</a>
                <a class="box_action">Mark as read</a>
                <a class="box_action">Mark as unread</a>
                <a class="last box_action">Spam</a>
            </div>
        </div>
        <div id="container">
            <div id="content">
                <div class="grid_container">
                    <div class="grid_12">
                        <div class="widget_wrap">
                            <div class="widget_top">
                                <span class="h_icon blocks_images"></span>
                                <h6>Only search filterable table </h6>
                            </div>
                            <div class="widget_content">
                                <table class="display data_tbl_search">
                                    <thead>
                                        <tr>
                                            <th>Görsel Adı</th>
                                            <th>Görsel Uzantısı</th>
                                            <th>Link</th>
                                            <th></th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <asp:Repeater ID="DataList1" runat="server">
                                            <ItemTemplate>
                                                <tr class="gradeU">
                                                    <td class="center"><%#Eval("GorselAdi")%></td>
                                                    <td class="center">
                                                        <asp:Image ImageUrl=<%#Eval("GorselUzantisi")%> runat="server"></asp:Image>

                                                    </td>
                                                    <td class="center" > <%#Eval("Link")%></td>
                                                    <td class="center">
                                                        <span><a href="UpdateSlider.aspx?ID=<%#Eval("S_Id")%>" class="action-icons c-edit" id="btnUpdate"></a></span>
                                                        <span><a href="Slider.aspx?op=delete&ID=<%#Eval("S_Id")%>" class="action-icons c-Delete"></a></span>
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </tbody>
                                </table>
                                <div>
                                    <span><a class="rightbutton" runat="server" href="AddSlider.aspx" id="btnAdd">Kullanıcı Ekle</a></span>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
                <span class="clear"></span>
            </div>
        </div>
    </div>
</asp:Content>
