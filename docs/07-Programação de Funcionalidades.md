# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2026-1-e2-proj-int-t3-agroconecta/blob/main/docs/02-Especifica%C3%A7%C3%A3o%20do%20Projeto.md"> Especificação do Projeto</a></span>, <a href="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2026-1-e2-proj-int-t3-agroconecta/blob/main/docs/04-Projeto%20de%20Interface.md"> Projeto de Interface</a>, <a href="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2026-1-e2-proj-int-t3-agroconecta/blob/main/docs/03-Metodologia.md"> Metodologia</a>, <a href="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2026-1-e2-proj-int-t3-agroconecta/blob/main/docs/04-Projeto%20de%20Interface.md"> Projeto de Interface</a>, <a href="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2026-1-e2-proj-int-t3-agroconecta/blob/main/docs/05-Arquitetura%20da%20Solu%C3%A7%C3%A3o.md"> Arquitetura da Solução</a>

---
# Tela de Cadastro de Propriedades Rurais (RF-002)

<img width="1920" height="879" alt="Screenshot 2026-05-10 at 21-05-43 Cadastrar Propriedade - AgroConecta" src="https://github.com/user-attachments/assets/372b5acf-717d-45e0-b607-7f8dc3c07961" />

## Requisito atendido

| ID | Descrição do Requisito | Artefatos produzidos | Aluno(a) responsável |
|---|---|---|---|
| RF-002 | O sistema deve permitir o cadastro de propriedades rurais. | PropriedadesController.cs, Propriedade.cs, Create.cshtml, tabela `propriedades` | Rodrigo Felix |

## Artefatos da funcionalidade

- PropriedadesController.cs
- Propriedade.cs
- Create.cshtml
- site.css
- AppDbContext.cs
- Tabela `propriedades`

## Instrução de Acesso

- É NECESSÁRIO ESTAR COM A APLICAÇÃO EXECUTANDO NO VISUAL STUDIO: Abra um navegador de internet e informe o seguinte URL:

https://localhost:7032/Propriedades/Create

---

# Tela de Edição de Propriedades (RF-002.3)

<img width="1920" height="879" alt="Screenshot 2026-05-10 at 21-07-30 Editar Propriedade - AgroConecta" src="https://github.com/user-attachments/assets/c33c6cb2-2200-4d91-a8f0-2884ef80e0bc" />


## Requisito atendido

| ID | Descrição do Requisito | Artefatos produzidos | Aluno(a) responsável |
|---|---|---|---|
| RF-002.3 | O sistema deve permitir a edição dos dados da propriedade. | Edit.cshtml, método de edição no controller | Rodrigo Felix |

## Artefatos da funcionalidade

- Edit.cshtml
- PropriedadesController.cs
- Propriedade.cs
- site.css

## Instrução de Acesso

- É NECESSÁRIO ESTAR COM A APLICAÇÃO EXECUTANDO NO VISUAL STUDIO: Abra um navegador de internet e informe o seguinte URL:

https://localhost:7032/Propriedades

---

# Tela de Visualização de Propriedades (RF-002.4)

<img width="1920" height="879" alt="Screenshot 2026-05-10 at 21-08-13 Propriedades - AgroConecta" src="https://github.com/user-attachments/assets/162a7467-d549-456e-b045-7e493e30c358" />


## Requisito atendido

| ID | Descrição do Requisito | Artefatos produzidos | Aluno(a) responsável |
|---|---|---|---|
| RF-002.4 | O sistema deve permitir a visualização das propriedades cadastradas. | Tela de listagem de propriedades | Rodrigo Felix |

## Artefatos da funcionalidade

- Index.cshtml
- PropriedadesController.cs
- site.css
- Tabela `propriedades`

## Instrução de Acesso

- É NECESSÁRIO ESTAR COM A APLICAÇÃO EXECUTANDO NO VISUAL STUDIO: Abra um navegador de internet e informe o seguinte URL:

https://localhost:7032/Propriedades
---
# Tela de Atividades Agrícolas (RF-003)

<img width="1905" height="959" alt="image" src="https://github.com/user-attachments/assets/7c2c5f75-f2bc-41d3-87e9-bc068fc72822" />

