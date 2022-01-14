using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Projeto1
{
    [TestClass]
    public class UnitTest2
    {

        //create a reference to chrome browser
        IWebDriver driver = new ChromeDriver();

        [TestMethod]
        public void TestMethod2()
        {
            // visit a web page
            driver.Navigate().GoToUrl("https://facebook.com");

            //full screen
            driver.Manage().Window.Maximize();

            //elements 
            IWebElement NewAccount = driver.FindElement(By.Id("u_0_2_I2"));
            NewAccount.Click();

        }
    }
}
