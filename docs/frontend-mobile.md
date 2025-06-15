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
Página que inclui os cards das obras comentadas pelo usuário. Nessa página é possível pesquisar os filmes comentados por meio do campo de busca. Também é possível, ao clicar em um card, editar ou excluir o comentário. 

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

<!--[Lista das tecnologias principais que serão utilizadas no projeto.] -->
### Introdução

Para o desenvolvimento deste projeto mobile, nosso objetivo foi criar uma aplicação moderna, funcional e de fácil utilização. Adotamos ferramentas e tecnologias que proporcionam uma implementação eficiente, com foco na usabilidade e na experiência do usuário.

### Design da Interface

- **Figma**: Utilizado para elaborar os protótipos e definir a estrutura visual da aplicação. Essa ferramenta colaborativa permitiu uma organização clara das telas e uma melhor visualização do fluxo do aplicativo.

### Tecnologias

- **[Expo](https://snack.expo.dev/)**: Plataforma utilizada para facilitar o desenvolvimento e teste da aplicação mobile. O Expo permitiu criar e testar o aplicativo rapidamente, diretamente pelo navegador ou dispositivo, sem a necessidade de configurações nativas complexas.

- **JavaScript**: Linguagem principal usada na construção da aplicação, responsável tanto pela lógica de negócio quanto pela criação dos elementos da interface. Sua sintaxe simples e versatilidade tornam o processo de desenvolvimento mais ágil.

- **React Native**: Framework utilizado para desenvolver o aplicativo mobile. Ele permite criar aplicações nativas utilizando JavaScript e a biblioteca React. O código é compilado para componentes nativos reais, o que garante desempenho e aparência equivalentes aos apps desenvolvidos de forma nativa.
<!-- Esta seção ainda pode ser expandida com bibliotecas como Axios ou Context API -->

## Considerações de Segurança

<!--[Discuta as considerações de segurança relevantes para a aplicação distribuída, como autenticação, autorização, proteção contra ataques, etc.]-->

Para garantir a integridade dos dados e a privacidade dos usuários na aplicação de gerenciamento de filmes, serão adotadas medidas essenciais de segurança. A plataforma foi pensada para oferecer uma experiência segura, protegendo informações sensíveis e controlando o acesso aos recursos de forma eficiente, em conformidade com diretrizes da Lei Geral de Proteção de Dados Pessoais (LGPD).

- **Requisições HTTPS**: Garantem a confidencialidade e integridade das informações trocadas entre o frontend e a API.
- **Autenticação via JWT**: Permite um controle de acesso seguro, sem necessidade de sessões no servidor (autenticação sem estado).
- **Criptografia de senhas**: As credenciais dos usuários são protegidas com algoritmos de criptografia robustos, prevenindo vazamentos de informações sensíveis.

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
## Testes
Caso de Teste 1 – Tempo de resposta
| Campo                  | Valor                                                                                                                                                                 |
| ---------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Caso de teste**      | CT-RNF-001                                                                                                                                                            |
| **Requisito**          | RNF-001 – Tempo de resposta médio abaixo de 2 s para operações comuns                                                                                                 |
| **Pré-condição**       | API em staging com dados de filmes já populados                                                                                                                       |
| **Passos**             | 1. Abrir DevTools → aba Network<br>2. Filtrar por XHR/Fetch e limpar histórico<br>3. Realizar 5 buscas iguais a “Lilo & Stitch”<br>4. Anotar todos os valores da coluna Time |
| **Métrica**            | Média < 2000 ms; nenhum request acima de 3000 ms                                                                                                                      |
| **Resultado Esperado** | Média calculada abaixo de 2 s e 0 requisições acima de 3 s                                                                                                            |
| **Resultado Obtido**   | 1ª: 298 ms → 2ª: 416 ms → 3ª: 173 ms → 4ª: 309 ms → 5ª: 262 ms → Média: 291 ms; Máxima: 416 ms                                                                        |
| **Status**             | Passou                                                                                                                                                                |
| **Observações**        | JSON retornado em todas as requisições; sem erros de status; variação de tempo consistente.                                             

Screenshot Caso de Teste 1

![image](https://github.com/user-attachments/assets/14907b1b-ab1d-45ca-872a-51342bbb2701)

Caso de Teste 2 – Favoritar Filme
| Campo                  | Valor                                                                                                                                 |
| ---------------------- | ------------------------------------------------------------------------------------------------------------------------------------- |
| **Caso de teste**      | CT-FUNC-002                                                                                                                           |
| **Requisito**          | RF-005 – Usuário pode favoritar/desfavoritar um filme                                                                                 |
| **Pré-condição**       | Usuário autenticado no app; filme visível na tela                                                                                     |
| **Passos**             | 1. Abrir app na Home<br>2. Clicar no botão de coração do filme<br>3. Reabrir modal e verificar estado<br>4. Repetir para desfavoritar |
| **Métrica**            | Ícone deve mudar imediatamente; filme salvo em favoritos                                                                              |
| **Resultado Esperado** | Estado do ícone muda corretamente; ação persistida localmente ou na API                                                               |
| **Resultado Obtido**   | Ícone mudou corretamente ao favoritar/desfavoritar; porém, o filme não apareceu na tela de "Favoritos"                                 |
| **Status**             | Falhou                                                                                                                              |
| **Observações**        | A UI responde à ação, mas o estado não está sendo persistido corretamente (possível falha na API ou na renderização dos favoritos).   |

Screenshots Caso de teste 2

![image](https://github.com/user-attachments/assets/25b5f2d0-ec5b-4a7a-a134-2e1d3f3eaf98)
![image](https://github.com/user-attachments/assets/ac3cd3d2-fd14-479c-9b27-6701d0ab7168)



Caso de Teste 3 – Filme não encontrado por nome
| Campo                  | Valor                                                                                                                                                                    |
| ---------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| **Caso de teste**      | CT-FUNC-003                                                                                                                                                              |
| **Requisito**          | RF-002 – Sistema deve informar quando nenhum filme é encontrado por nome                                                                                                 |
| **Pré-condição**       | Aplicação iniciada com conexão ativa à API                                                                                                                               |
| **Passos**             | 1. Acessar a Home ou tela de busca<br>2. Digitar um termo inexistente, como “abcd78&”<br>3. Pressionar Enter ou tocar na lupa<br>4. Observar a resposta na interface |
| **Métrica**            | O app deve exibir uma mensagem clara de "Erro ao carregar filme. Nenhum resultado encontrado."                                                                                            |
| **Resultado Esperado** | Mensagem tipo “Erro ao carregar filme. Nenhum resultado encontrado.” visível na tela                                                                              |
| **Resultado Obtido**   | Mensagem exibida corretamente abaixo do campo de busca                                                                                                                   |
| **Status**             | Passou                                                                                                                                                                   |
| **Observações**        | Nenhum erro de requisição na aba Network; resposta vazia tratada corretamente na interface.                                                                          

Screenshot Caso de Teste 3

![image](https://github.com/user-attachments/assets/3104111b-4fb6-45be-a991-91344c83900c)

Caso de Teste 4 – Comentário em Filme
| Campo                  | Valor                                                                                                                                |
| ---------------------- | ------------------------------------------------------------------------------------------------------------------------------------ |
| **Caso de teste**      | CT-FUNC-004                                                                                                                          |
| **Requisito**          | RF-006 – Usuário pode comentar em um filme                                                                                           |
| **Pré-condição**       | Usuário autenticado; filme com modal aberto                                                                                          |
| **Passos**             | 1. Abrir modal de um filme<br>2. Digitar comentário no campo<br>3. Clicar em "Enviar Comentário"<br>4. Verificar se comentário aparece na lista |
| **Métrica**            | Comentário salvo e exibido corretamente                                                                                              |
| **Resultado Esperado** | Comentário aparece na lista logo após envio                                                                                          |
| **Resultado Obtido**   | Comentário visível na UI após envio; sem erros                                                                                       |
| **Status**             | Passou                                                                                                                               |
| **Observações**        | API respondeu com status 200; feedback visual positivo.                                                                              |

Screenshots Caso de teste 4

![image](https://github.com/user-attachments/assets/2eb9b93d-87f9-498d-98e5-8ac57b41347b)
![image](https://github.com/user-attachments/assets/de3df03b-56b4-4e2c-97c9-a62ba3b5586c)

Caso de Teste 5 – Busca por Filme
| Campo                  | Valor                                                                                                                 |
| ---------------------- | --------------------------------------------------------------------------------------------------------------------- |
| **Caso de teste**      | CT-FUNC-005                                                                                                           |
| **Requisito**          | RF-002 – Sistema permite buscar filmes por título                                                                     |
| **Pré-condição**       | App aberto; campo de busca visível                                                                                    |
| **Passos**             | 1. Digitar “Titanic” no campo de busca<br>2. Pressionar Enter ou clicar na lupa<br>3. Verificar a lista de resultados |
| **Métrica**            | Lista atualizada com filmes relacionados ao termo                                                                     |
| **Resultado Esperado** | Filmes com “Titanic” são exibidos na grade                                                                            |
| **Resultado Obtido**   | Resultado retornado corretamente com imagem e título                                                                  |
| **Status**             | Passou                                                                                                                |
| **Observações**        | Tempo de resposta 352 ms; sem erros na Network.                                                                       |

Screenshot Caso de teste 5

![image](https://github.com/user-attachments/assets/0ad5b238-1d58-4251-9dc1-f59173190204)

Caso de Teste 6 – Cadastro de Usuário

| Campo                  | Valor                                                                                                                                             |
| ---------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Caso de teste**      | CT-FUNC-006                                                                                                                                       |
| **Requisito**          | RF-001 – Sistema deve permitir que novos usuários se cadastrem                                                                                    |
| **Pré-condição**       | App aberto na tela de cadastro                                                                                                                    |
| **Passos**             | 1. Preencher nome completo, e-mail, senha e nome de usuário<br>2. Clicar em "Cadastrar"<br>3. Verificar se o redirecionamento para login acontece |
| **Métrica**            | Cadastro realizado e sem erros                                                                                                                    |
| **Resultado Esperado** | Redirecionamento para tela de login com mensagem de sucesso                                                                                       |
| **Resultado Obtido**   | Cadastro realizado e redirecionado corretamente                                                                                                   |
| **Status**             | Passou                                                                                                                                            |
| **Observações**        | Validação de campos e API funcionando normalmente.       

Screenshots Teste 6

![Captura de tela 2025-06-15 180729](https://github.com/user-attachments/assets/e6022666-8be3-4ab4-a457-6493b19674cf)
![Captura de tela 2025-06-15 181031](https://github.com/user-attachments/assets/f748f52f-2557-4e54-b39f-b4409fe92eb9)

Caso de Teste 7 – Efetuar Login
| Campo                  | Valor                                                                                                           |
| ---------------------- | --------------------------------------------------------------------------------------------------------------- |
| **Caso de teste**      | CT-FUNC-007                                                                                                     |
| **Requisito**          | RF-002 – Usuário deve conseguir fazer login                                                                     |
| **Pré-condição**       | Conta já cadastrada                                                                                             |
| **Passos**             | 1. Inserir e-mail e senha válidos<br>2. Clicar em "Entrar"<br>3. Verificar se redireciona para a página inicial |
| **Métrica**            | Redirecionamento + persistência de sessão                                                                       |
| **Resultado Esperado** | Login com sucesso e sessão iniciada                                                                             |
| **Resultado Obtido**   | Login efetuado e dados salvos com sucesso                                                                       |
| **Status**             | Passou                                                                                                          |
| **Observações**        | Cookies/token armazenados; sem erros visuais.                                                                   |

![image](https://github.com/user-attachments/assets/d1053bce-8196-47f5-be52-f68c834cf431)

Caso de Teste 8 – Login com senha incorreta
| Campo                  | Valor                                                                                                                                                             |
| ---------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Caso de teste**      | CT-FUNC-008                                                                                                                                                       |
| **Requisito**          | RF-002 – O sistema deve informar o usuário quando o login falhar por dados incorretos                                                                             |
| **Pré-condição**       | Usuário já cadastrado no sistema                                                                                                                                  |
| **Passos**             | 1. Acessar a tela de login<br>2. Inserir e-mail correto<br>3. Inserir senha incorreta<br>4. Clicar em "Entrar"<br>5. Observar a interface                         |
| **Métrica**            | O sistema deve exibir mensagem clara como "Senha incorreta" ou "Usuário ou senha inválidos"                                                                       |
| **Resultado Esperado** | Mensagem de erro exibida, impedindo acesso                                                                                                                        |
| **Resultado Obtido**   | Nenhuma mensagem é exibida; tela permanece inalterada mesmo após clicar em "Entrar"                                                                               |
| **Status**             | Falhou                                                                                                                                                        |
| **Observações**        | A requisição de login retorna erro (401) na aba Network, mas a interface não trata ou exibe esse retorno ao usuário. Usuário fica sem saber se houve erro ou não. |

Caso de Teste 9 – Redefinir senha
| Campo                  | Valor                                                                                                                                                                            |
| ---------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Caso de teste**      | CT-FUNC-009                                                                                                                                                                      |
| **Requisito**          | RF-003 – O sistema deve permitir redefinir a senha do usuário diretamente pelo site                                                                                              |
| **Pré-condição**       | Usuário acessa a tela "Redefinir Senha" com o campo de nova senha disponível                                                                                                     |
| **Passos**             | 1. Acessar a tela "Redefinir Senha"<br>2. Preencher o campo "Nova Senha" com um valor válido<br>3. Clicar no botão "Redefinir Senha"<br>4. Observar o comportamento da interface |
| **Métrica**            | Sistema deve exibir uma mensagem de sucesso ou erro, e redirecionar ou bloquear ações conforme necessário                                                                        |
| **Resultado Esperado** | Mensagem do tipo “Senha redefinida com sucesso” ou “Erro ao redefinir senha” deve ser exibida                                                                                    |
| **Resultado Obtido**   | Nada acontece visualmente após o clique; nenhum feedback, redirecionamento ou mensagem aparece na tela                                                                           |
| **Status**             | **Falhou**                                                                                                                                                                       |
| **Observações**        | A requisição possivelmente não está sendo disparada ou o retorno não está sendo tratado. A ausência de resposta deixa o usuário sem saber se a senha foi redefinida.         

Caso de Teste 10 – Edição de Perfil

| Campo                  | Valor                                                                                                                             |
| ---------------------- | --------------------------------------------------------------------------------------------------------------------------------- |
| **Caso de teste**      | CT-FUNC-010                                                                                                                      |
| **Requisito**          | RF-004 – Usuário pode editar nome completo e nome de usuário                                                                      |
| **Pré-condição**       | Usuário logado na tela de perfil                                                                                                  |
| **Passos**             | 1. Alterar os campos de nome e nome de usuário<br>2. Clicar em "Salvar"<br>3. Verificar se valores foram atualizados na interface |
| **Métrica**            | Dados atualizados corretamente e persistência local/na API                                                                        |
| **Resultado Esperado** | Feedback de sucesso + dados atualizados                                                                                           |
| **Resultado Obtido**   | Dados alterados e atualizados na tela                                                                                             |
| **Status**             | Passou                                                                                                                            |
| **Observações**        | API respondeu com 200; edição refletida sem recarregar a tela.                                                                    |


![Captura de tela 2025-06-15 182610](https://github.com/user-attachments/assets/ccc86398-140e-4006-b2be-92a0ee6ddc59)
![image](https://github.com/user-attachments/assets/778ab7d6-1d51-47c4-a42b-6ea8ba40e921)


Caso de Teste 11 – Buscar por Gênero
| Campo                  | Valor                                                                                               |
| ---------------------- | --------------------------------------------------------------------------------------------------- |
| **Caso de teste**      | CT-FUNC-011                                                                                         |
| **Requisito**          | RF-008 – Sistema permite listar filmes por gênero                                                   |
| **Pré-condição**       | Tela de "Filmes por Gênero" acessada                                                                |
| **Passos**             | 1. Expandir uma seção de gênero (ex: Ação)<br>2. Verificar se os filmes daquele gênero são exibidos |
| **Métrica**            | Lista deve aparecer em até 2 segundos                                                               |
| **Resultado Esperado** | Filmes relacionados ao gênero exibidos corretamente                                                 |
| **Resultado Obtido**   | Listagem por gênero funcional e precisa                                                             |
| **Status**             | Passou                                                                                              |
| **Observações**        | Seção recolhível está funcionando corretamente também.                                              |

Screenshot caso de teste 11

![image](https://github.com/user-attachments/assets/dcbc7f4c-0932-427f-b295-28323d1fbd85)
![image](https://github.com/user-attachments/assets/c059615f-4bc8-4791-812e-f33ed86f5077)

Caso de Teste 12 – Ver Melhores Avaliados
| Campo                  | Valor                                                                                                |
| ---------------------- | ---------------------------------------------------------------------------------------------------- |
| **Caso de teste**      | CT-FUNC-012                                                                                          |
| **Requisito**          | RF-009 – Sistema mostra filmes com melhores notas                                                    |
| **Pré-condição**       | Tela específica com essa listagem                                                         |
| **Passos**             | 1. Verificar se a seção "Melhores Avaliados" está visível<br>2. Conferir as notas e títulos exibidos |
| **Métrica**            | Lista ordenada por nota decrescente                                                                  |
| **Resultado Esperado** | Filmes com maiores notas no topo                                                                     |
| **Resultado Obtido**   | Lista em ordem correta                                                                               |
| **Status**             | Passou                                                                                               |
| **Observações**        | Notas e valores renderizados corretamente.                                                        |

Screenshot caso de teste 12

![image](https://github.com/user-attachments/assets/4c098274-4a41-427f-8a28-8b1753d1d135)
![Captura de tela 2025-06-15 190455](https://github.com/user-attachments/assets/8a565dfc-5b24-41f7-9051-4519ba33dbbb)


# Referências

# Código Fonte

- App Avaliação de Obras: [avaliacao-de-obras-.zip](https://github.com/user-attachments/files/20747733/avaliacao-de-obras-.zip)

# Sites

- https://pucminas.instructure.com/courses/155666
- https://docs.expo.dev/
- https://expo.dev/
- https://reactnative.dev/docs/getting-started
- https://m3.material.io/get-started
- https://www.w3schools.com/
- https://docs.aws.amazon.com/
