using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumquiz
{
    public class commonmethod
    {
        public static IWebDriver driver;

        public commonmethod()
        {
            //driver = new ChromeDriver();
        }

        public commonmethod(string browsername)
        {
            if (browsername == "chrome")
            {
                driver=new ChromeDriver();
            }
            else if (browsername == "firefox")
            {
                driver = new FirefoxDriver();
            }
            driver.Manage().Window.Maximize();
        }
        public void myurl(string websitelink)
        {
            driver.Url = websitelink;
        }
        public IWebElement findelement(By locat)
        {
            return driver.FindElement(locat);
        }
        public void clickable(By locat)
        {
            IWebElement clickitem = findelement(locat);
            clickitem.Click();
        }
        public void chechkbox(By locat)
        {
            IWebElement checkbx = findelement(locat);
            checkbx.Click();
        }

        public void inputtext(By locat, string mydata)
        {
            IWebElement text = findelement(locat);
            text.SendKeys(mydata);

        }

        public void dropdownitem(By locat, string myvalue)
        {
            IWebElement mydrop = findelement(locat);
            SelectElement mydropdown = new SelectElement(mydrop);
            mydropdown.SelectByValue(myvalue);
        }

        public IWebElement explicitwaitelement(By locat)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locat));
        }
        public void scrollelement(By locat)
        {
            IJavaScriptExecutor scroll = (IJavaScriptExecutor)driver;
            IWebElement elementfind = explicitwaitelement(locat);
            scroll.ExecuteScript("argument[0].scrollIntoView(true);", elementfind);
        }
    }
}
