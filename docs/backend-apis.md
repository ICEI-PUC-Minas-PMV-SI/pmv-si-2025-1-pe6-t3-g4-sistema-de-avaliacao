# APIs e Web Services

O  foco do projeto é desenvolver uma aplicação de gerenciamento de obras cinematográficas, onde os usuários terão acesso a comentários e avaliações das obras, permitindo que alinhem suas escolhas de acordo com seus gostos pessoais. A API será responsável por fornecer os dados das produções, permitindo que os usuários registrem suas avaliações e recebam recomendações personalizadas, baseadas em suas preferências e interações com a plataforma.


## Objetivos da API
O objetivo é criar uma aplicação que estimule a interação dentro de uma comunidade com gostos semelhantes, permitindo a troca de conteúdos e oferecendo recomendações personalizadas com base nas preferências de cada usuário


## Modelagem da Aplicação
📚 Descrição da Estrutura de Dados da Aplicação

🧑‍💼 Usuário - Armazena os dados dos usuários do sistema.

Id (int) – Identificador único.

NomeCompleto (string) – Nome do usuário.

NomeDeUsuário (string) - Nome público do Usuário na plataforma.

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

No desenvolvimento da API foram utilizados as tecnologias:

Visual Studio 2022.

SQL Server Management Studio 20.

Insomnia.

## API Endpoints

## Endpoint 1: Obras
### - Perquisa de Obras
- Método: GET
- URL: /api/Filmes/tmdb
- Parâmetros:
  - Id <int, chave Primária>: Id correspondente a obra.
  - Titulo <string, Obrigatório>: Título da Obra.
  - AnoLancamento <int>: Ano de Lançamento da Obra.
  - Genero <string>: Gênero da Obra.
  - Sinopse <string>: Sinopse da Obra.
  - FotoUrl <string>: Foto/Poster da Obra.

- Resposta:
  - Sucesso (200 OK)
    ```
    {
    "$id": "1",
    "id": 254,
    "titulo": "King Kong",
    "anoLancamento": 0,
    "genero": "Aventura, Drama, Ação",
    "sinopse": "Nova York, 1933. Ann Darrow, uma atriz de vaudeville, enfrenta dificuldades para se sustentar, como vários outros americanos durante a Grande Depressão. Ela caminha pelas ruas de Manhattan pensando na possibilidade de trabalhar em um cabaré, até que a fome a faz roubar uma maçã. Ann é salva pelo cineasta Carl Denham, que oferece a ela o papel principal em sua próxima produção. Inicialmente indecisa, Ann aceita a oferta após saber que o roteirista é o conceituado dramaturgo Jack Driscoll. Na verdade Carl está em apuros, já que o patrocínio para concluir seu filme inacabado foi cancelado e sua antiga atriz principal abandonou o projeto. Apesar dos problemas, Carl embarca a equipe e o elenco de seu filme no cargueiro fretado S.S. Venture. O objetivo da viagem é chegar na Ilha da Caveira, que tem a fama de abrigar uma raça perdida e várias criaturas consideradas extintas.",
    "fotoUrl": "https://image.tmdb.org/t/p/w500",
    }
    ```
  - Erro (404 Not Found)
    ```
    {
     "Nenhum filme encontrado."
    }
    ```

### - Perquisa de Obras pelo Gênero
- Método: GET
- URL: api/filmes/genero/{idGenero}
- Parâmetros:
  - Id <int, chave Primária>: Id correspondente a obra.
  - Titulo <string, Obrigatório>: Título da Obra.
  - AnoLancamento <int>: Ano de Lançamento da Obra.
  - Genero <string>: Gênero da Obra.
  - Sinopse <string>: Sinopse da Obra.
  - FotoUrl <string>: Foto/Poster da Obra.

- Resposta:
  - Sucesso (200 OK)
    ```
		{
			"$id": "2",
			"id": 1197306,
			"titulo": "Resgate Implacável",
			"anoLancamento": 2025,
			"genero": "Ação",
			"sinopse": "Ele quer viver uma vida simples e ser um bom pai para sua filha. Mas quando a filha adolescente de seu chefe, Jenny, desaparece, ele é chamado para reempregar as habilidades que o tornaram uma figura lendária nas operações secretas.",
			"fotoUrl": "https://image.tmdb.org/t/p/w500/iT6yYCAuMQwm1PV4nByrsrsIOhG.jpg",
			"usuariosFavoritaram": {
				"$id": "3",
				"$values": []
			},
			"comentarios": {
				"$id": "4",
				"$values": []
			},
			"links": {
				"$id": "5",
				"$values": []
			}
		}
    ```
  - Erro (404 Not Found)
    ```
    {
      "Nenhum filme encontrado para o gênero {idGenero}."
    }
    ```

