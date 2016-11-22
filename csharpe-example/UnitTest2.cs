using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharpe_example
{
    [TestFixture]
    public class LitecardAdminLogin
    {

        private FirefoxDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Start()
        {
            driver = new FirefoxDriver();
            wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));
        }

        [Test]
        public void AdminLogin()
        {
            driver.Url = "http://localhost/litecart/admin/login.php";
            driver.FindElement(By.Name("username")).SendKeys("admin");
            driver.FindElement(By.Name("password")).SendKeys("admin");
            driver.FindElement(By.Name("login")).Click();
            wait.Until(ExpectedConditions.TitleIs("My Store"));
        }

        [TearDown]
        public void stop()
        {
            driver.Quit();
            driver = null;
        }
    }
}
