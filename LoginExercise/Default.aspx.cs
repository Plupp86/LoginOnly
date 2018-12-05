using LoginExercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginExercise
{
	public partial class _Default : Page
	{
		UserHandler _userHandler = new UserHandler();

		protected void Page_Load(object sender, EventArgs e)
		{

			if (Request.IsAuthenticated)
			{
				WelcomeBackMessage.Text = "<h3>You are logged in as " + User.Identity.Name + "!";

				AuthenticatedMessagePanel.Visible = true;
				AnonymousMessagePanel.Visible = false;
			}
			else
			{
				AuthenticatedMessagePanel.Visible = false;
				AnonymousMessagePanel.Visible = true;
			}
		}




	}
}