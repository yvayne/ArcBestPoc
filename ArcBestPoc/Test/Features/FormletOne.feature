Feature: FormletOne
	In order to verify functionalty of formlet one
	As an user
	I want to verify the formlet is working as expected.

@FormletOne
Scenario: Verify that is possible to set the start and end date manually
	Given I go to testone page
	When I set the startDate field with the following "03/06/1998" value
		And I set the endDate field with the following "03/06/2000" value
	Then the value of the startDate field should be "03/06/1998" 
		And the value of the endDate field should be "03/06/2000" 

@FormletOne
Scenario: Verify that is not possible to set the start date with invalid date
	Given I go to testone page
	When I set the startDate field with the following "131313" value
		And I set the endDate field with the following "03/06/2000" value
		And I press validate button
		And I press ok button from alert window

@FormletThree
Scenario: Verify that is possible to collapse the formlet three
Given I go to testone page
When I click hide button from formlet three
Then It should be displayed the following "This formlet has been collapsed with a summary!" message
