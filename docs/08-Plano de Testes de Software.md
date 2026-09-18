# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2026-1-e2-proj-int-t3-monitoramento-agricola/blob/main/docs/02-Especifica%C3%A7%C3%A3o%20do%20Projeto.md"> Especificação do Projeto</a></span>, <a href="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2026-1-e2-proj-int-t3-monitoramento-agricola/blob/main/docs/04-Projeto%20de%20Interface.md"> Projeto de Interface</a>

### PLANO DE TESTES – FUNCIONALIDADE DE LOGIN (AgroConecta)

1. Identificação

| Item               | Descrição                        |
| -----------------  | -------------------------------- |
| **Sistema**        | AgroConecta                      |
| **Funcionalidade** | Login e autenticação             |
| **Responsável**    | Equipe do Projeto                |
| **Versão**         | 1.0                              |
| **Data**           | 2026                             |

2. Objetivo

- Validar autenticação de usuários
- Garantir segurança no acesso
- Validar recuperação de senha
- Validar o funcionamento do recurso “Lembrar de mim”
- Validar o redirecionamento conforme o tipo de usuário

3. Ambiente de Testes

- Navegadores: Chrome, Firefox, Edge  
- Ambiente: Localhost ou homologação  
- Banco de dados: simulado ou real  
- Usuários: cadastrados no sistema (produtor, consumidor e técnico)  
- Estado inicial: usuário não autenticado  

-  Requisitos para execução dos testes:

 *  Site disponível na internet

4. Casos de teste
<table>
  <tr>
    <th>Teste</th>
    <th>Requisitos</th>
    <th>Objetivo</th>
    <th>Etapas</th>
    <th>Resultado esperado</th>
    <th>Responsável</th>
  </tr>

<!-- CT-01 -->
<tr>
<td>CT-01 – Login com credenciais válidas</td>
<td>RF-001.1</td>
<td>Validar autenticação de usuários</td>
<td>
<ol>
<li>Acessar a aplicação</li>
<li>Inserir e-mail e senha válidos</li>
<li>Clicar em "Entrar"</li>
</ol>
</td>
<td>Usuário autenticado com sucesso</td>
<td>Equipe</td>
</tr>

<!-- CT-02 -->
<tr>
<td>CT-02 – Login com credenciais inválidas</td>
<td>RF-001.1</td>
<td>Garantir segurança no acesso</td>
<td>
<ol>
<li>Acessar a aplicação</li>
<li>Inserir e-mail ou senha incorretos</li>
<li>Clicar em "Entrar"</li>
</ol>
</td>
<td>Sistema bloqueia acesso e exibe mensagem de erro</td>
<td>Equipe</td>
</tr>

<!-- CT-03 -->
<tr>
<td>CT-03 – Recuperação de senha</td>
<td>RF-001.5</td>
<td>Validar recuperação de senha</td>
<td>
<ol>
<li>Clicar em "Esqueci senha"</li>
<li>Informar e-mail cadastrado</li>
</ol>
</td>
<td>E-mail de recuperação enviado</td>
<td>Equipe</td>
</tr>

<!-- CT-04 -->
<tr>
<td>CT-04 – Lembrar de mim</td>
<td>RF-001.1</td>
<td>Validar funcionalidade “Lembrar de mim”</td>
<td>
<ol>
<li>Inserir credenciais válidas</li>
<li>Marcar "Lembrar de mim"</li>
<li>Fazer login</li>
<li>Fechar e reabrir o sistema</li>
</ol>
</td>
<td>Usuário permanece logado</td>
<td>Equipe</td>
</tr>

<!-- CT-05 -->
<tr>
<td>CT-05 – Redirecionamento por tipo de usuário</td>
<td>RF-001.2</td>
<td>Validar redirecionamento de acordo com o tipo de usuário</td>
<td>
<ol>
<li>Realizar login</li>
<li>Verificar tipo de usuário (produtor, consumidor, técnico)</li>
</ol>
</td>
<td>Usuário direcionado para a tela correta</td>
<td>Equipe</td>
</tr>
</table>

### PLANO DE TESTES – FUNCIONALIDADE DE CADASTRO DE USUÁRIO  (AgroConecta)

| Item               | Descrição           |
| ------------------ | ------------------- |
| **Sistema**        | AgroConecta         |
| **Funcionalidade** | Cadastro de Usuário |
| **Responsável**    | Equipe do Projeto   |
| **Versão**         | 1.0                 |
| **Data**           | 2026                |

2. Objetivo

- Validar cadastro de novos usuários no sistema
- Validar preenchimento dos campos obrigatórios
- Validar seleção do tipo de usuário
- Garantir armazenamento correto das informações cadastradas
- Garantir acesso ao sistema após cadastro válido

3. Ambiente de Testes

- Navegadores: Chrome, Firefox e Edge
- Ambiente: Localhost ou homologação
- Banco de dados: simulado ou real
- Usuário: visitante não autenticado
- Dados necessários: e-mail não cadastrado no sistema

4. Casos de teste

<table>
<tr>
<th>Caso de teste</th>
<th>Requisito</th>
<th>Objetivo</th>
<th>Passos</th>
<th>Critério de êxito</th>
<th>Responsável</th>
</tr>

<!-- CT-06 -->

<tr>
<td>CT-06 – Realizar cadastro de usuário</td>
<td>RF-001</td>
<td>Validar cadastro de novos usuários</td>
<td>
<ol>
<li>Acessar a tela de cadastro</li>
<li>Preencher nome completo</li>
<li>Informar e-mail válido</li>
<li>Informar senha</li>
<li>Selecionar o tipo de usuário</li>
<li>Clicar em "Cadastrar"</li>
</ol>
</td>
<td>Usuário cadastrado com sucesso no sistema</td>
<td>Equipe</td>
</tr>

<!-- CT-07 -->

