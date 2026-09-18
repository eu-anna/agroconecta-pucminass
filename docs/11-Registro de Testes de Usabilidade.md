# Registro de Testes de Usabilidade – AgroConecta

Os testes de usabilidade do AgroConecta avaliaram navegação, acessibilidade e facilidade de uso do sistema para diferentes perfis de usuários. Durante os testes, foram analisados tempo de execução, erros, quantidade de cliques e feedback dos participantes.

---

## Perfil dos Participantes

| ID  | Nome              | Perfil           | Experiência   |
| --- | ----------------- | ---------------- | ------------- |
| P1  | Ana Clara         | Consumidor       | Iniciante     |
| P2  | João Pedro        | Consumidor       | Avançado      |
| P3  | Carlos Henrique   | Produtor Rural   | Intermediário |
| P4  | Maria Luiza       | Produtor Rural   | Iniciante     |
| P5  | Felipe Santos     | Técnico Agrícola | Avançado      |
| P6  | Renata Oliveira   | Técnico Agrícola | Intermediário |
| P7  | Lucas Almeida     | Consumidor       | Intermediário |
| P8  | Beatriz Fernandes | Produtor Rural   | Avançado      |
| P9  | Gustavo Martins   | Técnico Agrícola | Iniciante     |
| P10 | Larissa Costa     | Consumidor       | Intermediário |

---

## Cenário CT-U03 – Visualização de Culturas

**Objetivo:** Avaliar a visualização e gerenciamento das culturas cadastradas no sistema.

| Usuário | Tempo (seg) | Cliques | Concluiu? | Erros                                     | Feedback                                                   |
| ------- | ----------- | ------- | --------- | ----------------------------------------- | ---------------------------------------------------------- |
| P3      | 95          | 14      | Sim       | Nenhum                                    | “Informações organizadas.”                                 |
| P4      | 160         | 20      | Não       | Dificuldade em localizar menu de culturas | “Tive dificuldade para encontrar as culturas cadastradas.” |
| P8      | 55          | 9       | Sim       | Nenhum                                    | “Sistema intuitivo.”                                       |


## Cenário CT-U04 – Cadastro de Atividade Agrícola

**Objetivo:** Avaliar a facilidade de registrar uma nova atividade agrícola.

| Usuário | Tempo (seg) | Cliques | Concluiu? | Erros                                     | Feedback                                            |
| ------- | ----------- | ------- | --------- | ----------------------------------------- | --------------------------------------------------- |
| P4      | 170         | 24      | Sim       | Erro ao preencher data                    | “Os campos poderiam ser mais claros.”               |
| P3      | 88          | 12      | Sim       | Nenhum                                    | “Cadastro rápido.”                                  |
| P8      | 50          | 8       | Sim       | Nenhum                                    | “Muito fácil.”                                      |
| P8      | 50          | 8       | Sim       | Dificuldade inicial ao selecionar cultura | “Depois que encontrei a opção ficou fácil.”         |


## Cenário CT-U05 – Análise da Cultura

**Objetivo:** Avaliar o processo de upload da imagem e visualização da análise gerada pela IA.

| Usuário | Tempo (seg) | Cliques | Concluiu? | Erros                                                       | Feedback                                                  |
| ------- | ----------- | ------- | --------- | ----------------------------------------------------------- | --------------------------------------------------------- |
| P5      | 48          | 8       | Sim       | Nenhum                                                      | “Indicadores claros e análise rápida.”                    |
| P6      | 72          | 11      | Sim       | Dificuldade na leitura                                      | “Fonte pequena na tela do resultado.”                     |
| P9      | 130         | 18      | Não       | Não encontrou botão de upload                               | “Menu confuso.”                                           |
| P9      | 125         | 17      | Não       | Erro na recomendação da IA                                  | “Às vezes a IA não gerava corretamente os diagnosticos.”  |
| P9      | 125         | 17      | Não       | Repetição da mesma mensagem no diagnóstico e recomendação   | “A IA repetia a mesma mensagem nas duas áreas.”           |
| P9      | 125         | 17      | Não       | Dificuldade em localizar o botão de voltar para as análises | “O menu estava confuso para navegar.”                     |


## Cenário CT-U06 – Consulta Climática

**Objetivo:** Avaliar a busca de informações climáticas e exibição dos dados meteorológicos.

| Usuário | Tempo (seg)    | Cliques | Concluiu? | Erros                           | Feedback                                  |
|----------|--------------|----------|------------|----------------------------------|-----------------------------------------|
| P1       | 40           | 6        | Sim        | Nenhum                          | “Tela simples e fácil de entender.”      |
| P3       | 58           | 8        | Sim        | Nenhum                          | “As informações apareceram rapidamente.” |
| P4       | 120          | 15       | Não        | Dificuldade ao pesquisar cidade | “Não percebi onde precisava digitar.”    |
| P8       | 35           | 5        | Sim        | Nenhum                          | “Muito intuitivo.”                       |

