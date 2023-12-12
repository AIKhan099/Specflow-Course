Feature: ThirdTableDataDrivenExample

A short summary of the feature

@tag1
Scenario: Login scenario through the data table.
	Given I am at the login page of automation exercise website.
	When I enter username <username>.
	And I enter password <password>.
	And I click the login button.
	Then I successfully logged in.
	
Examples:
	| username                | password |
	| automation@gmail.com | 54321    |
	| jen@gmail.co         | 12345    |
	
