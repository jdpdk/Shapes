Feature: Square

A short summary of the feature

@SquareArea
Scenario: Get area af square
	Given the height is 20
	And the width is 20
	When the area is calculated
	Then the result should be 400


@SquareCircumference
Scenario: Get circumference af square
	Given the height is 20
	And the width is 20
	When the circumference is calculated
	Then the result should be 80

@SquareCircumference
Scenario: Get circumference af square error
	Given the height is 30
	And the width is 20
	When the circumference is calculated
	Then the result should be 80