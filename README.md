# Controle de Fluxo de Caixa  

## Descritivo da Solução  
Esta aplicação foi desenvolvida para atender à necessidade de um comerciante em controlar o seu fluxo de caixa diário. Ela permite realizar lançamentos de débitos e créditos e fornece um relatório com o saldo diário consolidado.  

### Funcionalidades  
- **Cadastro de lançamentos (débitos e créditos)**  
- **Relatório diário consolidado do saldo**  

---

## Requisitos de Negócio  
- Serviço responsável pelo controle dos lançamentos financeiros  
- Serviço que gera o consolidado diário do saldo  

---

## Requisitos Técnicos  
- Implementado em **C#**  
- **Testes automatizados** para garantir a confiabilidade  
- **Boas práticas de desenvolvimento**:  
  - Aplicação de princípios **SOLID**  
  - Utilização de **Design Patterns** e **Padrões de Arquitetura**  

---

## Como Rodar o Projeto Localmente  

### Pré-requisitos  
Antes de começar, certifique-se de que você tenha as ferramentas abaixo instaladas:  
- [.NET SDK](https://dotnet.microsoft.com/download)  
- [Git](https://git-scm.com/)  
- Um editor de código como [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/)  

### Passo a Passo  
1. Clone o repositório:  
   ```bash  
   git clone https://github.com/AugustinhoCelestino/banco-carrefour.git
   cd banco-carrefour
    ```
---
### Estrutura do Projeto
O projeto está estruturado da seguinte forma:

   ```scss  
      ├── api/BancoCarrefour  
      │   ├── Application          // Endpoints e serviços expostos
      │   ├── Data                 // 
      │   ├── Domain               // 
      │   ├── IoC                  //   
      │   └── Services             // Serviços e regras de Negocios
      │   └── BancoCarrefour.sln   // Solução do projeto  
      ├── README.md                // Documentação do projeto  
      └── ...
   ```  
---

### Tecnologias Utilizadas
- C#
- ASP.NET Core para construção de APIs
- xUnit ou NUnit para testes automatizados
- Entity Framework Core para ORM (caso aplicável)
- Swagger para documentação de API (caso tenha uma API)
