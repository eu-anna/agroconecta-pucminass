# Plano de Testes de Usabilidade – AgroConecta

1. Objetivo
 
- Verificar se os usuários conseguem realizar tarefas essenciais no sistema sem dificuldades.
- Identificar problemas de navegação e interação.
- Avaliar a facilidade de uso e satisfação dos usuários. 
- Validar a acessibilidade para diferentes perfis (produtor, consumidor e técnico), incluindo pessoas com deficiência (visual, auditiva e motora).

## Seleção dos participantes

<table>
  <tr>
    <th>ID</th>
    <th>Nome</th>
    <th>Perfil de Usuário</th>
    <th>Experiência com Tecnologia</th>
    <th>Observações / Necessidades Especiais</th>
  </tr>

  <tr>
    <td>P1</td>
    <td>Ana Clara</td>
    <td>Consumidor</td>
    <td>Iniciante</td>
    <td>Nenhuma</td>
  </tr>

  <tr>
    <td>P2</td>
    <td>João Pedro</td>
    <td>Consumidor</td>
    <td>Avançado</td>
    <td>Nenhuma</td>
  </tr>

  <tr>
    <td>P3</td>
    <td>Carlos Henrique</td>
    <td>Produtor Rural</td>
    <td>Intermediário</td>
    <td>Nenhuma</td>
  </tr>

  <tr>
    <td>P4</td>
    <td>Maria Luiza</td>
    <td>Produtor Rural</td>
    <td>Iniciante</td>
    <td>Nenhuma</td>
  </tr>

  <tr>
    <td>P5</td>
    <td>Felipe Santos</td>
    <td>Técnico Agrícola</td>
    <td>Avançado</td>
    <td>Nenhuma</td>
  </tr>

  <tr>
    <td>P6</td>
    <td>Renata Oliveira</td>
    <td>Técnico Agrícola</td>
    <td>Intermediário</td>
    <td>Necessidade visual leve</td>
  </tr>

  <tr>
    <td>P7</td>
    <td>Lucas Almeida</td>
    <td>Consumidor</td>
    <td>Intermediário</td>
    <td>Nenhuma</td>
  </tr>

  <tr>
    <td>P8</td>
    <td>Beatriz Fernandes</td>
    <td>Produtor Rural</td>
    <td>Avançado</td>
    <td>Nenhuma</td>
  </tr>

  <tr>
    <td>P9</td>
    <td>Gustavo Martins</td>
    <td>Técnico Agrícola</td>
    <td>Iniciante</td>
    <td>Nenhuma</td>
  </tr>

  <tr>
    <td>P10</td>
    <td>Larissa Costa</td>
    <td>Consumidor</td>
    <td>Intermediário</td>
    <td>Necessidade auditiva leve</td>
  </tr>
</table>

## Definição de cenários de teste

