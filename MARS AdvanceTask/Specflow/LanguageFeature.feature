Feature: LanguageFeature

A short summary of the feature

As a Seller
I want the feature to add,Edit and delete my language Details
So that The people seeking for some skills can look into my details.



Scenario: [Create new language record with valid detail]
	Given I logged in to localhost  sucessfully
	When I create a New language and language level Record
	Then New language  and New language level record should be created successfully
	Then Close the Browser

Scenario: [Edit new language record with valid detail]
	Given I logged in to localhost  sucessfully
	When I edit a New language and language level Record
	Then New edited language and language level record should be edited successfully
	Then Close the Browser

Scenario: [Delete language record]
	Given I logged in to localhost  sucessfully
	When I delete a language and language level Record
	Then language record should be deleted successfully
	Then Close the Browser