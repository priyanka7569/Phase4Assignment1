Feature: Calculator1
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Multiply of Two numbers
	Given the first number is 5
	And the second number is 3
	When the two numbers are Multiplied
	Then the result should be 15

	Scenario: Subtraction of Two numbers
	Given the first number is 10
	And the second number is 5
	When the two numbers are Subtracting
	Then the result should be 5

	Scenario: Division  of Two numbers
	Given the first number is 15
	And the second number is 3
	When the two numbers are Dividing
	Then the result should be 5