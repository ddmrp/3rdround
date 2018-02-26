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
	| Section       | Link       | Url                                                                     |
	| Bottom Footer | Locale     | https://www.microsoft.com/en-us/surface/devices/surface-book-2/overview |
	| Bottom Footer | SiteMap    | https://www.microsoft.com/en-us/surface/devices/surface-book-2/overview |
	| Bottom Footer | ContactUs  | https://www.microsoft.com/en-us/surface/devices/surface-book-2/overview |
	| Bottom Footer | Privacy    | https://www.microsoft.com/en-us/surface/devices/surface-book-2/overview |
	| Bottom Footer | Terms      | https://www.microsoft.com/en-us/surface/devices/surface-book-2/overview |
	| Bottom Footer | Trademarks | https://www.microsoft.com/en-us/surface/devices/surface-book-2/overview |
	| Bottom Footer | AboutAds   | https://www.microsoft.com/en-us/surface/devices/surface-book-2/overview |