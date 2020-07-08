<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewLog.aspx.cs" Inherits="Website.Admin.ViewLog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
			<div class="content-wrapper margin-top-60px">
						<h1>LOG DE EXCEÇÕES OCORRIDAS NA APLICAÇÃO WEB</h1>
						<hr />
						<br />
						<br />
						<asp:Label ID="Resultado" Font-Size="16px" runat="server"></asp:Label>
			</div>
</asp:Content>
