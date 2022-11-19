Feature: Feature6
	Add customer

Scenario: Add customer
	Given Select bank manager login
	When I Select Add customer header
	And I Provide customer details
	When I Select add customer 
	Then I should get a succeful validation message

	