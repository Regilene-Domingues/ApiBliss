[BACKEND RECRUITMENT DELIVERY] v0.1

This test is incomplete, the share part is missing.

The API was developed in Backend.

Language: C#
Framework: .Net Core 3.1
Database: MySql
Architecture: DDD (Domain Driven Design)

The database connection string is in the ContexFactory Class, which is in the Context folder inside the Data layer.
Inside the Data layer, in the Seeds folder, there is the TableQuestionSeeds.cs class where we input 15 questions and answers for the Api's operation.

Information for the operation of the API:

Healths
Get/Healths - Only Execute

Questions
Get/Questions - enter the page number (1 or 2) and run
Get/Questions/{id} - Required id (Get the id through Get/Questions;)


