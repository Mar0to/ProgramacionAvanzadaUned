<%@ Page Title="" Language="C#" MasterPageFile="~/InicioSinSesion.Master" AutoEventWireup="true" CodeBehind="IniciarSesion.aspx.cs" Inherits="ProgramacionAvanzadaUned.IniciarSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="container" id="centrado">
			<br>
			<img src="img/Logo sin fondo.jpg" class="imagen">
			<h5 class="h3 mb-3 font-weight-normal"><strong>Iniciar Sesión</strong></h5>
			<section class="row" id="Form">
				<article class="col-lg-6" id="Registro">
					<label id="parrafos">Usuario:</label>
						<asp:TextBox runat="server" TextMode="SingleLine" CssClass="form-control" ID="txtUsuario"></asp:TextBox>
				</article>
				<article class="col-lg-6" id="Registro">
					<label id="parrafos">Clave:</label><asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="form-control"></asp:TextBox>
				</article>
			</section>
			<section class="row">
				<asp:Button runat="server" CssClass="offset-lg-1 col-lg-4 boton-ver col-sm-4 col-3" 
					Text="Iniciar Sesion" ID="btnIniciarSesion" OnClick="btnIniciarSesion_Click"/>
				<asp:Button runat="server" CssClass="col-lg-4 boton-ver col-sm-4 col-3" Text="Registrarse"
					ID="btnCancelar" OnClick="btnCancelar_Click"/>
			</section>
			<br>
	</main>
</asp:Content>
