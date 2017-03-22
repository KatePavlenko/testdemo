using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        FirefoxDriver firefox;

        // это тест.
        [TestMethod]
        public void TestMethod1()
        {
            firefox = new FirefoxDriver();
            firefox.Navigate().GoToUrl("http://www.google.com/");
            firefox.FindElement(By.Id("searchform")).SendKeys("habrahabr");
            firefox.FindElement(By.Id("searchform")).SendKeys(Keys.Enter);
            firefox.FindElement(By.XPath("//a[contains(text(),'Интересные публикации / Хабрахабр')]")).Click();
            //firefox.FindElement(By.LinkText("Интересные публикации / Хабрахабр")).Click();
            firefox.FindElement(By.CssSelector("span.tabs-menu__item-text.")).Click();
            firefox.FindElement(By.CssSelector("a.toggle-menu__item-link.toggle-menu__item-link_pagination")).Click();
        }
        public void TearDown()
        {
            firefox.Quit();
        }
    }
}


