Feature: Businesspartner
	
@login and businesspartner form check
Scenario: user should be able to login and Reset, close and submit business partner form
	Given Enter valid user email and password
	And click on Ok button
	And user selects Business Partner form Favorites
	And click on close button
	And Again open business partner form
	And Fills The Form And Clicks On Reset Button
	And Again fill the form
	And clik on ok button
	And clicks on new button
	And verifies business partner form is opened
	When Fill all required details
	Then user records successfully saved