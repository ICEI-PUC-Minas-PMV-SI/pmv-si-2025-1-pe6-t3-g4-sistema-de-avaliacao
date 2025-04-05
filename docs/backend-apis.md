# APIs e Web Services

O  foco do projeto é desenvolver uma aplicação de gerenciamento de filmes, onde os usuários terão acesso a comentários e avaliações de filmes, permitindo que alinhem suas escolhas de acordo com seus gostos pessoais. A API será responsável por fornecer os dados dos filmes, permitindo que os usuários registrem suas avaliações e recebam recomendações personalizadas, baseadas em suas preferências e interações com a plataforma.


## Objetivos da API
O objetivo é criar uma aplicação que estimule a interação dentro de uma comunidade com gostos semelhantes, permitindo a troca de conteúdos e oferecendo recomendações personalizadas com base nas preferências de cada usuário


## Modelagem da Aplicação
📚 Descrição da Estrutura de Dados da Aplicação

🧑‍💼 Usuário - Armazena os dados dos usuários do sistema.

Id (int) – Identificador único.

Nome (string) – Nome do usuário.

Email (string) – E-mail para login e contato.

Senha (string) – Senha criptografada para autenticação.

Relacionamentos:

Um usuário pode comentar vários filmes.

Um usuário pode favoritar vários filmes.


🎬 Filme - Contém os dados dos filmes disponíveis na aplicação.

Id (int) – Identificador único.

Titulo (string) – Nome do filme.

AnoLancamento (int) – Ano de lançamento do filme.

Genero (string) – Gênero principal do filme.

Sinopse (string) – Resumo da história do filme.

FotoUrl (string) – Caminho da imagem de capa do filme.

Relacionamentos:

Um filme pode ter vários comentários.

Um filme pode ser favoritado por vários usuários.


💬 Comentário - Representa as mensagens deixadas pelos usuários nos filmes.

Id (int) – Identificador único.

Texto (string) – Conteúdo do comentário.

UsuarioId (int) – Chave estrangeira que referencia o autor (Usuario).

FilmeId (int) – Chave estrangeira que referencia o filme comentado.

Relacionamento:

Comentário é uma entidade fraca associada a Usuário e Filme com cardinalidade muitos-para-um para ambos.


⭐ Favorito

Entidade associativa que representa a relação N:N entre Usuário e Filme, ou seja, um usuário pode favoritar vários filmes e um filme pode ser favoritado por vários usuários.

IdUsuario (int) – Chave estrangeira para Usuario.

IdFilme (int) – Chave estrangeira para Filme.

Essa entidade não possui atributos adicionais, apenas mantém o relacionamento.

![image](https://github.com/user-attachments/assets/dbc72f78-ad89-47cf-9b12-862ccf5eee56)
![image](https://github.com/user-attachments/assets/88936491-c581-4095-8bd0-a4ce12fcd56a)
![image](https://github.com/user-attachments/assets/28389195-bdee-4b4a-aad5-e4e0beae31b7)
![image](https://github.com/user-attachments/assets/b10869ac-f75c-473c-b8aa-35231e2ad126)


## Tecnologias Utilizadas

No desenvolvimento da API foram utilizados as tecnologias.

Visual Studio 2022.
SQL Server Management Studio 20.
Insomnia.

## API Endpoints

[Liste os principais endpoints da API, incluindo as operações disponíveis, os parâmetros esperados e as respostas retornadas.]

### Endpoint 1
- Método: GET
- URL: /endpoint1
- Parâmetros:
  - param1: [descrição]
- Resposta:
  - Sucesso (200 OK)
    ```
    {
      "message": "Success",
      "data": {
        ...
      }
    }
    ```
  - Erro (4XX, 5XX)
    ```
    {
      "message": "Error",
      "error": {
        ...
      }
    }
    ```

## Considerações de Segurança

[Discuta as considerações de segurança relevantes para a aplicação distribuída, como autenticação, autorização, proteção contra ataques, etc.]

## Implantação

Para a implantação utilizando Windows e os serviços da AWS, foram escolhidos os requisitos:

### Requisitos de Hardware

Máquina virtual vCPUs.
Memória: Pelo menos 4 GB de RAM.
Armazenamento de disco: 20GB.

### Requisitos de Software

Sistema operacional: Microsoft Windows Server 2019.
.NET SDK: .NET 8.
Servidor Web: IIS (Windows)
Banco de Dados: Amazon RDS(SQL Server).

### Hospedagem

A hospedagem será feita usitlizando a Amazon EC2 (Elastic Computer Cloud) da AWS.


## Testes

Para validar a qualidade da aplicação e garantir uma boa experiencia para o Usuário, foram realizados teste através do Insomnia, uma ferramenta que permite testar, depurar e interagir com APIs web. Os testes foram realizados com base em nossos requisitos, sendo assim divididos de acordo com sua funcionalidade:

## Consulta de Obras:
- Objetivo: Caso o usuário esteja a procura de uma obra ou um gênero específico, será possível pesquisar por eles através do método GET.
  
  **- Requisição esperada:** Parâmetros obrigatórios são preenchidos corretamente pelo Usuário(Id do Filme ou Id do Gênero), o sistema os interpreta e retorna 200: sucesso.
  ![image](https://github.com/user-attachments/assets/1139bae1-41d0-4612-8681-189b642016eb)
  
  **- Requisição inválida:** Cao o usuário passe parâmetros de Id inválidos, a aplicação retornará 404: Not Found.
  ![image](https://github.com/user-attachments/assets/2e07863e-5e76-4356-9725-b7ea750175d0)

## Resenha de Obras:
- Objetivo: O usuário terá como avaliar suas obras já assistidas com críticas textuais detalhando sua esperiência, sendo possível criá-las pelo método POST, atualizá-las com o método PUT e deletá-las com o método DELETE. 
  
  **- Requisição esperada:** Parâmetros obrigatórios são preenchidos corretamente pelo Usuário(Id do Filme e Id do Usuário), o sistema os interpreta e retorna 201: criado.
  
  **- Requisição inválida:** Cao o usuário passe parâmetros de Id inválidos, a aplicação retornará 400: Bad Request.

# Referências
**API de filmes para abastecimento do Banco de Dados:**
- The Movie Database (TMDB), disponível em: https://developer.themoviedb.org/reference/intro/getting-started

**Documentação:**
- ASP.NET Core, disponível em: https://learn.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-6.0
- Entity Framework Core, disponível em: https://learn.microsoft.com/pt-br/ef/core/

**Bibliotecas:**
- JSON Web Token, disponível em: https://www.npmjs.com/package/jsonwebtoken

**Ferramentas de teste da API:**
- Insomnia, disponível em: https://insomnia.rest/download
