using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Homework8
{
    public partial class AboutYou : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            if (validFirstName(txtFirstName.Text) &
               validLastName(txtLastName.Text) &
                validAddress(txtAddress.Text) &
                validBirthday(txtBirthday.Text) &
                validCity(txtCity.Text) &
                validState(txtState.Text) &
                validZIP(txtZIP.Text) &
                validEmail(txtEmail.Text) &
                validPhone(txtPhone.Text) &
                validCollege(txtCollege.Text) &
                validMajor(txtMajor.Text) &
                validGradDate(txtGradDate.Text))
            {
                lblRegister.Text = "You Have Successfully Registered";
                lblRegister.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                lblRegister.Text = "* Required Field";
                lblRegister.ForeColor = System.Drawing.Color.Red;
            }
        }

        public bool validFirstName(string text)
        {
            bool returnVal = false;

            if (text.Trim() == "")
            {
                returnVal = false;
                lblFirstName.Text = "First Name: *";
                lblFirstName.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                returnVal = true;
                lblFirstName.Text = "First Name:";
                lblFirstName.ForeColor = System.Drawing.Color.Black;
            }

            return returnVal;
        }

        public bool validLastName(string text)
        {
            bool returnVal = false;

            if (text.Trim() == "")
            {
                returnVal = false;
                lblLastName.Text = "Last Name: *";
                lblLastName.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                returnVal = true;
                lblLastName.Text = "Last Name:";
                lblLastName.ForeColor = System.Drawing.Color.Black;
            }

            return returnVal;
        }

        public bool validAddress(string text)
        {
            bool returnVal = false;

            if (text.Trim() == "")
            {
                returnVal = false;
                lblAddress.Text = "Address: *";
                lblAddress.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                returnVal = true;
                lblAddress.Text = "Address:";
                lblAddress.ForeColor = System.Drawing.Color.Black;
            }

            return returnVal;
        }

        public bool validBirthday(string text)
        {
            bool returnVal = false;
            if (text.Trim() == "")
            {
                returnVal = false;
                lblBirthday.Text = "Birthday: *";
                lblBirthday.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                returnVal = true;
                lblBirthday.Text = "Birthday:";
                lblBirthday.ForeColor = System.Drawing.Color.Black;
            }
            return returnVal;
        }

        public bool validCity(string text)
        {
            bool returnVal = false;

            if (text.Trim() == "")
            {
                returnVal = false;
                lblCity.Text = "City: *";
                lblCity.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                returnVal = true;
                lblCity.Text = "City:";
                lblCity.ForeColor = System.Drawing.Color.Black;
            }


            return returnVal;
        }

        public bool validState(string text)
        {
            bool returnVal = false;

            if (text.Trim() == "")
            {
                returnVal = false;
                lblState.Text = "State: *";
                lblState.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                returnVal = true;
                lblState.Text = "State:";
                lblState.ForeColor = System.Drawing.Color.Black;
            }

            return returnVal;
        }

        public bool validZIP(string text)
        {
            bool returnVal = false;

            if (text.Trim() == "")
            {
                returnVal = false;
                lblZIP.Text = "ZIP Code: *";
                lblZIP.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                returnVal = true;
                lblZIP.Text = "ZIP Code:";
                lblZIP.ForeColor = System.Drawing.Color.Black;
            }

            return returnVal;
        }

        public bool validEmail(string text)
        {
            bool returnVal = false;
            if (text.Trim() == "")
            {
                returnVal = false;
                lblEmail.Text = "E-Mail: *";
                lblEmail.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                returnVal = true;
                lblEmail.Text = "E-Mail:";
                lblEmail.ForeColor = System.Drawing.Color.Black;
            }
            return returnVal;
        }

        public bool validPhone(string text)
        {
            bool returnVal = false;
            if (text.Trim() == "")
            {
                returnVal = false;
                lblPhone.Text = "Phone: *";
                lblPhone.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                returnVal = true;
                lblPhone.Text = "Phone:";
                lblPhone.ForeColor = System.Drawing.Color.Black;
            }
            return returnVal;
        }

        public bool validCollege(string text)
        {
            bool returnVal = false;
            if (text.Trim() == "")
            {
                returnVal = false;
                lblCollege.Text = "College: *";
                lblCollege.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                returnVal = true;
                lblCollege.Text = "College:";
                lblCollege.ForeColor = System.Drawing.Color.Black;
            }
            return returnVal;
        }

        public bool validMajor(string text)
        {
            bool returnVal = false;
            if (text.Trim() == "")
            {
                returnVal = false;
                lblMajor.Text = "Major: *";
                lblMajor.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                returnVal = true;
                lblMajor.Text = "Major:";
                lblMajor.ForeColor = System.Drawing.Color.Black;
            }
            return returnVal;
        }

        public bool validGradDate(string text)
        {
            bool returnVal = false;
            if (text.Trim() == "")
            {
                returnVal = false;
                lblGradDate.Text = "Expected Graduation Date: *";
                lblGradDate.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                returnVal = true;
                lblGradDate.Text = "Expected Graduation Date:";
                lblGradDate.ForeColor = System.Drawing.Color.Black;
            }
            return returnVal;
        }

        
    }
}