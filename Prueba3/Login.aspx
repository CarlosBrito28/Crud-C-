<%@ Page Title="Login" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Prueba3.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Login.css" rel="stylesheet" />
    <div id="login">
        <h3 class="text-center mt-5 pt-5">Inicia Sesión</h3>
        <div class="container-fluid">
            <div id="login-row" class="row justify-content-center align-items-center">
                <div id="login-column" class="col-md-6">
                    <div id="login-box" class="col-md-12 pb-4">
                        <form id="login-form" class="form">
                            <div class="form-group pb-4">
                                <label for="txtNombre">Nombre de usuario:</label><br>
                                <asp:TextBox ID="txtNombre" runat="server" class="form-control" autocomplete="off" autofocus="on" required="on"></asp:TextBox>
                            </div>
                            <div class="form-group pb-4">
                                <label for="txtpassword">Contraseña:</label><br>
                                <asp:TextBox ID="txtPassword" runat="server" class="form-control" autocomplete="off"  required="on"></asp:TextBox>
                            </div>
                            <div class="form-group text-center">
                            </div>
                            <div class="text-center">
                                <asp:Button ID="Button1" runat="server" OnClick="ButtonLogin_Click" Text="Ingresar" CssClass="btn btn-info btn-md mb-5" />
                            </div>
                            <div class="text-center" id="register-link" >
                                <a href="Registro.aspx" class="text-info mt-5">Registrarse</a>
                            </div>
                    </div>
                     <div class="text-center" id="RecuperarPassword-link" >
                                <a href="RecuperacionDePassword.aspx" class="text-info">Recuperar Contraseña</a>
                            </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
