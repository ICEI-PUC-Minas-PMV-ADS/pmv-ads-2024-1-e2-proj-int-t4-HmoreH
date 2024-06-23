# Programação de Funcionalidades

## Funcionalidades

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir que o usuário crie uma conta pessoal | "ClientesController.cs", "View/Clientes/Create.cshtml", "Clientes.cs" | 
|RF-002| A aplicação deve permitir que o usuário realize login em sua conta pessoal | "Controllers/ClientesController.cs", "Views/Clientes/Login.cshtml", "Login.css" |
|RF-003| A aplicação deve permitir que o usuário gerencie suas tarefas | - |
|RF-004| A aplicação deve emitir um relatório de tarefas realizadas no mês   | - |
|RF-005| O sistema deve permitir manipular o cadastro de usuários, sejam clientes, funcionários ou administradores (crud) | "ClientesController.cs", "ClinicasController.cs", "MedicosController.cs" | 
|RF-006| O sistema deve exibir as informações do usuário do sistema | "ClientesController.cs", "Views/Clientes/MeuPerfil.cs", "ClinicasController.cs", "views/Clinicas/Index.cshtml"| 
|RF-007| O sistema deve exibir em sua homepage consultórios disponíveis para agendamento | "PaginaHome/Index.html" | 
|RF-008| O sistema deve fornecer informações dos consultórios exibidos | "View/Clinicas/Index.cshtml", "view/Clinicas/Details.cshtml" | 
|RF-009| O sistema deve fornecer opções de filtro de consultórios conforme localidade, disponibilidade, assuntos e preço | "ClinicasController.cs" | 
|RF-010| O sistema deve permitir a solicitação de transporte para a consulta agendada | - | 
|RF-011| O sistema deve acessar o banco de dados dos consultórios cadastrados| "Model/Clinicas.cs", "AppDbContext.cs" | 
|RF-012| O sistema deve permitir o agendamento de consultas direto do site | - | 
|RF-013| O sistema deve exibir as avaliações dos consultórios | "Views/Clinicas/Index.cshtml" | 
|RF-013| O sistema deve permitir avaliar consultórios entre 1 e 5 estrelas | - |
|RF-015| O sistema deve permitir a edição de informações da consulta agendada (crud) | - | 
|RF-016| Disponibilizar os meios de comunicação da clinica de forma acessivel, por exemplo, dispor de um botão para o WhatsApp, quando houver esse meio de contato.| "Clinica.cs", "Views/Clinicas/Details.cshtml", "ClinicasController.cs" |

# Instruções de acesso

Não deixe de informar o link onde a aplicação estiver disponível para acesso (por exemplo: https://adota-pet.herokuapp.com/src/index.html).

Se houver usuário de teste, o login e a senha também deverão ser informados aqui (por exemplo: usuário - admin / senha - admin).

O link e o usuário/senha descritos acima são apenas exemplos de como tais informações deverão ser apresentadas.

> **Links Úteis**:
>
> - [Trabalhando com HTML5 Local Storage e JSON](https://www.devmedia.com.br/trabalhando-com-html5-local-storage-e-json/29045)
> - [JSON Tutorial](https://www.w3resource.com/JSON)
> - [JSON Data Set Sample](https://opensource.adobe.com/Spry/samples/data_region/JSONDataSetSample.html)
> - [JSON - Introduction (W3Schools)](https://www.w3schools.com/js/js_json_intro.asp)
> - [JSON Tutorial (TutorialsPoint)](https://www.tutorialspoint.com/json/index.htm)
