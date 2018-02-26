@Profile
Feature: Profile
	In order to maintain personal information
	As a normal user
	I want to be able to manage my account information

@UI	@Success @Navigation
Scenario Outline: Success Profile page accessed after signin in
	Given I am signed in to the site with username <Username> password <Password>
	When I click on View Microsoft Account link
	Then I should land on my profile page
	Examples: 
	| Username             | Password       |
	| Ddmrp222@outlook.com | DemandDriven1! |


@UI	@Success @UpdateNames
Scenario Outline: Success Profile update names
	Given I am on my profile page
	When I save my updated firstname <FirstName> lastname <LastName>
	Then The updated names should show

	Examples: 
	| FirstName | LastName |
	| Ty        | Norton   |
	| Eric      | Falsken  |
	| Frank     | Zhang    |
	| Michael   | Durkin   |
	| Herman    | Xiao     |