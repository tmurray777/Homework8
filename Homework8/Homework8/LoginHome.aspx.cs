using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Homework8
{
    public partial class LoginHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            if (checkUsername(txtUsername.Text) & checkPassword(txtPassword.Text))
            {
                Response.Redirect("Home.aspx");
            }
        }

        public bool checkUsername(string text)
        {
            bool returnVal = false;

            if (text.Trim() == "")
            {
                returnVal = false;
                lblWarningUsername.Text = "Enter Valid Username";
            }
            else
            {
                returnVal = true;
                lblWarningUsername.Text = "";
            }

            return returnVal;
        }

        public bool checkPassword(string text)
        {
            bool returnVal = false;

            if (text.Trim() == "")
            {
                returnVal = false;
                lblWarningPassword.Text = "Enter Valid Password";
            }
            else
            {
                returnVal = true;
                lblWarningPassword.Text = "";
            }

            return returnVal;
        }
    }
}