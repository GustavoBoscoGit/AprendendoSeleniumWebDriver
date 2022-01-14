using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Projeto1
{
    [TestClass]
    public class UnitTest1
    {

        //create a reference to chrome browser
        IWebDriver driver = new ChromeDriver();

        [TestMethod]
        public void TestMethod1()
        {
            // visit a web page
            driver.Navigate().GoToUrl("https://amazon.com");

            //full screen
            driver.Manage().Window.Maximize();

            //operations
            IWebElement SingIn = driver.FindElement(By.Id("nav-link-accountList"));
            SingIn.Click();

            IWebElement EmailField = driver.FindElement(By.Id("ap_email"));
            EmailField.SendKeys("EmailTesteTeste@Teste.com");

            IWebElement ContinueBtn = driver.FindElement(By.Id("continue"));
            ContinueBtn.Click();

            IWebElement ErrorMessage = driver.FindElement(By.ClassName("a-alert-heading"));
            string ActualErrorMessaageText = ErrorMessage.Text;
            string ExpectedErrorMessageText = "There was a problem";

            Assert.AreEqual(ExpectedErrorMessageText, ActualErrorMessaageText);




        }
    }

} 
