using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PrepScraper;

public class Client
{
    ChromeDriver driver;

    public Client()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/web-form.html");
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
    }

    ~Client() {
        driver.Quit();
    }

    public string Test()
    {
        return driver.Title;
    }
}