## Endpoint 2: Avaliações de Obras
### - Comentar obra
- Método: POST
- URL: /api/comentarios
- Parâmetros:
 - Id <int, chave Primária>: Identificador do Comentário.
 - Texto <string, Obrigatório>: Resenha relacionada a Obra.
 - IdUsuario <int>: Identificador do Usuário.
 - TMDBFilmeId <int>: Identificador da Obra.

- Resposta:
  - Sucesso (201 Created):
    ```
    {
	"$id": "1",
	"id": 4,
	"texto": "Chato demais",
	"idUsuario": 1,
	"tmdbFilmeId": 254,
	"links": {
		"$id": "2",
		"$values": []
     }
    }
    ```
  - Erro (400 Bad Request): Sem corpo de resposta.
    ```
    ```

### - Editar comentário
- Método: PUT
- URL: /api/comentarios/{Id}
- Parâmetros:
 - Id <int, chave Primária>: Identificador do Comentário.
 - Texto <string, Obrigatório>: Resenha relacionada a Obra.
 - IdUsuario <int>: Identificador do Usuário.
 - TMDBFilmeId <int>: Identificador da Obra.

- Resposta:
  - Sucesso (204 No Content):  Sem corpo de resposta.
    ```
    ```
  - Erro (400 Bad Request): Sem corpo de resposta.
    ```
    ```

## Endpoint 3: Gestão de Usuário
### - Criação de Usuário
- Método: POST
- URL: /api/usuarios
- Parâmetros:
  - Id <int, chave Primária>: Identificador do Usuário.
  - NomeCompleto <string, Obrigatório>: Nome do Usuário.
  - NomeDeUsuario <string, Obrigatório>: Nome público do Usuário na plataforma.
  - Email <string, Obrigatório>: E-mail do Usuário
  - Senha <string, Obrigatório>: Senha de acesso do Usuário.

- Resposta:
  - Sucesso (201 Created):
    ```
    {
	"$id": "1",
	"id": 2,
	"nomeCompleto": "Laura L. B. Rocha",
	"nomeDeUsuario": "Laura0101",
	"email": "laura@example.com",
	"senha": "$2a$11$JAhewh7hoAL5i6AM7aDEuu1jMhi6aabu0oT5E7WzJ9sfhf4KFKaW2",
	"favoritos": {
		"$id": "2",
		"$values": []
	},
	"comentarios": {
		"$id": "3",
		"$values": []
	},
	"links": {
		"$id": "4",
		"$values": []
	}
}
    ```
  - Erro (400 Bad Request)
    ```
    "Já existe um usuário com esse Nome de Usuário."
    ```

    ```
    "Já existe um usuário com esse E-mail."
    ```
    
### - Atualização de dados
- Método: PUT
- URL: /api/usuarios/{id}
- Parâmetros:
  - Id <int, chave Primária>: Identificador do Usuário.
  - NomeCompleto <string, Obrigatório>: Nome do Usuário.
  - NomeDeUsuario <string, Obrigatório>: Nome público do Usuário na plataforma.
  - Email <string, Obrigatório>: E-mail do Usuário
  - Senha <string, Obrigatório>: Senha de acesso do Usuário.

- Resposta:
  - Sucesso (204 No Content):  Sem corpo de resposta.
    ```
    ```
  - Erro (400 Bad Request): Sem corpo de resposta.
    ```
    ```

### - Excluir Usuário
- Método: DELETE
- URL: /api/usuarios/{id}
- Parâmetros:
  - Id <int, chave Primária>: Identificador do Usuário.

- Resposta:
  - Sucesso (204 No Content):  Sem corpo de resposta.
    ```
    ```
  - Erro (404 Not Found): Sem corpo de resposta.
    ```
    ```

## Considerações de Segurança

Para garantir a integridade dos dados e a privacidade dos usuários na aplicação de gerenciamento de filmes, serão adotadas medidas essenciais de segurança. A plataforma foi pensada para oferecer uma experiência segura, protegendo informações sensíveis e controlando o acesso aos recursos de forma eficiente, em conformidade com diretrizes da Lei Geral de Proteção de Dados Pessoais (LGPD).

As principais práticas implementadas incluem:

- **Implementação de autenticação de usuário através de tokens JSON Web Token (JWT):** apenas usuários autenticados poderão acessar os recursos protegidos da API. O token é gerado no momento do login e validado em cada requisição subsequente.

