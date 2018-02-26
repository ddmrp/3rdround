@Search
Feature: Search
	In order to find out information from the site
	As a normal user
	I want to be able to type in search terms into searchbox

@UI	@Success @SearchBox
Scenario Outline: Success Search from Searchbox
	Given I am on HomePage
	When I search for terms <SearchTerms> in searchbox
	Then result items relevant to search terms <SearchTerms> should appear

	Examples: 
	| SearchTerms                             |
	| Demand Driven Material Requirement Plan |
	| DDMRP                                   |
	| Demand Driven                           |
	| Material Requirement Plan               |
	| MRP                                     |
	| DemandDrivenTech                        |

	@UI	@Success @SearchResults @ShowAll
Scenario Outline: Success Search Results Show All
	Given I am on SearchResults page for terms <SearchTerms>
	When I click on Show All results link
	Then all result items relevant to search terms <SearchTerms> should appear

	Examples: 
	| SearchTerms    |
	| Stephen King   |
	| Eric Falsken   |
	| Frank Zhang    |
	| Michael Durkin |
	| Herman Xiao    |