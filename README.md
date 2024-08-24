
# Solução de Cálculo do CDB

## Descrição Geral
Este projeto calcula o retorno de investimentos em Certificados de Depósito Bancário (CDB), incluindo impostos e o retorno esperado com base na duração do investimento. Ele é composto por uma API desenvolvida em .NET Framework e uma aplicação frontend em Angular.

## Requisitos
Certifique-se de que você tem as ferramentas necessárias:

### Backend (API .NET)
- Visual Studio 2019 ou superior
- .NET Framework 4.8

### Frontend (Angular)
- Node.js 14.x ou superior
- Angular CLI 13.x
- NPM 6.x ou superior

## Como Configurar e Executar

### API .NET (Backend)
1. **Abra a Solução no Visual Studio:**
   - Navegue até a pasta do backend e abra o arquivo `.sln`.

2. **Restaurar Pacotes:**
   - No Visual Studio, vá em `Tools > NuGet Package Manager > Package Manager Console` e execute:
     ```bash
     Update-Package -Reinstall
     ```

3. **Compilar e Executar:**
   - Pressione `F5` para compilar e executar a API. Ela deve estar disponível em `http://localhost:5000`.

### Aplicação Angular (Frontend)
1. **Instalar Dependências:**
   - Abra o terminal, navegue até a pasta do frontend e execute:
     ```bash
     npm install
     ```

2. **Servir a Aplicação:**
   - No mesmo terminal, execute:
     ```bash
     ng serve
     ```
   - Acesse `http://localhost:4200` no seu navegador.

## Como Testar

### Testes no Backend
- No Visual Studio, use o `Test Explorer` para rodar os testes unitários.

### Testes no Frontend
1. **Instalar Dependências:**
   - Certifique-se de que todas as dependências estão instaladas:
     ```bash
     npm install
     ```
2. **Executar Testes:**
   - Rode os testes com o comando:
     ```bash
     ng test
     ```
   - Isso abrirá um navegador e executará os testes automaticamente.

## Análise de Código
- **Backend:** Instale o SonarLint no Visual Studio para análise contínua da qualidade do código.
- **Frontend:** Use o ESLint com Angular CLI para manter o código limpo e conforme.
