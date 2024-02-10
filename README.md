
### Nome do Projeto: BlazorShop

#### Sumário

1. [Introdução](#introdução)
2. [Requisitos](#requisitos)
3. [Configuração do Ambiente](#configuração-do-ambiente)
4. [Estrutura do Projeto](#estrutura-do-projeto)
5. [Configuração do Banco de Dados](#configuração-do-banco-de-dados)
6. [Funcionalidades do E-commerce](#funcionalidades-do-e-commerce)
7. [Deployment](#deployment)
8. [Contribuições](#contribuições)

#### Introdução

BlazorShop é uma plataforma de e-commerce construída com WebAssembly utilizando Blazor e .NET 8, integrada a um banco de dados SQL Server através do Entity Framework Core. O projeto visa proporcionar uma experiência rica e interativa de um e-commerce para produtos em geral, incluindo funcionalidades como exibição de produtos, carrinho de compras, gestão de usuários, entre outros.
![Captura de tela 2024-02-09 221358](https://github.com/KaiokkFernandes/BlazorShopWeb/assets/148721400/a8d2ff5a-f3f4-4c57-838f-998569de5c85)

#### Requisitos

- .NET 8 SDK
- Visual Studio 2022 ou posterior
- SQL Server
- Entity Framework Core

#### Configuração do Ambiente

1. Instale o .NET 8 SDK a partir do site oficial da Microsoft.
2. Instale o Visual Studio 2022, garantindo que o workload de desenvolvimento ASP.NET e web esteja selecionado durante a instalação.
3. Instale o SQL Server e configure uma nova instância para o projeto.

#### Estrutura do Projeto

O projeto é estruturado da seguinte forma:

- **BlazorShop.Web**: Projeto de front-end que utiliza Blazor WebAssembly para a interface do usuário.
- **BlazorShop.API**: API backend desenvolvida em ASP.NET Core para gerenciar as operações de negócios.
- **BlazorShop.Data**: Camada de acesso a dados que utiliza Entity Framework Core para interagir com o SQL Server.

#### Configuração do Banco de Dados

1. Crie uma nova base de dados no SQL Server.
2. Atualize a string de conexão no arquivo `appsettings.json` do projeto BlazorShop.API.
3. Execute as migrações do Entity Framework Core para criar as tabelas necessárias utilizando o comando `Update-Database` no Package Manager Console.

#### Funcionalidades do E-commerce

- **Gerenciamento de Produtos**: Permite adicionar, editar e remover produtos.
- **Carrinho de Compras**: Funcionalidade para adicionar produtos ao carrinho e gerenciar a compra.
- **Gestão de Usuários**: Registro e autenticação de usuários, além de gerenciamento de perfis.
- **Checkout**: Processamento de pedidos e integração com sistemas de pagamento.

