# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

<img src="/docs/img/personas/nelsonPersona.png" alt="Persona1"/>

<img src="/docs/img/personas/anaPersona.png" alt="Persona2"/>

<img src="/docs/img/personas/jorgePersona.png" alt="Persona3"/>

<img src="/docs/img/personas/lucianaPersona.png" alt="Persona4"/>

<img src="/docs/img/personas/emersonPersona.png" alt="Persona5"/>



## Histórias de Usuários

| EU COMO...                | QUERO/PRECISO...                                      | PARA...                                         |
| ------------------------- | ----------------------------------------------------- | ----------------------------------------------- |
| Eu, como produtor rural   | criar e gerenciar minha conta na plataforma           | acessar e utilizar os serviços do sistema       |
| Eu, como produtor rural   | cadastrar e editar informações das minhas propriedades| organizar minhas áreas de cultivo               |
| Eu, como produtor rural   | registrar atividades agrícolas como plantio e colheita| acompanhar o histórico da produção              |
| Eu, como produtor rural   | visualizar dados climáticos da minha região           | Melhor planejar atividade agrícola              |
| Eu, como produtor rural   | receber recomendações sobre irrigação                 | utilizar a água de forma mais eficiente         |
| Eu, como produtor rural   | controlar o uso de água na irrigação                  | evitar desperdício e cuidar melhor da plantação |
| Eu, como produtor rural   | visualizar indicadores de produtividade               | avaliar os resultados da minha produção         |
| Eu, como produtor rural   | anunciar e vender meus produtos                       | ampliar minhas oportunidades de venda           |
| Eu, como produtor rural   | interagir com outros produtores e especialistas       | trocar experiências e aprender novas práticas   |
| Eu, como consumidor       | buscar produtos de produtores locais                  | comprar alimentos frescos e de origem conhecida |
| Eu, como consumidor       | visualizar informações sobre os produtos disponíveis  | tomar decisões de compra com mais confiança     |
| Eu, como consumidor       | visualizar dados das propriedades e produção          | oferecer orientações técnicas aos produtore     |
| Eu, como técnico agrícola | acompanhar as atividades dos produtores               | oferecer orientações quando necessário          |
| Eu, como técnico agrícola | visualizar informações sobre produção e clima         | ajudar os produtores a tomar melhores decisões  |
| Eu, como técnico agrícola | compartilhar recomendações agrícolas                  | ajudar na melhoria das práticas de cultivo      |

## Requisitos

O projeto tem seu escopo estabelecido a partir da definição dos requisitos. Os requisitos funcionais especificam as funcionalidades do sistema e como os usuários poderão interagir com ele. Já os requisitos não funcionais determinam as características gerais que o sistema deverá possuir, como desempenho, segurança e usabilidade.

Esses requisitos estão descritos a seguir.

### Requisitos Funcionais

