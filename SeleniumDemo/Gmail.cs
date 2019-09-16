using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace SeleniumDemo
{
    [TestClass]
    public class Gmail
    {
        [TestMethod]

        public void CrearCuenta()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("headless");
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            //using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions));
            {
                // IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://www.google.com.mx/?hl=es-419");

                IWebElement TxtSearch = driver.FindElement(By.Name("q"));
                TxtSearch.SendKeys("cuenta google");
                driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);

                driver.FindElement(By.ClassName("LC20lb")).Click();

                driver.FindElement(By.LinkText("Crea una cuenta de Google")).Click();


                //driver.FindElement(By.Id("firstName")).Clear();
                driver.FindElement(By.Id("firstName")).SendKeys("gerson");
                //driver.FindElement(By.Id("lastName")).Clear();
                driver.FindElement(By.Id("lastName")).SendKeys("alvarez");
                //driver.FindElement(By.Id("username")).Clear();
                driver.FindElement(By.Id("username")).SendKeys("gerson0000000007");
                //driver.FindElement(By.Name("Passwd")).Clear();
                driver.FindElement(By.Name("Passwd")).SendKeys("5aldeuva");
                //driver.FindElement(By.Name("ConfirmPasswd")).Clear();
                driver.FindElement(By.Name("ConfirmPasswd")).SendKeys("5aldeuva");
                //driver.FindElement(By.Name("ConfirmPasswd")).Clear();
                driver.FindElement(By.ClassName("CwaK9")).Click();
                //WAIT
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                driver.FindElement(By.Id("phoneNumberId")).SendKeys("5574309172");
                driver.FindElement(By.Id("gradsIdvPhoneNext")).Click();
                //WAIT

            }
        }
    }
}