## Requisito atendido

| ID | Descrição do Requisito | Artefatos produzidos | Aluno(a) responsável |
|---|---|---|---|
| RF-003 | O sistema deve permitir o registro de atividades agrícolas. | AtividadesAgricolasController.cs, AtividadesAgricolas.cs, Index.cshtml, tabela `atividades_agricolas` | Anna Clara dos Santos |
| RF-003.1 | O sistema deve permitir associar atividades a uma área cultivada. | Relacionamento entre `atividades_agricolas` e `culturas`, campo de seleção de cultura e propriedade | Anna Clara dos Santos |
| RF-003.4 | O sistema deve permitir a visualização do histórico de atividades. | Tela de listagem de atividades agrícolas | Anna Clara dos Santos |

## Artefatos da funcionalidade

- AtividadesAgricolasController.cs
- AtividadesAgricolas.cs
- Index.cshtml
- Create.cshtml
- site.css
- app.js
- Tabela `atividades_agricolas`
- Tabela `culturas`

## Instrução de Acesso

- É NECESSÁRIO ESTAR COM A APLICAÇÃO EXECUTANDO NO VISUAL STUDIO: Abra um navegador de internet e informe o seguinte URL: https://localhost:7032/AtividadesAgricolas

---
## Tela de Cadastro de Atividade Agricola

<img width="1902" height="959" alt="image" src="https://github.com/user-attachments/assets/6a7b2ca7-c57e-455f-b083-a1073c90154c" />

## Requisito atendido

| ID | Descrição do Requisito | Artefatos produzidos | Aluno(a) responsável |
|---|---|---|---|
| RF-003 | O sistema deve permitir o registro de atividades agrícolas. | Create.cshtml, formulário de cadastro, AtividadesAgricolasController.cs | Anna Clara dos Santos |
| RF-003.1 | O sistema deve permitir associar atividades a uma área cultivada. | Campo de seleção de propriedade e cultura | Anna Clara dos Santos |
| RF-003.2 | O sistema deve permitir o registro de culturas utilizadas. | Tabela `culturas`, Culturas.cs | Anna Clara dos Santos |
| RF-003.3 | O sistema deve permitir a atualização do status do cultivo. | Campo `status` no formulário | Anna Clara dos Santos |

## Artefatos da funcionalidade

- Create.cshtml
- AtividadesAgricolasController.cs
- AtividadesAgricolas.cs
- Culturas.cs
- site.css
- Bootstrap
- Tabela `atividades_agricolas`
- Tabela `culturas`

## Instrução de Acesso

- É NECESSÁRIO ESTAR COM A APLICAÇÃO EXECUTANDO NO VISUAL STUDIO: Abra um navegador de internet e informe o seguinte URL: https://localhost:7032/AtividadesAgricolas/Create

---
## Tela de Cultura

<img width="1905" height="959" alt="image" src="https://github.com/user-attachments/assets/314766f6-1651-4fc6-8584-1fc0a2fbba29" />

## Requisito atendido

| ID | Descrição do Requisito | Artefatos produzidos | Aluno(a) responsável |
|---|---|---|---|
| RF-003.2 | O sistema deve permitir o registro de culturas utilizadas. | CulturasController.cs, Culturas.cs, Index.cshtml, tabela `culturas` | Anna Clara dos Santos |
| RF-003.3 | O sistema deve permitir a atualização do status do cultivo. | Campo `status` da cultura, edição de culturas cadastradas | Anna Clara dos Santos |
| RF-003.4 | O sistema deve permitir a visualização do histórico de atividades. | Tela de listagem das culturas cadastradas | Anna Clara dos Santos |
| RF-002.4 | O sistema deve permitir a visualização das propriedades cadastradas. | Relacionamento entre cultura e propriedade | Anna Clara dos Santos |
| RNF-002 | A interface deve ser simples e intuitiva. | Layout responsivo com Bootstrap, tabela organizada e ações de gerenciamento | Anna Clara dos Santos |

## Artefatos da funcionalidade

