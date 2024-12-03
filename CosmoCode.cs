using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationDemo
{
    internal class CosmoCode
    {
        public static void Main(string[] args)
        {   
            //Chrome options
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("strat-maximized");
            options.AddArgument("--disable-notifications");

            //Driver Instantiation
            IWebDriver driver = new ChromeDriver(options);
            string url = "https://cosmocode.io/automation-practice-webtable/";
            driver.Navigate().GoToUrl(url);

            //List of Country details
            IList<IWebElement> ListOfCountries = driver.FindElements(By.XPath("//table[@id='countries']//tr"));
            int i = 1;
            string inCountry = "Nepal";
            
            foreach (IWebElement element in ListOfCountries)
            {
                //if (ListOfCountries.Count == i - 1)
                //    break;
                //Get Contry name for each record in table
               
                IWebElement country = driver.FindElement(By.XPath("//table[@id='countries']//tr["+i+"]/td[2]"));
                for (int j = 3; j <= 5; j++)
                { 
                    IWebElement header = driver.FindElement(By.XPath("//table[@id='countries']//tr[1]/td[" + j + "]"));
                    IWebElement cap = driver.FindElement(By.XPath("//table[@id='countries']//tr["+i+"]/td["+j+"]"));
                    Console.Write(country.Text + " " + header.Text + " is----" + cap.Text + "    ");
                    if (j == 5)
                        Console.WriteLine(" ");


                }
                if (country.Text == inCountry)
                {
                    //Get the corresponding capital, Currency and lnguage details based on the columns available in that row
                    IList<IWebElement> columns = driver.FindElements(By.XPath("//table[@id='countries']//tr[" + i + "]//td"));

                    int colCount = columns.Count;
                    //for (int j = 3; j<=colCount;j++)
                    //Get the corresponding capital, Currency and lnguage details with restricted increment using for Loop
                    //for (int j = 3; j<=5;j++)
                    //{
                    //    IWebElement header = driver.FindElement(By.XPath("//table[@id='countries']//tr[1]/td[" + j + "]"));
                    //    IWebElement value1 = driver.FindElement(By.XPath("//table[@id='countries']//tr[" + i + "]/td[" + j + "]"));
                    //    //Console.WriteLine(inCountry + " " + header.Text + " is----" + value1.Text);
                    //    Console.Write(inCountry + " " + header.Text + " is----" + value1.Text+"    ");
                    //}
                    //break;



                    // Get the corresponding capital, Currency and lnguage details with Index
                    //int ind = 3;
                    //IWebElement cap = driver.FindElement(By.XPath("//table[@id='countries']//tr["+i+"]/td["+ind+"]"));
                    //ind = ind + 1;
                    //IWebElement cur = driver.FindElement(By.XPath("//table[@id='countries']//tr["+i+ "]/td["+ind+"]"));
                    //ind = ind + 1; 
                    //IWebElement lan = driver.FindElement(By.XPath("//table[@id='countries']//tr["+i+ "]/td["+ind+"]"));
                    //ind = ind - 2;
                    ////Printing the capital, currency and language details of the mentiioned country
                    //Console.WriteLine(inCountry + " Capital is  --" + cap.Text);
                    //Console.WriteLine(inCountry + " Currency is --" + cur.Text);
                    //Console.WriteLine(inCountry + " Language is --" + lan.Text);
                    //break;
                }
                i = i + 1;
            }
        }
    }
}
