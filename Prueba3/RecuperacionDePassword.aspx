<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="RecuperacionDePassword.aspx.cs" Inherits="Prueba3.RecuperacionDePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Login.css" rel="stylesheet" />
    <div id="RecuperacionDePassword">
        <h3 class="text-center mt-5 pt-5">Preguntas de recuperación de contraseña</h3>
        <div class="container-fluid">
            <div id="login-row" class="row justify-content-center align-items-center">
                <div id="login-column" class="col-md-6">
                    <div id="login-box" class="col-md-12 pb-4">
                        <form id="login-form" class="form">
                            <div class="form-group pb-4">
                                <label for="txtNombre">Cual es su Nombre:</label><br>
                                <asp:TextBox ID="txtNombre" runat="server" class="form-control" autocomplete="off" autofocus="on" required="on"></asp:TextBox>
                            </div>
                            <div class="form-group pb-4">
                                <label for="txtEdad">Cual es su edad:</label><br>
                                <asp:TextBox ID="txtEdad" runat="server" class="form-control" type="number" autocomplete="off" required="on"></asp:TextBox>
                            </div>
                            <div class="form-group pb-4">
                                <label for="txtRut">Cual es su rut:</label><br />
                                <asp:TextBox ID="txtRut" runat="server" class="form-control" autocomplete="off" required="on"></asp:TextBox>
                            </div>
                            <div class="form-group text-center">
                            </div>
                            <div class="text-center">
                                <asp:Button ID="btnAceptar" runat="server" OnClick="RecuperarPassword_Click" Text="Aceptar" CssClass="btn btn-info btn-md mb-5" />
                            </div>
                    </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
