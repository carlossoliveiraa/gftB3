Solução de Cálculo do CDB
Descrição Geral
Este projeto calcula o retorno de investimentos em Certificados de Depósito Bancário (CDB), incluindo impostos e retorno esperado com base na duração do investimento. Ele é composto por uma API em .NET Framework e uma aplicação frontend em Angular.

Requisitos
Certifique-se de que você tem as ferramentas necessárias:

Backend (API .NET)
Visual Studio 2019 ou superior
.NET Framework 4.8
Frontend (Angular)
Node.js 14.x ou superior
Angular CLI 13.x
NPM 6.x ou superior
Como Configurar e Executar
API .NET (Backend)
Abra a Solução no Visual Studio:

Navegue até a pasta do backend e abra o arquivo .sln.
Restaurar Pacotes:

No Visual Studio, vá em Tools > NuGet Package Manager > Package Manager Console e execute:
bash
Copiar código
Update-Package -Reinstall
Compilar e Executar:

Pressione F5 para compilar e executar a API. Ela deve estar disponível em http://localhost:5000.
Aplicação Angular (Frontend)
Instalar Dependências:

Abra o terminal, navegue até a pasta do frontend e execute:
bash
Copiar código
npm install
Servir a Aplicação:

No mesmo terminal, execute:
bash
Copiar código
ng serve
Acesse http://localhost:4200 no seu navegador.
Como Testar
Testes no Backend
No Visual Studio, use o Test Explorer para rodar os testes unitários.
Testes no Frontend
Certifique-se de que todas as dependências estão instaladas:
bash
Copiar código
npm install
Execute os testes:
bash
Copiar código
ng test
Isso abrirá um navegador e executará os testes automaticamente.
Análise de Código
Backend: Instale o SonarLint no Visual Studio para análise contínua da qualidade do código.
Frontend: Use o ESLint com Angular CLI para manter o código limpo e conforme.
 
