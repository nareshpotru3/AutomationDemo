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


namespace AutomationDemo
{

    internal class Golf
    {
        public static void Main(string[] args)
        {
            var co = new ChromeOptions();
            co.AddArgument("start-maximized");
            co.AddArgument("--disable-notifications");
            co.PageLoadStrategy = PageLoadStrategy.Normal;

            IWebDriver driver1 = new ChromeDriver(co);
            driver1.Navigate().GoToUrl("https://www.americangolf.co.uk/");
            //WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(10));
            //wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("termly-styles-message-e9e76f termly-styles-message-a323da")));

            driver1.FindElement(By.XPath("//button[@data-tid='banner-accept']")).Click();
            Thread.Sleep(500);
            //IAlert alert = driver1.SwitchTo().Alert();
            //wait.IgnoreExceptionTypes(typeof(NoAlertPresentException));
            //alert.Accept();
            //driver1.GetType();
            //driver1.Manage().Window.Maximize();

            //Input field --Golf
            Actions a = new Actions(driver1);
            IWebElement search =  driver1.FindElement(By.Id("q"));
            //search.SendKeys("golf");
            //a.MoveToElement(search);
            search.SendKeys("golf");

            //Web driver wait to click on Search button to Go button 

            //WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(10));
            //IWebElement go = wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[3]/div[2]/header/div[2]/div/form/fieldset/button")));
            //a.MoveToElement(go).Click().Build().Perform();
            //go.Click();

            driver1.FindElement(By.XPath("//span[@class='twitter-typeahead']//following-sibling::button[1]")).Click();

            IList<IWebElement> List = driver1.FindElements(By.XPath("//div[@class='refinement categoryId']//a[@class='listingchange']//span[@class='refinement-name']"));
            string textoflement = "Putters";
            foreach(var element11 in List)
            {
                if(element11.Text == textoflement)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("Selected" + element11.Text);
                    element11.Click();
                    break;
                   
                }
                //Console.WriteLine(txt);
            }
            //Clicking on Putters

            //List[indexoflist].Click();
            //Console.WriteLine(List[55].Text+" is selected");
        }
    }
}
    
