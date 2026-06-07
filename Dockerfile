# 1. Etapa de compilación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar archivos del proyecto y restaurar
COPY *.csproj ./
RUN dotnet restore

# Copiar el resto del código y compilar
COPY . .
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false

# 2. Etapa de ejecución
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "ApiPeliculas.dll"]
