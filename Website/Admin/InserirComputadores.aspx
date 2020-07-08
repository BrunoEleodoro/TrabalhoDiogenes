<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InserirComputadores.aspx.cs" Inherits="Website.Admin.InserirComputadores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
			<div class="content-wrapper margin-top-60px">
						<div class="row">
									<!-- FORM DE CADASTRO -->
									<div class="col-6 box-padding box-border">
												<h2>CADASTRO DE COMPUTADORES</h2>
												<br />
												<div style="float: right">
															<asp:Label ID="Codigo" Font-Bold="true" Font-Size="30px" runat="server"></asp:Label>
												</div>
												<br />
												<label>NOME DO COMPUTADOR</label>
												<asp:TextBox ID="Nome" MaxLength="255" runat="server"></asp:TextBox>
												<label>ENDEREÇO</label>
												<asp:TextBox ID="Endereco" MaxLength="255" runat="server"></asp:TextBox>
												<label>ANOTAÇÕES</label>
												<asp:TextBox ID="Anotacoes" MaxLength="255" TextMode="MultiLine" Rows="4" runat="server"></asp:TextBox>
												<br />
												<br />
												<asp:Button ID="Salvar" OnClick="Salvar_Click" runat="server" Text="Salvar" />
												<asp:Button ID="Excluir" Visible="false" OnClick="Excluir_Click" runat="server" Text="Excluir" />
												<asp:Button ID="Cancelar" Visible="false" OnClick="Cancelar_Click" runat="server" Text="Cancelar" />
												<br />
												<br />
												<asp:Label ID="Mensagem" runat="server" ForeColor="red"></asp:Label>
												<br />
												<br />
									</div>
									<!-- EXIBIR OS CADASTRADOS -->
									<div class="col-6 box-padding box-border">
												<h2>COMPUTADORES</h2>
												<br />
												<asp:TextBox ID="BuscarComputador" Style="max-width:300px; display:inline;" runat="server"></asp:TextBox>
												<asp:Button ID="Buscar" OnClick="Buscar_Click" runat="server" Text="Buscar" />
												<asp:Button ID="CancelarBuscar" Visible="false" OnClick="CancelarBuscar_Click"  runat="server" Text="X" />
												<br /><br />
												<asp:Panel ID="Panel1" ScrollBars="Vertical" Height="500px" runat="server">
															<asp:GridView ID="Computadores" OnSelectedIndexChanged="Computadores_SelectedIndexChanged" AutoGenerateSelectButton="true" Width="100%" AutoGenerateColumns="true" CellPadding="8" HeaderStyle-BackColor="#dfdfdf" BorderColor="#cccccc" runat="server"></asp:GridView>
												</asp:Panel>
									</div>
						</div>
			</div>
</asp:Content>