<tr>
<td>CT-07 – Validar campos obrigatórios do cadastro</td>
<td>RF-001</td>
<td>Validar preenchimento obrigatório dos campos</td>
<td>
<ol>
<li>Acessar a tela de cadastro</li>
<li>Deixar um ou mais campos obrigatórios vazios</li>
<li>Clicar em "Cadastrar"</li>
</ol>
</td>
<td>Sistema impede o cadastro e exibe mensagens de validação</td>
<td>Equipe</td>
</tr>
</table>

### PLANO DE TESTES – FUNCIONALIDADE MEU PERFIL (AgroConecta)

| Item               | Descrição         |
| ------------------ | ----------------- |
| **Sistema**        | AgroConecta       |
| **Funcionalidade** | Meu Perfil        |
| **Responsável**    | Equipe do Projeto |
| **Versão**         | 1.0               |
| **Data**           | 2026              |

2. Objetivo

- Validar visualização dos dados do usuário
- Validar atualização das informações do perfil
- Validar exibição correta do tipo de usuário
- Validar persistência das alterações realizadas
- Validar desativação da conta do usuário

3. Ambiente de Testes

- Navegadores: Chrome, Firefox e Edge
- Ambiente: Localhost ou homologação
- Banco de dados: simulado ou real
- Usuário: autenticado no sistema
- Dados necessários: conta de usuário cadastrada

4. Casos de Teste

<table>
<tr>
<th>Caso de teste</th>
<th>Requisito</th>
<th>Objetivo</th>
<th>Passos</th>
<th>Critério de êxito</th>
<th>Responsável</th>
</tr>

<!-- CT-08 -->

<tr>
<td>CT-08 – Atualizar informações do perfil</td>
<td>RF-001</td>
<td>Validar edição dos dados do usuário</td>
<td>
<ol>
<li>Acessar a tela "Meu Perfil"</li>
<li>Alterar nome e/ou e-mail</li>
<li>Clicar em "Salvar Alterações"</li>
</ol>
</td>
<td>Dados atualizados e persistidos com sucesso</td>
<td>Equipe</td>
</tr>

<!-- CT-09 -->

<tr>
<td>CT-09 – Desativar conta de usuário</td>
<td>RF-001</td>
<td>Validar desativação da conta</td>
<td>
<ol>
<li>Acessar a tela "Meu Perfil"</li>
<li>Clicar em "Desativar minha conta"</li>
<li>Confirmar a operação</li>
</ol>
</td>
<td>Conta desativada com sucesso e acesso bloqueado ao sistema</td>
<td>Equipe</td>
</tr>
</table>

### PLANO DE TESTES – FUNCIONALIDADE VISÃO GERAL DO PRODUTOR RURAL (AgroConecta)

| Item               | Descrição                        |
| -----------------  | -------------------------------- |
| **Sistema**        | AgroConecta                      |
| **Funcionalidade** | Visão Geral - Produtor Rural     |
| **Responsável**    | Equipe do Projeto                |
| **Versão**         | 1.0                              |
| **Data**           | 2026                             |

2. Objetivo

- Validar o funcionamento da Visão Geral do Produtor Rural, garantindo que a página exiba corretamente:
- Propriedades cadastradas
- Áreas cultivadas
- Atividades agrícolas
- Indicadores de produção
- Informações climáticas
- Recomendações de irrigação
- Identificação do usuário logado
- Navegação do sistema
- Persistência dos dados

3. Ambiente de Testes

- Navegadores: Chrome, Firefox, Edge  
- Ambiente: Localhost ou homologação  
- Banco de dados: simulado ou real  
- API: serviços climáticos ativos  
- Usuário: Produtor autenticado  

4. Casos de teste
<table>
  <tr>
    <th>Teste</th>
    <th>Requisitos</th>
    <th>Objetivo</th>
    <th>Etapas</th>
    <th>Resultado esperado</th>
    <th>Responsável</th>
  </tr>

 <!-- CT-10 -->
<tr>
<td>CT-10 — Exibir usuário logado</td>
<td>RF-001.1</td>
<td>Validar identificação do usuário</td>
<td>
<ol>
<li>Realizar login como produtor</li>
<li>Acessar a Visão Geral do Produtor Rural</li>
</ol>
</td>
<td>Nome exibido corretamente</td>
<td>Equipe</td>
</tr>

 <!-- CT-11 -->
<tr>
<td>CT-11 — Exibir propriedades</td>
<td>RF-002.4</td>
<td>Validar listagem de propriedades</td>
<td>
<ol>
<li>Cadastrar propriedades</li>
<li>Acessar a Visão Geral do Produtor Rural</li>
</ol>
</td>
<td>Propriedades exibidas corretamente</td>
<td>Equipe</td>
</tr>

 <!-- CT-12 -->
<tr>
<td>CT-12 — Exibir áreas cultivadas</td>
<td>RF-002.2</td>
<td>Validar exibição de áreas</td>
<td>
<ol>
<li>Cadastrar áreas</li>
<li>Acessar a Visão Geral do Produtor Rural</li>
</ol>
</td>
<td>Áreas exibidas corretamente</td>
<td>Equipe</td>
</tr>

 <!-- CT-13 -->
<tr>
<td>CT-13 — Exibir atividades agrícolas</td>
<td>RF-003</td>
<td>Validar exibição de atividades</td>
<td>
<ol>
<li>Registrar atividades</li>
<li>Acessar a Visão Geral do Produtor Rural</li>
</ol>
</td>
<td>Atividades exibidas corretamente</td>
<td>Equipe</td>
</tr>

 <!-- CT-14 -->
<tr>
<td>CT-14 — Histórico de atividades</td>
<td>RF-003.4</td>
<td>Validar histórico</td>
<td>
<ol>
<li>Acessar histórico</li>
</ol>
</td>
<td>Histórico exibido corretamente</td>
<td>Equipe</td>
</tr>

 <!-- CT-15 -->
