using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject1
{
    class LocateByName
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hello Chrome browser is launched");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("F:\\Zensar\\selenium_session\\Selenium_Webdriver");

            //Maximize browser
            driver.Manage().Window.Maximize();

            //Open url(open google)
            driver.Url = "https://www.google.co.in/";

            //Enter Selenium in search box
            IWebElement searchbox = driver.FindElement(By.Name("q"));
            searchbox.SendKeys("Selenium");

            //alternate way for entering text in search box
            //driver.FindElement(By.Name("q")).SendKeys("Selenium");

            //Close Browser
            driver.Close();
        }
    }
}