Feature: Feature2
	Deposit money

Scenario: Deposit money
	Given I Select the deposit button
	When Input deposit amount
	And I Select deposit button
	Then the deposit is successful

	