using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Tests.Pages
{
	public class ContentPage
	{
		private string _url;

		public ContentPage Navigate()
		{
			_url = @"!!!login page url!!!";
			Browser.Current.Navigate().GoToUrl(_url);
			return this;
		}

		public ContentPage GoToWriteNewPostScreen()
		{
			var wait = new WebDriverWait(Browser.Current, TimeSpan.FromSeconds(10));
			var el = wait.Until(drv => drv.FindElement(By.ClassName("btn-header")));
			el.Click();
			return this;
		}

		public ContentPage Publish()
		{
			var wait = new WebDriverWait(Browser.Current, TimeSpan.FromSeconds(10));
			var el = wait.Until(drv => drv.FindElement(By.PartialLinkText("Publish")));
			el.Click();
			return this;
		}

		public ContentPage CheckIfPostPublished(string postTitle)
		{
			var wait = new WebDriverWait(Browser.Current, TimeSpan.FromSeconds(10));
			wait.Until(drv => drv.PageSource.Contains(postTitle));
			return this;
		}

		public ContentPage PostTitle(string title)
		{
			var wait = new WebDriverWait(Browser.Current, TimeSpan.FromSeconds(10));
			var el = wait.Until(drv => drv.FindElement(By.Name("txtTitle")));
			el.SendKeys(title);
			return this;
		}

		public ContentPage PostBody(string body)
		{
			var wait = new WebDriverWait(Browser.Current, TimeSpan.FromSeconds(10));
			var el = wait.Until(drv => drv.FindElement(By.Id("editor")));
			el.SendKeys(body);
			return this;
		}
	}
}