<tr>
<td>CT-15 — Exibir indicadores</td>
<td>RF-006</td>
<td>Validar métricas</td>
<td>
<ol>
<li>Acessar indicadores</li>
</ol>
</td>
<td>Indicadores exibidos corretamente</td>
<td>Equipe</td>
</tr>

 <!-- CT-16 -->
<tr>
<td>CT-16 — Consulta climática</td>
<td>RF-004</td>
<td>Validar dados climáticos</td>
<td>
<ol>
<li>Acessar a Visão Geral do Produtor Rural</li>
</ol>
</td>
<td>Dados exibidos corretamente</td>
<td>Equipe</td>
</tr>

 <!-- CT-17 -->
<tr>
<td>CT-17 — Falha na API climática</td>
<td>RF-004.1</td>
<td>Validar erro de API</td>
<td>
<ol>
<li>Simular falha</li>
<li>Acessar a Visão Geral do Produtor Rural</li>
</ol>
</td>
<td>Mensagem de erro exibida sem travar o sistema</td>
<td>Equipe</td>
</tr>

 <!-- CT-18 -->
<tr>
<td>CT-18 — Recomendação de irrigação</td>
<td>RF-005.4</td>
<td>Validar recomendação</td>
<td>
<ol>
<li>Acessar irrigação</li>
</ol>
</td>
<td>Recomendação exibida corretamente</td>
<td>Equipe</td>
</tr>

 <!-- CT-19 -->
<tr>
<td>CT-19 — Sem dados para irrigação</td>
<td>RF-005.1</td>
<td>Validar ausência de dados</td>
<td>
<ol>
<li>Acessar módulo sem dados</li>
</ol>
</td>
<td>Sistema informa ausência de dados</td>
<td>Equipe</td>
</tr>

 <!-- CT-20 -->
<tr>
<td>CT-20 — Persistência dos dados</td>
<td>RNF-001</td>
<td>Validar armazenamento</td>
<td>
<ol>
<li>Inserir dados</li>
<li>Recarregar página</li>
</ol>
</td>
<td>Dados permanecem salvos</td>
<td>Equipe</td>
</tr>

 <!-- CT-21 -->
<tr>
<td>CT-21 — Usabilidade</td>
<td>RNF-002</td>
<td>Validar facilidade de uso</td>
<td>
<ol>
<li>Navegar no sistema</li>
</ol>
</td>
<td>Interface intuitiva</td>
<td>Equipe</td>
</tr>

 <!-- CT-22 -->
<tr>
<td>CT-13 — Compatibilidade</td>
<td>RNF-003</td>
<td>Testar navegadores</td>
<td>
<ol>
<li>Acessar em diferentes navegadores</li>
</ol>
</td>
<td>Funciona corretamente</td>
<td>Equipe</td>
</tr>

 <!-- CT-22 -->
<tr>
<td>CT-14 — Acessibilidade</td>
<td>RNF-004</td>
<td>Validar navegação por teclado</td>
<td>
<ol>
<li>Usar tecla TAB</li>
</ol>
</td>
<td>Navegação funcional</td>
<td>Equipe</td>
</tr>

 <!-- CT-23 -->
<tr>
<td>CT-23 — Logout</td>
<td>RF-001.4</td>
<td>Validar saída</td>
<td>
<ol>
<li>Clicar em logout</li>
</ol>
</td>
<td>Usuário redirecionado corretamente</td>
<td>Equipe</td>
</tr>
</table>

### PLANO DE TESTES – FUNCIONALIDADE DE PROPRIEDADES (AgroConecta)

| Item               | Descrição                        |
| ------------------ | -------------------------------- |
| **Sistema**        | AgroConecta                      |
| **Funcionalidade** | Propriedades rurais              |
| **Responsável**    | Equipe do Projeto                |
| **Versão**         | 1.0                              |
| **Data**           | 2026                             |

2. Objetivo
   
- Gerenciar propriedades e áreas cultivadas

3. Ambiente de Testes

- Navegadores: Chrome, Firefox, Edge  
- Ambiente: Localhost ou homologação  
- Banco de dados: simulado ou real  
- Usuário: Produtor autenticado  
- Dados necessários: propriedades e áreas cadastradas para teste  

4. Casos de teste
<table>
<tr>
<th>Caso de teste</th>
<th>Requisito</th>
<th>Objetivo</th>
<th>Passos</th>
<th>Critério de êxito</th>
<th>Responsável</th>
</tr>

 <!-- CT-24 -->
 
<tr>
<td>CT-24 – Cadastro de propriedade</td>
<td>RF-002</td>
<td>Validar cadastro de propriedade rural</td>
<td>
<ol>
<li>Acessar a seção de propriedades</li>
<li>Cadastrar propriedade</li>
</ol>
</td>
<td>Propriedade cadastrada com sucesso</td>
<td>Equipe</td>
</tr>

<!-- CT-25 -->
 
<tr>
<td>CT-25 – Cadastro de área cultivada</td>
<td>RF-002.2</td>
<td>Validar cadastro de área cultivada</td>
<td>
<ol>
<li>Selecionar propriedade</li>
<li>Adicionar área</li>
</ol>
</td>
<td>Área cadastrada com sucesso</td>
<td>Equipe</td>
</tr>
</table>

### PLANO DE TESTES – TELA LISTA DE PROPRIEDADES (AgroConecta)

| Item               | Descrição             |
| ------------------ | --------------------- |
| **Sistema**        | AgroConecta           |
| **Funcionalidade** | Lista de Propriedades |
| **Responsável**    | Equipe do Projeto     |
| **Versão**         | 1.0                   |
| **Data**           | 2026                  |

2. Objetivo

