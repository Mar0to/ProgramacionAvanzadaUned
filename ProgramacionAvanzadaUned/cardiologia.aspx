<%@ Page Title="" Language="C#" MasterPageFile="~/InicioSinSesion.Master" AutoEventWireup="true" CodeBehind="cardiologia.aspx.cs" Inherits="ProgramacionAvanzadaUned.cardiologia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="container" id="centrado">
		<section class="row">
			<article class="col">
				<h5 class="h3 mb-3 font-weight-normal"><strong>Cardiología</strong></h5>
				<img src="img/cardiología.png" alt="imagen de cardiología" class="imagen">
				<p id="parrafos" class="textocentrado">El hospital metropolitano 506, se enorgullece de contar con el servicio de 
				ortopedia más completo del país, el cual está a la vanguardia de todos los 
				procesos requeridos para cualquier tipo de problema.</p>
	
				<p id="parrafos" class="textocentrado">Contamos con profesionales de la más alta calidad los cuales estarán a
				su servicio en el momento que así lo desee.</p>
	
				<p id="parrafos" class="textocentrado">Para poder reservar una cita, se debe de iniciar sesión, o de lo contrario
				registrarse en nuestro sitio web, con la finalidad de poder hacer su reserva.</p>

				<asp:Button runat="server" CssClass="boton-ver col-2" Text="Iniciar Sesión" ID="btnSesion" OnClick="btnSesion_Click"/>
			</article>
		</section>
		<br>
	</main>

    
</asp:Content>