<table>
  <tr>
    <th>Cenário</th>
    <th>Participante</th>
    <th>Objetivo</th>
    <th>Contexto</th>
    <th>Tarefas</th>
    <th>Critérios de Sucesso</th>
  </tr>

  <tr>
    <td>CT-U01</td>
    <td>P1 – Ana Clara (Consumidor)</td>
    <td>Avaliar navegação e compra</td>
    <td>Usuária deseja comprar um produto agrícola</td>
    <td>
      <ol>
        <li>Realizar login</li>
        <li>Visualizar produtos</li>
        <li>Selecionar produto</li>
        <li>Simular compra</li>
      </ol>
    </td>
    <td>Usuária consegue encontrar produto e concluir a compra sem dificuldades</td>
  </tr>

  <tr>
    <td>CT-U02</td>
    <td>P2 – João Pedro (Consumidor)</td>
    <td>Avaliar eficiência na navegação</td>
    <td>Usuário experiente busca produtos rapidamente</td>
    <td>
      <ol>
        <li>Realizar login</li>
        <li>Buscar produto</li>
        <li>Filtrar resultados</li>
      </ol>
    </td>
    <td>Usuário encontra produtos rapidamente sem erros</td>
  </tr>

  <tr>
    <td>CT-U03</td>
    <td>P3 – Carlos Henrique (Produtor)</td>
    <td>Avaliar gestão de propriedades</td>
    <td>Produtor deseja visualizar suas propriedades</td>
    <td>
      <ol>
        <li>Realizar login</li>
        <li>Acessar propriedades</li>
        <li>Visualizar áreas cultivadas</li>
      </ol>
    </td>
    <td>Informações exibidas corretamente e sem dificuldade de navegação</td>
  </tr>

  <tr>
    <td>CT-U04</td>
    <td>P4 – Maria Luiza (Produtor)</td>
    <td>Avaliar facilidade para iniciantes</td>
    <td>Produtora iniciante registra atividade</td>
    <td>
      <ol>
        <li>Realizar login</li>
        <li>Acessar atividades</li>
        <li>Registrar nova atividade</li>
      </ol>
    </td>
    <td>Usuária consegue registrar atividade sem ajuda</td>
  </tr>

  <tr>
    <td>CT-U05</td>
    <td>P5 – Felipe Santos (Técnico)</td>
    <td>Avaliar análise de dados</td>
    <td>Técnico deseja visualizar indicadores</td>
    <td>
      <ol>
        <li>Realizar login</li>
        <li>Acessar indicadores</li>
        <li>Analisar dados</li>
      </ol>
    </td>
    <td>Dados exibidos corretamente e compreensíveis</td>
  </tr>

  <tr>
    <td>CT-U06</td>
    <td>P6 – Renata Oliveira (Técnico)</td>
    <td>Avaliar acessibilidade</td>
    <td>Técnica com necessidade visual acessa sistema</td>
    <td>
      <ol>
        <li>Realizar login</li>
        <li>Navegar pelas telas</li>
        <li>Visualizar informações</li>
      </ol>
    </td>
    <td>Interface legível e utilizável sem dificuldade</td>
  </tr>

  <tr>
    <td>CT-U07</td>
    <td>P7 – Lucas Almeida (Consumidor)</td>
    <td>Avaliar navegação geral</td>
    <td>Usuário navega pelo marketplace</td>
    <td>
      <ol>
        <li>Realizar login</li>
        <li>Navegar entre produtos</li>
      </ol>
    </td>
    <td>Navegação fluida e sem erros</td>
  </tr>

  <tr>
    <td>CT-U08</td>
    <td>P8 – Beatriz Fernandes (Produtor)</td>
    <td>Avaliar desempenho do sistema</td>
    <td>Produtora acessa dados de produção</td>
    <td>
      <ol>
        <li>Realizar login</li>
        <li>Acessar indicadores</li>
      </ol>
    </td>
    <td>Carregamento rápido e dados corretos</td>
  </tr>

  <tr>
    <td>CT-U09</td>
    <td>P9 – Gustavo Martins (Técnico)</td>
    <td>Avaliar facilidade de uso</td>
    <td>Técnico iniciante utiliza o sistema</td>
    <td>
      <ol>
        <li>Realizar login</li>
        <li>Acessar produtores</li>
        <li>Registrar recomendação</li>
      </ol>
    </td>
    <td>Usuário consegue executar tarefas sem ajuda</td>
  </tr>

  <tr>
    <td>CT-U10</td>
    <td>P10 – Larissa Costa (Consumidor)</td>
    <td>Avaliar acessibilidade auditiva</td>
    <td>Usuária com necessidade auditiva usa o sistema</td>
    <td>
      <ol>
        <li>Realizar login</li>
        <li>Navegar e visualizar produtos</li>
      </ol>
    </td>
    <td>Interface compreensível sem necessidade de áudio</td>
  </tr>

</table>

<h4>Critérios de Sucesso Gerais</h4>
<ul>
  <li>Todos os usuários conseguem realizar login sem dificuldades.</li>
  <li>Cada perfil acessa corretamente sua área do sistema.</li>
  <li>As tarefas são concluídas sem erros ou travamentos.</li>
  <li>O sistema apresenta navegação clara e intuitiva.</li>
  <li>Usuários conseguem executar suas ações sem ajuda externa.</li>
  <li>Tempo médio de execução das tarefas inferior a 5 minutos.</li>
  <li>Usuários relatam experiência positiva (facilidade de uso e entendimento).</li>
