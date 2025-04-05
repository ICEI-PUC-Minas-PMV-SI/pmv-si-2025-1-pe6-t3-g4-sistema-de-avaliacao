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

Existem muitas tecnologias diferentes que podem ser usadas para desenvolver APIs Web. A tecnologia certa para o seu projeto dependerá dos seus objetivos, dos seus clientes e dos recursos que a API deve fornecer.

[Lista das tecnologias principais que serão utilizadas no projeto.]

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

[Instruções para implantar a aplicação distribuída em um ambiente de produção.]

1. Defina os requisitos de hardware e software necessários para implantar a aplicação em um ambiente de produção.
2. Escolha uma plataforma de hospedagem adequada, como um provedor de nuvem ou um servidor dedicado.
3. Configure o ambiente de implantação, incluindo a instalação de dependências e configuração de variáveis de ambiente.
4. Faça o deploy da aplicação no ambiente escolhido, seguindo as instruções específicas da plataforma de hospedagem.
5. Realize testes para garantir que a aplicação esteja funcionando corretamente no ambiente de produção.

## Testes

[Descreva a estratégia de teste, incluindo os tipos de teste a serem realizados (unitários, integração, carga, etc.) e as ferramentas a serem utilizadas.]

1. Crie casos de teste para cobrir todos os requisitos funcionais e não funcionais da aplicação.
2. Implemente testes unitários para testar unidades individuais de código, como funções e classes.
3. Realize testes de integração para verificar a interação correta entre os componentes da aplicação.
4. Execute testes de carga para avaliar o desempenho da aplicação sob carga significativa.
5. Utilize ferramentas de teste adequadas, como frameworks de teste e ferramentas de automação de teste, para agilizar o processo de teste.

# Referências

Inclua todas as referências (livros, artigos, sites, etc) utilizados no desenvolvimento do trabalho.
