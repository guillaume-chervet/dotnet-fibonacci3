FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
RUN ls
RUN dotnet publish "./src/Leonardo.Web/Leonardo.Web.csproj" -c Release -r linux-x64 -o /publish


FROM mcr.microsoft.com/dotnet/runtime:8.0 AS final
WORKDIR /app
COPY --from=build /publish .
#EXPOSE 5000
#ENV ASPNETCORE_URLS=http://*:5000
ENTRYPOINT ["/app/Leonardo.Web"]
