FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /src
COPY ["Caprice/Caprice.csproj", "Caprice/"]
RUN dotnet restore "Caprice/Caprice.csproj"
COPY . .
WORKDIR "/src/Caprice"
RUN dotnet build "Caprice.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Caprice.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Caprice.dll"]