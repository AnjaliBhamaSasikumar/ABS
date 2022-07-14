using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project.Pages
{
    public class HomePage
    {
        public void GoTOPage(IWebDriver driver)
        {
            // Click on administration tab
            Thread.Sleep(1500);
            IWebElement AdministrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            AdministrationTab.Click();

            //Select Time and Material
            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
            Thread.Sleep(1500);
        }
    }
}