- Validar a listagem das propriedades cadastradas
- Validar a visualização dos dados da propriedade
- Validar a edição de propriedades rurais
- Validar a geração de relatórios
- Validar a exclusão de propriedades

3. Ambiente de Testes

- Navegadores: Chrome, Firefox e Edge
- Ambiente: Localhost ou homologação
- Banco de dados: simulado ou real
- Usuário: Produtor Rural
- Estado inicial: usuário autenticado com propriedades cadastradas

4. Casos de teste
<table>
<tr>
<th>Caso de teste</th>
<th>Requisito</th>
<th>Objetivo</th>
<th>Passos</th>
<th>Critério de êxito</th>
<th>Responsável</th>
</tr>

<!-- CT-26 -->

<tr>
<td>CT-26 – Visualizar propriedades</td>
<td>RF-002.4</td>
<td>Validar listagem de propriedades</td>
<td>
<ol>
<li>Acessar a seção de propriedades</li>
<li>Visualizar propriedades cadastradas</li>
</ol>
</td>
<td>Propriedades exibidas corretamente</td>
<td>Equipe</td>
</tr>

<!-- CT-27 -->

<tr>
<td>CT-27 – Visualizar e editar propriedade</td>
<td>RF-002</td>
<td>Validar visualização e edição de propriedade rural</td>
<td>
<ol>
<li>Selecionar uma propriedade</li>
<li>Visualizar seus dados</li>
<li>Editar informações da propriedade</li>
<li>Salvar alterações</li>
</ol>
</td>
<td>Propriedade atualizada com sucesso</td>
<td>Equipe</td>
</tr>

<!-- CT-28 -->

<tr>
<td>CT-28 – Criar relatório e excluir propriedade</td>
<td>RF-002</td>
<td>Validar geração de relatório e exclusão de propriedade</td>
<td>
<ol>
<li>Selecionar uma propriedade</li>
<li>Clicar em "Criar Relatório"</li>
<li>Confirmar geração do relatório</li>
<li>Excluir a propriedade</li>
<li>Confirmar exclusão</li>
</ol>
</td>
<td>Relatório gerado e propriedade excluída com sucesso</td>
<td>Equipe</td>
</tr>
</table>

### PLANO DE TESTES – FUNCIONALIDADE DE RELATÓRIOS (AgroConecta)

| Item               | Descrição         |
| ------------------ | ----------------- |
| **Sistema**        | AgroConecta       |
| **Funcionalidade** | Relatórios        |
| **Responsável**    | Equipe do Projeto |
| **Versão**         | 1.0               |
| **Data**           | 2026              |

2. Objetivo

- Visualizar relatórios cadastrados
- Editar informações dos relatórios
- Exportar relatórios em PDF
- Excluir relatórios cadastrados

3. Ambiente de Testes

- Navegadores: Chrome, Firefox, Edge
- Ambiente: Localhost ou homologação
- Banco de dados: simulado ou real
- Usuário: Produtor autenticado
- Dados necessários: propriedades e relatórios cadastrados

4. Casos de teste
<table>
<tr>
<th>Caso de teste</th>
<th>Requisito</th>
<th>Objetivo</th>
<th>Passos</th>
<th>Critério de êxito</th>
<th>Responsável</th>
</tr>

<!-- CT-29 -->

<tr>
<td>CT-29 – Visualizar e editar relatório</td>
<td>RF-005</td>
<td>Validar visualização e edição de relatórios</td>
<td>
<ol>
<li>Acessar a seção de relatórios</li>
<li>Selecionar um relatório cadastrado</li>
<li>Visualizar as informações do relatório</li>
<li>Editar os dados necessários</li>
<li>Salvar alterações</li>
</ol>
</td>
<td>Relatório exibido e atualizado com sucesso</td>
<td>Equipe</td>
</tr>

<!-- CT-30 -->

<tr>
<td>CT-30 – Exportar e excluir relatório</td>
<td>RF-005</td>
<td>Validar exportação e exclusão de relatórios</td>
<td>
<ol>
<li>Acessar a seção de relatórios</li>
<li>Selecionar um relatório cadastrado</li>
<li>Clicar em "Exportar PDF"</li>
<li>Confirmar geração do arquivo</li>
<li>Clicar em "Excluir"</li>
<li>Confirmar exclusão</li>
</ol>
</td>
<td>Relatório exportado em PDF e removido com sucesso</td>
<td>Equipe</td>
</tr>
</table>

### PLANO DE TESTES – FUNCIONALIDADE DE ATIVIDADES AGRÍCOLAS (AgroConecta)

| Item               | Descrição                        |
| -----------------  | -------------------------------- |
| **Sistema**        | AgroConecta                      |
| **Funcionalidade** | Atividades Agrícolas             |
| **Responsável**    | Equipe do Projeto                |
| **Versão**         | 1.0                              |
| **Data**           | 2026                             |

2. Objetivo

- Registrar e acompanhar atividades agrícolas

3. Ambiente de Testes

- Navegadores: Chrome, Firefox, Edge  
- Ambiente: Localhost ou homologação  
- Banco de dados: simulado ou real  
- Usuário: Produtor autenticado  
- Dados necessários: propriedades, áreas cultivadas e atividades cadastradas  

4. Casos de teste
<table>
<tr>
<th>Caso de teste</th>
<th>Requisito</th>
<th>Objetivo</th>
<th>Passos</th>
<th>Critério de êxito</th>
<th>Responsável</th>
</tr>

<!-- CT-31 -->

<tr>
<td>CT-31 – Registro de atividade</td>
<td>RF-003</td>
<td>Validar registro de atividade</td>
<td>
<ol>
<li>Acessar a seção</li>
<li>Registrar atividade</li>
</ol>
</td>
<td>Atividade registrada com sucesso</td>
<td>Equipe</td>
</tr>

<!-- CT-32 -->

