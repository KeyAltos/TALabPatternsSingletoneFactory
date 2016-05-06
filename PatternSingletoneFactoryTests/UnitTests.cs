using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternSingletoneFactory;
using System.Configuration;

namespace PatternSingletoneFactoryTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void OpenCloseBrowser()
        {   
            var firstDriver = WebDriver.GetDriver();
            var secondDriver = WebDriver.GetDriver();

            firstDriver.Navigate().GoToUrl("https://www.epam.com/");
            firstDriver.Quit();

            Assert.AreSame(firstDriver, secondDriver);
        }
    }
}
