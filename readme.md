# Editorconfig ignored

Reproduces a false positive. Now that Sonar is scanning razor (blazor) files, we get warnings there, but the editorconfig is not being obeyed.

Identical code is present in Index.razor and OtherClass.cs which volates S1125. This error is disabled in editorconfig, but that does not suppress the warning from the .razor file. 

Build output. 
```
dotnet build /Users/mjc82/Documents/GitHub/Sonar-Razor-Repro/BlazorApp.slnx --no-incremental /property:GenerateFullPaths=true /consoleloggerparameters:NoSummary /p:Configuration=Debug /p:Platform="Any CPU" 
  Determining projects to restore...
  All projects are up-to-date for restore.
/Users/mjc82/Documents/GitHub/Sonar-Razor-Repro/BlazorApp/Pages/Index.razor(9,23): warning S1125: Remove the unnecessary Boolean literal(s). (https://rules.sonarsource.com/csharp/RSPEC-1125) [/Users/mjc82/Documents/GitHub/Sonar-Razor-Repro/BlazorApp/BlazorApp.csproj]
  BlazorApp -> /Users/mjc82/Documents/GitHub/Sonar-Razor-Repro/BlazorApp/bin/Debug/net9.0/BlazorApp.dll
```