# Yggdrasil
 > Principal aplicativo teste tecnico 

## Ferramentas
* [Visual Studio Code](https://code.visualstudio.com/download)
* [dotnet](https://www.microsoft.com/net/download/core)
* [Mysql](https://www.mysql.com/)

## Dependências
* [Node](https://nodejs.org)  
* [Grunt](http://gruntjs.com/)
* [Bower](https://bower.io)

## Inicializando o projeto
Antes de inicializar o projeto certifique-se que seu node esteja na versão > `6`.
```bash
# Clone o AppFrontend
$ cd yggdrasil

# Instale as dependências dotnet
$ dotnet restore

## Entre no projeto Financeira.WebApi na pasta wwwroot
# Instale as dependências do bower
$ bower install

# Instale as dependências do node
$ npm install

# Execute a aplicação
$ npm start
```

```bash
# Entre no projeto Financeira.Infra na pasta Context altere a configuração mysql
$ cd Financeira.Infra

# Update das migrations
$ dotnet ef database migrations

## Entre no projeto Financeira.WebApi na pasta wwwroot
# Instale as dependências do bower
$ bower install

# # Entre no projeto Financeira.WebApi e start o projeto
$ dotnet run
```
