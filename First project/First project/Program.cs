using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


// open chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// launch turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

// identify username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

// identify password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

// identify login button and click on it
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();

// check if the user has logged in successfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("Logged in successfully, test passed.");
}
else
{
    Console.WriteLine("Login failed, test failed.");
}

// Click on administration tab
Thread.Sleep(1500);
IWebElement AdministrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
AdministrationTab.Click();

//Select Time and Material
IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmOption.Click();
Thread.Sleep(1500);

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
// check if material record has been created successfully
IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

if (newCode.Text == "June2022")
{
    Console.WriteLine("New material record created successfully.");
}
else
{
    Console.WriteLine("New material record hasn't been created");
}
