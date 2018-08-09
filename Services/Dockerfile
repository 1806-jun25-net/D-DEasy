FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY DandDeasy.Data/*.csproj ./DandDeasy.Data/
COPY DandDEasy.Services/*.csproj ./DandDEasy.Services/


# copy everything else and build app
COPY . ./
WORKDIR /app/DandDEasy.Services
RUN dotnet publish -c Release -o out


FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
WORKDIR /app/DandDEasy.Services
COPY --from=build /app/DandDEasy.Services/out ./
ENTRYPOINT ["dotnet", "DandDEasy.Services.dll"]
