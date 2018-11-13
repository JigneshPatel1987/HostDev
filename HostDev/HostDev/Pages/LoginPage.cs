using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostDev
{
    class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement username => driver.FindElement(By.Id("UserName"));
        IWebElement password => driver.FindElement(By.Id("Password"));
        IWebElement clickbutton => driver.FindElement(By.XPath("//input[@class='btn btn-default']"));
   
        internal void LoginSuccess()
        {
            username.SendKeys("hari");
            password.SendKeys("123123");
            clickbutton.Click();
         }

        internal void ValidateTheMaxcharacterforemailfield()
        {
            //IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");
        }
    }
}
