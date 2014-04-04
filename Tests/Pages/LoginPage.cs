using OpenQA.Selenium;

namespace Tests.Pages
{
	public class LoginPage
	{
		private const string Url = @"!!!login page url!!!";

		public LoginPage Navigate()
		{
			Browser.Current.Navigate().GoToUrl(Url);
			return this;
		}

		public LoginPage EnterCredentials(string login, string password)
		{
			var log = Browser.Current.FindElement(By.Id("UserName"));
			log.SendKeys(login);
			var pwd = Browser.Current.FindElement(By.Id("Password"));
			pwd.SendKeys(password);
			return this;
		}

		public LoginPage ClickLogin()
		{
			Browser.Current.FindElement(By.Id("LoginButton")).Click();
			return this;
		}

		public LoginPage ShouldContainLogOffLink()
		{
			Browser.Current.FindElement(By.PartialLinkText("Log off"));
			return this;
		}
	}
}
