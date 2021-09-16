using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject1
{
    class RealativeXpathDemo
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

            driver.FindElement(By.XPath("//div[@jsname='UUbT9']//input")).SendKeys("Selenium");
            //Close Browser
            //driver.Close();
        }
    }
}