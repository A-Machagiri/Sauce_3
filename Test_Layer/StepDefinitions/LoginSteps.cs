using NUnit.Framework;
using OpenQA.Selenium;
using PageObjects.Login;
using TechTalk.SpecFlow;

[Binding]
public class LoginSteps
{
    private IWebDriver _driver;
    private LoginPage _loginPage;

    public LoginSteps(IWebDriver driver)
    {
        _driver = driver;
        _loginPage = new LoginPage(_driver);
    }

    [Given("I am on the login page")]
    public void GivenIAmOnTheLoginPage()
    {
        _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
    }

    [When("I enter valid credentials")]
    public void WhenIEnterValidCredentials()
    {
        _loginPage.EnterCredentials("standard_user", "secret_sauce");
    }

    [When("I enter invalid credentials")]
    public void WhenIEnterInvalidCredentials()
    {
        _loginPage.EnterCredentials("invalid_user", "wrong_sauce");
    }

    [When("I click the login button")]
    public void WhenIClickTheLoginButton()
    {
        _loginPage.ClickLoginButton();
    }

    [Then("I should be redirected to the home page")]
    public void ThenIShouldBeRedirectedToTheHomePage()
    {
        Assert.IsTrue(_driver.Url.Contains("inventory"));
    }

    [Then("I should see an error message")]
    public void ThenIShouldSeeAnErrorMessage()
    {
        Assert.IsTrue(_loginPage.GetErrorMessage().Contains("error"));
    }
}