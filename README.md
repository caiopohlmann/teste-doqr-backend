# Gerenciamento de Funcionários

Este é um projeto de API para gerenciamento de funcionários, desenvolvido em C# usando ASP.NET Core.

## Características do Projeto

- Desenvolvido em C# com ASP.NET Core 8.0
- Utiliza Entity Framework Core para acesso a dados
- Suporta banco de dados MySQL
- Implementa operações CRUD (Create, Read, Update, Delete) para funcionários
- Utiliza Swagger para documentação da API
- Inclui validações de dados
- Implementa paginação para listagem de funcionários

## Estrutura do Projeto

O projeto segue uma estrutura típica de uma aplicação ASP.NET Core:

- `Controllers/`: Contém os controladores da API
- `Data/`: Inclui o contexto do banco de dados e configurações
- `Models/`: Define os modelos de dados, incluindo a classe `Employee`
- `Services/`: Contém a lógica de negócios
- `Program.cs`: Ponto de entrada da aplicação e configuração

## Pré-requisitos

- .NET 8.0 SDK
- MySQL Server

## Como Executar o Projeto

1. Clone o repositório:
   ```
   git clone git@github.com:caiopohlmann/teste-doqr-backend.git
   cd teste-doqr-backend
   ```

2. Configure a string de conexão do banco de dados:
   Abra o arquivo `appsettings.json` e ajuste a string de conexão para corresponder às suas configurações do MySQL.

3. Execute as migrações do banco de dados:
   ```
   dotnet ef database update
   ```

4. Execute o projeto:
   ```
   dotnet run
   ```

5. Acesse a API:
   A API estará disponível em `http://localhost:5000`


## Endpoints da API

- GET /api/employees: Lista todos os funcionários (com suporte a paginação)
- GET /api/employees/{id}: Obtém um funcionário específico
- POST /api/employees: Cria um novo funcionário
- PUT /api/employees/{id}: Atualiza um funcionário existente
- DELETE /api/employees/{id}: Remove um funcionário

## Tecnologias Utilizadas

- ASP.NET Core 8.0
- Entity Framework Core 8.0
- Pomelo.EntityFrameworkCore.MySql 8.0.2
- Swashbuckle.AspNetCore 6.8.1
