Feature: DescriptionFeature1

As a Seller
I want the feature to add,Edit and delete my Description Details
So that The people seeking for some skills can look into my details.



Scenario: [Create new description record with valid detail]
	Given I logged in to localhost  sucessfully
	When I create a New description Record
	Then New description record should be created successfully
	Then Close the Browser

Scenario: [Edit new description record with valid detail]
	Given I logged in to localhost  sucessfully
	When I edit a New description Record
	Then New edited description record should be deleted successfully
	Then Close the Browser

Scenario: [Delete new description record with valid detail]
	Given I logged in to localhost  sucessfully
	When I delete a New description Record
	Then New editeddescription record should be deleted successfully
	Then Close the Browser

