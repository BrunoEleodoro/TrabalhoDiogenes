using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
			public partial class Site : System.Web.UI.MasterPage
			{
						protected void Page_Load(object sender, EventArgs e)
						{
									if(Session["Usuario"] != null)
									{
												ViewLog.Visible = true;
												ExecutarPing.Visible = true;
												InserirComputadores.Visible = true;
												TesteComputadores.Visible = true;
												Login.Visible = false;
												Logout.Visible = true;
									}
									else
									{
												ViewLog.Visible = false;
												ExecutarPing.Visible = false;
												InserirComputadores.Visible = false;
												TesteComputadores.Visible = false;
												Login.Visible = true;
												Logout.Visible = false;
									}
						}
			}
}