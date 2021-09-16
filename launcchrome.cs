using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Project1
{
    class LaunchChrome
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Chrome browser is launched");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("F:\\Zensar\\selenium_session\\Selenium_Webdriver");

            //Maximize browser
            driver.Manage().Window.Maximize();

            //Open url(open google)
            driver.Url = "https://www.google.co.in/"; 

            //Close Browser
            //driver.Close();
        }
    }
}