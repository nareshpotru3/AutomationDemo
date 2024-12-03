using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V128.WebAuthn;
using OpenQA.Selenium.Interactions;


namespace AutomationDemo
{
    internal class Checkbox
    {


        public static void Chkbox(string requiredMilkProduct)
        {
            var co = new ChromeOptions();
            co.AddArguments("start-maximized");
            co.PageLoadStrategy = PageLoadStrategy.Normal;
            IWebDriver driver = new ChromeDriver(co);
            string url = "https://echoecho.com/htmlforms09.htm";
            driver.Navigate().GoToUrl(url);
            IList<IWebElement> options = driver.FindElements(By.XPath("//td[@class='table5'][1]//input[@type='checkbox']"));
            foreach(IWebElement opt in options)
            {
                var val = opt.GetAttribute("value");
            
                if(val == requiredMilkProduct)
                {
                    Actions a = new Actions(driver);
                    if (!opt.Selected)
                    {
                        a.MoveToElement(opt).Click().Build().Perform();
                    }
                }
            }
            ////dynamic x path
            IWebElement MILKproducts(string requiredMilkProduct) => driver.FindElement(By.XPath(@$"//input[@value='{requiredMilkProduct}']"));

            if (!(MILKproducts(requiredMilkProduct).Selected))
            {
                MILKproducts(requiredMilkProduct).Click();
            }

        }
        public static void Main(string[] args)
        {
            Chkbox("Milk");
        }
    }

}

    
