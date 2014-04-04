using System;
using TechTalk.SpecFlow;
using Tests.Pages;

namespace WebTests.Steps
{
	[Binding]
	public class BlogLoginSteps
	{
		[Given(@"I navigated to the login page")]
		public void GivenINavigatedToTheLoginPage()
		{
			new LoginPage().Navigate();
		}

		[Given(@"Entered ""(.*)"" as user name and ""(.*)"" as password")]
		public void GivenEnteredAsUserNameAndAsPassword(string userName, string password)
		{
			new LoginPage().EnterCredentials(userName, password);
		}

		[When(@"I click login button")]
		public void WhenIClickLoginButton()
		{
			new LoginPage().ClickLogin();
		}

		[Then(@"I should see log off text at the top of the screen")]
		public void ThenIShouldSeeLogOffTextAtTheTopOfTheScreen()
		{
			new LoginPage().ShouldContainLogOffLink();
		}
	}
}
