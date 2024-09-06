
# Solução de Cálculo do CDB

## Descrição Geral
Este projeto calcula o retorno de investimentos em Certificados de Depósito Bancário (CDB), incluindo impostos e o retorno esperado com base na duração do investimento. Ele é composto por uma API desenvolvida em .NET Framework 4.7.2 e uma aplicação frontend em Angular.
##Padrões de Projeto: Utilizei SOLID e Strategy para futuras implementações de calculos. 
## Requisitos
Certifique-se de que você tem as ferramentas necessárias:

### Backend (API .NET)
- Visual Studio 2019 ou superior. Eu utilizei o vs 2022
- .NET Framework 4.7.2

### Frontend (Angular)
- Node.js 14.x ou superior
- Angular CLI 13.x
- NPM 6.x ou superior

## Como Configurar e Executar

### API .NET (Backend)
1. **Abra a Solução no Visual Studio:**
   - Navegue até a pasta do backend e abra o arquivo `.sln`.

2. **Restaurar Pacotes:**
   - No Visual Studio, clique com o botao direito em cima do projeto -> Manage Nuget Packages. 
    

3. **Compilar e Executar:**
   - Pressione `F5` para compilar e executar a API. Ela deve estar disponível em `http://localhost:5000`.

### Aplicação Angular (Frontend)
1. **Instalar Dependências:**
   - Abra o terminal, navegue até a pasta do frontend e execute:
     npm install
   

2. **Servir a Aplicação:**
   - No mesmo terminal, execute:
     ng serve
     
   - Acesse `http://localhost:4200` no seu navegador.

## Como Testar

### Testes no Backend
- Os testes unitários foram implementados utilizando `[TestClass]` no Visual Studio. Para executá-los, use o `Test Explorer`.

### Testes no Frontend
1. **Instalar Dependências:**
   - Certifique-se de que todas as dependências estão instaladas:
       npm install
    
2. **Executar Testes:**
   - Os testes foram implementados utilizando Jasmine. Rode os testes com o comando:
     ng test
     
   - Isso abrirá um navegador e executará os testes automaticamente.

## Análise de Código
- **Backend:** Instale o SonarLint no Visual Studio para análise contínua da qualidade do código.
- **Frontend:** Use o ESLint com Angular CLI para manter o código limpo e conforme.
