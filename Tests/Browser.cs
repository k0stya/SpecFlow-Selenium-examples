using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
	public class Browser
	{
		private static IWebDriver _currentWebDriver;

		public static IWebDriver Current
		{
			get { return _currentWebDriver = (_currentWebDriver ?? new ChromeDriver()); }
		}

		public static void Close()
		{
			Current.Quit();
		}
	}
}