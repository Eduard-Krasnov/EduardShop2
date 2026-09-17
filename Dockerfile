FROM mcr.microsoft.com/dotnet/sdk:10.0

WORKDIR /src

COPY . .

RUN dotnet publish ./EduardShop2.Api/EduardShop2.Api.csproj -c Release -o /app/publish

EXPOSE 8080

ENTRYPOINT ["dotnet", "/app/publish/EduardShop2.Api.dll"]