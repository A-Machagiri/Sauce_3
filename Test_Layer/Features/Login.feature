Feature: Login Functionality

  Scenario: Successful Login
    Given I am on the login page
    When I enter valid credentials
    And I click the login button
    Then I should be redirected to the home page

  Scenario: Failed Login
    Given I am on the login page
    When I enter invalid credentials
    And I click the login button
    Then I should see an error message