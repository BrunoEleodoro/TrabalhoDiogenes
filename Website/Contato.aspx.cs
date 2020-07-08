using System;
using System.Net;
using System.Net.Mail;

namespace Website
{
			public partial class Contato : System.Web.UI.Page
			{
						protected void Page_Load(object sender, EventArgs e)
						{
									// executado quando o form é chamado pelo usuário
									//...
						}

						protected void Enviar_Click(object sender, EventArgs e)
						{
									try
									{
												// codigo para enviar o email
												// 1. Fazer a validação dos dados
												if (Mensagem.Text.Trim() == "")
												{
															Erro.Text = "A mensagem deve ser informada";
												}
												else if (SeuNome.Text.Trim() == "")
												{
															Erro.Text = "O seu nome deve ser informado";
												}
												else if (SeuEmail.Text.Trim() == "")
												{
															Erro.Text = "O seu e-mail deve ser informado";
												}
												else
												{
															// 2. Criar o pacote do e-mail 
															MailMessage email = new MailMessage();
															email.Subject = "FALE CONOSCO";
															email.To.Add("contato@seudominio.com.br");
															MailAddress from = new MailAddress("contato@seudominio.com.br");
															email.From = from;
															email.Body = "MENSAGEM ENVIADA PELO FORM FALE CONOSCO\n";
															email.Body += "Nome: " + SeuNome.Text + "\n";
															email.Body += "Email: " + SeuEmail.Text + "\n";
															email.Body += "Mensagem: " + Mensagem.Text + "\n";
															email.IsBodyHtml = false;
															// 3. Transmitir o pacote do email via protocolo SMTP
															SmtpClient smtp = new SmtpClient();
															smtp.Host = "smtp.seudominio.com.br";
															smtp.Port = 587;
															smtp.EnableSsl = true;
															smtp.Credentials = new NetworkCredential("contato@seudominio.com.br", "sua senha");
															smtp.Send(email);
															// fim
												}
									}
									catch (Exception ex)
									{
												Erro.Text = "Houve uma falha ao enviar o e-mail";
												// Grave a exceção no banco de dados
												// Envie os dados da exceção para o seu e-mail
												App_Code.RecoverExceptions re = new App_Code.RecoverExceptions();
												re.SaveException(ex);
									}
						}
			}
}