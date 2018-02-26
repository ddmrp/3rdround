@Navigation
Feature: Navigation
	In order to access to top level links
	As a user on the site
	I want to be able to navigate to various links from top

@UI @Success
Scenario Outline: Success top navigation link
	Given I am on HomePage
	When I click on a link <Link> from top navigation
	Then correct top navigation web page <Link> should render
	Examples:
	| Section        | Link    |  
	| Top Navigation | Logo    |
	| Top Navigation | Office  |
	| Top Navigation | Windows |
	| Top Navigation | Surface |
	| Top Navigation | Xbox    |
	| Top Navigation | Deals   |
	| Top Navigation | Support |
	| Top Navigation | More    |
	| Top Navigation | Search  |
	| Top Navigation | Cart    | 