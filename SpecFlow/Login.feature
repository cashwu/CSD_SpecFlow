Feature: Login

Scenario: Login Success
	Given there is a user with username "cc@cc.com" and password "P@ssw0rd"
	When login with "cc@cc.com" and "P@ssw0rd"
	Then i can see "Hello cc@cc.com!"