- **Senhas criptografadas e armazenamento seguro das credenciais de acesso:** todas as senhas serão protegidas com algoritmos de criptografia robustos, evitando o vazamento de informações sensíveis.

- **Uso de requisições HTTPS para garantir comunicação segura:** toda a troca de dados entre o frontend e a API será feita via protocolo HTTPS, assegurando a confidencialidade e integridade das informações transmitidas.

- **Controle de acesso a certas operações da API com base no tipo de usuário:** funcionalidades como comentar, favoritar ou visualizar recomendações estarão disponíveis apenas conforme o nível de acesso de cada usuário, evitando usos indevidos da plataforma.


## Implantação

Para a implantação utilizando Windows e os serviços da AWS, foram escolhidos os requisitos:

### Requisitos de Hardware

Máquina virtual vCPUs.

Memória: Pelo menos 4 GB de RAM.

Armazenamento de disco: 20GB.

### Requisitos de Software

Sistema operacional: Microsoft Windows Server 2019.

.NET SDK: .NET 8.

Servidor Web: IIS (Windows).

Banco de Dados: Amazon RDS(SQL Server).

### Hospedagem

A hospedagem será feita pelo uso da Amazon EC2 (Elastic Computer Cloud) da AWS.


## Testes

Para validar a qualidade da aplicação e garantir uma boa experiencia para o Usuário, foram realizados teste através do Insomnia, uma ferramenta que permite testar, depurar e interagir com APIs web. Os testes foram realizados com base em nossos requisitos, sendo assim divididos de acordo com sua funcionalidade:

## Consulta de Obras
- Objetivo: Caso o usuário esteja a procura de uma obra ou um gênero específico, será possível pesquisar por eles através do método GET.
  
  **- Requisição esperada:** Parâmetros obrigatórios são preenchidos corretamente pelo Usuário(Id do Filme ou Id do Gênero), o sistema os interpreta e retorna 200: sucesso.
  ![image](https://github.com/user-attachments/assets/1139bae1-41d0-4612-8681-189b642016eb)
  
  **- Requisição inválida:** Cao o usuário passe parâmetros de Id inválidos, a aplicação retornará 404: Not Found.
  ![image](https://github.com/user-attachments/assets/2e07863e-5e76-4356-9725-b7ea750175d0)

## Resenha de Obras
- Objetivo: O usuário terá como avaliar suas obras já assistidas com críticas textuais detalhando sua esperiência, sendo possível criá-las pelo método POST, atualizá-las com o método PUT e deletá-las com o método DELETE. 
  
  **- Requisição esperada:** Parâmetros obrigatórios são preenchidos corretamente pelo Usuário(Texto referênte a resenha), o sistema os interpreta e retorna 201: criado.
  ![image](https://github.com/user-attachments/assets/36aa605c-5397-476c-a053-6534699aaa07)
  
  **- Requisição inválida:** Cao o usuário passe parâmetros de Id inválidos, a aplicação retornará 400: Bad Request.
  ![image](https://github.com/user-attachments/assets/983e908c-c61a-451b-b7c0-05b26a167640)

  ## Gestão do Perfil de Usuário
- Objetivo: O usuário consegue gerenciar seu perfil completamente, tendo como realizar todos os métodos de um CRUD, como por exemplo atulizar suas informações com o método PUT.
  
  **- Requisição esperada:** Parâmetros obrigatórios são preenchidos corretamente pelo Usuário(Id de Usuário, Nome, E-mail e Senha), o sistema os interpreta e retorna 204: No Content.
  ![image](https://github.com/user-attachments/assets/be3ddccc-acf8-4e92-aa61-ad838e19f12f)

  **- Requisição inválida:** Cao o usuário passe parâmetros de Id inválidos, a aplicação retornará 400: Bad Request.
  ![image](https://github.com/user-attachments/assets/569b711b-3b59-470c-87d2-54a291853a5b)

  
# Referências
**Código Fonte:**
- [api-web-services-avaliacao-manager-master.zip](https://github.com/user-attachments/files/19624094/api-web-services-avaliacao-manager-master.zip)


**API de filmes para abastecimento do Banco de Dados:**
- The Movie Database (TMDB), disponível em: https://developer.themoviedb.org/reference/intro/getting-started

**Documentação:**
- ASP.NET Core, disponível em: https://learn.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-6.0
- Entity Framework Core, disponível em: https://learn.microsoft.com/pt-br/ef/core/

**Bibliotecas:**
- JSON Web Token, disponível em: https://www.npmjs.com/package/jsonwebtoken

**Ferramentas de teste da API:**
- Insomnia, disponível em: https://insomnia.rest/download
