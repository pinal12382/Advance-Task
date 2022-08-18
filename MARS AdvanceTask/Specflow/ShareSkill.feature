Feature: ShareSkill

A short summary of the feature

@tag1
Scenario: [Add a Skill Record with valid Details]
	Given [I logged in to localhost  Sucessfully]
	When [I added new skill record ]
	Then [New skill record should be created Sucessfully]
	Then [Close thr Browser]

	Scenario Outline: [Edit a Share Skill Record with valid Details]
	Given [I logged in to localhost  Sucessfully]
	When [I Edited new skill record ]
	Then [Edited skill record should be created Sucessfully]
	Then [Close thr Browser]

   Scenario Outline: [Delete a Skill Record Sucessfully]
	Given [I logged in to localhost  Sucessfully]
	When [I Delete new skill record ]
	Then [New skill record should be deleted Sucessfully]
	Then [Close thr Browser]
