# Stage 1: base runtime
FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

# Stage 2: build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the entire solution into the container
COPY . .

# Restore & publish the console app
RUN dotnet restore DBConsoleApp/DBConsoleApp.csproj
RUN dotnet publish DBConsoleApp/DBConsoleApp.csproj -c Release -o /app/publish

# Stage 3: final image
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "DBConsoleApp.dll"]



