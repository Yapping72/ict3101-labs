Feature: UsingCalculatorBasicReliability
    In order to calculate the Basic Musa model's failures/intensities
    As a Software Quality Metric enthusiast
    I want to use my calculator to do this

@BasicReliability
Scenario: Calculate Failure Intensity
    Given I have a calculator
    When I have entered initial failure as 10 total failure as 100 average failure as 50 and press CurrentFailureIntensity
    Then the BasicReliability result should be 5
    
@BasicReliability
Scenario: Calculate Average Number of Expected Failures
    Given I have a calculator
    When  I have entered initial failure as 10 total failure as 100 time as 10 and press AverageNumberOfExpectedFailures
    Then the BasicReliability result should be 63