<h2>Detalhes pipeline</h2>

[![.NET](https://github.com/MarcosMomesso/demonttdata/actions/workflows/pipeline.yml/badge.svg)](https://github.com/MarcosMomesso/demonttdata/actions/workflows/pipeline.yml)

# Projeto 📜

Desafio técnico NTTDATA

## Objetivo ☕️

<p>Crie um pipeline de CI/CD usando o GitHub Actions para um projeto simples de aplicação web</p> 

## Repositório 🎉
Repositório referente aos arquivos de projeto: **[repositório demo nttdata](https://github.com/MarcosMomesso/demonttdata)** 
<p>Projeto contem 3 principais .csprojec composto em uma unica solution</p>
<ul>
  <li>Webapp</li> 
  <p> projeto web exemplo da propria github onde a cada refresh na pagina um novo mascote renderizado na tela a partir de uma fonte do próprio github </p>
  <li>webapi</li> <p>Representa um exemplo de uma API com algumas funçoes de negócio</p>
  <li>api.Test</li> <p> Representa um exemplo de um projeto de teste para funções da api</p>
</ul>

## Environments 🔥
### Pre-requisitos
webapp na azure com as credenciais configuradas respectivamente pelo ambientes a seguir

**[Link Ambiente Desenvovimento](https://webappnttdata.azurewebsites.net/)**

<p>Foco para Desenvolvedor com CI e CD a cada novo pullrequest ou push** na branch main</p>
<p>**Deixado intencionalmente a cada push para facilidar o exemplo, mas poderias também restringir a apenas ao pr deixa do a estratégia de merge mais robusta</p>

**[Link Ambiente Homologação](https://webappnttdatahmg.azurewebsites.net/)**

<p>Foco em validações, a entrada para este ambiente, precisa obrigatóriamente ter passado pelo ambiente anterior + a aprovação de um usuário específico.</p>

**[Link Ambiente Produção](https://webappnttdataprd.azurewebsites.net/)**

<p><Ambiente de produção, precisa obrigatóriamente ter passado e validado pelas etadas anteriores + nova aprovação</p>


## Premissas ✨
<ul>
  <li> - O pipeline deve ser ativado sempre que um novo commit for feito na branch main.</li>
  <li> - Instalar as dependências do projeto</li>
  <li> - Executar testes unitários</li>
  <li> - Construir a aplicação.</li>
  <li> - Armazenar o artefato como release do githu</li>
  <li> - Usar funcionalidade environment do github para restringir a aprovação do deploy para um usuário ou grupo do github</li>
  <li> - O pipeline deve fazer o deploy da aplicação em um ambiente de teste</li>
  <li> - O pipeline deve notificar o desenvolvedor via e-mail se o processo de CI/CD falhar em qualquer etapa</li>
  <li> - Loreipsum</li>
</ul>

## Diferenciais ✨
<ul>
  <li> - Criar um desenho simples de arquitetura CI, CD</li>

![fluxo imagem ci e cd](https://github.com/MarcosMomesso/demonttdata/blob/main/files/fluxoCIeCD.jpg)
  
  <li> - Criar uma action do tipo TypeScript que faça execução de algum linter ou quality gates</li>
  <li> - Executar uma análise estática usando a ferramenta SonarQube ou alguma outra similiar</li>
  
  **[Link acesso ao SonarCloud - Ferramenta para analise da qualidade estatica do código](https://sonarcloud.io/project/overview?id=MarcosMomesso_demonttdata)**

  <li> - Loreipsum</li>
  <li> - Loreipsum</li>
</ul>

## Critérios de Avaliação ✨
<ul>
  <li> - Funcionalidade</li>
  <li> - Compreensão/Dominio sobre pipeline</li>
  <li> - Eficiência</li>
  <li> - Boas Práticas</li>
  <li> - Prazo</li>
</ul>
