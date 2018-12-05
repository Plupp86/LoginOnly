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
	public partial class Login : System.Web.UI.Page
	{
		UserHandler _userHandler = new UserHandler();

		protected void Page_Load(object sender, EventArgs e)
		{
			userNameError.Style.Value = "display:none";
			passwordError.Style.Value = "display:none";


			//if (Request.IsAuthenticated)
			//{
			//	WelcomeBackMessage.Text = "Welcome back, " + User.Identity.Name + "!";

			//	AuthenticatedMessagePanel.Visible = true;
			//	AnonymousMessagePanel.Visible = false;
			//}
			//else
			//{
			//	AuthenticatedMessagePanel.Visible = false;
			//	AnonymousMessagePanel.Visible = true;
			//}
		}

		protected void submit_Click(object sender, EventArgs e)
		{
			LoginResponse loginResponse = _userHandler.Login(userName.Value, password.Value);
			if (!loginResponse.UserNameExists)
			{
				userNameError.Style.Value = "display:block; color: red;";
			}
			else if (!loginResponse.PasswordMatch)
			{
				passwordError.Style.Value = "display:block; color: red;";
			}
			else
			{
				FormsAuthentication.RedirectFromLoginPage(userName.Value, true);
			}
		}
	}
}