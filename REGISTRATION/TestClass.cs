using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using REGISTRATION.Pages.GooglePage;
using REGISTRATION.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REGISTRATION
{
    [TestFixture]
    public class DemoQARegistrationTests
    {
        private IWebDriver driver;

        [SetUp]
        public void BeforeEachTest()
        {
            this.driver = new ChromeDriver();
            this.driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void AfterEachTest()
        {
            this.driver.Log().Quit();
        }

        [Test]
        public void NavigateToEtGeorgiShoulBeProcessed()
        {
            //// Arrange
            var googlePage = new GooglePage(this.driver);
            
            
            //// Act
            googlePage.Open();                  
            //.....................// тук искам да натисна бутона ServiciesButton.

        }
    }        
}
