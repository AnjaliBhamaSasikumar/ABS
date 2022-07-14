using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project.Pages
{
    public class TMPage
    {
    public void CreateTM(IWebDriver driver)
    {
        // Click on create button
        IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
        createNewButton.Click();
        Thread.Sleep(2000);

        //Input code(Default selected material)
        IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
        codeTextBox.SendKeys("Trial0");

        //Input description
        IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
        descriptionTextBox.SendKeys("Trial0");

        // Pricetag interactable(Right click on the label Price per unit and copy the XPath)
        IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
        priceTag.Click();

        // Input Pricetag
        IWebElement priceTextBox = driver.FindElement(By.Id("Price"));
        priceTextBox.SendKeys("123");

        // Click on save button
        IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
        saveButton.Click();
        Thread.Sleep(3000);

        // Go to last page
        IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
        goToLastPageButton.Click();
        Thread.Sleep(1500);
        // check if material record has been created successfully
        IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

        if (newCode.Text == "Trial0")
        {
            Console.WriteLine("New material record created successfully.");
        }
        else
        {
            Console.WriteLine("New material record hasn't been created");
        }
        Thread.Sleep(1500);
    }
        public void EditTM(IWebDriver driver)
        {
            // Click on Edit
            IWebElement clickEdit = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            clickEdit.Click();

            IWebElement clearCodeTextBox = driver.FindElement(By.Id("Code"));
            clearCodeTextBox.Clear();
            clearCodeTextBox.SendKeys("hi");
            IWebElement saveclearCodeText = driver.FindElement(By.Id("SaveButton"));
            saveclearCodeText.Click();

            Thread.Sleep(2500);

            IWebElement goToLastPageB = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageB.Click();

            Thread.Sleep(3500);
        }

        public void deleteTM(IWebDriver driver)
        {
            // delete 
            IWebElement clickDelete = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            clickDelete.Click();
            driver.SwitchTo().Alert().Accept();
        }
    }
}
