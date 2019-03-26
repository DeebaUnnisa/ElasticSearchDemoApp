FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["ElasticSearchDemoApp/ElasticSearchDemoApp.csproj", "ElasticSearchDemoApp/"]
RUN dotnet restore "ElasticSearchDemoApp/ElasticSearchDemoApp.csproj"
COPY . .
WORKDIR "/src/ElasticSearchDemoApp"
RUN dotnet build "ElasticSearchDemoApp.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ElasticSearchDemoApp.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ElasticSearchDemoApp.dll"]