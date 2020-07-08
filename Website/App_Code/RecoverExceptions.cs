using System;
// para tratamento de arquivo e diretório
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace Website.App_Code
{
			/// <summary>
			/// Recupera e grava as exceções ocorridas na aplicação no arquivo de log.txt
			/// Envia os dados da exceção para o seu email.
			/// Modifique a propriedade deste arquivo "RecoverExceptions.cs" Build Action = Compile.
			/// </summary>
			public class RecoverExceptions
			{

						/// <summary>
						/// Salva os dados da ultima exceção ocorrida no arquivo "~/Exceptions/log.txt"
						/// </summary>
						/// <param name="ex">Estrutura de dados Exception</param>
						public void SaveException(Exception ex)
						{
									// 1. Construir uma string com os dados da exceção que deseja salvar
									string falha = DateTime.Now.ToString() + " - " + ex.Message + "\n";
									falha += "----------------------------------------------------------\n";
					
									// 2. Salva os dados da exceção no arquivo log.txt
									string caminho = HttpContext.Current.Server.MapPath("~/Admin/Exceptions/log.txt");
									File.AppendAllText(caminho, falha);

									// 3. Envia o email para o desenvolvedor
									// 2. Criar o pacote do e-mail 
									/*
									MailMessage email = new MailMessage();
									email.Subject = "EXCEÇÃO NA APLICAÇÃO WEB";
									email.To.Add("desenvolvedor@seudominio.com.br");
									MailAddress from = new MailAddress("desenvolvedor@seudominio.com.br");
									email.From = from;
									email.Body = "EXCEÇÃO NA APLICAÇÃO WEB\n";
									email.Body += falha;
									email.IsBodyHtml = false;
									// 3. Transmitir o pacote do email via protocolo SMTP
									SmtpClient smtp = new SmtpClient();
									smtp.Host = "smtp.seudominio.com.br";
									smtp.Port = 587;
									smtp.EnableSsl = true;
									smtp.Credentials = new NetworkCredential("desenvolvedor@seudominio.com.br", "sua senha");
									smtp.Send(email);
									*/
									// fim
						}
			}
}