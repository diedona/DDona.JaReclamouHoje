#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DDona.JaReclamouHoje.Api/DDona.JaReclamouHoje.Api.csproj", "DDona.JaReclamouHoje.Api/"]
COPY ["DDona.JaReclamouHoje.Infra/DDona.JaReclamouHoje.Infra.csproj", "DDona.JaReclamouHoje.Infra/"]
COPY ["DDona.JaReclamouHoje.Dominio/DDona.JaReclamouHoje.Dominio.csproj", "DDona.JaReclamouHoje.Dominio/"]
RUN dotnet restore "DDona.JaReclamouHoje.Api/DDona.JaReclamouHoje.Api.csproj"
COPY . .
WORKDIR "/src/DDona.JaReclamouHoje.Api"
RUN dotnet build "DDona.JaReclamouHoje.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DDona.JaReclamouHoje.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DDona.JaReclamouHoje.Api.dll"]