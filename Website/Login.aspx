<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Website.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
			<div class="content-wrapper margin-top-60px">
						<div class="row">
									<div class="col-3 box-border box-padding" style="background-color: white;">
												<h2>Entrar</h2>
												<br />
												<asp:Label ID="Mensagem" runat="server" Font-Bold="true" Font-Size="16px" ForeColor="Red" ></asp:Label>
												<br />
												<label>LOGIN</label>
												<asp:TextBox ID="NomeLogin" runat="server"></asp:TextBox>
												<label>SENHA</label>
												<asp:TextBox ID="Senha" TextMode="Password" runat="server"></asp:TextBox>
												<br />
												<br />
												<asp:Button ID="Entrar" OnClick="Entrar_Click" runat="server" Text="Entrar" />
												<br />
									</div>
						</div>
			</div>
</asp:Content>
