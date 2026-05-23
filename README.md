# 💼 SistemaDesktopFinanceiroCSharp

Sistema desktop desenvolvido em **Microsoft C# (C-Sharp)** com integração a **SQL Server**, voltado para controle e gerenciamento financeiro.

O projeto foi desenvolvido com foco em:
- arquitetura organizada
- persistência de dados
- regras de negócio
- experiência desktop
- boas práticas de engenharia de software

---

# 📌 Visão Geral

O **SistemaDesktopFinanceiroCSharp** é uma aplicação desktop criada para simular um ambiente corporativo de gestão financeira, permitindo o gerenciamento eficiente de informações e operações financeiras através de uma interface robusta e integrada a banco de dados relacional.

O projeto busca demonstrar conhecimentos sólidos em:

- desenvolvimento desktop com C#
- modelagem de banco de dados
- integração com SQL Server
- manipulação de dados
- arquitetura de software
- lógica de negócio
- organização de camadas
- boas práticas de desenvolvimento

---

# 🏗️ Arquitetura do Projeto

A aplicação foi estruturada seguindo princípios de organização e separação de responsabilidades, permitindo maior escalabilidade e manutenção do sistema.

### Camadas do Projeto

- **Interface Gráfica (UI)**
  - Responsável pela interação com o usuário

- **Camada de Negócio**
  - Regras de negócio e processamento das informações

- **Camada de Dados**
  - Comunicação com o banco SQL Server

- **Banco de Dados**
  - Persistência e gerenciamento das informações financeiras

---

# 🛠️ Tecnologias Utilizadas

## 💻 Linguagem Principal

- **Microsoft C# (C-Sharp)**
  - Desenvolvimento desktop
  - Programação orientada a objetos
  - Manipulação de eventos
  - Integração com banco de dados

---

## 🗄️ Banco de Dados

- **Microsoft SQL Server**
  - Modelagem relacional
  - Persistência de dados
  - Consultas SQL
  - Procedures e gerenciamento de registros

---

## 🧱 Conceitos Aplicados

- Programação Orientada a Objetos (POO)
- CRUD Completo
- Conexão com Banco de Dados
- Organização em Camadas
- Tratamento de Exceções
- Validação de Dados
- Persistência de Informações
- Engenharia de Software

---

# 📂 Estrutura do Projeto

```bash
📦 SistemaDesktopFinanceiroCSharp
 ┣ 📂 BancoDeDados
 ┃ ┗ 📜 ScriptSQL.sql
 ┃
 ┣ 📂 SistemaFinanceiro
 ┃ ┣ 📂 Forms
 ┃ ┣ 📂 Models
 ┃ ┣ 📂 Controllers
 ┃ ┣ 📂 Services
 ┃ ┗ 📂 Database
 ┃
 ┣ 📜 README.md
 ┗ 📜 .gitignore
```

---

# 🚀 Funcionalidades

✅ Cadastro de informações financeiras  
✅ Gerenciamento de registros  
✅ Integração com SQL Server  
✅ Manipulação de dados em tempo real  
✅ Interface desktop interativa  
✅ Estrutura modular e organizada  
✅ Operações CRUD completas

---

# 🖥️ Requisitos do Sistema

## Ambiente de Desenvolvimento

- Visual Studio
- .NET Framework / .NET
- SQL Server
- SQL Server Management Studio (SSMS)

---

# ⚙️ Configuração do Banco de Dados

1️⃣ Criar o banco no SQL Server

2️⃣ Executar o script SQL presente na pasta:

```bash
/BancoDeDados/ScriptSQL.sql
```

3️⃣ Configurar a string de conexão no projeto

---

# ▶️ Como Executar

## 1️⃣ Clonar o Repositório

```bash
git clone https://github.com/AlissonRochaDev/SistemaDesktopFinanceiroCSharp.git
```

---

## 2️⃣ Abrir no Visual Studio

Abra o arquivo `.sln` do projeto.

---

## 3️⃣ Configurar Banco de Dados

Atualize a connection string conforme seu ambiente SQL Server.

---

## 4️⃣ Executar o Projeto

Compile e execute normalmente pelo Visual Studio.

---

# 🎯 Objetivos do Projeto

Este projeto possui como finalidade:

- fortalecimento técnico em C#
- prática de integração com banco de dados
- aplicação de conceitos de engenharia de software
- simulação de ambiente corporativo
- desenvolvimento de aplicações desktop robustas

---

# 🔒 Segurança e Boas Práticas

- Validação de entradas
- Organização em camadas
- Tratamento de erros
- Separação de responsabilidades
- Estrutura modular

---

# 📈 Possíveis Evoluções

- [ ] Dashboard financeiro
- [ ] Relatórios em PDF
- [ ] Controle de usuários
- [ ] Níveis de acesso
- [ ] Backup automático
- [ ] Exportação Excel
- [ ] API de integração
- [ ] Gráficos financeiros

---

# 👨‍💻 Autor

**Alisson Fernando Rocha Trindade**

Desenvolvedor Web • Professor • Técnico em Informática

🔗 GitHub:
https://github.com/AlissonRochaDev

---

# 📄 Licença

Este projeto está sob a licença MIT.

---

# ⭐ Considerações Finais

Este projeto representa a aplicação prática de conceitos fundamentais de desenvolvimento desktop utilizando tecnologias Microsoft, unindo organização, persistência de dados e arquitetura de software em um ambiente profissional.
