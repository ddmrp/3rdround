Feature: BottomFooter
	In order to navigate to other links from the footer
	As a user on the site
	I want to be able to navigate to various links from the footer

@UI @Footer
Scenario: Add two numbers
	Given I am on the homepage of the site
	When I click on a link on the footer
	Then the corresponding web page should render
	| Section         | Link            | Url                                                                     |
	| What's New      | Surface Book 2  | https://www.microsoft.com/en-us/surface/devices/surface-book-2/overview |
	| Store & Support | Account Profile | https://www.microsoft.com/en-us/surface/devices/surface-book-2/overview |