</ul>

## Métodos de coleta de dados

<h3>Métodos de Coleta de Dados</h3>

<p>
Os dados coletados têm como objetivo avaliar a experiência dos usuários durante a utilização do sistema <strong>AgroConecta</strong>, considerando os diferentes perfis do sistema (Consumidor, Produtor Rural e Técnico Agrícola).
A análise permitirá identificar dificuldades na navegação, falhas de usabilidade e oportunidades de melhoria na interface.
</p>

<p>A coleta de dados será realizada por meio das seguintes abordagens:</p>

<h4>🔹 Observação Direta</h4>
<ul>
  <li>Acompanhamento dos participantes durante a execução das tarefas definidas nos cenários</li>
  <li>Registro de comportamentos, dúvidas e dificuldades enfrentadas</li>
  <li>Análise da interação com funcionalidades como login, navegação e execução de tarefas específicas por perfil</li>
</ul>

<h4>🔹 Métricas Quantitativas</h4>
<ul>
  <li>Tempo para realizar login e acessar o sistema</li>
  <li>Tempo para execução de tarefas por perfil:
    <ul>
      <li>Consumidor: visualizar produtos, realizar compra e acompanhar pedidos</li>
      <li>Produtor: acessar propriedades, registrar atividades e visualizar indicadores</li>
      <li>Técnico: acompanhar produtores, visualizar dados e registrar orientações</li>
    </ul>
  </li>
  <li>Número de cliques necessários para concluir cada tarefa</li>
  <li>Quantidade de erros cometidos durante o uso</li>
  <li>Taxa de sucesso na conclusão das tarefas</li>
</ul>

<h4>🔹 Métricas Qualitativas</h4>
<ul>
  <li>Dificuldades relatadas pelos usuários durante a navegação</li>
  <li>Comentários sobre clareza da interface</li>
  <li>Percepção sobre facilidade de uso e organização das informações</li>
  <li>Nível de satisfação com o sistema</li>
</ul>

<h4>🔹 Questionário Pós-Teste</h4>
<p>Após a execução das tarefas, cada participante responderá um questionário contendo perguntas como:</p>
<ul>
  <li>A interface foi fácil de entender?</li>
  <li>Você encontrou dificuldades em alguma etapa?</li>
  <li>As funcionalidades estavam claras e acessíveis?</li>
  <li>O que poderia ser melhorado no sistema?</li>
  <li>Você utilizaria o sistema novamente?</li>
</ul>

<h4>🔹 Registro dos Dados por Participante</h4>
<p>
Os dados serão coletados individualmente para cada participante definido no teste (P1 a P10), considerando seu perfil e tarefas executadas:
</p>

<ul>
  <li><strong>Consumidores (P1, P2, P7, P10):</strong> avaliação da navegação no marketplace, busca de produtos e processo de compra</li>
  <li><strong>Produtores Rurais (P3, P4, P8):</strong> avaliação do gerenciamento de propriedades, atividades e indicadores</li>
  <li><strong>Técnicos Agrícolas (P5, P6, P9):</strong> avaliação do acompanhamento de produtores, análise de dados e interação</li>
</ul>

<h4>🔹 Organização e Análise dos Dados</h4>
<ul>
  <li>Os dados serão organizados em tabelas e relatórios</li>
  <li>Serão identificados padrões de erro e dificuldades comuns</li>
  <li>Os resultados servirão como base para melhorias no sistema</li>
</ul>

<h4>🔹 Conformidade com a LGPD</h4>
<ul>
  <li>Nenhum dado pessoal ou sensível dos participantes será divulgado</li>
  <li>Os usuários serão identificados apenas por IDs (P1, P2, etc.)</li>
  <li>Os dados serão utilizados exclusivamente para fins acadêmicos</li>
</ul>