- CulturasController.cs
- Culturas.cs
- Index.cshtml
- Edit.cshtml
- Details.cshtml
- Delete.cshtml
- Tabela `culturas`
- Integração com propriedades agrícolas

## Instrução de Acesso

- É NECESSÁRIO ESTAR COM A APLICAÇÃO EXECUTANDO NO VISUAL STUDIO: Abra um navegador de internet e informe o seguinte URL: https://localhost:7032/Culturas

---
## Tela de Cadastro de Cultura (RF-003/RF-002)

<img width="1891" height="949" alt="image" src="https://github.com/user-attachments/assets/599d8f56-a4a4-4beb-97da-8e1a06793343" />

## Requisito atendido


| ID | Descrição do Requisito | Artefatos produzidos | Aluno(a) responsável |
|---|---|---|---|
| RF-003.2 | O sistema deve permitir o registro de culturas utilizadas. | Create.cshtml, CulturasController.cs, Culturas.cs, formulário de cadastro de cultura | Anna Clara dos Santos |
| RF-002.1 | O sistema deve permitir vincular uma propriedade a um produtor. | Campo de seleção de propriedade rural | Anna Clara dos Santos |
| RF-003.3 | O sistema deve permitir a atualização do status do cultivo. | Campo `status` no formulário de cadastro | Anna Clara dos Santos |
| RF-002.2 | O sistema deve permitir cadastrar áreas cultivadas dentro da propriedade. | Campo `area_plantio` no cadastro da cultura | Anna Clara dos Santos |
| RNF-002 | A interface deve ser simples e intuitiva. | Layout responsivo com Bootstrap, formulário centralizado e navegação simplificada | Anna Clara dos Santos |

## Artefatos da funcionalidade

- Create.cshtml
- CulturasController.cs
- Culturas.cs
- Tabela `culturas`
- Bootstrap
- Validação de formulário
- Integração com propriedades rurais

## Instrução de Acesso

