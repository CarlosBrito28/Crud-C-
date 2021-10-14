<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="NuevaClave.aspx.cs" Inherits="Prueba3.NuevaClave" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Login.css" rel="stylesheet" />
    <div id="NuevaClave">
        <h3 class="text-center mt-5 pt-5">Nueva Clave</h3>
        <div class="container-fluid">
            <div id="login-row" class="row justify-content-center align-items-center">
                <div id="login-column" class="col-md-6">
                    <div id="login-box" class="col-md-12 pb-4">
                        <form id="login-form" class="form">
                            <div class="form-group pb-4">
                                <label for="txtRut">Ingrese Rut:</label><br>
                                <asp:TextBox ID="txtRut" runat="server" class="form-control" autocomplete="off" autofocus="on" required="on"></asp:TextBox>
                            </div>
                            <div class="form-group pb-4">
                                <label for="txtPassword">Ingrese Clave Nueva:</label><br>
                                <asp:TextBox ID="txtPassword" runat="server" class="form-control" autocomplete="off" required="on"></asp:TextBox>
                            </div>
                            <div class="text-center">
                                <asp:Button ID="Aceptar" runat="server" OnClick="Aceptar_Click" Text="Aceptar" CssClass="btn btn-info btn-md mb-5" />
                            </div>
                    </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
