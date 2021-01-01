FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

WORKDIR /app
COPY ProductManager ./

RUN dotnet restore ProductManager.Api/ProductManager.Api.csproj
RUN dotnet publish ProductManager.Api/ProductManager.Api.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /app

COPY --from=build /app/out ./
ENTRYPOINT ["dotnet", "ProductManager.Api.dll"]