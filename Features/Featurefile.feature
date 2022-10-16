Feature: Featurefile
	Simple calculator for adding two numbers

@mytag
Scenario: Get API response using given endpoint
	Given I have an endpoint / /
	And I have base url https://ddd
	When I call GET Mthod api
	Then I get API response in json format