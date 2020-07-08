<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contato.aspx.cs" Inherits="Website.Contato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
			<div class="content-wrapper">
						<div class="row margin-top-60px">
									<!-- FORMULÁRIO DE DADOS -->
									<div class="col-6" style="background-color: white;border-radius: 5px;">
												<div class="box-padding">
															<h1>Fale Conosco</h1>
															<hr />
															<asp:Label ID="Erro" ForeColor="red" runat="server"></asp:Label>
															<br />
															<label>Mensagem</label>
															<asp:TextBox ID="Mensagem" runat="server" TextMode="MultiLine" Rows="6"></asp:TextBox>
															<label>Nome</label>
															<asp:TextBox ID="SeuNome" runat="server"></asp:TextBox>
															<label>E-mail</label>
															<asp:TextBox ID="SeuEmail" runat="server"></asp:TextBox>
															<br />
															<br />
															<asp:Button ID="Enviar" runat="server" OnClick="Enviar_Click" Text="Enviar" />
															<br />
															<br />
												</div>
									</div>
									<!-- EXIBE O MAPA DO GOOGLE -->
									<div class="col-6">
												<div class="box-padding">
															<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3679.689238352258!2d-47.35252258503734!3d-22.73978918509698!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94c89bea5cdb94f9%3A0xffb368bd91ea12ae!2sFatec%20Americana%20-%20Faculdade%20de%20Tecnologia%20de%20Americana!5e0!3m2!1spt-BR!2sbr!4v1589330157549!5m2!1spt-BR!2sbr" width="100%" height="600" frameborder="0" style="border: 0;" allowfullscreen="" aria-hidden="false" tabindex="0"></iframe>
												</div>
									</div>
						</div>
			</div>
</asp:Content>
