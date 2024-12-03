using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.DevTools.V128.Browser;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AutomationDemo
{
    internal class MakeMyTrip
    {
        static IWebDriver? driver;
        public static void Main(string[] args)
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("start-maximized");
            driver = new ChromeDriver(chromeOptions);
            string url = "https://www.makemytrip.com/";

            driver.Navigate().GoToUrl(url);
            Thread.Sleep(2000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.PollingInterval = TimeSpan.FromMilliseconds(200);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[@class='commonModal__close']"))).Click();

            DeptDate("02/03/2025", "03/22/2025");

        }

        public static void DeptDate(string dat1, string dat2)
        {
            //From date
            DateTime inpdate = Convert.ToDateTime(dat1);
            DateTime currDate = DateTime.Now;

            var mon = inpdate.Month;
            Console.WriteLine(mon);
            string Feb = inpdate.ToString("MMMM");
            string Wday = inpdate.ToString("ddd");
            Console.WriteLine(Wday);
            string monabb = inpdate.ToString("MMM");
            var dt = inpdate.Day;
            var dat = inpdate.ToString("dd");
            var year = inpdate.Year;
            IWebElement Deptdt = driver!.FindElement(By.XPath("//p[@data-cy='departureDate']"));

            Actions act = new Actions(driver);
            act.MoveToElement(Deptdt).Click().Build().Perform();
            string dateinp = dat + " " + Feb + "'" + year;
            Thread.Sleep(2000);
            IWebElement monyrdisplayel = driver.FindElement(By.XPath("//div[@class='DayPicker-Caption']//div"));
            string monyrdisplay = monyrdisplayel.Text;
            string monyrselected = Feb + " " + year;

            Console.WriteLine("Input date in date format" + dateinp);
            string combdt = Wday + " " + monabb + " " + dat + " " + year;
            while (true)
            {
                if (monyrdisplay.Equals(monyrselected))
                {
                    IWebElement dateselected = driver.FindElement(By.XPath("//div[@aria-label='" + combdt + "']"));
                    act.MoveToElement(dateselected).Click().Build().Perform();
                    Console.WriteLine("Clicked on date");
                    break;
                }
                else
                {
                    if (inpdate.CompareTo(currDate) == 1)
                    {
                        //Next button   
                        Thread.Sleep(500);
                        driver.FindElement(By.XPath("//span[@class='DayPicker-NavButton DayPicker-NavButton--next']")).Click();
                    }
                    else
                    {
                        Thread.Sleep(500);
                        //back button
                        driver.FindElement(By.XPath("//span[@class='DayPicker-NavButton DayPicker-NavButton--prev']")).Click();
                    }
                }
                monyrdisplay = driver.FindElement(By.XPath("//div[@class='DayPicker-Caption']//div")).Text;
            }

            //Return date
            //    DateTime retdate = Convert.ToDateTime(dat2);
            //    var mont = retdate.Month;
            //    var Mar = retdate.ToString("MMM");
            //    var datret = retdate.Day;
            //    var yearret = retdate.Year;
            //    string monyrret = Mar + " " + yearret;

            //    driver.FindElement(By.XPath("//input[@placeholder='Return Date']")).Click();
            //    while (true)
            //    {
            //        Console.WriteLine(monyrret);
            //        Console.WriteLine(monyrdisplay);
            //        if (inpdate <= retdate)
            //        {
            //            monyrdisplay = driver.FindElement(By.ClassName("js_monthTitle")).Text;
            //            if (monyrret != monyrdisplay)

            //            {
            //                driver.FindElement(By.XPath("//a[@class='js_btnNext new-cal ico-next-b']")).Click();
            //            }
            //            else
            //            {
            //                driver.FindElement(By.XPath("//*[@id=\"a_" + year + "_" + mont + "_" + datret + "\"]")).Click();
            //                break;
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Ret date is lesser than From Date");
            //            break;
            //        }
            //}
        }
   }
}

