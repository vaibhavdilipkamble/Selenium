using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject1
{
    class LocateByLinkText_AlertDemo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello this is locate by LinkText practical");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("F:\\Zensar\\selenium_session\\Selenium_Webdriver");

            //Maximize browser
            driver.Manage().Window.Maximize();

            //Open url(open google)
            driver.Url = "https://www.w3schools.com/jsref/met_win_alert.asp";

            //By LinkText
            driver.FindElement(By.LinkText("Try it Yourself »")).Click();
            driver.FindElement(By.LinkText("Try it")).Click();

            //Close Browser
            //driver.Close();
        }
    }
}