using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationDemo.Assignment
{
    internal class News18
    {
        public static void NewsText()
        {
            IWebDriver driver = new ChromeDriver();
            string url = "https://www.news18.com/";
            driver.Navigate().GoToUrl(url);
            //IWebElement tab = driver.FindElement(By.XPath("//div[@class='jsx-3ee703561b303a3f trndvdo']//figure[@class='jsx-3ee703561b303a3f']"));


            IList<IWebElement> list = driver.FindElements(By.XPath("//div[@class='jsx-3ee703561b303a3f trndttl']"));
            foreach (var text in list)
            {
                // var eletext = text.GetAttribute("class");
                var Text = text.Text;
                Console.WriteLine(Text);
            }
        }
        public static void Main(string[] args)
        {
            NewsText();
        }
    }
}