| ID       | Descrição do Requisito                                                                 | Prioridade |
|----------|----------------------------------------------------------------------------------------|------------|
| RF-001   | O sistema deve permitir o cadastro de usuários com nome, email e senha.              | ALTA       |
| RF-001.1 | O sistema deve permitir login e autenticação de usuários.                            | ALTA       |
| RF-001.2 | O sistema deve permitir a definição do tipo de usuário (produtor, consumidor, técnico). | ALTA   |
| RF-001.3 | O sistema deve permitir a edição dos dados do usuário.                               | ALTA       |
| RF-001.4 | O sistema deve permitir a desativação de contas de usuários.                          | ALTA       |
| RF-001.5 | O sistema deve permitir a recuperação de senha.                                       | ALTA       |
| RF-002   | O sistema deve permitir o cadastro de propriedades rurais.                           | ALTA       |
| RF-002.1 | O sistema deve permitir vincular uma propriedade a um produtor.                      | ALTA       |
| RF-002.2 | O sistema deve permitir cadastrar áreas cultivadas dentro da propriedade.            | ALTA       |
| RF-002.3 | O sistema deve permitir a edição dos dados da propriedade.                           | ALTA       |
| RF-002.4 | O sistema deve permitir a visualização das propriedades cadastradas.                 | ALTA       |
| RF-003   | O sistema deve permitir o registro de atividades agrícolas.                          | ALTA       |
| RF-003.1 | O sistema deve permitir associar atividades a uma área cultivada.                   | ALTA       |
| RF-003.2 | O sistema deve permitir o registro de culturas utilizadas.                          | ALTA       |
| RF-003.3 | O sistema deve permitir a atualização do status do cultivo.                         | ALTA       |
| RF-003.4 | O sistema deve permitir a visualização do histórico de atividades.                 | ALTA       |
| RF-004   | O sistema deve disponibilizar informações climáticas.                                | ALTA       |
| RF-004.1 | O sistema deve consultar dados climáticos por API externa.                          | ALTA       |
| RF-004.2 | O sistema deve associar dados climáticos à localização da propriedade.              | ALTA       |
| RF-004.3 | O sistema deve exibir a previsão do tempo ao usuário.                              | ALTA       |
| RF-004.4 | O sistema deve armazenar histórico climático.                                       | ALTA       |
| RF-004.5 | O sistema deve emitir alertas climáticos relevantes.                                | ALTA       |
| RF-005   | O sistema deve oferecer suporte à irrigação.                                        | ALTA       |
| RF-005.1 | O sistema deve calcular a necessidade de irrigação com base em dados climáticos.   | ALTA       |
| RF-005.2 | O sistema deve considerar o tipo de cultura no cálculo.                             | ALTA       |
| RF-005.3 | O sistema deve permitir o registro de eventos de irrigação.                        | ALTA       |
| RF-005.4 | O sistema deve recomendar frequência ideal de irrigação.                           | ALTA       |
| RF-005.5 | O sistema deve exibir recomendações ao usuário.                                    | ALTA       |
| RF-006   | O sistema deve apresentar indicadores e métricas.                                  | ALTA       |
| RF-006.1 | O sistema deve calcular produtividade por cultura.                                 | ALTA       |
| RF-006.2 | O sistema deve apresentar gráficos de desempenho.                                 | ALTA       |
| RF-006.3 | O sistema deve gerar relatórios agrícolas.                                         | ALTA       |
| RF-006.4 | O sistema deve permitir análise histórica da produção.                             | ALTA       |
| RF-006.5 | O sistema deve exibir métricas ambientais.                                         | ALTA       |
| RF-007   | O sistema deve permitir comércio entre produtores e consumidores.                 | ALTA       |
| RF-007.1 | O sistema deve permitir o cadastro de produtos agrícolas.                          | ALTA       |
| RF-007.2 | O sistema deve permitir que produtores publiquem produtos.                        | ALTA       |
| RF-007.3 | O sistema deve permitir que consumidores visualizem produtos.                     | ALTA       |
| RF-007.4 | O sistema deve permitir a realização de compras.                                  | ALTA       |
| RF-007.5 | O sistema deve registrar transações de compra e venda.                            | ALTA       |
| RF-007.6 | O sistema deve permitir o acompanhamento do histórico de compras.                 | ALTA       |
| RF-008   | O sistema deve oferecer interação entre usuários.                                  | ALTA       |
| RF-008.1 | O sistema deve permitir a criação de publicações.                                | ALTA       |
| RF-008.2 | O sistema deve permitir a visualização de publicações.                           | ALTA       |
| RF-008.3 | O sistema deve permitir comentários em publicações.                              | ALTA       |
| RF-008.4 | O sistema deve permitir curtidas em publicações.                                 | ALTA       |
| RF-008.5 | O sistema deve permitir o compartilhamento de conhecimento.                      | ALTA       |


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve garantir a segurança de dados dos usuários| ALTA | 
|RNF-002| A interface deve ser simples e intuitiva|  ALTA | 
|RNF-003| A aplicação deve ser compatível com os principais navegadores (Chrome, Firefox e Edge)|  ALTA | 
|RNF-004| O sistema deve ser acessível, permitindo navegação e utilização de todas as funcionalidades por meio do teclado, garantindo inclusão de usuários com limitações motoras|  BAIXA | 


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| o projeto deve ter processos de testes antes da entraga |
|03| Todos integrantes deverão ter sua coloboração no projeto, garatindo um trabalho em equipe  |


## Diagrama de Casos de Uso

<img width="3761" height="3748" alt="Diagrama de caso de uso - AgroConecta" src="https://github.com/user-attachments/assets/613f68c4-e310-4b5a-b79c-7988f4275e7e" />

```
