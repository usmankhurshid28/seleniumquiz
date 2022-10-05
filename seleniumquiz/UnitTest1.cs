using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace seleniumquiz
{
    [TestClass]
    public class UnitTest1
    {
        commonmethod commonObj = new commonmethod("firefox");
        public string URL = "https://www.automationexercise.com/";
        login loginObj = new login();
        registeruser regobj= new registeruser();


        [TestMethod]
        public void UserRegExc()
        {
            regobj.myurl(URL);
            regobj.user_reg();
        }
        [TestMethod]
        public void loginExc()
        {
            loginObj.myurl(URL);
            loginObj.loginFunctionality();
        }
    }
}
