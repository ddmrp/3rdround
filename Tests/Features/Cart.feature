@Cart
Feature: Cart
	In order to shop on site
	As a normal user
	I want to be able to manage my shopping cart

@UI	@Success @AddItem
Scenario: Success Cart add item
	Given I am in my shopping cart
	When I click on Add to cart link
	Then The item should be added to cart

@UI	@Success @RemoveItem
Scenario: Success Cart remove item
	Given I am in my shopping cart
	When I click on Remove item link
	Then The item should be removed from cart


@UI	@Success @Navigation
Scenario Outline: Success cart accessed
	Given I am signed in to the site with username <Username> password <Password>
	When I click on shopping cart link
	Then I should land on my shopping cart

	Examples: 
	| Username             | Password       |
	| Ddmrp222@outlook.com | DemandDriven1! |
