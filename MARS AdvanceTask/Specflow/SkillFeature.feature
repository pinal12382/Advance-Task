Feature: SkillFeature



As a Seller
I want the feature to add,Edit and delete my Skill Details
So that The people seeking for some skills can look into my details.



Scenario: [Create new Skill record with valid detail]
	Given I logged in to localhost  sucessfully
	When I create a New Skill and Skill level Record
	Then New Skill  and New Skill level record should be created successfully
	Then Close the Browser

 Scenario Outline: : [Edit new Skill record with valid detail]
	Given I logged in to localhost  sucessfully
	When I edit a New Skill and Skill level Record
	Then New edited Skill and Skill level record should be edited successfully
	Then Close the Browser

Scenario Outline: [Delete Skill record]
	Given I logged in to localhost  sucessfully
	When I delete a Skill and Skill level Record
	Then Skill record should be deleted successfully
	Then Close the Browser