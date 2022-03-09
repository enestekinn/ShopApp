FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["ShopApp.UI/ShopApp.UI.csproj", "ShopApp.UI/"]
RUN dotnet restore "ShopApp.UI/ShopApp.UI.csproj"
COPY . .
WORKDIR "/src/ShopApp.UI"
RUN dotnet build "ShopApp.UI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ShopApp.UI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ShopApp.UI.dll"]
