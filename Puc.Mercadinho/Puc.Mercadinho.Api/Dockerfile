FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["./Puc.Mercadinho.Api/Puc.Mercadinho.Api.csproj", "Puc.Mercadinho.Api/"]
RUN dotnet restore "Puc.Mercadinho.Api/Puc.Mercadinho.Api.csproj"
COPY . .
WORKDIR "Puc.Mercadinho.Api"
RUN dotnet build "Puc.Mercadinho.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Puc.Mercadinho.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Puc.Mercadinho.Api.dll"]
