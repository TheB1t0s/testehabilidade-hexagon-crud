Foram utilizadas as tecnologias: 
Asp.NET -- C#

MySql

Xampp

CSS/HTML

Javascript

Datatable

Inicialmente foi utilizado o programa Microsoft Visual Studio para criação da tabela, além da captura e organização de dados pelo MySql, onde hospedei minha tabela.
A criação do projeto se deu pelo Asp.NET Core, onde usei o c# para inicialização do código e para criação do banco de dados, onde as soluções Program e Startup, fazem a função de inicializar o banco de dados e a outra de salvar, excluir ou editar os dados entregues.

A parte da coleta de dados mais o front end se deu pela criação de labels e displays criados por cshtml, onde eu coletei os dados e linkei a conexão ao banco de dados que receberia os dados e poderia visualizar os mesmos após o recebimento. Além de adicionar os dados com a solução create.cshtml, também foi adicionada as soluções, delete, details, edit e o index. Possibilitando o usuário acessar os dados através de uma tabela salva no front do programa para deletar, editar ou apenas visualizar mais detalhadamente, ou então até mesmo criar um novo usuário.

Por fim eu alterei o layout.cshtml na pasta views para criar uma paginação da tabela com possibilidade de selecionar quantos usuários a pessoa gostaria de ver na tela e também um filtro de busca para facilitar a procurar pelos dados injetados no banco, isso sendo possibilitado pelo plug-in/framework DataTable que foi inserido no layout a parte do css e do js e depois adicionado com script no index, onde mostra o principal dos usuários.
