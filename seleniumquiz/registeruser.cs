using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace seleniumquiz
{
    public class registeruser : commonmethod
    {
        #region
        By signup_btn=By.XPath("//*[@id='header']/div/div/div/div[2]/div/ul/li[4]/a");
        By user_name = By.Name("name");
        By user_email = By.XPath("//input[@data-qa='signup-email']");
        By signup_submit_btn = By.XPath("//button[text()='Signup']");
        By radio_btn = By.Name("title");
        By pass = By.Name("password");
        By day=By.Name("days");
        By month = By.Name("months");
        By year = By.Name("years");
        By newsletterbox1 = By.Name("newsletter");
        By offerbox2 = By.Name("optin");
        By first_name = By.Name("first_name");
        By last_name = By.Name("last_name");
        By company = By.Name("company");
        By address1 = By.Name("address1");
        By address2 = By.Name("address2");
        By country_name = By.Name("country");
        By state_name = By.Name("state");
        By city_name = By.Name("city");
        By zipcode_name = By.Name("zipcode");
        By mobile_number = By.Name("mobile_number");
        By create_acc_btn= By.XPath("//button[@data-qa='create-account']");


        #endregion

        public void user_reg()
        {
            clickable(signup_btn);
            inputtext(user_name,"usman");
            inputtext(user_email, "muusmanlhr1@gmail.com");
            clickable(signup_submit_btn);
            Thread.Sleep(2000);
            clickable(radio_btn);
            inputtext(pass,"test1234");
            dropdownitem(day,"5");
            dropdownitem(month, "8");
            dropdownitem(year, "2000");
            chechkbox(newsletterbox1);
            chechkbox(offerbox2);
            inputtext(first_name, "usman");
            inputtext(last_name, "malik");
            inputtext(company, "Usman Brother");
            inputtext(address1, "House.No 1");
            inputtext(address2, "Mumbai");
            Thread.Sleep(3000);
            dropdownitem(country_name, "Canada");
            inputtext(state_name, "mumbai");
            inputtext(city_name, "Mumbai");
            inputtext(zipcode_name, "1000");
            inputtext(mobile_number, "91234567880");
            clickable(create_acc_btn);


        }
    }
}
