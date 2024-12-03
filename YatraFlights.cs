using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationDemo
{
    internal class YatraFlights
    {
        static IWebDriver? driver;
        public static void Main(string[] args)
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("start-maximized");

            driver = new ChromeDriver(chromeOptions);
            string url = "https://www.yatra.com/flight-schedule";

            driver.Navigate().GoToUrl(url);
            DeptDate("02/20/2025", "03/22/2025");

        }

        public static void DeptDate(string dat1,string dat2)
        {

            
            //From date
            DateTime inpdate = Convert.ToDateTime(dat1);
            DateTime currDate = DateTime.Now;

            var mon = inpdate.Month;
            string Feb = inpdate.ToString("MMM");
            var dat = inpdate.Day;
            var year = inpdate.Year;

            IWebElement fromDate = driver!.FindElement(By.XPath("//input[@name='flight_depart_date']"));
            fromDate.Click();
            string dateinp = dat + " " + Feb + "'" + year;
            string monyrdisplay = driver.FindElement(By.ClassName("js_monthTitle")).Text;
            string monyrselected = Feb + " " + year;

            Console.WriteLine("Input date in date format" + dateinp);
            while (true)
            {
                if (monyrdisplay.Equals(monyrselected))
                {
                    driver.FindElement(By.XPath("//*[@id=\"a_" + year + "_" + mon + "_" + dat + "\"]")).Click();
                    break;
                }
                else
                {
                    if (inpdate.CompareTo(currDate) == 1)
                    {
                        //Next button   
                        Thread.Sleep(500);
                        driver.FindElement(By.XPath("//a[@class='js_btnNext new-cal ico-next-b']")).Click();

                    }
                    else
                    {
                        Thread.Sleep(500);
                        //back button
                        driver.FindElement(By.XPath("//a[@class='js_btnPrev new-cal ico-prev-b']")).Click();
                    }
                }
                monyrdisplay = driver.FindElement(By.ClassName("js_monthTitle")).Text;
            }

            //Return date
            DateTime retdate = Convert.ToDateTime(dat2);
            var mont = retdate.Month;
            var Mar = retdate.ToString("MMM");
            var datret = retdate.Day;
            var yearret = retdate.Year;

            string monyrret = Mar + " " + yearret;

            driver.FindElement(By.XPath("//input[@placeholder='Return Date']")).Click();
            
            while(true)
            {
                Console.WriteLine(monyrret);
                Console.WriteLine(monyrdisplay);
                
                if (inpdate <= retdate)
                {
                    monyrdisplay = driver.FindElement(By.ClassName("js_monthTitle")).Text;
                    if (monyrret != monyrdisplay)

                    {
                        driver.FindElement(By.XPath("//a[@class='js_btnNext new-cal ico-next-b']")).Click();

                    }
                    else
                    {
                        driver.FindElement(By.XPath("//*[@id=\"a_" + year + "_" + mont + "_" + datret + "\"]")).Click();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Ret date is lesser than From Date");
                    break;
                }
            }
        }       
    }   
}

