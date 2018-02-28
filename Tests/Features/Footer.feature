@Footer
Feature: Footer
	In order to navigate to other links from the footer
	As a user on the site
	I want to be able to navigate to various links from the footer

@UI @Success
Scenario Outline: Success footer link
	Given I am on HomePage
	When I click on a link <Link> from footer
	Then the corresponding web page <Link> should render
	Examples:
	| Section         | Link                    | 
	| Bottom Footer   | Locale                  |
	| Bottom Footer   | SiteMap                 |
	| Bottom Footer   | ContactUs               |
	| Bottom Footer   | Privacy                 |
	| Bottom Footer   | Terms                   |
	| Bottom Footer   | Trademarks              |
	| What's new      | AboutAds                |
	| Store & Support | Account profile         |
	| Education       | Microsoft in education  |
	| Enterprise      | Microsoft Azure         |
	| Developer       | Microsoft Visual Studio |
	| Company         | Careers                 |
