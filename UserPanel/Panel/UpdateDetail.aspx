<%@ Page Title="" Language="C#" MasterPageFile="~/Panel/Main.Master" AutoEventWireup="true" CodeBehind="UpdateDetail.aspx.cs" Inherits="UserPanel.Panel.UpdateDetail" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div id="tab1">
                                <h3>Post/Edit Your Content Here</h3>
                                <p>
                                    Cras erat diam, consequat quis tincidunt nec, eleifend a turpis. Aliquam ultrices feugiat metus, ut imperdiet erat mollis at. Curabitur mattis risus sagittis nibh lobortis vel.
                                </p>
                                <div id="form1" action="#" method="post" class="form_container left_label field_set">
                                    <fieldset>
                                        <legend>Content</legend>
                                        <ul>
                                            <li>
                                                <div class="form_grid_12">
                                                    <label class="field_title">Menü ID</label>
                                                    <div class="form_input">
                                                        <asp:TextBox runat="server" ID="txtMenuId" type="text" TabIndex="1" class="limiter" />
                                                        <span class="input_instruction green">This is an instruction</span>
                                                    </div>
                                                </div>
                                            </li>
                                            <li>
                                                <div class="form_grid_12">
                                                    <label class="field_title">Description <span class="label_intro">Please Give Full Description Here</span></label>
                                                    <div class="form_input">
                                                        <CKEditor:CKEditorControl ID="txtCK" runat="server"></CKEditor:CKEditorControl>
                                                    </div>
                                                </div>
                                            </li>
                                            <%--<li>
										<div class="form_grid_12">
											<label class="field_title">Tags </label>
											<div class="form_input">
												<input id="tags_1" type="text" class="tags" value="foo,bar,baz,roffle"/>
											</div>
										</div>
										</li>--%>
                                        </ul>
                                    </fieldset>
                                    <ul>
                                        <li>
                                            <div class="form_grid_12">
                                                <div class="form_input">
                                                    <asp:Button runat="server" Text="Ekle" ID="btnUpdate" OnClick="btnUpdate_Click" class="btn_small btn_blue"></asp:Button>
                                                </div>
                                            </div>
                                        </li>
                                    </ul>
                                </div>
                            </div>
</asp:Content>
