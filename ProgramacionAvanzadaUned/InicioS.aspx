<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/InicioSinSesion.Master" AutoEventWireup="true" CodeBehind="InicioS.aspx.cs" Inherits="ProgramacionAvanzadaUned.InicioS1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="container" id="centrado">
		<section class="row">
			<article class="col">
            	<h5 id="titulos"><strong>Medicina General</strong></h5>
				<a href="MedicinaGeneral.html" id="ImagenesLogo"><img src="img/MedicinaGeneral.png" alt="MedicinaGeneral" class="imagen"/></a>
            	<p id="parrafos">Procedimiento quirúrgico electrivo. Ademá se debe realizar debido a sus grandes beneficios. Esto requiere una cuidadosa selección de pacientes a realizar.
			    </p>
				<asp:Button runat="server" CssClass="boton-ver" Text="Ver" ID="btnMedicinaG" OnClick="btnMedicinaG_Click"/> 	
			</article>
			<br/>
			<article class="col">
				<h5 id="titulos"><strong>Cirugía Ambulatoria</strong></h5>
				<a href="cirugiaAmbulatoria.html"><img src="img/CirugiaAmbulatoria.png" class="imagen"/></a>
				<p id="parrafos">Procedimiento quirúrgico electrivo. Ademá se debe realizar debido a sus grandes beneficios. 
				Esto requiere una cuidadosa selección de pacientes a realizar.</p>
				<asp:Button runat="server" CssClass="boton-ver" Text="Ver" ID="btnCirugia" OnClick="btnCirugia_Click"/>
				<br/>
			</article>
			<br/>
			<article class="col">
            	<h5 id="titulos"><strong>Nutrición</strong></h5>
				<a href="Nutricion.html"><img src="img/Nutricion.png" class="imagen"/></a>
            	<p id="parrafos">Procedimiento quirúrgico electrivo. Ademá se debe realizar debido a sus grandes beneficios. 
                Esto requiere una cuidadosa selección de pacientes a realizar.</p>
            	<asp:Button runat="server" CssClass="boton-ver" Text="Ver" ID="btnNutricion" OnClick="btnNutricion_Click"/>
			</article>
		</section>
		<section class="row">
			<article class="col">
				<br/>
				<h5 id="titulos"><strong>Psicología</strong></h5>
				<a href="psicologia.html"><img src="img/psicologia.png" class="imagen"/></a>
				<p id="parrafos">Procedimiento quirúrgico electrivo. Ademá se debe realizar debido a sus grandes beneficios. 
					Esto requiere una cuidadosa selección de pacientes a realizar.</p>
				<asp:Button runat="server" CssClass="boton-ver" Text="Ver" ID="btnPsicologia" OnClick="btnPsicologia_Click"/> 	
			</article>
			<br/>
			<article class="col">
				<br/>
				<h5 id="titulos"><strong>Ortopedia</strong></h5>
				<a href="ortopedia.html"><img src="img/Ortopedia.png" class="imagen"/></a>
				<p id="parrafos">Procedimiento quirúrgico electrivo. Ademá se debe realizar debido a sus grandes beneficios. 
					Esto requiere una cuidadosa selección de pacientes a realizar.</p>
				<asp:Button runat="server" CssClass="boton-ver" Text="Ver" ID="btnOrtopedia" OnClick="btnOrtopedia_Click"/> 	
			</article>
			<br/>
			<article class="col">
				<br/>
				<h5 id="titulos"><strong>Fisioterapia</strong></h5>
				<a href="Fisioterapia.html"><img src="img/fisioterapia.png" class="imagen"/></a>
				<p id="parrafos">Procedimiento quirúrgico electrivo. Ademá se debe realizar debido a sus grandes beneficios. 
					Esto requiere una cuidadosa selección de pacientes a realizar.</p>
				<asp:Button runat="server" CssClass="boton-ver" Text="Ver" ID="btnFisioterapia" OnClick="btnFisioterapia_Click"/> 	
			</article>
		</section>
		<br/>
		<section class="row">
			<article class="col">
				<br/>
            	<h5 id="titulos"><strong>Cardiología</strong></h5>
				<a href="cardiologia.html"><img src="img/Cardiología.png" class="imagen"/></a>
				<p id="parrafos">Procedimiento quirúrgico electrivo. Ademá se debe realizar debido a sus grandes beneficios. 
					Esto requiere una cuidadosa selección de pacientes a realizar.</p>
            	<asp:Button runat="server" CssClass="boton-ver" Text="Ver" ID="btnCardiologia" OnClick="btnVer_Click"/> 	
			</article>
			<br/>
			<article class="col">
				<br/>
            	<h5 id="titulos"><strong>Laboratorio</strong></h5>
				<a href="Laboratorio.html"><img src="img/laboratorio.png" class="imagen" alt="Imagen de laboratorio"/></a>
				<p id="parrafos">Procedimiento quirúrgico electrivo. Ademá se debe realizar debido a sus grandes beneficios. 
					Esto requiere una cuidadosa selección de pacientes a realizar.</p>
				<asp:Button runat="server" CssClass="boton-ver" Text="Ver" ID="btnLaboratorio" OnClick="btnLaboratorio_Click"/> 	
			</article>
			<article class="col">
				<br/>
            	<h5 id="titulos"><strong>Psiquiatría</strong></h5>
				<a href="Psiquiatria.html"><img src="img/psiquiatria.png" class="imagen"/></a>
				<p id="parrafos">Procedimiento quirúrgico electrivo. Ademá se debe realizar debido a sus grandes beneficios. 
					Esto requiere una cuidadosa selección de pacientes a realizar.</p>
            	<asp:Button runat="server" CssClass="boton-ver" Text="Ver" ID="btnPsiquiatria" OnClick="btnPsiquiatria_Click"/> 	
			</article>
		</section>
		<br/>
	</main>
</asp:Content>
