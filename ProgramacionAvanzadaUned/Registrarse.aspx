<%@ Page Title="" Language="C#" MasterPageFile="~/InicioSinSesion.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="ProgramacionAvanzadaUned.Registrarse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="container" id="centrado">
			<br>
			<h5 class="h3 mb-3 font-weight-normal"><strong>Registrarse</strong></h5>
			<img src="img/Logo sin fondo.jpg" class="imagen">
			<section class="row" id="Form">
				<article class="col-lg-6">
					<label id="parrafos">Nombre:</label><asp:TextBox TextMode="SingleLine" CssClass="form-control" runat="server" ID="txtNombre" ></asp:TextBox>
					<label id="parrafos">Apellido(s):</label><asp:TextBox TextMode="SingleLine" CssClass="form-control" runat="server" ID="txtApellidos" ></asp:TextBox>
					<label id="parrafos">Teléfono:</label><asp:TextBox TextMode="SingleLine" CssClass="form-control" runat="server" ID="txtTelefono"></asp:TextBox>
					<label id="parrafos">Cédula:</label><asp:TextBox TextMode="SingleLine" CssClass="form-control" runat="server" ID="txtCedula"></asp:TextBox>
			</article>
			
			<article class="col-lg-6" >		
					<label id="parrafos">Fecha de nacimiento: </label><asp:TextBox ID="DateFechaNacimiento" TextMode="Date" CssClass="form-control" runat="server"></asp:TextBox>   
					<label id="parrafos">Usuario:</label><asp:TextBox TextMode="SingleLine" CssClass="form-control" runat="server" ID="txtUsuario"></asp:TextBox>
        			<label id="parrafos">Clave:</label> <asp:TextBox TextMode="Password" CssClass="form-control" runat="server" ID="txtClave"></asp:TextBox>
					<label id="parrafos">Re-ingresar clave: </label><asp:TextBox TextMode="Password" CssClass="form-control" runat="server" ID="txtClave2"></asp:TextBox>
				</article>
			</section>
			<br>
			<section class="row">
				<asp:Button CssClass="offset-lg-1 col-lg-4 boton-ver col-sm-4 col-3" ID="btnRegistro" OnClick="btnRegistro_Click" Text="Registrarse" runat="server"/>
				<asp:Button CssClass="col-lg-4 boton-ver col-sm-4 col-3" ID="btnInciarSesion" OnClick="btnInciarSesion_Click" TexT="Iniciar Sesión" runat="server" />
			</section>
	<br>
	</main>
</asp:Content>
