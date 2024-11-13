using System;
using OpenQA.Selenium;

namespace PageObjects.Login
{
    public partial class LoginPage
    {
        public void EnterCredentials(string username, string password)
        {
            IWebElement usernameField = driver.FindElement(By.Id(LoginPage_Locators.UsernameLocator));
            IWebElement passwordField = driver.FindElement(By.Id(LoginPage_Locators.PasswordLocator));
            usernameField.SendKeys(username);
            passwordField.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            IWebElement loginButton = driver.FindElement(By.Id(LoginPage_Locators.LoginButtonLocator));
            loginButton.Click();
        }
    }
}
