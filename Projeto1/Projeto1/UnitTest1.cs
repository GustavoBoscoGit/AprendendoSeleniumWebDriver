using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Projeto1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create a reference to chrome browser
            IWebDriver driver = new ChromeDriver();

            // visit a web page
            driver.Navigate().GoToUrl("https://google.com");

            //full screen
            driver.Manage().Window.Maximize();

            //find the element 
            IWebElement searchBox = driver.FindElement(By.Name("q"));

            //type something in the search bar
            searchBox.SendKeys("hello world");

            //close the browser
            //driver.Quit(); 
        } 
    }

} 
