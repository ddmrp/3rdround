@Signin
Feature: Signin
	In order to manage my account and profile information
	As an authorized user
	I want to be authenticated to the site

Background: 
Given I am on the Signin page

@UI @Success
Scenario Outline: Success Sign In with valid username password
When I enter username <Username> / password <Password>
Then I should be able to access the site
	Examples: 
	| Username             | Password       |
	| Ddmrp222@outlook.com | DemandDriven1! |

@UI	@Failed @InvalidUsername
Scenario Outline: Failed Sign In with invalid username
When I enter username <Username> / password <Password>
Then I should be denied access to the site
	Examples: 
	| Username              | Password     |
	| ddmrp9999@outlook.com | DoesntMatter |
	| ZZZ666ZZZ@outlook.com | DoesntMatter |
	| ZZZ888ZZZ@gmail.com   | DoesntMatter |
	| ZZZ999ZZZ@gmail.com   | DoesntMatter |

@UI	@Failed @InvalidPassword
Scenario Outline: Failed Sign In with invalid password
When I enter username <Username> / password <Password>
Then I should be denied access to the site
	Examples: 
	| Username             | Password      |
	| test1000@example.com | WrongPassword |
	| test1001@example.com | WrongPassword |
	| test1002@example.com | WrongPassword |
	| test1003@example.com | WrongPassword |
	| test1004@example.com | WrongPassword |
