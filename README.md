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
* Microsoft.VisualStudio.Web.CodeGenerators.Tools (Nuget - UI Project Only)
* Microsoft.VisualStudio.Web.CodeGenerators.Mvc (Nuget - UI Project Only)

Note:
The above packages should restore automatically on build.

## To Run Project
* Have VisualStudio 2015 installed
* Have SQL Server 2014 Express installed
* Clone this repository (https://github.com/chris-cornish/fitness-frog.git)
- Open FitnessFrog.sln
* Open (\FitnessFrog.Core.UI\appsettings.JSON)
- Replace 'LAPTOP-MTVPNT7U\\\SQLEXPRESS' with your local database (usually computer name followed by '\\\SQLEXPRESS')
* Open Package Manager Console ( Tools > NuGet Packet Manager > Package Manager Console)
- Set Package source to All
- Set Default project to 'Core\FitnessFrog.Core.Domain.Data'
- In the console type in 'update-database' then hit enter (should return with 'Done' when finished)
* F5 to run project
* In the current project state you'll need to add a User first (will have to manually enter LastLoginDate, IP, and Modification Date)
- Next create a Day
- Then Exercises, Notes, or Foods in any order.

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

## Scaffolding
There is a bug in scaffolding currently when the model is referenced in an outside assembly, i.e. the way
we are doing it and the way it should be done. This was supposedly fixed in the preview1-update2, September
release, but I can confirm that it is NOT and will recommend they re-open the issue. In the near term, the
only suggested workaround is to temporarily include the contents of Domain and Domain.Data in the UI project,
create the scaffolds, and then remove the contents again.

Here is the tracked issue:
* https://github.com/aspnet/Scaffolding/issues/251

Here are the steps I used to get around the issue:
* I "unreferenced" FitnessFrog.Core.Domain and FitnessFrog.Core.Domain.Data.
* I created a folder in the UI project called "Workaround."
* I copied all of the .cs files from FitnessFrog.Core.Domain and .Data to the "Workaround" folder.
* I right clicked on the "Controllers" folder and chose Add "New Scaffolded Item."
* I selected "MVC Controller with Views Using Entity Framework."
* I selected my domain entity.
* I selected the DbContext.
* I left the default checkboxes for setting up the Views.
* I created my scaffold.
* I repeated for each domain model.
* I deleted the "Workaround" folder.
* I "re-referenced" FitnessFrog.Core.Domain and FitnessFrog.Core.Domain.Data.
* All was well.

## Helpful Documentation
* http://localhost:49865/ (When you run the FitnessFrog.Core.UI)
* http://www.microsoft.com/net/core#windows
* https://docs.asp.net/en/latest/tutorials/first-mvc-app/start-mvc.html
* https://docs.asp.net/en/latest/data/ef-mvc/intro.html#entity-framework-core-nuget-packages
