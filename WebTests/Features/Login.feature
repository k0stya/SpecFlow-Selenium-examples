Feature: BlogLogin
	In order edit blog content
	As a blog user
	I want to be able to login into the blog

Scenario: Login into the blog
	Given I navigated to the login page
	And Entered "Admin" as user name and "admin" as password
	When I click login button
	Then I should see log off text at the top of the screen