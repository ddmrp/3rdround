@Signin
Feature: Signin
	In order to manage my account and profile information
	As an authorized user
	I want to be authenticated to the site

Background: 
Given I am on the Signin page

@UI @Success
Scenario Outline: Success Sign In with valid username password
When I enter valid username <Username> / password <Password>
Then I should be able to sign in the site
	Examples: 
	| Username             | Password       |
	| Ddmrp222@outlook.com | DemandDriven1! |

@UI	@Failed @InvalidUsername
Scenario Outline: Failed Sign In with invalid username
When I enter invalid username <Username>
Then I should be denied access to the site
	Examples: 
	| Username             | Password     |
	| ddmrp999@outlook.com | DoesntMatter |
	| ZZZ99ZZZ@outlook.com | DoesntMatter |
	| ZZZZZZZZ@gmail.com   | DoesntMatter |

@UI	@Failed @InvalidPassword
Scenario Outline: Failed Sign In with invalid password
When I enter invalid password <password>
Then I should be denied access to the site
	Examples: 
	| Username             | Password      |
	| test@example.com     | WrongPassword |
	| ZZZZZZZZ@outlook.com | WrongPassword |
	| ddmrp222@outlook.com | WrongPassword |
