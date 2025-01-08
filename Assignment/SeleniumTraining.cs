using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace AutomationDemo.Assignment;

internal class SeleniumTraining
{
    public static void Main(string[] args)
    {
        var chrome = new ChromeOptions();
        chrome.AddArguments("start-maximized");
        chrome.PageLoadStrategy = PageLoadStrategy.Normal;

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.seleniumtraining.com/login");

        driver.FindElement(By.XPath("//*[@id=\"bs-navbar-collapse-1\"]/ul/li[2]/a")).Click();
        Thread.Sleep(3000);

        driver.FindElement(By.XPath("/html/body/div[2]/nav/div/div[2]/ul/li[2]/ul/li[2]/a")).Click();
        Thread.Sleep(3000);
    }
}
