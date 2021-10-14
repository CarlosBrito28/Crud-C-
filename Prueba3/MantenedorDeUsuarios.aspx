<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="MantenedorDeUsuarios.aspx.cs" Inherits="Prueba3.MantenedorDeUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <link href="Login.css" rel="stylesheet" />
    <div id="MantenedorDeUsuarios">
        <h3 class="text-center mt-5 pt-5">Usuarios.CB</h3>
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
                                <asp:TextBox ID="txtNombre" runat="server" class="form-control" autocomplete="off" ></asp:TextBox>
                            </div>
                            <div class="form-group pb-4">
                                <label for="txtEdad">Edad del usuario:</label><br>
                                <asp:TextBox ID="txtEdad" runat="server" class="form-control" type="number" autocomplete="off" ></asp:TextBox>
                            </div>
                            <div class="form-group pb-4">
                                <label for="password">Contraseña:</label><br />


                                <asp:TextBox ID="txtPassword" runat="server" class="form-control" autocomplete="off" ></asp:TextBox>
                            </div>
                            <div class="form-group text-center">
                            </div>
                              <div>
                                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" CssClass="btn btn-info btn-md" />
                                <asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar" CssClass="btn btn-info btn-md" />
                                <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" CssClass="btn btn-info btn-md" />
                            </div>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
