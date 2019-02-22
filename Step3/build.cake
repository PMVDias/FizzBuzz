///////////////////////////////////////////////////////////////////////////////
// ARGUMENTS
///////////////////////////////////////////////////////////////////////////////
var target = Argument("target", "Run");
var configuration = Argument("configuration", "Release");

///////////////////////////////////////////////////////////////////////////////
// TASKS
///////////////////////////////////////////////////////////////////////////////
Task("Clean")
   .Does(() =>
{
   CleanDirectories("**/bin/" + configuration);
   CleanDirectories("**/obj/" + configuration);
});

Task("Restore")
.IsDependentOn("Clean")
.Does(() => {
   DotNetCoreRestore();
});

Task("Build")
.IsDependentOn("Restore")
.Does(() => {
   DotNetCoreBuild("./Step3.sln", new DotNetCoreBuildSettings{
      Configuration = configuration
   });
});

Task("Test")
.IsDependentOn("Build")
.Does(() => {
   var location = File("./Example.Tests/Example.Tests.csproj");
   DotNetCoreTest(location, new DotNetCoreTestSettings{
      Configuration = configuration,
      NoBuild = true
   });
});

Task("Run")
.IsDependentOn("Test")
.Does(() => {
   var location = File("./Example/Example.csproj");
   DotNetCoreRun(location);
});

RunTarget(target);