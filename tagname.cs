using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;

namespace SeleniumProject1
{
    class Tagname
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello...!!!! Counting of Links and Link Text Practicle");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("F:\\Zensar\\selenium_session\\Selenium_Webdriver");

            driver.Manage().Window.Maximize();

            //Open url(open google)
            driver.Url = "https://www.google.co.in/";

            //Getting links by Tagname
            IReadOnlyCollection<IWebElement> links = driver.FindElements(By.TagName("a"));

            //Printing Count of links present on web-page
            Console.WriteLine(links.Count);

            //Printing all Links using Text
            //for (int i = 0; i < links.Count; i++)
            //{
            //    Console.WriteLine(links.ElementAt(i).Text);
            //}

            foreach (IWebElement item in links)
            {
                Console.WriteLine(item.Text);
            }

            Thread.Sleep(3000);
            //Closing Browser
            driver.Close();
        }
    }
}