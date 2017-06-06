using OpenQA.Selenium;
using REGISTRATION.Models;
using REGISTRATION.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REGISTRATION.Pages.GooglePage
{
    public class GooglePage : BasePage<GooglePageMap>
    {
        public GooglePage(IWebDriver driver) : base(driver, new GooglePageMap(driver))
        {
        }

        public override string Url
        {
            get
            {
                return Constants.ET_GEORGI_URL;
            }
        }

        public void Navigate(MainTabs tabs)
        {
            this.Elements.ServiciesButton.Click();
            
        }
               
    }
}
