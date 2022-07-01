<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/Main.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="UserPanel.Panel.Detail" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://cdn.ckeditor.com/4.16.2/full/ckeditor.js"></script>
    <script src="~/ckfinder/ckfinder.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .mrg {
            margin-right: 20px;
            margin-top: 10px;
        }
    </style>
    <div id="container">
        <div id="content">
            <div class="grid_container">
                <div class="grid_12 full_block">
                    <div class="widget_wrap">                        
                        <div class="widget_content">
                            <div>
                                <div class="page_content">
                                    <div class="grid_12 post_preview">
                                        <asp:Repeater ID="DataList1" runat="server">
                                            <ItemTemplate>
                                                <div class="grid_12">

                                                    <div class="widget_wrap">
                                                        <div class="widget_top">
                                                            <h6><%#Eval("MenuAdi")%></h6>
                                                        </div>
                                                        <div class="widget_content">
                                                            <asp:Label runat="server" Text='<%#Eval("Detay")%>'></asp:Label>
                                                            <div class="post_action_bar">
                                                                <span><a href="UpdateDetail.aspx?ID=<%#Eval("K_Id")%>" class="action-icons c-edit"></a></span>
                                                                <span><a href="Detail.aspx?op=delete&ID=<%#Eval("K_Id")%>" class="action-icons c-Delete mrg"></a></span>
                                                            </div>
                                                        </div>
                                                    </div>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                        <div>
                                            <div class="btn_30_blue">								
                                              <span><a href="AddDetail.aspx?ID=<%#Eval("K_Id")%>">EKLE</a></span>
                                        </div>
                                   
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <span class="clear"></span>
        </div>
                </div>
            </div>
    </div>
</asp:Content>
