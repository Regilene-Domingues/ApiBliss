[BACKEND RECRUITMENT DELIVERY] v0.1

The API was developed in Backend.

Language: C#
Framework: .Net Core 3.1
Database: MySql
Architecture: DDD (Domain Driven Design)

The database connection string is in the ContexFactory Class, which is in the Context folder inside the Api.Data layer.


Information for the operation of the API:

Get/Healths - Only Execute

Get/Questions - Only Execute
Post/Questions - Required fields
	{
		"question": "string",
			"choice": [
			{
				"choice": "string"
			}]
	}

Get/Questions/{id} - Required id


How to run the API:

Enter data using Post/Questions;
Get the id through Get/Questions;
Use the information you got from Get/Questions to work on Get/Questions{id};