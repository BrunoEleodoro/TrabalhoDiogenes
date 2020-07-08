using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website.Admin
{
			public partial class ViewLog : System.Web.UI.Page
			{
						protected void Page_Load(object sender, EventArgs e)
						{
									// ler o arquivo de log.txt e colocar o conteudo no controle Resultado.
									//
									string caminho = HttpContext.Current.Server.MapPath("~/Admin/Exceptions/log.txt");
									Resultado.Text = System.IO.File.ReadAllText(caminho).Replace("\n","<br/>");

						}
			}
}