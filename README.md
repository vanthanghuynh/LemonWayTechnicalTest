# LemonWayTechnicalTest
Technical test project

# Run applications
To run application, you must setup the startup projects, right-click on the solution -> Propertises-> Startup Project-> Multipes startup project:
- Set LemonWay.WebService project as Start without debugging
- Set LemonWay.Winform project as Start

# Url webservice
By default, url webservice is http://localhost:52811/, if you change the port, you must update the file app.config in two project: LemonWay.WebserviceConnector and LemonWay.WinFom

# Integration test
To run integration test, you must run the LemonWay.WebService project first (as Start without debugging).

# Nuget pakages
The following nuget packages were used in the projects:
- Autofac 4.9.4.0
- Autofac.Web 4.0.0.0
- Newtonsoft.Json  12.0.0.0

