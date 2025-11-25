# Use .NET runtime image for running app
FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

# Use SDK image to build/publish
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy all files from current context (DBConsoleApp/) to /src in container
COPY . .

# Publish the console app (path adjusted)
RUN dotnet publish DBConsoleApp.csproj -c Release -o /app/publish

# Final stage
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "DBConsoleApp.dll"]


