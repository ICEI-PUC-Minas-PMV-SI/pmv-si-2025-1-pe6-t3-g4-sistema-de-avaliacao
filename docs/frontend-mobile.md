# Front-end Móvel

Este projeto tem como objetivo desenvolver a interface móvel da aplicação de filmes, proporcionando uma experiência intuitiva e agradável para os usuários. A aplicação permite visualizar os filmes mais bem avaliados, gerenciar usuários e interagir com o conteúdo de forma prática por meio de um aplicativo desenvolvido em React Native com Expo.

## Projeto da Interface
A interface móvel da aplicação foi projetada com foco na simplicidade, elegância e usabilidade. Inspirada no design retrô das salas de cinema, a interface utiliza um fundo em verde escuro para transmitir uma atmosfera imersiva, com elementos visuais contrastantes, como cards arredondados com fundo bege, que destacam as informações principais de cada filme.

A navegação foi planejada para ser intuitiva, com menus claros, botões acessíveis e interação fluida. O layout se adapta bem a diferentes tamanhos de tela, garantindo uma boa experiência tanto em celulares menores quanto em dispositivos com telas maiores.

As páginas incluem:

Tela inicial com os filmes mais bem avaliados;

Tela de gestão de usuários (cadastro, listagem e remoção);

Navegação por categorias/gêneros;

Barra de pesquisa e filtros.


A identidade visual visa unir funcionalidade e apelo estético, proporcionando uma experiência agradável tanto para usuários ocasionais quanto para cinéfilos assíduos.



### Wireframes
Os Wireframes do front-end móvel da aplicação foram criados se baseando nas páginas Web, com o foco na experiência do usuário e na portabilidade oferecida pelos dispositivos móveis.
A interface móvel do projeto foi projetada para oferecer uma experiência imersiva e intuitiva, considerando o design do front-end Web criado na etapa anterior como base. Com um design minimalista e objetivo, priorizamos a usabilidade em dispositivos móveis, integrando elementos visuais que remetem à nostalgia e ao charme das salas de cinema, como tons claros de pipoca amantegada e o vermelho veludo de poltronas.

### Layout das Páginas

- **Página Inicial (Home)**:
Exibe uma lista com os filmes presentes no banco de dados da API externa do TMDB, que podem ser avaliados e procurados pelo título através da barra de pesquisa, além do filtro de página que redireciona o Usuário para outras telas da aplicação, e o ícone de Usuário que dá acesso ao gerenciamento de seus dados.

