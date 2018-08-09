FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY DnDEasy.Testing/*.csproj ./DnDEasy.Testing/
COPY DandDEasy_WEB/*.csproj ./DandDEasy_WEB/


# copy everything else and build app
COPY . ./
WORKDIR /app/DandDEasy_WEB
RUN dotnet publish -c Release -o out


FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
WORKDIR /app/DandDEasy_WEB
COPY --from=build /app/DandDEasy_WEB/out ./
ENTRYPOINT ["dotnet", "DandDEasy_WEB.dll"]
    