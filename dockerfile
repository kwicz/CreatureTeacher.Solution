# Use .NET 8 runtime as the base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

# Use .NET 8 SDK to build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["CreatureTeacher/CreatureTeacher.csproj", "CreatureTeacher/"]
RUN dotnet restore "CreatureTeacher/CreatureTeacher.csproj"
COPY . .
WORKDIR "/src/CreatureTeacher"
RUN dotnet publish -c Release -o /app/publish

# Final runtime image
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:8080
ENTRYPOINT ["dotnet", "CreatureTeacher.dll"]
