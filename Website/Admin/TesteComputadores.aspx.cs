using System;
using System.Drawing;
using System.Web;

namespace Website.Admin
{
			public partial class TesteComputadores : System.Web.UI.Page
			{
						// 1. CONEXÃO COM O BANCO DE DADOS
						// Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\myFolder\myAccessFile.accdb;Persist Security Info=False;
						// endereço virtual do banco de dados: ~/App_Data/SINDB.accdb
						// STRING DE CONEXÃO
						static string local = HttpContext.Current.Server.MapPath("~/App_Data/SINDB.accdb");
						string conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + local + ";Persist Security Info=False;";

						protected void Page_Load(object sender, EventArgs e)
						{
									// indica que não será executado o método "ExibirComputadores" quando um botão é pressionado no form.
									if (!IsPostBack)
									{
												ExibirComputadores();
									}
						}

						// EXIBE OS DADOS NO GRIDVIEW
						protected void ExibirComputadores()
						{
									string comando = "SELECT Codigo,Nome,Endereco FROM Computadores ORDER BY Nome;";

									AppDatabase.OleDBTransaction db = new AppDatabase.OleDBTransaction();
									db.ConnectionString = conexao;
									System.Data.DataTable tb = new System.Data.DataTable();

									tb = (System.Data.DataTable)db.Query(comando);

									Computadores.DataSource = tb;
									Computadores.DataBind();

									tb.Dispose();
						}

						protected void ExecutarPing_Click(object sender, EventArgs e)
						{
									Resposta.Text = "";
									int totalLinhas = Computadores.Rows.Count;

									for (int i = 0; i <= totalLinhas - 1; i++)
									{
												string nome = Computadores.Rows[i].Cells[1].Text;
												string endereco = Computadores.Rows[i].Cells[2].Text;
												try
												{
															//excutar o ping
															System.Net.NetworkInformation.Ping envia = new System.Net.NetworkInformation.Ping();
															System.Net.NetworkInformation.PingReply retorno = envia.Send(endereco);

															if (retorno.Status == System.Net.NetworkInformation.IPStatus.Success)
															{

																		Resposta.Text += "Nome: " + nome + "<br/>";
																		Resposta.Text += "Endereço IP: " + retorno.Address.ToString() + "<br/>";
																		Resposta.Text += "Status: " + retorno.Status.ToString() + "<br/>";
																		Resposta.Text += "Tempo: " + retorno.RoundtripTime.ToString() + "ms<br/>";
																		Resposta.Text += "Tempo de vida: " + retorno.Options.Ttl.ToString() + "ms<br/>";
																		Resposta.Text += "Tamanho do Buffer: " + retorno.Buffer.Length.ToString() + "Bytes<br/>";
															}
															else
															{
																		Resposta.Text += "Nome: " + nome + "<br/>";
																		Resposta.Text += "Endereço: " + endereco + "<br/>";
																		Resposta.Text += "<b>FALHA NA CONEXÃO</b>";
															}
												}
												catch (Exception ex)
												{
															Resposta.Text += "Nome: " + nome + "<br/>";
															Resposta.Text += "Endereço: " + endereco + "<br/>";
															Resposta.Text += "<b>FALHA NA CONEXÃO</b>";

															// Grave a exceção no banco de dados
															// Envie os dados da exceção para o seu e-mail
															App_Code.RecoverExceptions re = new App_Code.RecoverExceptions();
															re.SaveException(ex);
												}
												Resposta.Text += "<hr><br/>";
									}
						}

						protected void Buscar_Click(object sender, EventArgs e)
						{
									string comando = "SELECT Codigo,Nome,Endereco FROM Computadores WHERE Nome+' '+Endereco LIKE '%" + BuscarComputador.Text + "%';";

									AppDatabase.OleDBTransaction db = new AppDatabase.OleDBTransaction();
									db.ConnectionString = conexao;
									System.Data.DataTable tb = (System.Data.DataTable)db.Query(comando);

									Computadores.DataSource = tb;
									Computadores.DataBind();

									tb.Dispose();
									CancelarBusca.Visible = true;

						}

						protected void CancelarBusca_Click(object sender, EventArgs e)
						{
									BuscarComputador.Text = "";
									CancelarBusca.Visible = false;
									ExibirComputadores();
						}
			}
}