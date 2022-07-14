using First_project.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// Open chrome driver
IWebDriver driver = new ChromeDriver();

//Login page intialization and definition
LoginPage loginPageObj = new LoginPage();
loginPageObj.LoginActions(driver);

//Homepage intialization and definition
HomePage homePageObj = new HomePage();
homePageObj.GoTOPage(driver);

//TM Page intialization and definition

TMPage tmPageObj = new TMPage();
tmPageObj.CreateTM(driver);
tmPageObj.EditTM(driver);
tmPageObj.deleteTM(driver);






