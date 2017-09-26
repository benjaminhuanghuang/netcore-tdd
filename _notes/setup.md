
## Create Solution
  dotnet new sln

## Create project to be test
  mkdir <project>
  dotnet new classlib -o <project>
  
## Add project to solution
  dotnet sln add ./<project>/<project>.csproj

## Create xUnit Test Project and add it to solution
```
  mkdir <tests-project>
  dotnet new xunit -o <tests-project>
  dotnet sln add ./<test project>/<test project>.csproj
```
  xUnit test project need xUnit framework and xUnit runner

## Add reference to the xUnit test project
```
  cd <test project>
  dotnet add reference ../<project to be test>/<project to be test>.csproj
```

## Project structure
- Unit testing C# in .NET Core using dotnet test and xUnit
  - https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test
```
/unit-testing-using-dotnet-test
    unit-testing-using-dotnet-test.sln
    /PrimeService
        Source Files
        PrimeService.csproj
    /PrimeService.Tests
        Test Source Files
        PrimeServiceTests.csproj
```

## Run Test
  dotnet test
   
## Watch Test
  Add watch tool into test project
  ```
  <ItemGroup>
      <DotNetCliToolReference Include="Microsoft.DotNet.Watcher.Tools" Version="2.0.0" />
  </ItemGroup>
  ```
  dotnet watch test