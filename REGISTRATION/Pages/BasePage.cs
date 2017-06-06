using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REGISTRATION.Pages
{
    public abstract class BasePage<T> where T : class
    {
        public BasePage(IWebDriver driver, T elements)
        {
            this.Driver = driver;
            this.Elements = elements;
        }

        public IWebDriver Driver { get; private set; }

        public T Elements { get; private set; }

        public abstract string Url { get; }

        public virtual void Open(string part = "")
        {
            this.Driver.Navigate().GoToUrl($"{this.Url}{part}");
        }
    }
}
