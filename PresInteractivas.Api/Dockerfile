FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["PresInteractivas.Api/PresInteractivas.Api.csproj", "PresInteractivas.Api/"]
RUN dotnet restore "PresInteractivas.Api/PresInteractivas.Api.csproj"
COPY . .
WORKDIR "/src/PresInteractivas.Api"
RUN dotnet build "PresInteractivas.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PresInteractivas.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PresInteractivas.Api.dll"]

FROM catthehacker/ubuntu:act-latest

RUN apt install gnupg ca-certificates \
    && apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF \
    && echo "deb https://download.mono-project.com/repo/ubuntu stable-focal main" | sudo tee /etc/apt/sources.list.d/mono-official-stable.list \
    && apt update \
    && apt install -y mono-devel