---

## Cenário CT-U07 – Histórico de Pesquisas Climáticas

**Objetivo:** Avaliar o funcionamento do histórico de cidades pesquisadas.

| Usuário  | Tempo (seg)  | Cliques  | Concluiu?  | Erros                              | Feedback                                                    |
|----------|--------------|----------|------------|------------------------------------|-------------------------------------------------------------|
| P2       | 45           | 7        | Sim        | Nenhum                             | “Gostei de salvar as pesquisas automaticamente.”            |
| P6       | 72           | 10       | Sim        | Dificuldade em localizar histórico | “Não vi de imediato onde ficavam as pesquisas anteriores.”  |
| P9       | 135          | 18       | Não        | Não encontrou pesquisas anteriores | “Achei que as pesquisas tinham sumido.”                     |

---

## Cenário CT-U08 – Persistência após Atualização

**Objetivo:** Avaliar a permanência das pesquisas após atualizar a página.

| Usuário  | Tempo (seg)  | Cliques  | Concluiu?  | Erros                     | Feedback                                               |
|----------|--------------|----------|------------|---------------------------|--------------------------------------------------------|
| P2       | 52           | 8        | Sim        | Nenhum                    | “As pesquisas continuaram salvas normalmente.”         |
| P7       | 64           | 9        | Sim        | Nenhum                    | “Funcionou corretamente após atualizar.”               |
| P10      | 98           | 14       | Não        | Não percebeu persistência | “Achei que teria apagado tudo ao atualizar a tela.”    |

---

## Cenário CT-U09 – Limpeza do Histórico Climático

**Objetivo:** Avaliar a funcionalidade de limpar pesquisas salvas.

| Usuário  | Tempo (seg)  | Cliques  | Concluiu?  | Erros                                     | Feedback                                |
|----------|--------------|----------|------------|-------------------------------------------|-----------------------------------------|
| P5       | 25           | 4        | Sim        | Nenhum                                    | “Botão fácil de localizar.”             |
| P7       | 52           | 7        | Sim        | Nenhum                                    | “Funcionou corretamente.”               |
| P10      | 88           | 12       | Não        | Dificuldade em localizar botão de limpeza | “O botão poderia estar mais destacado.” |

---

## Cenário CT-U10 – Tratamento de Erros na Busca Climática

**Objetivo:** Avaliar o comportamento do sistema ao pesquisar cidades inválidas ou deixar o campo vazio.

| Usuário  | Tempo (seg)  | Cliques  | Concluiu?  | Erros                           | Feedback                                    |
|----------|--------------|----------|------------|---------------------------------|---------------------------------------------|
| P1       | 38           | 5        | Sim        | Nenhum                          | “Mensagem de erro clara.”                   |
| P4       | 95           | 13       | Não        | Campo vazio                     | “Não entendi porque nada aconteceu.”        |
| P9       | 110          | 16       | Não        | Cidade inválida não encontrada  | “Achei que o sistema tinha travado.”        |




# Relatório dos Testes de Usabilidade

## Taxa de sucesso por cenário

| Cenário                         | Taxa de sucesso |
| ------------------------------- | --------------- |
| Visualização de Culturas        | 60%             |
| Cadastro de Atividade Agrícola  | 80%             |
| Análise da Cultura              | 67%             |
| Resultado da Análise da Cultura | 50%             |


## Tempo médio para completar cada cenário

| Cenário                         | Tempo médio  |
| ------------------------------- | ------------ |
| Visualização de Culturas        | 103 segundos |
| Cadastro de Atividade Agrícola  | 102 segundos |
| Análise da Cultura              | 83 segundos  |
| Resultado da Análise da Cultura | 92 segundos  |


## Número médio de erros por tarefa

| Cenário                         | Média de erros |
| ------------------------------- | -------------- |
| Visualização de Culturas        | 1,0            |
| Cadastro de Atividade Agrícola  | 0,6            |
| Análise da Cultura              | 1,2            |
| Resultado da Análise da Cultura | 2,0            |

---

# Organização dos Resultados e Identificação de Padrões

## Principais dificuldades encontradas

- Usuários iniciantes tiveram dificuldade em localizar menus.
- Alguns usuários relataram tamanho pequeno das fontes.
- Houve dificuldade para localizar o botão de upload da imagem.
- Dúvidas no preenchimento dos campos de data nas atividades agrícolas.
- Dificuldade em localizar o botão de voltar para a tela de análises de cultura.

## Tarefas concluídas sem problemas

