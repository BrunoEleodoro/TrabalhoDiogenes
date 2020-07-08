<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExecutarPing.aspx.cs" Inherits="Website.ExecutarPing" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
			<div class="content-wrapper margin-top-60px">
						<h2>Testar a conectividade de um equipamento</h2>
						<br />
						<hr />
						<br />
						<div class="row">
									<!-- COLUNA 1 -->
									<div class="col-6 box-padding">
												<h3>PING</h3>
												<br />
												<label>DIGITE O ENDEREÇO</label>
												<asp:TextBox ID="Endereco" runat="server"></asp:TextBox>
												<br />
												<br />
												<asp:Button ID="Enviar" OnClick="Enviar_Click" runat="server" Text="Enviar" />
									</div>
									<!-- COLUNA 2-->
									<div class="col-6 box-padding">
												<p>Ping ou latência, é um utilitário que utiliza o protocolo ICMP para testar a conectividade entre equipamentos. É um comando disponível praticamente em todos os sistemas operacionais. Seu funcionamento consiste no envio de pacotes para o equipamento de destino e na "escuta" das respostas. Se o equipamento de destino estiver ativo, uma resposta é devolvida ao computador solicitante.</p>
												<br />
												<br />
												<asp:Label ID="Resposta" ForeColor="#333333" runat="server"></asp:Label>
									</div>
						</div>
			</div>
</asp:Content>
