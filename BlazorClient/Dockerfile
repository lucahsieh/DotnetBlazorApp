FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY BlazorClient.csproj .
#RUN dotnet restore "BlazorClient.csproj"
COPY . .
RUN dotnet build "BlazorClient.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlazorClient.csproj" -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/BlazorClient/dist .
COPY nginx.conf /etc/nginx/nginx.conf