- Cadastro de Atividade Agrícola.
- Usuários intermediários e avançados conseguiram navegar sem dificuldades.
- Visualização das culturas foi considerada organizada e intuitiva pela maioria dos participantes.
- Navegação entre as telas principais para usuários intermediários e avançados.
- Visualização dos resultados da análise da cultura.
- 

## Tarefas que apresentaram falhas

- Localização do botão de upload da imagem.
- Navegação em menus por usuários iniciantes.
- Preenchimento dos campos de data.
- Leitura das informações na tela de análise da cultura.
- Falhas durante o carregamento e análise da imagem pela IA em alguns testes.

---

# Problemas Identificados

| Problema Identificado                                              | Prioridade |
| ------------------------------------------------------------------ | ---------- |
| Dificuldade em localizar funcionalidades importantes               | Crítico    |
| Falhas no carregamento ou retorno da análise pela IA               | Crítico    |
| Dificuldade em encontrar o botão de voltar para a tela de análises | Moderado   |
| Botão de upload da imagem pouco visível                            | Moderado   |
| Fonte pequena nas telas                                            | Moderado   |
| Navegação confusa em alguns menus                                  | Moderado   |
| Campos de data confusos                                            | Leve       |
| Excesso de informações em algumas páginas                          | Leve       |
| Falta de mensagens explicativas em alguns campos                   | Leve       |

---

# Sugestões de Melhorias

## Interface
- Aumentar tamanho das fontes.
- Melhorar contraste dos botões.
- Destacar botão de upload.
- Organizar melhor as telas.
- Padronizar layouts do sistema.
- Reduzir excesso de informações.
- Adicionar mensagens explicativas.
- Melhorar visualização da análise da IA.
- Exibir mensagens claras de erro.

## Navegação
- Simplificar os menus do sistema.
- Adicionar botão “Voltar” nas telas.
- Destacar funcionalidades principais.
- Melhorar identificação das áreas do sistema.
- Facilitar localização das funcionalidades importantes.
- Melhorar organização dos menus laterais.
- Criar navegação mais intuitiva para usuários iniciantes.
- Padronizar posição dos botões de ação.

## Acessibilidade
- Melhorar legibilidade das telas.
- Aumentar tamanho dos botões.
- Melhorar contraste visual.
- Facilitar visualização para usuários com dificuldade visual.
- Implementar fontes responsivas.
- Melhorar espaçamento entre elementos da interface.
- Tornar formulários mais intuitivos.
- Adicionar suporte visual para preenchimento de datas.

## Funcionalidades
- Melhorar estabilidade da análise realizada pela IA.
- Permitir repetir o envio da imagem em caso de falha.
- Adicionar mensagens de carregamento durante a análise.
- Melhorar validação dos arquivos enviados.
- Inserir exemplos de preenchimento nos campos de data.
- Adicionar confirmação visual após conclusão das ações do sistema.

---

# Propostas de Ações Corretivas

| Problema                                                           | Ação proposta                                               |
| ------------------------------------------------------------------ | ----------------------------------------------------------- |
| Dificuldade em localizar funcionalidades                           | Reorganizar os menus e destacar as funções principais       |
| Falhas no carregamento ou retorno da análise pela IA               | Exibir mensagem de erro clara e permitir tentar novamente   |
| Dificuldade em encontrar o botão de voltar para a tela de análises | Deixar o botão “Voltar” mais visível e padronizado          |
| Botão de upload pouco visível                                      | Aumentar o tamanho e melhorar o contraste do botão          |
| Fonte pequena nas telas                                            | Implementar fontes maiores e responsivas                    |
| Navegação confusa em alguns menus                                  | Simplificar a organização dos menus                         |
| Campos de data confusos                                            | Adicionar calendário automático e exemplos de preenchimento |
| Excesso de informações em algumas páginas                          | Dividir as informações em seções menores                    |
| Falta de mensagens explicativas em alguns campos                   | Inserir textos de apoio e orientações nos formulários       |


---

# Melhorias Incrementais

- Adicionar tutorial e mensagens explicativas para usuários iniciantes.
- Padronizar layouts, botões e organização das telas.
- Melhorar contraste visual, tamanho das fontes e acessibilidade.
- Simplificar menus e facilitar localização das funcionalidades.
- Melhorar upload e visualização das análises da IA.
- Adicionar mensagens de erro, carregamento e exemplos nos campos de data.

---

# Conclusão

Os testes demonstraram boa eficiência para usuários intermediários e avançados. Porém, usuários iniciantes apresentaram dificuldades na navegação, localização de funcionalidades, leitura das informações e uso da IA, além de falhas nas recomendações e diagnósticos gerados.

Com base nos resultados, recomenda-se melhorar acessibilidade, organização dos menus, clareza visual e estabilidade da integração com a IA para tornar o sistema mais intuitivo e eficiente.