- É NECESSÁRIO ESTAR COM A APLICAÇÃO EXECUTANDO NO VISUAL STUDIO: Abra um navegador de internet e informe o seguinte URL: (https://localhost:7032/Culturas/Create)

---
## Tela de Analises da Cultura (RF-005)

<img width="1914" height="953" alt="image" src="https://github.com/user-attachments/assets/1871bd4a-356e-4a63-aa60-7371944f0d82" />

## Requisito atendido

| ID | Descrição do Requisito | Artefatos produzidos | Aluno(a) responsável |
|---|---|---|---|
| RF-005 | O sistema deve oferecer suporte à irrigação. | AnalisesCulturasController.cs, AnalisesCulturas.cs, tabela `analise_culturas` | Anna Clara dos Santos |
| RF-005.2 | O sistema deve considerar o tipo de cultura no cálculo. | Relacionamento entre análise e cultura | Anna Clara dos Santos |
| RF-005.5 | O sistema deve exibir recomendações ao usuário. | Campos `diagnostico` e `recomendacoes` | Anna Clara dos Santos |

## Artefatos da funcionalidade

- AnalisesCulturasController.cs
- AnalisesCulturas.cs
- Index.cshtml
- Create.cshtml
- Upload de imagem
- Tabela `analise_culturas`

## Instrução de Acesso

- É NECESSÁRIO ESTAR COM A APLICAÇÃO EXECUTANDO NO VISUAL STUDIO: Abra um navegador de internet e informe o seguinte URL: (https://localhost:7032/AnalisesCulturas)

---
## Tela de Upload para Análise da Cultura (RF-005)

<img width="1912" height="952" alt="image" src="https://github.com/user-attachments/assets/60d7f008-cc31-415b-8654-cd3aa41c9415" />

---

<img width="1613" height="951" alt="image" src="https://github.com/user-attachments/assets/b29e1495-85d3-4ec4-bb4d-66c775470877" />


## Requisito atendido

| ID | Descrição do Requisito | Artefatos produzidos | Aluno(a) responsável |
|---|---|---|---|
| RF-005 | O sistema deve oferecer suporte à irrigação. | Upload de imagem, Create.cshtml, integração com análise da cultura | Anna Clara dos Santos |
| RF-005.5 | O sistema deve exibir recomendações ao usuário. | Geração e exibição de diagnóstico e recomendações | Anna Clara dos Santos |
| RNF-002 | A interface deve ser simples e intuitiva. | Layout responsivo com Bootstrap, formulários centralizados | Anna Clara dos Santos |

## Artefatos da funcionalidade

- Create.cshtml
- Upload de imagem
- Bootstrap
- site.css
- AnalisesCulturasController.cs

## Instrução de Acesso

- É NECESSÁRIO ESTAR COM A APLICAÇÃO EXECUTANDO NO VISUAL STUDIO: Abra um navegador de internet e informe o seguinte URL: (https://localhost:7032/AnalisesCulturas/Create

---
## Tela de Resultado para Análise da Cultura (RF-005/RNF-002 )

<img width="1618" height="957" alt="image" src="https://github.com/user-attachments/assets/c40c2106-fda3-41ed-a4c9-c1bc0c7aacbd" />

## Requisito atendido

| ID | Descrição do Requisito | Artefatos produzidos | Aluno(a) responsável |
|---|---|---|---|
| RF-005 | O sistema deve oferecer suporte à irrigação. | Resultado da análise da cultura, integração com IA para interpretação da imagem agrícola | Anna Clara dos Santos |
| RF-005.2 | O sistema deve considerar o tipo de cultura no cálculo. | Identificação da cultura analisada e geração de diagnóstico baseado na imagem enviada | Anna Clara dos Santos |
| RF-005.5 | O sistema deve exibir recomendações ao usuário. | Exibição automática de diagnóstico, recomendações e relatório agrícola gerado por IA | Anna Clara dos Santos |
| RNF-002 | A interface deve ser simples e intuitiva. | Layout responsivo, relatório organizado e visualização simplificada da análise | Anna Clara dos Santos |

## Artefatos da funcionalidade

Resultado.cshtml

- AnalisesCulturasController.cs
- AnalisesCulturas.cs
- GeminiService.cs
- Integração com OpenRouter
- Integração com modelos Meta Llama
- Tabela `analise_culturas`
- Upload de imagem agrícola

## Instrução de Acesso

- É NECESSÁRIO ESTAR COM A APLICAÇÃO EXECUTANDO NO VISUAL STUDIO: Abra um navegador de internet e informe o seguinte URL: (https://localhost:7032/AnalisesCulturas/Resultado - A tela de resultado da análise utiliza inteligência artificial para processar imagens agrícolas enviadas pelo usuário. Foi utilizada integração com APIs de IA através do OpenRouter e modelos Meta Llama para geração automática de: ( diagnóstico da cultura; identificação visual da plantação; recomendações agrícolas; observações sobre irrigação e possíveis sinais de pragas ou estresse hídrico. O relatório é gerado dinamicamente após o envio da imagem pelo usuário.

---

# Tela de Categorias do Fórum  (RF-008)

<img width="1314" height="634" alt="VER-CATEGORIAS" src="https://github.com/user-attachments/assets/d69e49ee-77c2-4f67-bebc-7ce2448b1b5a" />


## Requisito atendido

| ID | Descrição do Requisito | Artefatos produzidos | Aluno(a) responsável |
|---|---|---|---|
| RF-008.2 | O sistema deve permitir a visualização de publicações. | Visualização das categorias de assuntos. | Mateus da Cunha Tito |

## Artefatos da funcionalidade

- CategoriaModel.cs
- CategoriasController.cs
- Index.cshtml
- Bootstrap
- site.css

## Instrução de Acesso

- É NECESSÁRIO ESTAR COM A APLICAÇÃO EXECUTANDO NO VISUAL STUDIO: Abra um navegador de internet e informe o seguinte URL: (https://localhost:7032/Categorias)

---
# Tela de Criar Categoria  (RF-008)

<img width="1316" height="637" alt="CADASTRAR-CATEGORIA" src="https://github.com/user-attachments/assets/34a8c6f6-e9ba-4e45-827e-10460b745d16" />


## Requisito atendido

| ID | Descrição do Requisito | Artefatos produzidos | Aluno(a) responsável |
|---|---|---|---|
| RF-008.1 |O sistema deve permitir a criação de publicações. | Criar categoria de assunto. | Mateus da Cunha Tito |

## Artefatos da funcionalidade

- CategoriaModel.cs
- CategoriasController.cs
- Create.cshtml
- Bootstrap
- site.css

## Instrução de Acesso

- É NECESSÁRIO ESTAR COM A APLICAÇÃO EXECUTANDO NO VISUAL STUDIO: Abra um navegador de internet e informe o seguinte URL: (https://localhost:7032/Categorias/Create)

---
# Tela de Editar Categoria  (RF-008)

<img width="1313" height="638" alt="EDITAR-CATEGORIA" src="https://github.com/user-attachments/assets/e3e17369-d18c-426b-97b1-6b52a365223d" />


## Requisito atendido

| ID | Descrição do Requisito | Artefatos produzidos | Aluno(a) responsável |
|---|---|---|---|
| RF-008.1 |O sistema deve permitir a criação de publicações. | Editar categoria de assunto. | Mateus da Cunha Tito |

## Artefatos da funcionalidade

- CategoriaModel.cs
- CategoriasController.cs
- Edit.cshtml
- Bootstrap
- site.css

## Instrução de Acesso

- É NECESSÁRIO ESTAR COM A APLICAÇÃO EXECUTANDO NO VISUAL STUDIO: Abra um navegador de internet e informe o seguinte URL: (https://localhost:7032/Categorias/Edit/{id})

---

# Tela de Tópicos  (RF-008)

<img width="1314" height="634" alt="VER-TOPICOS" src="https://github.com/user-attachments/assets/8577d795-7d22-4251-a6d1-da5e614cb727" />


## Requisito atendido

| ID | Descrição do Requisito | Artefatos produzidos | Aluno(a) responsável |
|---|---|---|---|
| RF-008.2 |O sistema deve permitir a criação de publicações. | Visualizar tópicos de determinada categoria. | Mateus da Cunha Tito |

## Artefatos da funcionalidade

- TopicoModel.cs
- TopicosController.cs
- Index.cshtml
- Bootstrap
- site.css

## Instrução de Acesso

- É NECESSÁRIO ESTAR COM A APLICAÇÃO EXECUTANDO NO VISUAL STUDIO: Abra um navegador de internet e informe o seguinte URL: (https://localhost:7032/Topicos/{id}
---

# Tela de Novo Tópico  (RF-008)

<img width="1313" height="637" alt="NOVO-TOPICO" src="https://github.com/user-attachments/assets/d24b56c6-f961-4cd8-98a2-dd36f7e41811" />


## Requisito atendido

| ID | Descrição do Requisito | Artefatos produzidos | Aluno(a) responsável |
|---|---|---|---|
| RF-008.1 |O sistema deve permitir a criação de publicações. | Criar tópicos em determinada categoria. | Mateus da Cunha Tito |

## Artefatos da funcionalidade

- TopicoModel.cs
- TopicosController.cs
- Create.cshtml
- Bootstrap
- site.css

## Instrução de Acesso

- É NECESSÁRIO ESTAR COM A APLICAÇÃO EXECUTANDO NO VISUAL STUDIO: Abra um navegador de internet e informe o seguinte URL: (https://localhost:7032/Topicos/Create
---

# Tela de Editar Tópico  (RF-008)

<img width="1313" height="635" alt="EDITAR-TOPICO" src="https://github.com/user-attachments/assets/c7d1cf3b-3279-4c98-a021-13155a89b846" />


## Requisito atendido

| ID | Descrição do Requisito | Artefatos produzidos | Aluno(a) responsável |
|---|---|---|---|
| RF-008.1 |O sistema deve permitir a criação de publicações. | Editar tópicos de determinada categoria. | Mateus da Cunha Tito |

## Artefatos da funcionalidade

- TopicoModel.cs
- TopicosController.cs
- Edit.cshtml
- Bootstrap
- site.css

## Instrução de Acesso

- É NECESSÁRIO ESTAR COM A APLICAÇÃO EXECUTANDO NO VISUAL STUDIO: Abra um navegador de internet e informe o seguinte URL: (https://localhost:7032/Topicos/Edit/{}
---
# Tela de Detalhes do Tópico  (RF-008)

<img width="1314" height="634" alt="DETALHES-TOPICO" src="https://github.com/user-attachments/assets/afa5024c-73c9-4b17-8442-dc3fabdd4bb3" />


## Requisito atendido

| ID | Descrição do Requisito | Artefatos produzidos | Aluno(a) responsável |
|---|---|---|---|
| RF-008.2 |O sistema deve permitir a visualização de publicações. | Visualizar determinado tópico.| Mateus da Cunha Tito |
| RF-008.3 |O sistema deve permitir comentários em publicações. | Comentar em tópico.| Mateus da Cunha Tito |
| RF-008.4 |O sistema deve permitir curtidas em publicações. | Curtir tópico e comentário.| Mateus da Cunha Tito |
| RF-008.5 |O sistema deve permitir o compartilhamento de conhecimento. | Visualizar tópico e comentários.| Mateus da Cunha Tito |

## Artefatos da funcionalidade

- TopicoModel.cs
- ComentarioModel.cs
- TopicosController.cs
- ComentariosController.cs
- Detail.cshtml
- Bootstrap
- site.css

## Instrução de Acesso

- É NECESSÁRIO ESTAR COM A APLICAÇÃO EXECUTANDO NO VISUAL STUDIO: Abra um navegador de internet e informe o seguinte URL: (https://localhost:7032/Topicos/Detail/{id}
## Observações:

O sistema foi desenvolvido utilizando ASP.NET MVC com C#, integração com SQL Server e interface responsiva utilizando Bootstrap. As funcionalidades implementadas estão relacionadas ao gerenciamento agrícola, permitindo o cadastro, acompanhamento e análise de atividades agrícolas e culturas cadastradas no sistema. Para a funcionalidade de análise da cultura, foi utilizada integração com APIs de inteligência artificial, incluindo OpenRouter e modelos Meta Llama, para processamento de imagens enviadas pelo usuário, possibilitando a geração de diagnósticos e recomendações relacionadas à cultura analisada. Atualmente, a aplicação está sendo executada em ambiente local (`localhost`), sendo necessário baixar o projeto no computador e executá-lo pelo Microsoft Visual Studio para que o sistema funcione corretamente.

Após baixar o projeto, é necessário:
- Restaurar os pacotes NuGet;
- Verificar a conexão com o SQL Server;
- Executar a aplicação pelo Visual Studio;
- Acessar as rotas locais disponibilizadas pelo sistema.

Posteriormente, o sistema será publicado em ambiente online/hospedagem web para permitir acesso externo sem a necessidade de execução local no computador do usuário.

## Tecnologias Utilizadas

- Microsoft Visual Studio
- HTML
- CSS
- Bootstrap
- JavaScript
- C#
- SQL Server
- GitHub

---
# Tela de Produtos

<img width="1909" height="911" alt="Screenshot 2026-05-10 154230" src="https://github.com/user-attachments/assets/04c4a388-134f-4d54-a587-cb670941564c" />
</br>

| ID | Descrição do Requisito | Artefatos produzidos | Aluno(a) responsável |
|---|---|---|---|
| Rf-007 | O sistema deve permitir comércio entre produtores e consumidores. | Views/Produtos/Details.cshtml (Botão de comprar que adiciona itens ao carrinho). | Maria Eduarda Pacheco Meireles
| RF-007.1 | O sistema deve permitir o cadastro de produtos agrícolas. | Views/Produtos/Create.cshtml, Tabela produtos, ProdutosControllers.cs, Pedido.cs, Views/Produtos/Edit.cshtml, View/Produtos/Create.cshtml e View/Produtos/Delete.cshtml | Maria Eduarda Pacheco Meireles |
| RF-007.2 | O sistema deve permitir que produtores publiquem produtos. | Views/Produtos/Create.cshtml | Maria Eduarda Pacheco Meireles |
| RF-007.3 | O sistema deve permitir que consumidores visualizem produtos. | Views/Produtos/Index.cshtml, Views/Produtos/Details.cshtml | Maria Eduarda Pacheco Meireles |

### Instruções de acesso

- Rodar o projeto em seu localhost, acessando a url https://localhost:7032;
- Acessar a página de "Produtos" no componente de navegação lateral.

## Produtos - Detalhes

<img width="1909" height="911" alt="Screenshot 2026-05-10 154246" src="https://github.com/user-attachments/assets/2cca160c-f1f9-4240-b263-abe78bdb00ac" />
</br>

### Instruções de Acesso
- Rodar o projeto em seu localhost, acessando a url https://localhost:7032;
- Acessar a url https://localhost:7032/Produtos/Details/{id}

## Produtos - Criação

<img width="1910" height="912" alt="Screenshot 2026-05-10 154132" src="https://github.com/user-attachments/assets/a84e2367-6a2c-4cac-b945-e6307c2302c5" />
</br>

### Instruções de acesso

- Rodar o projeto em seu localhost, acessando a url https://localhost:7032;
- Acessar a página "Cadastrar produtos" no componente de navegação lateral;


## Produtos - Edição

<img width="1909" height="912" alt="Screenshot 2026-05-10 154315" src="https://github.com/user-attachments/assets/87d1a374-08a3-4b60-8010-a0a51d25db35" />
</br>

### Instruções de acesso

- Rodar o projeto em seu localhost, acessando a url https://localhost:7032;
- Acessar a url https://localhost:7032/Produtos/Edit/{id}


## Produtos - Deleção

<img width="1899" height="904" alt="Screenshot 2026-05-10 203820" src="https://github.com/user-attachments/assets/7f5e1034-7c25-4cc2-bce0-38f356302a75" />
</br>

### Instruções de acesso

- Rodar o projeto em seu localhost, acessando a url https://localhost:7032;
- Acessar a url https://localhost:7032/Produtos/Delete/{id}

---

# Tela de Categorias

<img width="1910" height="922" alt="Screenshot 2026-05-10 154442" src="https://github.com/user-attachments/assets/1f361e34-d326-4ece-b485-4189b657b976" />
</br>

| ID | Descrição do Requisito | Artefatos produzidos | Aluno(a) responsável |
|---|---|---|---|
| N/A | Relacionada aos requisitos das telas de produtos. As categorias descritas aqui são as categorias de produtos às quais os mesmos estão vinculados. | tabela categoriaProduto, CategoriaProdutosController.cs, CategoriaProduto.cs, Views/CategoriaProdutos/Create.cshtml, Views/CategoriaProdutos/Edit.cshtml e Views/CategoriaProdutos/Index.cshtml | Maria Eduarda Pacheco Meireles

## Categorias - Criação

<img width="1911" height="910" alt="Screenshot 2026-05-10 154517" src="https://github.com/user-attachments/assets/2e56e69e-473a-4c39-a71e-76d991c5849d" />
</br>

### Instruções de acesso

- Rodar o projeto em seu localhost, acessando a url https://localhost:7032;
- Acessar a url https://localhost:7032/CategoriaProdutos/Create


## Categorias - Edição

<img width="1903" height="901" alt="Screenshot 2026-05-10 154504" src="https://github.com/user-attachments/assets/4bd04605-da60-42aa-a6a9-a837b6928c32" />
</br>

### Instruções de acesso

- Rodar o projeto em seu localhost, acessando a url https://localhost:7032;
- Acessar a url https://localhost:7032/CategoriaProdutos/ Edit/{id}

## Categorias - Deleção (Modal na tela de visualização)

<img width="1233" height="784" alt="Screenshot 2026-05-10 154454" src="https://github.com/user-attachments/assets/44ed287a-2dca-41ca-9744-3668fac29a41" />
</br>

### Instruções de acesso

- Rodar o projeto em seu localhost, acessando a url https://localhost:7032;
- Acessar a url https://localhost:7032/CategoriaProdutos/Index;
- Clicar no ícone de lixeira na lateral direita da categoria listada;
- Um modal de deleção deve aparecer em tela ao realizar o clique.

---

# Tela de Carrinho
Através desta tela é possível adicionar mais quantidades de um mesmo produto, remover o mesmo, esvaziar o carrinho e fechar compra. Todas as funcionalidades são aqui executadas no Index.cshtml.

<img width="1909" height="916" alt="Screenshot 2026-05-10 154346" src="https://github.com/user-attachments/assets/a6303edc-647e-4295-85eb-23d5bc2a506e" />
</br>
<img width="1913" height="913" alt="Screenshot 2026-05-10 154334" src="https://github.com/user-attachments/assets/5ca47152-2ce3-43f4-96db-1054c8d149f5" />
</br>

| ID | Descrição do Requisito | Artefatos produzidos | Aluno(a) responsável |
|---|---|---|---|
| Rf-007 | O sistema deve permitir comércio entre produtores e consumidores. | Tabelas pedidos e itensPedido, PedidosController.cs, Pedido.cs, ItemPedido.cs,  | Maria Eduarda Pacheco Meireles
| RF-007.4 | O sistema deve permitir a realização de compras. | Todos os anteriores. | Maria Eduarda Pacheco Meireles


### Instruções de acesso

- Rodar o projeto em seu localhost, acessando a url https://localhost:7032;
- Acessar a página de Produtos no componente de navegação lateral;
- Clicar em "Ver detalhes" de um produto;
- Clicar em comprar;
- Clicar no ícone flutuante de carrinho no topo da página.

---

# Tela de Dashboard
Através desta tela é possível visualizar alguns indicadores sobre as culturas e atividades agricolas.

<img width="1310" height="633" alt="image" src="https://github.com/user-attachments/assets/a55f71e9-aa6c-4aed-aa2b-737fb53008ac" />


| ID | Descrição do Requisito | Artefatos produzidos | Aluno(a) responsável |
|---|---|---|---|
| Rf-006 | O sistema deve apresentar indicadores e métricas. | Home.cshtml | Mateus da Cunha Tito
| Rf-006.2 | O sistema deve apresentar gráficos de desempenho. | Home.cshtml | Mateus da Cunha Tito


### Instruções de acesso

- Rodar o projeto em seu localhost, acessando a url https://localhost:7032;
- Após o login o usuário será redirecionado a pagina de dashboard;

---  

# Tela de Vendas 
Tela em que o perfil de usuário de produtor pode acompanhar a evolução das suas vendas. 

<img <img width="1359" height="582" alt="telaVendas" src="https://github.com/user-attachments/assets/917e47f5-3ffe-4b41-8bb4-5423a8cb3908" />

| ID | Descrição do Requisito | Artefatos produzidos | Aluno(a) responsável |
|---|---|---|---|
| Rf-007 | O sistema deve permitir comércio entre produtores e consumidores.| Vendas.cshtml | Rafaela Parolini Fragnan


### Instruções de acesso

- Rodar o projeto em seu localhost, acessando a url https://localhost:7032;
- Após o login o usuário produtor deverá localizar o Marketplace no sidebar da aplicação e clicar na opção 'vendas' do submenu.

---

# Tela de Detalhes do Pedido
Tela em que o perfil de usuário de consumidor pode avaliar sua compra após entrega concluída.

<img width="1323" height="578" alt="Captura de tela 2026-06-21 000304" src="https://github.com/user-attachments/assets/d88e3177-3a94-4dce-8726-72899998acdd" />
<img width="1337" height="585" alt="Captura de tela 2026-06-20 235812" src="https://github.com/user-attachments/assets/58e72d28-9659-4a23-9be3-779399f65e1c" />

| ID | Descrição do Requisito | Artefatos produzidos | Aluno(a) responsável |
|---|---|---|---|
| Rf-007.4 | O sistema deve permitir a realização de compras.| Pedidos.cs | Rafaela Parolini Fragnan


### Instruções de acesso 

- Rodar o projeto em seu localhost, acessando a url https://localhost:7032;
- Após o login, localizar no sidebar o menu do seu perfil e acessar 'meus pedidos';
- Quando o status do pedido estiver 'entregue', efetuar a avaliação da compra.
  
---

