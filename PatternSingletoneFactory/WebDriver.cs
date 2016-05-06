using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternSingletoneFactory
{
    public sealed class WebDriver
    {
        private WebDriver() { }
        static WebDriver() { }

        private static readonly IWebDriver driver = InitDriver();
        
        public static IWebDriver GetDriver()
        {
            return driver;
        }

        private static IWebDriver InitDriver()
        {
            return new AppConfigDriverFactory().GetDriver();
        }
    }
}
