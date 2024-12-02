Feature: Customer List Sorting

  Scenario: Sorting the customer list by first name
    Given I am on the bank login page
    When I log in as a bank manager
    And I navigate to the customers page
    And I sort the customer list by first name
    Then the customer list should be sorted in alphabetical order by first name
