# 888-DevOps-Test
This is the hiring assignment for Devops candidates at 888\Sparkware. It’s intended to mimic work you might do here, while giving us an understanding of your skills.

# How to answer this assignment
In this repo you can find a Hello world application writen in .NET 5 that also includes UnitTest Porject.

You required to create a new project in Azure DevOps and use it to create a full CI/CD pipeline.
The pipeline should include:
- Build the application.
- Run the unit test (continue only if all tests have passed).
- Create a docker image of the appcalition.
- Deploy it to Kubernetes or any other docker container.  

*You can use the following these docker images:
mcr.microsoft.com/dotnet/sdk:5.0-alpine to build the app and mcr.microsoft.com/dotnet/aspnet:5.0-alpine to run the app on.

