using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject1
{
    class LocateByLinkText
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello this find by LinkText practical");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("F:\\Zensar\\selenium_session\\Selenium_Webdriver");

            //Maximize browser
            driver.Manage().Window.Maximize();

            //Open url(open google)
            driver.Url = "https://www.google.co.in/";

            //By LinkText
            driver.FindElement(By.LinkText("Gmail")).Click();

            //Close Browser
            driver.Close();
        }
    }
}