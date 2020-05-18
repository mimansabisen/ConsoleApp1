#FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

#COPY ConsoleApp2/bin/Release/netcoreapp3.1/publish/ app/

#ENTRYPOINT ["dotnet", "app/ConsoleApp2.dll"]

FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8
WORKDIR /inetpub/wwwroot
COPY . ./


