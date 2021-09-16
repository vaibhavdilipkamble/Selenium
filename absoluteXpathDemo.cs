using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumProject1
{
    class AbsoluteXpathDemo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("F:\\Zensar\\selenium_session\\Selenium_Webdriver");

            //Maximize browser
            driver.Manage().Window.Maximize();

            //Open url(open google)
            driver.Url = "https://www.google.co.in/";

            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]")).SendKeys("Selenium");
            //Close Browser
            //driver.Close();
        }
    }
}