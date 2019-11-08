FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build

VOLUME /app

# restore as a separate layer to speed up builds
WORKDIR /src
COPY src/Account.Service.Api/GlossaryApi.csproj .
RUN dotnet restore

COPY src/Account.Service.Api/ .
CMD dotnet publish -c Release -o /app/out/