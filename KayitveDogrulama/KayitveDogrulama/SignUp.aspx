<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="KayitveDogrulama.SignUp" %>

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
                        <h6>Kayıt Oluştur</h6>
                    </div>
                    <div class="widget_content">
                        <div action="#" method="post" class="form_container">
                            <ul>
                                <li>
                                    <div class="form_grid_12">
                                        <label class="field_title">TC Kimlik No</label>

                                        <div class="form_input">
                                            <asp:TextBox type="number" TextMode="Number"  min="0" placeholder="TC Kimlik No" TabIndex="1" ID="txtTCNo" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </li>
                                <li>
                                    <div class="form_grid_12">
                                        <label class="field_title">Kullanıcı Adı</label>

                                        <div class="form_input">
                                            <asp:TextBox type="text" style="text-transform:uppercase" placeholder="Ad" TabIndex="1" ID="txtName" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </li>
                                <li>
                                    <div class="form_grid_12">
                                        <label class="field_title">Kullanıcı Soyadı</label>

                                        <div class="form_input">
                                            <asp:TextBox type="text" style="text-transform:uppercase" TabIndex="1" placeholder="Soyad" ID="txtSurname" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </li>
                                <li>
                                    <div class="form_grid_12">
                                        <label class="field_title">Telefon Numarası</label>

                                        <div class="form_input">
                                            <asp:TextBox type="number" TextMode="Number" min="0" placeholder="Telefon Numarası" TabIndex="1" ID="txtPhoneNumber" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </li>                                
                                <li>
                                    <div class="form_grid_12">
                                        <label class="field_title">Doğum Tarihi</label>
                                        <div class="form_input">
                                            <asp:TextBox TextMode="Date" TabIndex="1" ID="txtBirthDate" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </li>                               
                            </ul>
                            <div class="form_grid_12 " style="margin-left:50px; margin-bottom:20px;">
                             <a href="Result.aspx"> <asp:Button  Font-Bold="true" BorderColor="#cccccc" ForeColor="#666666" BackColor="#ccffff" runat="server" id="btnSignUp" Text="Kayıt Ol"  OnClick="btnSignUp_Click" /> </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>


