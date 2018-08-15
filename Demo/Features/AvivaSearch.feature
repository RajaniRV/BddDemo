Feature: AvivaHomeLinks
	In order to get main links on Google for Aviva
	As a user I search for Google
	So that I can see the links of Aviva websites

Scenario: Successful search of Aviva in the Google homepage
	Given User launch google.com
	When User search for Aviva in Google
	Then They should see 6 links in the first search page
	And They should see the fifth link text