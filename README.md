# Fitness-Frog

FitnessFrog is a demo application that applies modern tools and practices for developing an ASP.NET application. 
FitnessFrog is designed to work on the go-foward .NET Framework for open source development (.NET Core).
Likewise, it allows Fitness-Frog to run in multiple environments (Windows, Linux, Mac, Docker).

## Requirements   
* VisualStudio 2015 Community
* .NET Core 1.01 - VS 2015 Tooling Preview 2
* SQL Server 2014 Express

## Other Packages
* Microsoft.EntityFrameworkCore.Tools (Nuget)
* Microsoft.EntityFrameworkCore.SqlServer (Nuget)

Note:
The above packages should restore automatically on build.

## Other 1st-Time Experiences
We're going with .NETCoreApp Framework (.NET Core 1.01).  This is Microsoft's go-forward strategy, but it's not
totally mature.  Getting this solution setup was a hodge-podge of creating from templates, and manually
editing package/project.json files.  Most noteably, The EntityFrameworkCore.Tools is still in preview; a "final"
preview, but a preview nonetheless.  These are the command-line tools for EntityFrameworkCore, which we will
need for code-first migrations (yet untested). Also, creating a "Class Library" from the template you have
available (after installing .NET Core 1.01 - VS 2015 Tooling Preview 2) uses the .NETStandard framework, which
is not totally compatible with the .NETCoreApp framework we use for the UI project so that sucks. It will,
but doesn't today. The way around that was to create a "Console Application" from the Core templates and then
delete the Program.cs file, which essentially turns it back into a class library, but one that uses .NETCoreApp
framework and can subsequently have EntityFrameworkCore.Tools and EntityFramework.SqlServer referenced within,
and that can be referenced within the UI project with intellisence on members.  In other words, the environment
is setup, but all this new stuff is not 100% documented yet for 1st-Time users.

## Helpful Documentation
* http://localhost:49865/ (When you run the FitnessFrog.Core.UI)
* http://www.microsoft.com/net/core#windows
* https://docs.asp.net/en/latest/tutorials/first-mvc-app/start-mvc.html
* https://docs.asp.net/en/latest/data/ef-mvc/intro.html#entity-framework-core-nuget-packages
