rm -r packages
nuget restore ./faunadb-csharp.sln

msbuild ./faunadb-csharp.sln /t:Build /p:Configuration=Release /p:SignAssembly=true /p:AssemblyOriginatorKeyFile=../SigningKey/FaunaDB.Client.snk
