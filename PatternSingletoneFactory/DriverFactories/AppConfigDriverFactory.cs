using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace PatternSingletoneFactory
{
    public class AppConfigDriverFactory
    {
        private IWebDriver driver;


        public IWebDriver GetDriver()
        {

            var browser = ConfigurationManager.AppSettings["browser"];
            switch (browser)
            {
                case "chrome":
                    driver = new ChromeDriver(); 
                    break;

                case "firefox":
                    driver = new FirefoxDriver();
                    break;

                case "ie":
                    driver = new InternetExplorerDriver();
                    break;

                default:
                    throw new IncorrectAppConfigDriverType("Enter in App.config value for key browser "+ browser + " is incorrect. Correct App.config with 'chrome', 'firefox' or 'ie'");
                    
            }
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