<tr>
<td>CT-32 – Histórico de atividades</td>
<td>RF-003.4</td>
<td>Validar histórico</td>
<td>
<ol>
<li>Acessar histórico</li>
</ol>
</td>
<td>Histórico exibido corretamente</td>
<td>Equipe</td>
</tr>
</table>

### PLANO DE TESTES – FUNCIONALIDADE CLIMÁTICA (AgroConecta)

| Item               | Descrição                        |
| -----------------  | -------------------------------- |
| **Sistema**        | AgroConecta                      |
| **Funcionalidade** | Informações Climáticas           |
| **Responsável**    | Equipe do Projeto                |
| **Versão**         | 1.0                              |
| **Data**           | 2026                             |

2. Objetivo

- Exibir informações climáticas

3. Ambiente de Testes

- Navegadores: Chrome, Firefox, Edge  
- Ambiente: Localhost ou homologação  
- Banco de dados: simulado ou real  
- API: serviço de dados climáticos ativo  
- Usuário: Produtor autenticado  
- Dados necessários: localização da propriedade cadastrada  

4. Casos de teste
<table>
<tr>
<th>Caso de teste</th>
<th>Requisito</th>
<th>Objetivo</th>
<th>Passos</th>
<th>Critério de êxito</th>
<th>Responsável</th>
</tr>

<!-- CT-33 -->

<tr>
<td>CT-33 – Consulta climática</td>
<td>RF-004</td>
<td>Validar dados climáticos</td>
<td>
<ol>
<li>Acessar a seção climática</li>
</ol>
</td>
<td>Dados exibidos corretamente</td>
<td>Equipe</td>
</tr>

<!-- CT-34 -->

<tr>
<td>CT-34 – Falha na API climática</td>
<td>RF-004.1</td>
<td>Validar erro de API</td>
<td>
<ol>
<li>Simular falha da API</li>
<li>Acessar a seção</li>
</ol>
</td>
<td>Mensagem de erro exibida corretamente</td>
<td>Equipe</td>
</tr>
</table>

### PLANO DE TESTES – FUNCIONALIDADE DE ANÁLISE DA CULTURA (AgroConecta)

| Item               | Descrição          |
| ------------------ | ------------------ |
| **Sistema**        | AgroConecta        |
| **Funcionalidade** | Análise da Cultura |
| **Responsável**    | Equipe do Projeto  |
| **Versão**         | 1.0                |
| **Data**           | 2026               |

2. Objetivo

- Validar envio de imagens para análise agrícola
- Validar integração da IA para diagnóstico da cultura
- Validar exibição dos resultados da análise
- Garantir tratamento de arquivos inválidos

3. Ambiente de Testes

- Navegadores: Chrome, Firefox, Edge
- Ambiente: Localhost ou homologação
- Banco de dados: simulado ou real
- Usuário: Produtor autenticado
- Dados necessários: culturas cadastradas e imagens agrícolas

4. Casos de teste

<table>
<tr>
<th>Caso de teste</th>
<th>Requisito</th>
<th>Objetivo</th>
<th>Passos</th>
<th>Critério de êxito</th>
<th>Responsável</th>
</tr>

<!-- CT-35 -->

<tr>
<td>CT-35 – Realizar upload de imagem agrícola</td>
<td>RF-005</td>
<td>Validar envio de imagem para análise</td>
<td>
<ol>
<li>Acessar a seção de análises da cultura</li>
<li>Clicar em "Nova análise"</li>
<li>Selecionar uma cultura</li>
<li>Escolher uma imagem agrícola</li>
<li>Clicar em "Analisar"</li>
</ol>
</td>
<td>Imagem enviada com sucesso para processamento</td>
<td>Equipe</td>
</tr>

<!-- CT-36 -->

<tr>
<td>CT-36 – Gerar análise da cultura utilizando IA</td>
<td>RF-005.5</td>
<td>Validar geração automática de diagnóstico e recomendações</td>
<td>
<ol>
<li>Selecionar uma cultura</li>
<li>Enviar imagem agrícola válida</li>
<li>Clicar em "Analisar"</li>
</ol>
</td>
<td>Sistema gera diagnóstico e recomendações automaticamente</td>
<td>Equipe</td>
</tr>

<!-- CT-37 -->

<tr>
<td>CT-37 – Visualizar resultado da análise da cultura</td>
<td>RF-005.5</td>
<td>Validar exibição do relatório agrícola</td>
<td>
<ol>
<li>Acessar a seção de análises da cultura</li>
<li>Selecionar uma análise realizada</li>
<li>Visualizar os resultados apresentados</li>
</ol>
</td>
<td>Resultado da análise exibido corretamente</td>
<td>Equipe</td>
</tr>

<!-- CT-38 -->

<tr>
<td>CT-38 – Verificar integração da IA com imagem agrícola</td>
<td>RF-005</td>
<td>Validar integração com OpenRouter e modelos Meta Llama</td>
<td>
<ol>
<li>Enviar uma imagem agrícola válida</li>
<li>Executar a análise</li>
<li>Verificar o retorno gerado pela IA</li>
</ol>
</td>
<td>IA processa a imagem e retorna um diagnóstico válido</td>
<td>Equipe</td>
</tr>

<!-- CT-39 -->

<tr>
<td>CT-39 – Validar envio de imagem acima de 2MB</td>
<td>RF-005</td>
<td>Validar processamento de imagens agrícolas pela IA</td>
<td>
<ol>
<li>Selecionar uma imagem superior a 2MB</li>
<li>Tentar realizar a análise</li>
</ol>
</td>
<td>Sistema exibe mensagem de validação e impede o envio</td>
<td>Equipe</td>
</tr>
</table>

### PLANO DE TESTES – RESULTADO DA ANÁLISE DA CULTURA (AgroConecta)

