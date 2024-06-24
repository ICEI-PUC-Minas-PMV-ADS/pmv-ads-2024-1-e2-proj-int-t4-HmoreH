# Plano de Testes de Software

Os testes funcionais a serem realizados na aplicação tem como finalidade compreender se o sistema atende os requisitos funcionais iniciais.
Os testes não se esgotam na lista abaixo e o responsável poderá ser alterado em qualquer fase do projeto.
Abaixo, descrição do Plano de Testes de Software.
<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 <tr>
  <td> CT-01: Cadastro e Autenticação </td>
  <td>
   <ul>
      <li>RF-001: A aplicação deve permitir que os usuários criem contas pessoais;</li>
      <li>RF-002:  aplicação deve permitir que o usuário realize login em sua conta pessoal.</li>
      <li>RF-017: O sistema deve permitir o cadastro das clínicas</li>
   </ul>
  </td>
  <td>Verificar se os usuários podem criar contas pessoais, e confirmar que podem fazer login e logout em suas contas</td>
  <td>
   <ol>
    <li>Acessar a página de cadastro;</li>
    <li>Preencher os campos obrigatórios;</li>
    <li>Clicar no botão de cadastro;</li>
    <li>Verificar se foi redireionado corretamente;</li>
    <li>Acessar a página de login;</li>
    <li>Inserir credenciais válidas;</li>
    <li>Clicar no botão de login;</li>
    <li>Verificar se está logado;</li>
    <li>Clicar no botão de logout;</li>
    <li>Verificar se está deslogado;</li>
   </ol>
   </td>
  <td>O usuário consegue criar uma conta e é redirecionado para a página principal, e realizar login e logout com sucesso.</td>
  <td>Walter</td>
 </tr>
</table>




<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 <tr>
  <td> CT-02: Gerenciamento de Tarefas</td>
  <td>
   <ul>
      <li>RF-003: A aplicação deve permitir que o usuário gerencie suas tarefas;</li>
      <li>RF-004: A aplicação deve emitir um relatório de tarefas realizadas no mês;</li>
      <li>RF-012: O sistema deve permitir o agendamento de consultas direto do site.</li>
   </ul>
  </td>
  <td>Avaliar se os usuários (clinicas) podem disponibilizar datas e horário em formato de agendas e usuários (clientes) podem selecionar e travar datas e horário para atendimento em suas contas. Avaliar se o sistema permite realizar agendamento de consultas.</td>
  <td>
   <ol>
    <li>(Usuário clínica)  Acessar página administrador</li>
    <li>Selecionar clinica/médico;</li>
    <li>Exibir calendário mês</li>
    <li>Selecionar datas e horários disponíveis para agendamento;</li>
    <li>Salvar</li>
    <li>(Usuário cliente)  Pesquisar pela especialidade;</li>
    <li>Selecionar clinica/médico;</li>
    <li>Filtrar data e horário;</li>
    <li>Selecionar data e horário;</li>
    <li>Confirmar agendamento;</li>
    <li>Extrair relatório de agendamentos por período de ambos perfis.</li>
   </ol>
   </td>
  <td>O usuário consegue disponibilizar sua agenda ou travar datas disponíveis para atendimento com sucesso. O sistema gera relatório de agendamentos por período solicitado.</td>
  <td>Walter</td>
 </tr>
</table>




