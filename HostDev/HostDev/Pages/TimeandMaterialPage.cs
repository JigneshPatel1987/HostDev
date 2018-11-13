using System;
using System.Threading;
using OpenQA.Selenium;

namespace _087Nov18
{
    internal class TimeandMaterialPage
    {
        private IWebDriver driver;

        public TimeandMaterialPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement Clickcreate1 => driver.FindElement(By.XPath("//a[@href='/TimeMaterial/Create']"));
        IWebElement Id => driver.FindElement(By.Id("Code"));
        IWebElement Descid => driver.FindElement(By.Id("Description"));
        IWebElement Editbutton => driver.FindElement(By.XPath("//a[contains(.,'Edit')]"));

        internal void Clickcreate()
        {
            Clickcreate1.Click();            
        }

        internal void Savebutton1()
        {
            Id.SendKeys("Test");
            Descid.SendKeys("Test Descrition");
            driver.FindElement(By.XPath(".//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("7.90");
            driver.FindElement(By.XPath("//input[@id='SaveButton']")).Click();
        }

        internal void Editbutoon()
        {

            Thread.Sleep(2000);
            Editbutton.Click();          
            

        }
    }
}