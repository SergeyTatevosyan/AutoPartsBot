# Сборка
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Копируем всё содержимое репозитория
COPY . .

# Собираем конкретный проект из подпапки
RUN dotnet publish "AutoPartsBot/AutoPartsBot.csproj" -c Release -o /app/publish

# Финальный образ
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .

# Указываем порт 80 (стандарт .NET 8)
ENV ASPNETCORE_URLS=http://+:80
EXPOSE 80

ENTRYPOINT ["dotnet", "AutoPartsBot.dll"]