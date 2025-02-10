#Usar la imagen base de .NET SDK para compilar la aplicación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

#Copiar la solución y el archivo de proyecto
COPY DBTargetQuiz.sln . 
COPY DBTargetQuiz/*.csproj ./DBTargetQuiz/
RUN dotnet restore

#Copiar el resto del código y compilar la aplicación
COPY DBTargetQuiz ./DBTargetQuiz/
RUN dotnet publish DBTargetQuiz -c Release -o out

#Usar la imagen base de .NET Runtime para ejecutar la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

#Copiar los archivos compilados desde la etapa de compilación
COPY --from=build /app/out ./

#Configurar el puerto en el que la app escuchará
ENV ASPNETCORE_URLS=http://0.0.0.0:8072/

#Exponer el puerto correcto
EXPOSE 8072

#Definir el comando de inicio
ENTRYPOINT ["dotnet", "DBTargetQuiz.dll"]