# Step 1: Use the official .NET 8 runtime as the base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080


# Step 2: Use the .NET SDK image for building the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Install dotnet-ef CLI globally inside the container
RUN dotnet tool install --global dotnet-ef

# Add the global tools directory to PATH
ENV PATH="$PATH:/root/.dotnet/tools"

COPY ["CreatureTeacher/CreatureTeacher.csproj", "CreatureTeacher/"]
RUN dotnet restore "CreatureTeacher/CreatureTeacher.csproj"
COPY . .
WORKDIR "/src/CreatureTeacher"
RUN dotnet publish -c Release -o /app/publish

# Step 3: Use the runtime image for the final container
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:8080
ENTRYPOINT ["dotnet", "CreatureTeacher.dll"]