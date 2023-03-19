<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="KayitveDogrulama.Scripts.Result" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="grid-container">
            <div class="grid_12 text-center" style="margin-top: 100px;">
                <div class="alert-info" role="alert">
                    <h4 class="alert-heading">Tebrikler!</h4>
                    <p>TC Kimlik Numaranız kontrol edildi ve sisteme başarıyla kaydedildi.</p>
                    <hr>
                    <p class="mb-0">Yeniden kayıt oluşturmak istersniz <a href="SignUp.aspx" class="alert-link">bu linkten</a> kayıt sayfamıza ulaşabilirsiniz.</p>
                    <br />
                    <p>İyi Günler Dileriz...</p>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
