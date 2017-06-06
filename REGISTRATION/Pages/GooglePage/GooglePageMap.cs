using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REGISTRATION.Pages.GooglePage
{
    public class GooglePageMap
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public GooglePageMap(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(Constants.WAIT_SECCONDS));
        }

        public IWebElement ServiciesButton
        {
            get
            {
                return this.driver.FindElement(By.XPath(Constants.SERVICES_SELECTOR));
            }
        }
    }
}
