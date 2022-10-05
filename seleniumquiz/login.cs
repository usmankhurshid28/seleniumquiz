using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumquiz
{
    public class login :commonmethod
    {
        #region loginlocator

        By login_btn = By.XPath("//*[@id='header']/div/div/div/div[2]/div/ul/li[4]/a");
        By email_login = By.Name("email");
        By pass_login = By.XPath("password");
        By login_submit_btn = By.XPath("//input[@value='Log in']");

        #endregion
        public void loginFunctionality()
        {
            clickable(login_btn);
            inputtext(email_login, "muusmanlhr1@gmail.com");
            inputtext(pass_login, "test1234");
            clickable(login_submit_btn);
        }

    }
}