<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 <tr>
  <td>CT-03: Manipulação e exibição de dados cadastrais</td>
  <td>
   <ul>
      <li>RF-005: O sistema deve permitir manipular o cadastro de usuários, sejam clientes, funcionários ou administradores (crud);</li>
      <li>RF-006: O sistema deve exibir as informações do usuário do sistema;</li>
   </ul>
  </td>
  <td>Avaliar se os usuários tem liberdade para alterar dados pessoais preenchidos no cadastro. Ex: email, telefone, nome da cliníca;
      Conferir se os dados do cliente são exibidos na página afim de garantir uma esperiência personalizada</td>
  <td>
   <ol>
    <li>Criar um cadastro;</li>
    <li>Preencher as informações;</li>
    <li>Salvar e verificar se o cadastro foi concluído;</li>
    <li>Ir a página de informações pessoais;</li>
    <li>Editar dados;</li>
    <li>Salvar e verificar se os dados foram alterados no cadastro;</li>
    <li>Ir para página inicial;</li>
    <li>Confirmar se os dados do cliente são exibidos de forma personalizada;</li>
   </ol>
   </td>
  <td>O usuário editar dados de cadastro quantas vezes julgar necessário. 
      O sistema salva e exibe os dados inseridos corretamente.
      O sistema apresenta os dados do cliente durante a navegação (nome).</td>
  <td>Walter</td>
 </tr>
</table>




<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 <tr>
  <td>CT-04: Dados de consultórios</td>
  <td>
   <ul>
      <li>RF-007: O sistema deve exibir em sua homepage consultórios disponíveis para agendamento;</li>
      <li>RF-008: O sistema deve fornecer informações dos consultórios exibidos</li>

   </ul>
  </td>
  <td>Avaliar se os consultórios cadastrados são exibidos na homepage;
      Avaliar se ao selecionar um consultório, os dados básicos, como especialidade, agenda disponível, endereço e apresentação são exibidos ao usuário.</td>
  <td>
   <ol>
    <li>Acessar homepage;</li>
    <li>Confirmar se as clinicas são exibidas na homepage;</li>
    <li>Selecionar uma clinica;</li>
    <li>Verificar se a clinica solicitada tem os dados básicos exibidos na tela (endereço, especilidades, preço, agenda, apresentação)</li>
   </ol>
   </td>
  <td>O sistema apresenta clinínicas disponívels em na homepage;
      O sistema apresentada dados da clínica selecionada ao cliente.
   </td>
  <td>Walter</td>
 </tr>
</table>



<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 <tr>
  <td>CT-05: Filtros</td>
  <td>
   <ul>
      <li>RF-009: O sistema deve fornecer opções de filtro de consultórios conforme localidade, disponibilidade, assuntos e preço;</li>
      
   </ul>
  </td>
  <td>Avaliar se o usuário tem opção de utilizar filtros para tornar sua experiência mas personalizada e objetiva, respeitando suas preferências como preço, especialidade e localidade.</td>
  <td>
   <ol>
    <li>Acessar homepage;</li>
    <li>Selecionar filtros;</li>
    <li>Filtrar por preço;</li>
    <li>Verificar resultado;</li>
    <li>Repetir o processo substiuindo o item 3 por especialidade e endereço;</li> 
    <li> Repetir o teste utilizando multiplos filtros.</li>
   </ol>
   </td>
  <td>O sistema deve ser capaz de permitir que o usuário, ao realizar agendamento de uma consulta, tenha a opção de agendar transporte.</td>
  <td>Walter</td>
 </tr>
</table>




<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 <tr>
  <td>CT-06: Solicitação de transporte</td>
  <td>
   <ul>
      <li>RF-010: O sistema deve permitir a solicitação de transporte para a consulta agendada</li>
      
   </ul>
  </td>
  <td>Avaliar se o usuário ao realizar agendamento de consulta, é capaz de solicitar transporte.</td>
  <td>
   <ol>
    <li>Acessar homepage;</li>
    <li>Selecionar uma clínica;</li>
    <li>Agendar uma consulta;</li>
    <li>Selecionar a opção transporte;</li>
    <li>Verificar se o site direciona para o fornecedor de transporte credenciado;</li> 
    
   </ol>
   </td>
  <td>O sistema deve ser capaz de permitir que o usuário, ao realizar agendamento de uma consulta, tenha a opção de agendar transporte.</td>
  <td>Walter</td>
 </tr>
</table>

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
