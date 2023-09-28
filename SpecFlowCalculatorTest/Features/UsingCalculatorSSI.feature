Feature: Calculate SSI
  As a Quality Engineer,
  I want to calculate the new total Shipped Source Instructions (SSI) for successive releases
  So that I can keep track of the system’s complexity.

# As a Quality Engineer, I want to calculate the new total Shipped Source Instructions (SSI) 
    # for successive releases so that i keep track of the system’s complexity.
#	Acceptance Criteria:
#	Input: Previous SSI, New Lines of Code, Deleted Lines of Code
#	Output: New SSI


  Scenario: Calculate new total SSI for successive releases
    Given I have a calculator 
    When I have entered 10, 20 and 5 into the calculator and press SSI
    Then the SSI shiould be total 25
    
 

    