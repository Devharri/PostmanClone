# Postman Clone
- Blazor Web App for API calls
- Targeted to run from a Docker container

This app provides a user-friendly interface for making GET requests to to APIs and viewing the responses in formatted JSON. Ideal for developers and testers. This tool simplifies API interaction and debugging, helping you efficiently validate and troubleshoot your API calls. 

## Technologies Used
* C#
* .NET 8
* Blazor Web App
* HttpClient

## Using The App
1. Clone the repository
2. Run from terminal: "dotnet publish --os linux --arch x64 -p:PublishProfile=DefaultContainer -c Release"
![Postman Clone App dotnet publish](Images/screenshot0.png "Dotnet publish")
3. Run your docker image
4. When the application launches, it should look like this
![Postman Clone App ready to run](Images/screenshot1.png "Ready to run")
5. Fill in your API URL and hit Submit
![Postman Clone App results](Images/screenshot2.png "Submit results")

## Upcoming Changes
* Adding POST, PUT, PATCH and DELETE functionalities
* Adding API headers
* Handling API authentication
* Adding Dependency Injection
* Adding Logging
