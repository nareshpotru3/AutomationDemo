using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;


namespace AutomationDemo.Assignment
{

    internal class Golf2
    {
        public static void Main(string[] args)
        {
            var co = new ChromeOptions();
            co.AddArgument("start-maximized");
            co.AddArgument("--disable-notifications");
            co.PageLoadStrategy = PageLoadStrategy.Normal;

            IWebDriver driver1 = new ChromeDriver(co);
            driver1.Navigate().GoToUrl("https://www.americangolf.co.uk/");
            driver1.FindElement(By.XPath("//button[@data-tid='banner-accept']")).Click();

            //Getting all headers
            IList<IWebElement> HeaderList = driver1.FindElements(By.XPath("//*[@id=\"header-navigation\"]/div/ul/li/a"));
            Actions a = new Actions(driver1);
            foreach (IWebElement header in HeaderList)
            {
                if (header.Text == "GOLF CLOTHING")
                {
                    Thread.Sleep(1000);
                    a.MoveToElement(header).Build().Perform();
                    break;
                }
            }

            //Getting all the List Items under Men's Clothing
            IList<IWebElement> MensList = driver1.FindElements(By.XPath("//*[@id=\"CLOTHFOOTW_1\"]/ul/li[1]/ul/li/a/span"));

            foreach (IWebElement Men in MensList)
            {
                //Console.WriteLine(Men.Text);
                if (Men.Text == "Men's Trousers")
                {
                    Men.Click();
                    break;
                }
            }

        }
    }
}