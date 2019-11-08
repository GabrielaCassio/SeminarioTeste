using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeminarioTeste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.sistemas.pucminas.br/sgaaluno3/SilverStream/Pages/pgAln_LoginSSL.html");
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(1000);
            IWebElement matricula = driver.FindElement(By.Name("S48_"));
            matricula.SendKeys("600049");
            System.Threading.Thread.Sleep(1000);

            IWebElement senha = driver.FindElement(By.Name("S62_"));
            senha.SendKeys("calor");
            System.Threading.Thread.Sleep(1000);

            IWebElement tipo = driver.FindElement(By.Name("S76_"));
            tipo.SendKeys("g");
            System.Threading.Thread.Sleep(1000);

            IWebElement clicar = driver.FindElement(By.Name("S122_"));
            clicar.Click();


            System.Threading.Thread.Sleep(5000);
            driver.Quit();

        }
    }
}
