using OpenQA.Selenium;

namespace Utilities
{
    public class WebUtilities
    {
        private IWebDriver _driver;

        public WebUtilities(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement FindElement(By by)
        {
            return _driver.FindElement(by);
        }

        public IReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return _driver.FindElements(by);
        }

        public void Click(By by)
        {
            FindElement(by).Click();
        }

        public void SendKeys(By by, string text)
        {
            FindElement(by).SendKeys(text);
        }
    }
}