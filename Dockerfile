#IMAGEM BASE
FROM microsoft/dotnet:2.2-aspnetcore-runtime
LABEL version = "1.0.1" description="App with .NET Core MVC"
#COPIA O CONTEÚDO DE DIST PARA UM NOVO DIR CHAMADO /app
COPY dist /app
#DEFINE O DIR /app como diretório de trabalho(p/ container)
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet","mvc1.dll"]
