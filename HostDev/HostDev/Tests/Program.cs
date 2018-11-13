using HostDev;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _087Nov18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating instance of chrome driver
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login");

            // login page :: Identifying and sending valid inputs
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginSuccess();
            
            // Home Page - clicking on adminsitration and time n materials
            HomePage instanceName = new HomePage(driver);
            instanceName.clickAdminstration();
            instanceName.clickTimenMaterial();
                       
            // Time & Material Page - Click on Create New record and Submit Time and Material Value.
            TimeandMaterialPage instanceNameTandM = new TimeandMaterialPage(driver);
            instanceNameTandM.Clickcreate();
            instanceNameTandM.Savebutton1();
            instanceNameTandM.Editbutoon();

                       
            //Time and Material Page - create new and adding valid details

            //Time and Material Page  - validating the record created

            //Closing driver instance
            driver.Close();


            //IWebDriver driver1 = new ChromeDriver();
            //driver1.Navigate().GoToUrl("http://www.industryconnect.io");

            //driver1.FindElement(By.Id("Email")).SendKeys("jigneshpatel1987@gmail.com");
            //driver1.FindElement(By.Id("Password")).SendKeys("Test@123");

            //driver1.FindElement(By.XPath("//input[@class='btn btn-xl  signinbtn']")).Click();



        }



    }

}
