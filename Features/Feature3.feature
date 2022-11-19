Feature: Feature3
	Withdraw money

Scenario: Withdraw money
	Given I select the withdrawal button
	When I Input a withdrawal amount
	And I Select withdraw
	Then I should get a withdrawal succefful message


