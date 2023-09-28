Feature: Calculate Defect Density
  As a Quality Engineer,
  I want to calculate Defect Density
  So that I can assess the quality of the code base.

# As a Quality Engineer, I want to calculate the Defect Density 
    #  so that I can assess the quality of the code base.
#	Acceptance Criteria:
#	Input: Total defects, Total Lines of Code
#	Output: Defect Density

  Scenario: Calculate Defect Density
    Given I have a calculator
    When I have entered 100 and 50 into the calculator and press defect density
	Then the defect density should be 2
    
	