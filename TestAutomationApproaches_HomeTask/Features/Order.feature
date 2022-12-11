Feature: Order

Background: login
	Given user in the login page to sign in

@tag1
Scenario Outline: Verify user can log in successfully
	When user enter <username> <password>
	Then user will login to the Swag Labs

Examples: 
		| username      | password     |
		| standard_user | secret_sauce |


@tag2
Scenario: verify user can place a order
	Given user in the product page
	When user click on the product
	Then navigate to the product details page
	When user click on the add to cart button
	When user click on the cart icon
	Then navigate to cart
	When user click on the checkout button
	Then navigate to checkout page
	When user enter firstName lastName and zipCode
		| FirstName | LastName | ZipCode |
		| Leshani   | Isanka   | 12345   |
	When user click on the continue button
	Then navigate to overview page
