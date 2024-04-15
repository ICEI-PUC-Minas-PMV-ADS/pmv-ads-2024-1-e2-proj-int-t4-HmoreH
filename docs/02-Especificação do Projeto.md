# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas na Figuras que se seguem.

|IMAGEM|NOME| CARACTERÍSTICAS|
|--------------------|------------------------------------|----------------------------------------|
|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t4-HmoreH/assets/32981763/6e7c6c2b-cac5-4b48-8fae-0e8d070a39d6" width="350">| Olívia Barbara de Jesus           | * Idade: 70 anos <br> * Ocupação: Aposentada <br> <b> Aplicativos: </b> <br> * WhatsApp <br> * Facebook <br> <b>Frustrações</b><br> * Letras muito pequenas;<br> * Falta de objetividade nas aplicações. <br> <b>Hobbies</b><br> * História;<br> * Jardinagem.|
|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t4-HmoreH/assets/32981763/8c4d944f-e142-4e80-a31f-eb5f33fa936e" width="350">| Thomas Ferreira           | * Idade: 75 anos <br> * Ocupação: Aposentado <br> <b> Aplicativos: </b> <br> * WhatsApp <br> <b>Frustrações</b><br> * Excesso de informação;<br> * Dificuldade de aprendizado. <br> <b>Hobbies</b><br> * História;<br> * Culinária.|

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Olívia Barbara de Jesus  | Quero um aplicativo de fácil uso para marcar minhas consultas           | Para conseguir usar o aplicativo sem precisar pedir ajuda.|
|Olívia Barbara de Jesus     | Quero um aplicativo que me auxilie a conseguir um transporte até a clínica                 | Para conseguir chegar facilmente até o local do atendimento. |
|Olívia Barbara de Jesus  | Quero consultas médicas com horários flexíveis na clínica           | Para poder agendar de acordo com meus compromissos e não ter que esperar muito tempo na sala de espera|
|Olívia Barbara de Jesus| Desejo uma equipe médica simpática e atenciosa na clínica                | Para me sentir confortável e compreendida durante minhas consultas e exames |
|Olívia Barbara de Jesus  | Quero instalações acessíveis na clínica, incluindo rampas e banheiros adaptados            | Para facilitar minha locomoção e garantir minha segurança|
|Thomas Ferreira | Desejo receber orientações prévias sobre preparos para exames online na clínica| Para acompanhar minha saúde de forma rápida e conveniente, sem precisar esperar por correspondências |
|Thomas Ferreira  | Quero agendar exames online na clínica| para evitar longas esperas e facilitar o planejamento dos meus compromissos|
|Thomas Ferreira | Quero acessar meus resultados de exames pela internet na clínica | Para não esquecer compromissos importantes e garantir minha presença nos horários marcados |
|Thomas Ferreira  | Quero poder acompanhar a disponibilidade de horários para consultas e exames online na clínica  | Para encontrar facilmente o melhor momento que se encaixe na minha agenda|
|Thomas Ferreira      | Quero receber orientações sobre transporte acessível até a clínica. | Para garantir que posso chegar lá de forma segura e sem dificuldades de locomoção |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir que os usuários criem contas pessoais | ALTA | 
|RF-002| A aplicação deve permitir que o usuário realize login em sua conta pessoal | ALTA |
|RF-003| A aplicação deve permitir que o usuário gerencie suas tarefas | ALTA |
|RF-004| A aplicação deve emitir um relatório de tarefas realizadas no mês   | MÉDIA |
|RF-005| O sistema deve permitir manipular o cadastro de usuários, sejam clientes, funcionários ou administradores (crud) | ALTA | 
|RF-006| O sistema deve exibir as informações do usuário do sistema | ALTA | 
|RF-007| O sistema deve exibir em sua homepage consultórios disponíveis para agendamento | ALTA | 
|RF-008| O sistema deve fornecer informações dos consultórios exibidos | ALTA | 
|RF-009| O sistema deve fornecer opções de filtro de consultórios conforme localidade, disponibilidade, assuntos e preço | MÉDIA | 
|RF-010| O sistema deve permitir a solicitação de transporte para a consulta agendada | ALTA | 
|RF-011| O sistema deve acessar o banco de dados dos consultórios cadastrados| ALTA | 
|RF-012| O sistema deve permitir o agendamento de consultas direto do site | ALTA | 
|RF-013| O sistema deve exibir as avaliações dos consultórios | MÉDIA | 
|RF-014| O sistema deve permitir a edição de informações da consulta agendada (crud) | ALTA | 
|RF-015| Disponibilizar os meios de comunicação da clinica de forma acessivel, por exemplo, dispor de um botão para o WhatsApp, quando houver esse meio de contato.| MÉDIA | 

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser responsiva | MÉDIA | 
|RNF-002| A aplicação deve processar requisições do usuário em no máximo 3s |  BAIXA | 
|RNF-003| As páginas do site devem ser otimizadas para carregamento rápido, mesmo em dispositivos com baixa conectividade| ALTA |
|RNF-004| A interface do sistema deve ser intuitiva e fácil de usar para pessoas de todas as idades e níveis de familiaridade com a tecnologia. | ALTA |
|RNF-005| O site deve ser confiável e seguro com criptografia | ALTA |
|RNF-006| O site deve ser compatível com os principais navegadores e dispositivos, incluindo smartphones e tablets.| ALTA |
|RNF-007| O sistema deve ser modular e fácil de manter.| ALTA |
|RNF-008| O sistema deve cumprir todas as leis e regulamentos aplicáveis à privacidade de dados| ALTA |
|RNF-009|| ALTA |

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |
|03| Verificar se os requisitos e as metas propostas estão compatíveis com o nível de estudo dos integrantes |

## Diagrama de Casos de Uso

![Untitled Workspace (1)](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t4-HmoreH/assets/117231834/e5155e5f-dd9f-43b6-a3f5-847b244b6236)
