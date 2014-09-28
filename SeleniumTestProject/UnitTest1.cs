using System;
using System.Configuration;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Internal;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTestProject
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver _driver;

        /*[SetUp]
        public void Setup()
        {
            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl("http://my.zerys.com");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }*/

        [TestMethod]
        public void TestMethod1()
        {
            _driver = new FirefoxDriver();
            _driver.Manage().Window.Maximize();
           // _driver.Manage().Window.Size = new System.Drawing.Size(100, 100);
            
            _driver.Navigate().GoToUrl("http://my.zerys.com");
            _driver.FindElement(By.Id("txtUserName")).SendKeys("mohseen.khanr@gmail.com");
            _driver.FindElement(By.Id("txtPwd")).SendKeys("halsys");
            _driver.FindElement(By.Id("btnLogin")).Click();
            _driver.FindElement(By.
            string windcur = _driver.CurrentWindowHandle;
            ReadOnlyCollection<string> wiidows = _driver.WindowHandles;
            foreach (string win1 in wiidows)
            {
                //IWebDriver win = _driver.SwitchTo().Window(win1).Title.Contains("");
                
            }
            /*Actions act = new Actions(_driver);
            act.Click();
            act.Build();
            act.DoubleClick();
            act.DragAndDrop(IWebElement src, IWebElement dtn);
            act.DragAndDropToOffset();
            act.KeyDown(string Keys);
            IWebElement ele = _driver.FindElement(By.Id(""));
            act.ContextClick(ele).SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).Build().Perform();
            double ste = Math.Exp(4);
            double ste = Math.Pow(2,2);*/
            IWebElement ele1 = _driver.FindElement(By.Id(""));
            SelectElement select = new SelectElement(ele1); 
            select.DeselectByIndex(2);
            select.DeselectByText("man");
            select.SelectByIndex(2);
            select.SelectByValue("auto");
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(100));
            _driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromMinutes(2));
            _driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromMilliseconds(200));
            _driver.Navigate().Forward();
            _driver.Navigate().Back();
            _driver.Navigate().Refresh();
            _driver.SwitchTo().Alert();
            IAlert alert = (IAlert)_driver;
            alert.Accept();
            alert.Dismiss();
            _driver.SwitchTo().Frame(ele1);
            _driver.SwitchTo().ParentFrame();
            _driver.SwitchTo().ActiveElement();
            _driver.SwitchTo().DefaultContent();
            _driver.SwitchTo().Window("name");
            







        }
    }

}
