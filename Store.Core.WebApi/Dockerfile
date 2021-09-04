#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Store.Core.WebApi/Store.Core.WebApi.csproj", "Store.Core.WebApi/"]
RUN dotnet restore "Store.Core.WebApi/Store.Core.WebApi.csproj"
COPY . .
WORKDIR "/src/Store.Core.WebApi"
RUN dotnet build "Store.Core.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Store.Core.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Store.Core.WebApi.dll"]