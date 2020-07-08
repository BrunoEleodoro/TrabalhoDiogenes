<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TesteComputadores.aspx.cs" Inherits="Website.Admin.TesteComputadores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
			<div class="content-wrapper margin-top-60px">
						<div class="row">
									<!-- COMPUTADORES-->
									<div class="col-6 box-padding box-border">
												<div style="float: left;">
															<h2>COMPUTADORES</h2>
												</div>
												<div style="float: right;">
															<asp:Button ID="ExecutarPing" OnClick="ExecutarPing_Click" runat="server" Text="Executar" />
												</div>
												<div style="clear: both;"></div>
												<br />
												<asp:TextBox ID="BuscarComputador" Style="max-width: 300px; display: inline;" runat="server"></asp:TextBox>
												<asp:Button ID="Buscar" OnClick="Buscar_Click" runat="server" Text="Buscar" />
												<asp:Button ID="CancelarBusca" Visible="false" OnClick="CancelarBusca_Click"  runat="server" Text="X" />
												<br />
												<br />
												<asp:Panel ID="Panel2" ScrollBars="Vertical" Height="500px" runat="server">
															<asp:GridView ID="Computadores" Width="100%" AutoGenerateColumns="true" CellPadding="8" HeaderStyle-BackColor="#dfdfdf" BorderColor="#cccccc" runat="server"></asp:GridView>
												</asp:Panel>
									</div>
									<!-- RESULTADO DO TESTE DE CONEXÃO -->
									<div class="col-6 box-padding box-border">
												<h2>STATUS DOS COMPUTADORES</h2>
												<br />
												<br />
												<asp:Panel ID="Panel1" ScrollBars="Vertical" Height="500px" runat="server">
															<asp:Label ID="Resposta" runat="server"></asp:Label>
												</asp:Panel>
									</div>
						</div>
			</div>
</asp:Content>
