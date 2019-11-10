FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build

VOLUME /app

COPY . ./

WORKDIR /src/Account.Service.Api

RUN dotnet publish -c Release -o /app/out/

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "Account.Service.Api.dll"]