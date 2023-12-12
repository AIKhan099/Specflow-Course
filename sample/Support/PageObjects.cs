using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample.Support
{
    internal class LoginPage
    {
        public string  UsernameInputBarXpath = "//input[@data-qa=\"login-email\"]";
        public string  PasswordInputBarXpath = "//input[@data-qa=\"login-password\"]";
        public string SubmitBtnXpath = "//button[@data-qa=\"login-button\"]";

    }
}
