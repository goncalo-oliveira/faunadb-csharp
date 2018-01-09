nuget restore ./faunadb-csharp.sln

nuget install NUnit.Console -ExcludeVersion -OutputDirectory tools

msbuild ./faunadb-csharp.sln /t:Build /p:Configuration=Debug

mono ./tools/NUnit.ConsoleRunner/tools/nunit3-console.exe FaunaDB.Client.Common.Test/bin/Debug/FaunaDB.Client.Common.Test.dll --noresult
mono ./tools/NUnit.ConsoleRunner/tools/nunit3-console.exe FaunaDB.Client.Api.V2.Test/bin/Debug/FaunaDB.Client.Api.V2.Test.dll --noresult

