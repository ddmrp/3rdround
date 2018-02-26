@UI @Search
Feature: Search
	In order to find out information from the site
	As a normal user
	I want to be able to type in search terms into searchbox

	@Success
Scenario Outline: Success Search for information
	Given I am on HomePage
	When I search for terms <SearchTerms> in searchbox
	Then result items relevant to search terms <SearchTerms> should appear

	Examples: 
	| Name          | SearchTerms                             |
	| Ddmrp         | Demand Driven Material Requirement Plan |
	| PersonTy      | Ty Norton                               |
	| PersonEric    | Eric Falsken                            |
	| PersonFrank   | Frank Zhang                             |
	| PersonMichael | Michael Durkin                          |
	| PersonHerman  | Herman Xiao                             |