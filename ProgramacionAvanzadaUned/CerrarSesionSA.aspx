<%@ Page Title="" Language="C#" MasterPageFile="~/InicioSesionIniciada.Master" AutoEventWireup="true" CodeBehind="CerrarSesionSA.aspx.cs" Inherits="ProgramacionAvanzadaUned.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <main class="container" id="centrado">
        <section class="row">
            <article class="col">
                <h5 id="titulos"><strong>¿Desea realmente cerrar sesión?</strong></h5>
                <section class="row">
                    <asp:Button runat="server" CssClass="col-lg-4 boton-ver col-sm-4 col-3" Text="Sí" ID="btnCerrarSesion" OnClick="btnCerrarSesion_Click"/>
                    <asp:Button runat="server" CssClass="col-lg-4 boton-ver col-sm-4 col-3" Text="No" ID="btnCancelar" OnClick="btnCancelar_Click"/>
                    <br />
                </section>  
            </article>
        </section>
         <br />
    </main>
</asp:Content>
