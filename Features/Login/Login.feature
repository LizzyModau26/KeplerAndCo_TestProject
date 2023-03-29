Feature: Login



@Login
Scenario: [Accessing an existing account]
	Given that the login form is displayed
	When I enter the correct login details Login_email and Login_password.
	| Login_email             | Login_password |
	| modaulebogang@gmail.com | Tester123@@    |
	When I click on the login button
	Then I should be redirected to the homescreen. 

	@IncorrectLogin
Scenario: [Accessing an existing account with incorrect credentials]
	Given that the login form is loaded
	When I enter the incorrect login details Login_email and Login_password.
	| Login_email             | Login_password |
	| modau@gmail.com | Tester987##    |
	When I click on the sign in button
	Then I should not be redirected to the homescreen. 
