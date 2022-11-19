Feature: Feature4
	Change account to show pound

Scenario: Change account to show pound
	Given I change account type to show the currency pound
	Then the account number should change
	