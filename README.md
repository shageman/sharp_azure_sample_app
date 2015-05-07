# sharp_azure_sample_app
Showing testing, components, dependency injection, azure deployment, 

## Setup

* Change the DB connection string in UserService/Web.config to the creds of your DB
* Run with `F5`

## API

Check out http://userservice4143.azurewebsites.net/Help for details of the available API calls.

* GET /api/Users gets all users from the DB
* POST /api/Users (be sure to set the content-type to be json) creates a user in the DB

## Production

The service runs on Azure at  http://userservice4143.azurewebsites.net
