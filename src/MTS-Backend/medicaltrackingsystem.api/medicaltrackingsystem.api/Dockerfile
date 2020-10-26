#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["MTS-Backend/medicaltrackingsystem.api/medicaltrackingsystem.api/medicaltrackingsystem.api.csproj", "MTS-Backend/medicaltrackingsystem.api/medicaltrackingsystem.api/"]
RUN dotnet restore "MTS-Backend/medicaltrackingsystem.api/medicaltrackingsystem.api/medicaltrackingsystem.api.csproj"
COPY . .
WORKDIR "/src/MTS-Backend/medicaltrackingsystem.api/medicaltrackingsystem.api"
RUN dotnet build "medicaltrackingsystem.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "medicaltrackingsystem.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "medicaltrackingsystem.api.dll"]