| Item               | Descrição          |
| ------------------ | ------------------ |
| **Sistema**        | AgroConecta        |
| **Funcionalidade** | Análise da Cultura |
| **Responsável**    | Equipe do Projeto  |
| **Versão**         | 1.0                |
| **Data**           | 2026               |

2. Objetivo

- Validar envio de imagens para análise agrícola
- Validar geração de diagnósticos por IA
- Validar exibição dos resultados da análise
- Validar criação de novas análises
- Validar navegação entre as telas de análise

3. Ambiente de Testes

- Navegadores: Chrome, Firefox, Edge
- Ambiente: Localhost ou homologação
- Banco de dados: simulado ou real
- Usuário: Produtor autenticado
- Dados necessários: culturas cadastradas e imagens agrícolas

4. Casos de teste

<table>
<tr>
<th>Caso de teste</th>
<th>Requisito</th>
<th>Objetivo</th>
<th>Passos</th>
<th>Critério de êxito</th>
<th>Responsável</th>
</tr>

<!-- CT-40 -->

<tr>
<td>CT-40 – Visualizar resultado da análise da cultura</td>
<td>RF-005.5</td>
<td>Validar exibição do relatório agrícola gerado pela IA</td>
<td>
<ol>
<li>Acessar a lista de análises realizadas</li>
<li>Selecionar uma análise cadastrada</li>
<li>Visualizar a imagem enviada</li>
<li>Visualizar cultura, diagnóstico, recomendações e data da análise</li>
</ol>
</td>
<td>Resultado da análise exibido corretamente com todas as informações da cultura</td>
<td>Equipe</td>
</tr>

<!-- CT-40 -->

<tr>
<td>CT-40 – Realizar nova análise a partir do resultado</td>
<td>RF-005</td>
<td>Validar criação de uma nova análise pela tela de resultado</td>
<td>
<ol>
<li>Acessar o resultado de uma análise</li>
<li>Clicar em "Fazer nova análise"</li>
<li>Selecionar nova imagem e cultura</li>
<li>Executar a análise</li>
</ol>
</td>
<td>Sistema redireciona para o cadastro de análise e permite gerar uma nova análise</td>
<td>Equipe</td>
</tr>

<!-- CT-41 -->

<tr>
<td>CT-1 – Retornar para lista de análises</td>
<td>RF-005</td>
<td>Validar navegação para a tela de análises</td>
<td>
<ol>
<li>Acessar o resultado de uma análise</li>
<li>Clicar em "Voltar para análises"</li>
</ol>
</td>
<td>Usuário retorna para a lista de análises cadastradas</td>
<td>Equipe</td>
</tr>

<!-- CT-42 -->

<tr>
<td>CT-42 – Validar exibição de diagnóstico e recomendações</td>
<td>RF-005.5</td>
<td>Validar apresentação das informações retornadas pela IA</td>
<td>
<ol>
<li>Acessar o resultado de uma análise concluída</li>
<li>Verificar os campos de diagnóstico e recomendações</li>
</ol>
</td>
<td>Diagnóstico e recomendações são exibidos corretamente ao usuário</td>
<td>Equipe</td>
</tr>

### PLANO DE TESTES – FUNCIONALIDADE DE FÓRUM (AgroConecta)

| Item               | Descrição          |
| ------------------ | ------------------ |
| **Sistema**        | AgroConecta        |
| **Funcionalidade** | Fórum              |
| **Responsável**    | Equipe do Projeto  |
| **Versão**         | 1.0                |
| **Data**           | 2026               |

2. Objetivo

- Validar criação de categorias
- Validar edição e exclusão de categorias
- Validar acesso às categorias do fórum
- Validar criação de tópicos
- Validar navegação entre categorias e tópicos

3. Ambiente de Testes

- Navegadores: Chrome, Firefox e Edge
- Ambiente: Localhost ou homologação
- Banco de dados: simulado ou real
- Usuário: autenticado
- Dados necessários: categorias e tópicos cadastrados]

4. Casos de teste

<table>
<tr>
<th>Caso de teste</th>
<th>Requisito</th>
<th>Objetivo</th>
<th>Passos</th>
<th>Critério de êxito</th>
<th>Responsável</th>
</tr>

<!-- CT-43 -->

<tr>
<td>CT-43 – Entrar na categoria e visualizar tópicos</td>
<td>RF-008.2</td>
<td>Validar acesso à categoria e exibição dos tópicos</td>
<td>
<ol>
<li>Acessar o fórum</li>
<li>Selecionar uma categoria cadastrada</li>
<li>Visualizar os tópicos disponíveis</li>
</ol>
</td>
<td>Os tópicos da categoria são exibidos corretamente</td>
<td>Equipe</td>
</tr>

<!-- CT-44 -->

<tr>
<td>CT-44 – Criar tópico</td>
<td>RF-008.1</td>
<td>Validar criação de publicação</td>
<td>
<ol>
<li>Acessar uma categoria do fórum</li>
<li>Clicar em "+" para criar um tópico</li>
<li>Preencher as informações necessárias</li>
<li>Salvar tópico</li>
</ol>
</td>
<td>Tópico criado com sucesso e exibido na categoria</td>
<td>Equipe</td>
</tr>

<!-- CT-45 -->

<tr>
<td>CT-45 – Criar nova categoria</td>
<td>RF-008.5</td>
<td>Validar criação de categoria</td>
<td>
<ol>
<li>Acessar a tela de cadastro de categoria</li>
<li>Informar nome da categoria</li>
<li>Informar descrição da categoria</li>
<li>Clicar em "Salvar"</li>
</ol>
</td>
<td>Categoria cadastrada com sucesso</td>
<td>Equipe</td>
</tr>

<!-- CT-46 -->

<tr>
<td>CT-46 – Editar categoria</td>
<td>RF-008.5</td>
<td>Validar edição de categoria</td>
<td>
<ol>
<li>Selecionar uma categoria existente</li>
<li>Alterar nome ou descrição</li>
<li>Salvar alterações</li>
</ol>
</td>
<td>Categoria atualizada com sucesso</td>
<td>Equipe</td>
</tr>

