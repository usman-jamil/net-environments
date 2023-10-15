### Changing Environments

Edit the file: `NetEnvironments/Properties/launchSettings.json` and change the environment 
variable `ASPNETCORE_ENVIRONMENT` to Development to start using appsettings.Development.json. 
If you change this variable to: Production then it will start using 
appsettings.Production.json

### Firestore Key File
This needs to be done for firebase.Development.json as well inside of Program.cs. like:

```c#
var environment= Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
var firestoreFile = $"firestore.{environment}.json"
```


