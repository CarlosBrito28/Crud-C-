<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Prueba3.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Login.css" rel="stylesheet" />
    <div id="Registro">
        <h3 class="text-center mt-5 pt-5">Registro de Usuarios</h3>
        <div class="container-fluid">
            <div id="login-row" class="row justify-content-center align-items-center">
                <div id="login-column" class="col-md-6">
                    <div id="login-box" class="col-md-12 pb-4">
                        <form id="login-form" class="form">
                            <div class="form-group pb-4">
                                <label for="txtRut">Rut del usuario:</label><br>
                                <asp:TextBox ID="txtRut" runat="server" class="form-control" autocomplete="off" autofocus="on" required="on"></asp:TextBox>
                            </div>
                            <div class="form-group pb-4">
                                <label for="txtNombre">Nombre de usuario:</label><br>
                                <asp:TextBox ID="txtNombre" runat="server" class="form-control" autocomplete="off" required="on"></asp:TextBox>
                            </div>
                            <div class="form-group pb-4">
                                <label for="txtEdad">Edad del usuario:</label><br>
                                <asp:TextBox ID="txtEdad" runat="server" class="form-control" type="number" autocomplete="off" required="on"></asp:TextBox>
                            </div>
                            <div class="form-group pb-4">
                                <label for="txtPassword">Contraseña:</label><br />
                                <asp:TextBox ID="txtPassword" runat="server" class="form-control" autocomplete="off" required="on"></asp:TextBox>
                            </div>
                            <div class="form-group text-center">
                            </div>
                            <div>
                                <asp:Button ID="btnRegistro" runat="server" OnClick="Registro_Click" Text="Registrar" CssClass="btn btn-info btn-md" />
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