<!-- CT-47 -->

<tr>
<td>CT-47 – Excluir categoria</td>
<td>RF-008.5</td>
<td>Validar exclusão de categoria</td>
<td>
<ol>
<li>Selecionar uma categoria existente</li>
<li>Clicar em excluir</li>
<li>Confirmar exclusão</li>
</ol>
</td>
<td>Categoria removida com sucesso</td>
<td>Equipe</td>
</tr>
</table>

### PLANO DE TESTES – FUNCIONALIDADE DE CADASTRO DE PRODUTOS (AgroConecta)

| Item               | Descrição                    |
| ------------------ | ---------------------------- |
| **Sistema**        | AgroConecta                  |
| **Funcionalidade** | Cadastro de Produtos         |
| **Responsável**    | Equipe do Projeto            |
| **Versão**         | 1.0                          |
| **Data**           | 2026                         |

2. Objetivo

- Validar cadastro de produtos no marketplace
- Validar upload de imagem do produto
- Validar preenchimento dos dados obrigatórios
- Validar associação do produto a uma categoria
- Garantir armazenamento correto das informações

3. Ambiente de Testes

- Navegadores: Chrome, Firefox e Edge
- Ambiente: Localhost ou homologação
- Banco de dados: simulado ou real
- Usuário: Produtor autenticado
- Dados necessários: categorias cadastradas

4. Casos de teste

<table>
<tr>
<th>Caso de teste</th>
<th>Requisito</th>
<th>Objetivo</th>
<th>Passos</th>
<th>Critério de êxito</th>
<th>Responsável</th>
</tr>

<!-- CT-48 -->

<tr>
<td>CT-48 – Cadastrar produto com imagem</td>
<td>RF-007</td>
<td>Validar cadastro de produto no marketplace</td>
<td>
<ol>
<li>Acessar a tela de cadastro de produtos</li>
<li>Informar nome, descrição, preço e estoque</li>
<li>Selecionar uma categoria</li>
<li>Enviar uma imagem do produto</li>
<li>Clicar em "Salvar"</li>
</ol>
</td>
<td>Produto cadastrado com sucesso e exibido no marketplace</td>
<td>Equipe</td>
</tr>

<!-- CT-49 -->

<tr>
<td>CT-49 – Validar campos obrigatórios do produto</td>
<td>RF-007</td>
<td>Validar preenchimento obrigatório dos campos</td>
<td>
<ol>
<li>Acessar a tela de cadastro de produtos</li>
<li>Deixar um ou mais campos obrigatórios vazios</li>
<li>Clicar em "Salvar"</li>
</ol>
</td>
<td>Sistema impede o cadastro e exibe mensagens de validação</td>
<td>Equipe</td>
</tr>
</table>

### PLANO DE TESTES – FUNCIONALIDADE DE Produtos Cadastrados (AgroConecta)

| Item               | Descrição                    |
| ------------------ | ---------------------------- |
| **Sistema**        | AgroConecta                  |
| **Funcionalidade** | Lista de Produtos            |
| **Responsável**    | Equipe do Projeto            |
| **Versão**         | 1.0                          |
| **Data**           | 2026                         |

2. Objetivo

- Validar visualização dos produtos cadastrados no marketplace
- Validar exibição dos detalhes do produto
- Validar edição de produtos cadastrado
- Validar exclusão de produtos do marketplace
- Garantir exibição correta das informações do produto (nome, categoria, preço, estoque, imagem e descrição)
- Garantir atualização correta dos dados após edição
- Garantir remoção correta do produto após exclusão

3. Ambiente de Testes

- Navegadores: Chrome, Firefox e Edge
- Ambiente: Localhost ou homologação
- Banco de dados: simulado ou real
- Usuário: Produtor autenticado
- Dados necessários: categorias cadastradas, produtos cadastrados no marketplace

4. Casos de teste

<table>
<tr>
<th>Caso de teste</th>
<th>Requisito</th>
<th>Objetivo</th>
<th>Passos</th>
<th>Critério de êxito</th>
<th>Responsável</th>
</tr>

<!-- CT-50 -->

<tr>
<td>CT-50 – Visualizar produtos cadastrados</td>
<td>RF-007</td>
<td>Validar listagem de produtos do marketplace</td>
<td>
<ol>
<li>Acessar a seção Marketplace</li>
<li>Visualizar os produtos cadastrados</li>
<li>Verificar nome, categoria, preço e estoque</li>
</ol>
</td>
<td>Produtos exibidos corretamente com suas informações</td>
<td>Equipe</td>
</tr>

<!-- CT-51 -->

<tr>
<td>CT-51 – Visualizar detalhes do produto</td>
<td>RF-007</td>
<td>Validar exibição completa dos dados do produto</td>
<td>
<ol>
<li>Acessar o Marketplace</li>
<li>Selecionar um produto</li>
<li>Clicar em "Ver detalhes"</li>
</ol>
</td>
<td>Detalhes do produto exibidos corretamente, incluindo imagem, descrição, categoria, preço e estoque</td>
<td>Equipe</td>
</tr>

<!-- CT-52 -->

<tr>
<td>CT-52 – Editar produto cadastrado</td>
<td>RF-007</td>
<td>Validar atualização de informações do produto</td>
<td>
<ol>
<li>Acessar os detalhes do produto</li>
<li>Clicar em "Editar"</li>
<li>Alterar informações do produto</li>
<li>Salvar alterações</li>
</ol>
</td>
<td>Produto atualizado com sucesso</td>
<td>Equipe</td>
</tr>

<!-- CT-53 -->

