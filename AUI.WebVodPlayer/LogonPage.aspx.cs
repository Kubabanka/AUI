using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseAccess;

namespace AUI.WebVodPlayer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            LoginTextbox.Text = LoginTextbox.Text.Trim();
            PasswordTextBox.Text = PasswordTextBox.Text.Trim();

            if (Global.database.Users.Any(u => u.Login == LoginTextbox.Text && u.Password == PasswordTextBox.Text))
            {
                FormsAuthentication.RedirectFromLoginPage
                    (LoginTextbox.Text, PersistCheckbox.Checked);
            }
            else
            {
                InvalidCredentialsLabel.Text = "Invalid credentials. Please try again.";
            }
        }
    }
}