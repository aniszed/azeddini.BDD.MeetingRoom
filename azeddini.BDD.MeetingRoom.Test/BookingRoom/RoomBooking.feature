Feature: RoomBooking
	In order to book a room
	As a user of the app
	I want to be able to perform book operations aver the api

@t_room @t_get
Scenario: Get All rooms
	When I want to display the room list
	Then the result should be http OK result
	And we must obtain 10 rooms
	And the rooms name must be unique
