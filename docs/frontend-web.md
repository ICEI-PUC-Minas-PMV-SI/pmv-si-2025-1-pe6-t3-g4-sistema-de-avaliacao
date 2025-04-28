# Front-end Web

O objetivo central deste projeto é criar uma plataforma dedicada à organização e consulta de obras audiovisuais, na qual os Usuários poderão explorar críticas e notas atribuídas por outros espectadores. Isso possibilitará que eles tomem decisões mais alinhadas aos seus interesses individuais.
A interface do Usuário será desenvolvida com foco em experiência intuitiva, utilizando tecnologias modernas para garantir dinamismo e responsividade. O design priorizará:

- Navegação fluida, com páginas organizadas em seções claras.

- Componentes interativos, como o filtro por gênero, busca inteligente e cards das obras com visualização rápida de avaliações médias.

- Personalização visual, exibindo recomendações em destaque com base nas avaliações dos Usuários.

- Integração em tempo real com a API, garantindo atualizações rápidas de reviews e notas.

## Projeto da Interface Web

A interface web do projeto foi desenvolvida para ser a principal porta de entrada do Usuário, proporcionando uma experiência intuitiva, agradável e alinhada com a temática cinematográfica. Com um design minimalista e objetivo, priorizamos a usabilidade e a imersão visual, incorporando elementos que remetem à atmosfera do cinema, como as cores características de baldes de pipoca e salas de projeção.

## Wireframes

### Layout das Páginas
A estrutura foi pensada para garantir navegação fluida e acesso rápido às principais funcionalidades.

- **Página Inicial (Home)**:

Destaca os filmes disponíveis na aplicação para avalização, com um menu interativo que guia o Usuário até as outras páginas do site, incluindo uma aba específica para redirecionamentos relacionados ao Usuário.
Possuí também uma barra de pesquisa para localização de obras audiovisuais.

- **Painel do Usuário**:

A aba do Usuário possuí 4 opções de páginas para acesso do Usuário, sendo elas:

  - Perfil, referente a página de gestão dos dados do Usuário.
  - Avaliações, onde ficam as obras avaliadas por esse Usuário.
  - Favoritados, onde ficam as obras favoritadas por esse Usuário.
  - Desconectar, opção para desconectar a conta da aplicação (Sign Out).


- **Criação Usuário**:

Caso o usuário não possua uma conta, ele concegue acessar a página para cadastro pela aba Perfil, disponível no painel do Usuário, que também sera o caminho a ser seguido para se conectar (Login) a aplicação.
Para criar um novo Usuário, é necessário fornecer um E-mail, uma senha, nome completo e nome de usuário (visível em suas avaliações para os outros Usuários).

- **Login de Usuário**:

Nessa página, o usuário consegue se conectar a aplicação para salvar suas informações (Obras avaliadas e/ou favoritadas), além de ter acesso a página de recuperação de senha.

- **Nova Senha**:

Caso o Usuário tenha se esquecido de sua senha inicial, é possível definir uma nova através do fornecimento do E-mail cadastrado e uma nova senha para cadastro.

- **Gestão de Perfil do Usuário**:

Mostra as informações cadastrais do Usuário (Nome completo, e-mail e nome de Usuário), além do histórico de obras avaliadas e/ou favoritadas, com a possibilidade de atualização dos dados ou exclusão da conta.

- **Página das Obras Favoritas**:

Grid responsivo com poster das obras e o botão de favoritar, que incluirá ela em sua Lista de Favoritados.

- **Página das Obras Avaliadas**:

Grid responsivo com poster e a nota média da obra, representada por estrelas, que permite uma nova avalização quando selecionada, direcionando o Usuário para um painel com informações da obra.

- **Painel das Obras**:

Modal de detalhes ao clicar em um filme, exibindo título, ano de lançamento, gênero, sinopse e sua nota, que permite ao Usuário favoritar e avaliar a obra selecionada, além de vizualizar quantos a favoritaram e o que outros Usuários comentaram sobre. 

- **Lista de Favoritos**:

Pelo menu superior é possível acessar a página das Listas de Favoritos, que mostra todas as listas criadas pelos Usuários.

- **Obras Avaliadas**:

Pelo perfil público de outros Usuários é possível acessar a página de Obras Avaliadas, que mostra as obras que foram avaliadas pelo Usuário selecionado.

 - **Página Filmes por gênero**:

Semelhante a Home, destaca as obras disponíveis na aplicação para avalização, porém às separando pelo seu gênero, possuindo também uma barra de pesquisa para localização de obras audiovisuais e/ou gêneros específicos.

<!-- - **Perfil Público do Usuário**: -->

<!-- Nesta página o Usuário tem acesso ao "Nome de Usuário" de outras contas, assim como suas listas de obras avaliadas e favoritadas, sendo possível seguí-lo para acompanhar seu perfil. -->

<!-- - **Perfis Seguidos**: -->

<!-- O Usuário pode acompanhar seus perfis seguidos e suas listas criadas através dessa página, tendo como pesquisar por um perfil específico pela barra de pesquisa. -->

### Design Visual

- Paleta de Cores:

Tons de vermelho e bege, inspirados na coloração de pipocas e no ambiente acolhedor das salas de cinema.

Contrastes sutis com preto e azul escuro para evocar a sensação de telão e poltronas de cinema.

Tipografia limpa e legível, com a fonte Instrument Serif para melhor leitura em diferentes dispositivos.

- Elementos Gráficos:

Ícones simples (como lupa para referenciar a pesquisa e uma silhueta humana para representar a área do Usuário) usados de forma discreta para reforçar a identidade visual.

Efeitos de transição suaves, simulando o fade-in e fade-out de projeções cinematográficas.


## Fluxo de Dados

![image](https://github.com/user-attachments/assets/fb3fe2de-6107-4bc5-8e25-82a00c1f9090)
![image](https://github.com/user-attachments/assets/f48df881-dd53-45d7-974b-7a260c36f3ea)
![image](https://github.com/user-attachments/assets/0ba47b33-6751-4ea6-9bbf-0f939d23af76)
![image](https://github.com/user-attachments/assets/3676fc21-dc90-44b2-91e3-1d7c05eea622)
![image](https://github.com/user-attachments/assets/ee4ab3ab-b2ef-4f13-b550-befe897335f1)


## Diagrama Entidade-Relacionamento (ER)

![image](https://github.com/user-attachments/assets/049ecbc5-4478-4688-a91c-0240e4e19cc3)


## Diagrama de Fluxo


## Tecnologias Utilizadas

Visual Studio Code, para desenvolvimento do Front-End da aplicação.

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
