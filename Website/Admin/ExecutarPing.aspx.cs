using System;
// PROCESSAMENTO DE REDE (PING)
using System.Net.NetworkInformation;
using System.Drawing;

namespace Website
{
			public partial class ExecutarPing : System.Web.UI.Page
			{
						protected void Page_Load(object sender, EventArgs e)
						{

						}

						protected void Enviar_Click(object sender, EventArgs e)
						{
									try
									{
												//excutar o ping
												Ping envia = new Ping();
												PingReply retorno = envia.Send(Endereco.Text);

												if (retorno.Status == IPStatus.Success)
												{
															Resposta.Text = "<b>RESULTADO DO PING</b> <br/>";
															Resposta.Text += "Status: " + retorno.Status.ToString() + "<br/>";
															Resposta.Text += "Endereço IP: " + retorno.Address.ToString() + "<br/>";
															Resposta.Text += "Tempo: " + retorno.RoundtripTime.ToString() + "ms<br/>";
															Resposta.Text += "Tempo de vida: " + retorno.Options.Ttl.ToString() + "ms<br/>";
															Resposta.Text += "Tamanho do Buffer: " + retorno.Buffer.Length.ToString() + "<br/>";
															Resposta.ForeColor = Color.Black;

												}
												else
												{
															Resposta.Text = "FALHA NA EXECUÇÃO DO PING";
															Resposta.ForeColor = Color.Red;
												}
									}
									catch (Exception ex)
									{
												Resposta.Text = "FALHA NA EXECUÇÃO DO PING";
												Resposta.ForeColor = Color.Red;

												// Grave a exceção no banco de dados
												// Envie os dados da exceção para o seu e-mail
												App_Code.RecoverExceptions re = new App_Code.RecoverExceptions();
												re.SaveException(ex);

									}
						}
			}
}
