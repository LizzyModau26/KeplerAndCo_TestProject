Feature: Register



@Register
Scenario: [Creating a new account]
	Given that the account registration page is dislayed.
	When I enter my correct credentials Reg_email , Reg_password and Confirm_password
	| Reg_email             | Reg_password  | Confirm_password |
	| lebogang@eblocks.co.za| Register123@@ | Register123@@    |
	When I click the register button
	Then I Should be redirected to a email verification page
