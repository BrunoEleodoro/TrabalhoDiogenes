using System;
using System.Web;
// PACOTE DE SEGURANÇA WEB DA APLICAÇÃO 
using System.Web.Security;

namespace Website
{
			public partial class Login : System.Web.UI.Page
			{
						protected void Page_Load(object sender, EventArgs e)
						{

						}

						protected void Entrar_Click(object sender, EventArgs e)
						{
									// VALIDAÇÃO DAS ENTRADAS
									if (NomeLogin.Text.Trim() == "")
									{
												Mensagem.Text = "Entre com o nome";
									}
									else if (Senha.Text.Trim() == "")
									{
												Mensagem.Text = "Entre com a senha";
									}
									else
									{
												if (NomeLogin.Text == "Admin" & Senha.Text == "12345")
												{
															Session["Usuario"] = "Admin";
															// Inicializa a classe de autenticação do server
															FormsAuthentication.Initialize();
															// cria o ticket de autenticação 
															FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, "Admin", DateTime.Now, DateTime.Now.AddMinutes(30), false, "Admin", FormsAuthentication.FormsCookiePath);
															Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket)));
															Response.Redirect("~/Default.aspx");
												}
												else
												{
															Mensagem.Text = "Dados de acesso invalidos";
												}
									}
						}
			}
}