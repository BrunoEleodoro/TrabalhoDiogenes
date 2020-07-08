using System;
using System.Web;
// Não se esqueça de colocar a biblioteca AppDatabase.DLL nas referencias do projeto

namespace Website.Admin
{
			public partial class InserirComputadores : System.Web.UI.Page
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

						// SALVA/EDITA OS DADOS NO BANCO DE DADOS
						protected void Salvar_Click(object sender, EventArgs e)
						{
									try
									{
												string comando = "";

												if (Codigo.Text == "")
												{
															// 2. CRIA A STRING DE COMANDO SQL PARA INSEIR UMA LINHA
															comando = "INSERT INTO Computadores(Nome,Endereco,Anotacoes) VALUES('" + Nome.Text + "','" + Endereco.Text + "','" + Anotacoes.Text + "');";
												}
												else
												{
															// 2. COMANDO PARA EDITAR A LINHA SELECIONADA
															comando = "UPDATE Computadores SET Nome='" + Nome.Text + "',Endereco='" + Endereco.Text + "',Anotacoes='" + Anotacoes.Text + "' WHERE Codigo=" + Codigo.Text;
												}
												// 3. ENVIAR O COMANDO AO BANCO DE DADOS
												AppDatabase.OleDBTransaction db = new AppDatabase.OleDBTransaction();
												db.ConnectionString = conexao;
												db.Query(comando);

												ExibirComputadores();
									}
									catch (Exception ex)
									{
												Mensagem.Text = "Houve uma falha ao gravar o registro; " + ex.Message;
												App_Code.RecoverExceptions re = new App_Code.RecoverExceptions();
												re.SaveException(ex);
									}
						}

						// EXIBE OS DADOS NO GRIDVIEW
						protected void ExibirComputadores()
						{
									string comando = "SELECT Codigo,Nome,Endereco FROM Computadores WHERE Nome+' '+Endereco LIKE '%" + BuscarComputador.Text + "%' ORDER BY Nome;";

									AppDatabase.OleDBTransaction db = new AppDatabase.OleDBTransaction();
									db.ConnectionString = conexao;
									System.Data.DataTable tb = new System.Data.DataTable();

									tb = (System.Data.DataTable)db.Query(comando);

									Computadores.DataSource = tb;
									Computadores.DataBind();

									tb.Dispose();

									Codigo.Text = "";
									Nome.Text = "";
									Endereco.Text = "";
									Anotacoes.Text = "";
									Excluir.Visible = false;
									Cancelar.Visible = false;
						}

						protected void Computadores_SelectedIndexChanged(object sender, EventArgs e)
						{
									// coloca o valor do código no controle de formulário "Codigo"
									Codigo.Text = Computadores.SelectedRow.Cells[1].Text;

									string comando = "SELECT * FROM Computadores WHERE Codigo=" + Codigo.Text;
									AppDatabase.OleDBTransaction db = new AppDatabase.OleDBTransaction();
									db.ConnectionString = conexao;
									System.Data.DataTable tb = (System.Data.DataTable)db.Query(comando);

									if (tb.Rows.Count == 1)
									{
												Nome.Text = tb.Rows[0]["Nome"].ToString();
												Endereco.Text = tb.Rows[0]["Endereco"].ToString();
												Anotacoes.Text = tb.Rows[0]["Anotacoes"].ToString();

												tb.Dispose();
												Excluir.Visible = true;
												Cancelar.Visible = true;
									}
						}

						protected void Excluir_Click(object sender, EventArgs e)
						{
									// 2. CRIA O COMANDO PARA EXCLUIR O REGISTRO
									string comando = "DELETE FROM Computadores WHERE Codigo=" + Codigo.Text;

									// 3. ENVIAR O COMANDO AO BANCO DE DADOS
									AppDatabase.OleDBTransaction db = new AppDatabase.OleDBTransaction();
									db.ConnectionString = conexao;
									db.Query(comando);

								ExibirComputadores();
						}

						protected void Cancelar_Click(object sender, EventArgs e)
						{
									Codigo.Text = "";
									Nome.Text = "";
									Endereco.Text = "";
									Anotacoes.Text = "";
									Excluir.Visible = false;
									Cancelar.Visible = false;
						}

						protected void Buscar_Click(object sender, EventArgs e)
						{
									string comando = "SELECT Codigo,Nome,Endereco FROM Computadores WHERE Nome+' '+Endereco LIKE '%"+ BuscarComputador.Text + "%'ORDER BY Nome;";

									AppDatabase.OleDBTransaction db = new AppDatabase.OleDBTransaction();
									db.ConnectionString = conexao;
									System.Data.DataTable tb = (System.Data.DataTable)db.Query(comando);

									Computadores.DataSource = tb;
									Computadores.DataBind();

									tb.Dispose();
									CancelarBuscar.Visible = true;
						}

						protected void CancelarBuscar_Click(object sender, EventArgs e)
						{
									BuscarComputador.Text = "";
									CancelarBuscar.Visible = false;
									ExibirComputadores();
						}
			}
}