![image](https://github.com/user-attachments/assets/8b05a1ad-2c84-4eb0-ac8e-9b92d5ddab67)

- **Página Filmes por gênero**:
Semelhante a página inicial, destaca as obras disponíveis na aplicação para avalização, porém às separando pelo seu gênero, possuindo também uma barra de pesquisa para localização de obras audiovisuais e/ou gêneros específicos, o filtro de página e o ícone de Usuário.

![image](https://github.com/user-attachments/assets/f4455d8e-de8d-4567-b7b1-c9a5b15aee33)

- **Melhores Avaliados**:
Nessa página são exibidas as obras mais bem avaliadas de acordo com a nota média no TMDB.

![image](https://github.com/user-attachments/assets/6ca05c6b-e5d4-4cae-a5ea-1a15ff532e1a)

- **Filtro de Páginas**:
Para um design mais leve, optamos por substituir o menu horizontal do layout Web por esse filtro de páginas, que dá acesso as três principais telas de navegação para o Usuário.

![image](https://github.com/user-attachments/assets/bebedb44-d2ff-435d-9691-fee00c419c52)

- **Painel do Usuário**:
A aba do Usuário possuí 4 opções de páginas relacionadas ao Usuário, sendo elas:

  - Perfil, referente a página de gestão dos dados do Usuário.
  - Avaliações, onde ficam as obras avaliadas por esse Usuário.
  - Favoritados, onde ficam as obras favoritadas por esse Usuário.
  - Desconectar, opção para desconectar a conta da aplicação (Sign Out).

![image](https://github.com/user-attachments/assets/8d0610cf-8cd7-4851-a912-0d4920ae77b3)

- **Criação Usuário**:
Caso o usuário não possua uma conta, ele concegue acessar a página para cadastro pela aba Perfil, disponível no painel do Usuário, que também é o caminho a ser seguido para se conectar (Login) a aplicação.
Para criar um novo Usuário, é necessário fornecer um E-mail, uma senha, nome completo e nome de usuário (visível em suas avaliações para os outros Usuários).

![image](https://github.com/user-attachments/assets/ad1d234c-0ecf-4617-b1b6-0fde417f5e16)

- **Login de Usuário**:
Essa aba permite ao Usuário se conectar a aplicação para salvar suas informações (Obras avaliadas e/ou favoritadas), além de ter acesso a página de recuperação de senha.

![image](https://github.com/user-attachments/assets/440242a3-ddda-42cc-b94b-672582d7eae0)

- **Nova Senha**:
Caso o Usuário tenha se esquecido de sua senha inicial, é possível definir uma nova através do fornecimento do E-mail cadastrado e uma nova senha para cadastro.

![image](https://github.com/user-attachments/assets/6fce1c89-3946-4faa-9f15-df48f1c6ed3e)

- **Gestão de Perfil do Usuário**:
Mostra as informações cadastrais do Usuário (Nome completo, e-mail e nome de Usuário), além do histórico de obras avaliadas e/ou favoritadas, com a possibilidade de atualização dos dados ou exclusão da conta.

![image](https://github.com/user-attachments/assets/1d11e668-0475-47bb-8bbd-2bdc97d6972e)

- **Página das Obras Favoritas**:
Página que inclui os posteres das obras e o botão de favorito, representando a Lista de Favoritados do Usuário.

![image](https://github.com/user-attachments/assets/c59b7aa5-8505-452e-832c-62a66c1dbf4f)

- **Página das Obras Avaliadas**:
Página que inclui os posteres das obras e sua nota média, representada por estrelas, que permite vizualizar as obras avaliadas do Usuário.

![image](https://github.com/user-attachments/assets/9431423c-8d6f-43eb-867f-0b1340dfe062)

- **Painel das Obras**:
Modal de detalhes ao clicar em um filme, exibindo título, ano de lançamento, gênero, sinopse e sua nota, que permite ao Usuário favoritar e avaliar a obra selecionada, além de vizualizar quantos a favoritaram e o que outros Usuários comentaram sobre.

![image](https://github.com/user-attachments/assets/b5db64e8-0ca2-4da0-932b-1589dd37228f)


### Design Visual

Paleta de Cores:

Primária: Vermelho vinho (#B0333B) e bege (#F3D3AA), inspirados em baldes de pipoca e detalhes clássicos de salas de cinema.

Secundária: Tons de azul acinzentado (#4A6C6E) para fundos, junto ao preto (#1A1E1F) para simular a escuridão das salas, e amarelo (#C87C0C) para contrastes sutis.

Tipografia:

Fonte Instrument Serif, em itálico e negrito apenas nos menus e títulos, para legibilidade e impacto visual.

Elementos Gráficos:

Utilizamos ícones modestos e modernos, para reforçar a identidade visual da plataforma e ao mesmo tempo se comunicar com Usuário através de elementos já conhecidos.

São eles:
- Logo, símbolo da aplicação.
- Lupa, para referenciar a barra de pesquisa.
- Silhueta humana, para representar a área do Usuário.
- Coração, para favoritar as obras.
- Estrelas, para representação das notas atribuídas as obras.

Microinterações: Efeitos de sombra suave no fundo ao selecionar um filme, reminiscentes de refletores de cinema.

## Fluxo de Dados
![image](https://github.com/user-attachments/assets/9bd199aa-f1a6-464c-98aa-9236b97be3c5)
![image](https://github.com/user-attachments/assets/852bbd65-1968-4e8e-b4a0-cc37bb7fcac5)
![image](https://github.com/user-attachments/assets/545bfeaa-b0d5-4d5e-b1d4-cb601f36860b)
![image](https://github.com/user-attachments/assets/6cd678fc-e0e3-49e1-aece-c8d74376f05d)
![image](https://github.com/user-attachments/assets/3ad5eaac-f4f0-41b1-8d6b-d6ba4529640e)

## Tecnologias Utilizadas

[Lista das tecnologias principais que serão utilizadas no projeto.]

## Considerações de Segurança

[Discuta as considerações de segurança relevantes para a aplicação distribuída, como autenticação, autorização, proteção contra ataques, etc.]

## Implantação

# Requisitos de Software

1. Frontend (Reactive Native)
   - Expo CLI ou React Native CLI para gerar builds de Android e iOS.
   - Node.js (versão 16 ou superior).
   - Configuração de CORS no backend para permitir requisições no frontend.
  
2. Requisitos de Hardware (Reactive Native)
   - Para Android: Máquina com Android Studio instalado.
   - Para iOS: Mác com Xcode instalado (necessário para builds de iOS).

# Plataforma de hospedagem

  - Para a hospedagem mobile utilizaremos o provedor de Nuvem da AWS.
  - Servidor dedicado (AWS EC2).
  - Amazon RDS para gerenciar o banco de dados SQL server.
   

## Testes

[Descreva a estratégia de teste, incluindo os tipos de teste a serem realizados (unitários, integração, carga, etc.) e as ferramentas a serem utilizadas.]

1. Crie casos de teste para cobrir todos os requisitos funcionais e não funcionais da aplicação.
2. Implemente testes unitários para testar unidades individuais de código, como funções e classes.
3. Realize testes de integração para verificar a interação correta entre os componentes da aplicação.
4. Execute testes de carga para avaliar o desempenho da aplicação sob carga significativa.
5. Utilize ferramentas de teste adequadas, como frameworks de teste e ferramentas de automação de teste, para agilizar o processo de teste.

# Referências

# Sites

- https://pucminas.instructure.com/courses/155666
- https://docs.expo.dev/
- https://expo.dev/
- https://reactnative.dev/docs/getting-started
- https://m3.material.io/get-started
- https://www.w3schools.com/
- https://docs.aws.amazon.com/
