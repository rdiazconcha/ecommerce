#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["ECommerce.Api.Orders/ECommerce.Api.Orders.csproj", "ECommerce.Api.Orders/"]
RUN dotnet restore "ECommerce.Api.Orders/ECommerce.Api.Orders.csproj"
COPY . .
WORKDIR "/src/ECommerce.Api.Orders"
RUN dotnet build "ECommerce.Api.Orders.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ECommerce.Api.Orders.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ECommerce.Api.Orders.dll"]
