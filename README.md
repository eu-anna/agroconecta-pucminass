# AgroConecta

Plataforma web acadêmica para apoiar pequenos produtores rurais no gerenciamento da produção, no acompanhamento de informações agrícolas e na comercialização de produtos.

> Projeto desenvolvido em equipe na graduação de Análise e Desenvolvimento de Sistemas da PUC Minas, no período 2026/1. Este repositório é um fork do projeto acadêmico original.

## Sobre o projeto

O AgroConecta reúne ferramentas para organizar informações da propriedade e aproximar produtores e consumidores. A aplicação foi construída como projeto acadêmico e contém módulos de gestão agrícola, marketplace e interação entre usuários.

## Funcionalidades implementadas

- Cadastro e gerenciamento de propriedades rurais, culturas e atividades agrícolas.
- Consulta de condições climáticas atuais por localização, usando a API Open-Meteo.
- Envio de imagem de uma cultura e geração de análise textual por meio da API da OpenAI.
- Cadastro e organização de produtos agrícolas por categorias.
- Carrinho, pedidos, acompanhamento de vendas e integração de checkout com Mercado Pago.
- Fórum com categorias, tópicos, comentários e curtidas.
- Relatórios agrícolas e exportação em PDF.
- Painel com indicadores do sistema.

A análise por IA é experimental e pode produzir resultados incorretos. As informações geradas não substituem avaliação de um profissional agrícola.

## Tecnologias

- **Back-end:** C#, ASP.NET Core MVC e .NET 10
- **Persistência:** Entity Framework Core e SQL Server
- **Interface:** Razor Views, HTML, CSS, JavaScript e Bootstrap
- **Serviços externos:** Open-Meteo, OpenAI API e Mercado Pago
- **Relatórios:** QuestPDF
- **Versionamento:** Git e GitHub

## Minha contribuição

De acordo com a documentação do projeto, Anna Clara dos Santos contribuiu principalmente com:

- Cadastro, edição e acompanhamento de atividades agrícolas.
- Cadastro e gerenciamento de culturas e associação com propriedades.
- Interface de envio de imagens e exibição das análises de cultura.
- Integração da análise de imagens com a API da OpenAI para gerar diagnóstico e recomendações textuais.

O projeto foi feito em equipe; os demais módulos e decisões foram desenvolvidos em colaboração com as pessoas listadas em **Equipe**.

## Demonstração

A demonstração online está temporariamente indisponível. Para conhecer o sistema, consulte a documentação e as capturas de tela vinculadas nela. O endereço antigo do Render foi retirado até que a equipe confirme uma publicação funcionando.

## Executar localmente

### Pré-requisitos

- .NET 10 SDK
- SQL Server ou SQL Server LocalDB
- Chave da API OpenAI para usar a análise de imagens
- Credencial de teste do Mercado Pago para testar o checkout (opcional)

### Configuração

Configure as credenciais fora do código, usando variáveis de ambiente. No PowerShell, por exemplo:

```powershell
$env:ConnectionStrings__DefaultConnection = "Server=(localdb)\MSSQLLocalDB;Database=AgroConecta;Trusted_Connection=True;TrustServerCertificate=True;"
$env:OpenAI__ApiKey = "SUA_CHAVE_OPENAI"
$env:MercadoPagoSettings__AccessToken = "SEU_TOKEN_DE_TESTE"
```

Não publique chaves, senhas ou strings de conexão com credenciais no GitHub. A API de clima Open-Meteo não requer chave.

### Iniciar

Na pasta raiz do repositório, execute:

```powershell
dotnet restore src/AgroConecta/AgroConecta/AgroConecta.csproj
dotnet run --project src/AgroConecta/AgroConecta/AgroConecta.csproj
```

Abra no navegador a URL local indicada no terminal. Na inicialização, a aplicação tenta criar o banco e as tabelas usando a conexão configurada. A integração com OpenAI e o checkout dependem de credenciais válidas; sem elas, esses recursos externos não funcionarão.

## Estrutura

```text
src/AgroConecta/AgroConecta/   Aplicação ASP.NET Core MVC
  Controllers/                  Fluxos e ações da aplicação
  Data/                         Contexto e inicialização do banco
  Models/                       Entidades e modelos de tela
  Services/                     Integrações externas
  Views/                        Páginas Razor
  wwwroot/                      CSS, JavaScript, imagens e uploads

docs/                           Documentação acadêmica e testes
presentation/                   Materiais da apresentação
```

## Documentação

A pasta [`docs`](docs/) contém documentação de contexto, requisitos, metodologia, interface, arquitetura, programação das funcionalidades e registros de testes. O projeto original também pode ser consultado em [ICEI-PUC-Minas-PMV-ADS](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2026-1-e2-proj-int-t3-agroconecta).

## Equipe

- Anna Clara dos Santos
- Elizabeth França Vaz dos Santos
- Maria Eduarda Pacheco Meireles
- Mateus da Cunha Tito
- Rafaela Parolini Fragnan
- Rodrigo Felix Gomes

**Orientador:** Claudio Faria  
**Curso:** Análise e Desenvolvimento de Sistemas — PUC Minas  
**Período:** 2026/1

## Observação

Este é um protótipo acadêmico. Antes de qualquer uso público com dados reais, é necessário revisar a segurança da aplicação, a configuração de credenciais e os fluxos de autenticação e pagamento.
