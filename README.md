# Solução de CÁLCULO DO CDB 

## Descrição Geral
Esta solução calcula o retorno de investimentos em Certificados de Depósito Bancário (CDB), incluindo cálculos de impostos e retorno esperado com base na duração do investimento. A solução é composta por um backend desenvolvido em .NET Framework 4.7.2 e um frontend em Angular.

## Requisitos
Para executar a solução, você precisará das seguintes ferramentas instaladas em seu sistema:

### Para o Backend
- Visual Studio 2019 ou superior
- .NET Framework 4.8 SDK

### Para o Frontend
- Node.js 14.x ou superior
- Angular CLI 13.x
- NPM 6.x ou superior (geralmente vem com Node.js)

## Configuração e Execução

### Backend (.NET API)
1. **Abra a Solução no Visual Studio:**
   - Navegue até a pasta do backend e abra o arquivo `.sln` no Visual Studio.

2. **Restaurar Pacotes NuGet:**
   - No Visual Studio, vá em `Tools > NuGet Package Manager > Package Manager Console` e execute:
     ```
     Update-Package -Reinstall
     ```

3. **Compilar e Executar:**
   - Pressione `F5` para compilar e executar a API. Certifique-se de que não há erros e que a API está rodando em `http://localhost:5000`.

### Frontend (Angular App)
1. **Instalar Dependências:**
   - Abra um terminal ou prompt de comando.
   - Navegue até a pasta do frontend e execute:
     ```
     npm install
     ```

2. **Servir a Aplicação:**
   - Ainda no terminal, execute:
     ```
     ng serve
     ```
   - Acesse `http://localhost:4200` no navegador para ver a aplicação.

## Testes

### Executando Testes no Backend
- No Visual Studio, use o `Test Explorer` para rodar os testes unitários.

### Executando Testes no Frontend
- Execute o seguinte comando no terminal dentro da pasta do frontend:


## Análise de Código
- Recomendamos a instalação do SonarLint no Visual Studio para análise contínua de qualidade de código no backend.
- Para o frontend, utilize o ESLint com Angular CLI para manter a qualidade e conformidade do código.

## Contribuições
Contribuições são bem-vindas. Por favor, envie pull requests para a branch `develop` para revisão e possível integração.

## Licença
Este projeto é distribuído sob a licença MIT. Veja o arquivo `LICENSE` para mais detalhes.

