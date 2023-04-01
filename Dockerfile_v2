
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /code
# Copy and restore as distinct layers
COPY ["Puc.Mercadinho/Puc.Mercadinho.Api/Puc.Mercadinho.Api.csproj", "Puc.Mercadinho/Puc.Mercadinho.Api/Puc.Mercadinho.Api.csproj"]
COPY ["Puc.Mercadinho/Puc.Mercadinho.Test/Puc.Mercadinho.Test.csproj", "Puc.Mercadinho/Puc.Mercadinho.Test/Puc.Mercadinho.Test/"]

RUN dotnet restore "Puc.Mercadinho/Puc.Mercadinho.Api/Puc.Mercadinho.Api.csproj" -r linux-musl-x64
RUN dotnet restore "Puc.Mercadinho/Puc.Mercadinho.Test/Puc.Mercadinho.Test.csproj" -r linux-musl-x64
COPY . .

# Build
RUN dotnet build \
    "Puc.Mercadinho/Puc.Mercadinho.Api/Puc.Mercadinho.Api.csproj" \
    -c Release \
    --runtime linux-musl-x64 \
    --no-restore
	
RUN dotnet build \
    "Puc.Mercadinho/Puc.Mercadinho.Test/Puc.Mercadinho.Test.csproj" \
    -c Release \
    -r linux-musl-x64 \
    --no-restore


# Api mercadinho runner
FROM build AS puc-mercadinho-api
WORKDIR /code/Puc.Mercadinho/Puc.Mercadinho.Api
ENTRYPOINT dotnet \
    -c Release \
    --runtime linux-musl-x64 \
    --no-restore \
    --no-build


# Unit test runner
FROM build AS puc-mercadinho-teste
WORKDIR /code/Puc.Mercadinho/Puc.Mercadinho.Test
ENTRYPOINT dotnet test \
    -c Release \
    --runtime linux-musl-x64 \
    --no-restore \
    --no-build \
    --logger "trx;LogFileName=test_results_unit_test.trx"