<tr>
<td>CT-53 – Excluir produto cadastrado</td>
<td>RF-007</td>
<td>Validar exclusão de produto do marketplace</td>
<td>
<ol>
<li>Acessar a listagem de produtos</li>
<li>Selecionar um produto</li>
<li>Clicar em "Excluir"</li>
<li>Confirmar exclusão</li>
</ol>
</td>
<td>Produto removido com sucesso da listagem</td>
<td>Equipe</td>
</tr>
</table>

---

<blockquote>
<strong>Observação:</strong> O AgroConecta utiliza um mecanismo de controle de acesso baseado em perfis de usuário, garantindo que cada tipo de usuário tenha acesso apenas às funcionalidades compatíveis com suas responsabilidades dentro da plataforma. Dessa forma, as telas, operações e permissões disponíveis podem variar entre <strong>Produtores Rurais</strong>, <strong>Consumidores</strong> e <strong>Técnicos Agrícolas</strong>. A funcionalidade de <strong>Análise da Cultura</strong> constitui uma exceção, estando disponível para todos os perfis, permitindo a consulta de diagnósticos e recomendações geradas por inteligência artificial conforme as necessidades de cada usuário.
</blockquote>

---

### PLANO DE TESTES – FUNCIONALIDADE DE DASHBOARD (AgroConecta)

| Item               | Descrição                    |
| ------------------ | ---------------------------- |
| **Sistema**        | AgroConecta                  |
| **Funcionalidade** | Dashboard            |
| **Responsável**    | Equipe do Projeto            |
| **Versão**         | 1.0                          |
| **Data**           | 2026                         |

2. Objetivo

- Validar visualização dos indicadores condizentes com tabelas de atividades e culturas


3. Ambiente de Testes

- Navegadores: Chrome, Firefox e Edge
- Ambiente: Localhost ou homologação
- Banco de dados: simulado ou real
- Usuário: Produtor autenticado
- Dados necessários: atividades cadastradas e culturas cadastradas.

4. Casos de teste

<table>
<tr>
<th>Caso de teste</th>
<th>Requisito</th>
<th>Objetivo</th>
<th>Passos</th>
<th>Critério de êxito</th>
<th>Responsável</th>
</tr>

<!-- CT-54 -->

<tr>
<td>CT-54 – Visualizar Dashboard</td>
<td>RF-006</td>
<td>Validar se numeros de atividaes e culturas estão de acordo com as cadastradas</td>
<td>
<ol>
<li>Visualizar os itens no dashboard</li>
</ol>
</td>
<td>Itens exibidos corretamente com suas informações</td>
<td>Equipe</td>
</tr>


</table>

---

<blockquote>
<strong>Observação:</strong> O AgroConecta utiliza um mecanismo de controle de acesso baseado em perfis de usuário, garantindo que cada tipo de usuário tenha acesso apenas às funcionalidades compatíveis com suas responsabilidades dentro da plataforma. Dessa forma, as telas, operações e permissões disponíveis podem variar entre <strong>Produtores Rurais</strong>, <strong>Consumidores</strong> e <strong>Técnicos Agrícolas</strong>. A funcionalidade de <strong>Análise da Cultura</strong> constitui uma exceção, estando disponível para todos os perfis, permitindo a consulta de diagnósticos e recomendações geradas por inteligência artificial conforme as necessidades de cada usuário.
</blockquote>

---

## Testes Não Funcionais

### PLANO DE TESTES – QUALIDADE DO SISTEMA

| Item               | Descrição                        |
| -----------------  | -------------------------------- |
| **Sistema**        | AgroConecta                      |
| **Funcionalidade** | Qualidade do Sistema             |
| **Responsável**    | Equipe do Projeto                |
| **Versão**         | 1.0                              |
| **Data**           | 2026                             |

2. Objetivo

- Garantir a qualidade geral do sistema, incluindo segurança, usabilidade, compatibilidade e acessibilidade.

3. Ambiente de Testes

- Navegadores: Chrome, Firefox, Edge  
- Ambiente: Localhost ou homologação  
- Banco de dados: simulado ou real  
- Usuários: Produtor, Consumidor e Técnico agrícola autenticados  
- Dados necessários: dados variados no sistema para validação (usuários, produtos, propriedades, atividades)  

4.Casos de teste
<table>
<tr>
<th>Caso de teste</th>
<th>Requisito</th>
<th>Objetivo</th>
<th>Passos</th>
<th>Critério de êxito</th>
<th>Responsável</th>
</tr>

<!-- CT-16 --> 

<tr>
<td>CT-16 – Segurança</td>
<td>RNF-001</td>
<td>Garantir proteção de dados</td>
<td>
<ol>
<li>Tentar acesso não autorizado</li>
</ol>
</td>
<td>Sistema bloqueia acesso e mantém dados protegidos</td>
<td>Equipe</td>
</tr>

<!-- CT-17 --> 

<tr>
<td>CT-17 – Usabilidade</td>
<td>RNF-002</td>
<td>Avaliar facilidade de uso</td>
<td>
<ol>
<li>Navegar no sistema</li>
</ol>
</td>
<td>Interface intuitiva e de fácil utilização</td>
<td>Equipe</td>
</tr>

<!-- CT-18 --> 

<tr>
<td>CT-18 – Compatibilidade</td>
<td>RNF-003</td>
<td>Testar navegadores</td>
<td>
<ol>
<li>Acessar em Chrome, Firefox e Edge</li>
</ol>
</td>
<td>Sistema funciona corretamente em todos os navegadores</td>
<td>Equipe</td>
</tr>

<!-- CT-19 --> 

<tr>
<td>CT-19 – Acessibilidade</td>
<td>RNF-004</td>
<td>Validar navegação por teclado</td>
<td>
<ol>
<li>Navegar utilizando TAB</li>
</ol>
</td>
<td>Usuário consegue utilizar o sistema sem mouse</td>
<td>Equipe</td>
</tr>
</table>
