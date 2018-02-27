@Profile
Feature: Profile
	In order to maintain personal information
	As a normal user
	I want to be able to manage my account information


@UI	@Success @UpdateNames
Scenario Outline: Success Profile update names
	When I save updated firstname <Firstname> lastname <Lastname>
	Then The new firstname <Firstname> lastname <Lastname> should show

	Examples: 
	| Username             | Password       | Firstname | Lastname |
	| ddmrp222@outlook.com | DemandDriven1! | Ty        | Norton   |
	| ddmrp222@outlook.com | DemandDriven1! | Eric      | Falsken  |
	| ddmrp222@outlook.com | DemandDriven1! | Frank     | Zhang    |
	| ddmrp222@outlook.com | DemandDriven1! | Michael   | Durkin   |
	| ddmrp222@outlook.com | DemandDriven1! | Herman    | Xiao     |


@UI	@Success @Navigation
Scenario Outline: Success Profile page accessed
	Given I am signed in to the site with username <Username> password <Password>
	When I click on View Microsoft Account link
	Then I should land on my profile page

	Examples: 
	| Username             | Password       |
	| Ddmrp222@outlook.com | DemandDriven1! |
