<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Website.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
			<div class="content-wrapper">
						<div class="flexslider">
									<ul class="slides">
												<li>
														<img src="images/banner1.png" />
												</li>
												<li>
														<img src="images/banner2.png" />
												</li>
												<li>
														<img src="images/banner3.png" />
												</li>
									</ul>
						</div>
						<script type="text/javascript">
									$(window).load(function () {
												$('.flexslider').flexslider({
															animation: "slide"
												});
									});
						</script>
						<div class="row margin-top-60px" style="background-color: white">
									<div class="col-3">
												<div class="box-padding">
															<div class="center">
																		<img src="https://www.centrify.com/sites/default/files/styles/statement_item_selector_image_2x/public/2020-05/home-page-cloud.png?itok=nwnundDO" width="240"/>
															</div>
															<h2>Transformação na Nuvem</h2>
															<hr />
															<p>
																		Oferecemos todo o suporte na migracao da sua infraestrutura para a cloud utilizando nossos servicos criptografados com PGP e altissima seguranca de ponta-a-ponta.
															</p>
												</div>
									</div>
									<div class="col-3">
												<div class="box-padding">
															<div class="center">
																		<img src="https://www.centrify.com/sites/default/files/styles/statement_item_selector_image_2x/public/2020-05/home-page-sra.png?itok=6Jp7W58H" width="240" />
															</div>
															<hr />
															<h3>Acesso Remoto</h3>
															Atraves de nossa VPN, temos mais de 50 nos de criptografia entre o cliente e o servidor, trazendo 99.9% de garantia de uptime e seguranca para o trabalho remoto especialmente em tempos de pandemia.
												</div>
									</div>
									<div class="col-3">
												<div class="box-padding">
															<div class="center">
																		<img src="https://www.centrify.com/sites/default/files/styles/statement_item_selector_image_2x/public/2020-05/home-page-audit.png?itok=JG-GzKI5" width="240" />
															</div>
															<hr />
															<h3>Compliance</h3>
															<p>
																		Somos uma empresa certificada ISO 27001, com todo o suporte para oferecer na adequacao dos seus processos e produtos da sua empresa.
															</p>
												</div>
									</div>
									<div class="col-3">
												<div class="box-padding">
															<div class="center">
																		<img src="https://www.centrify.com/sites/default/files/styles/statement_item_selector_image_2x/public/2020-05/home-page-UNIX.png?itok=VRiYIC9Z" width="240" />
															</div>
															<hr />
															<h3>Identidade</h3>
															<p>
																		Com nossos sistemas, oferecemos uma variedade de autenticadores que sao altamente seguros e com criptografia de ponta-a-ponta, trazendo uma agilidade e seguranca na auditoria.
															</p>
												</div>
									</div>
						</div>
			</div>
</asp:Content>
