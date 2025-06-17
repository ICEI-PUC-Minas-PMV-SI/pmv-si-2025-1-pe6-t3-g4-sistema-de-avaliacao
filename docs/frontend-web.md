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

![image](https://github.com/user-attachments/assets/2f1132a4-e796-4242-a5dc-5aae3721102d)

 - **Página Filmes por gênero**:

Semelhante a Home, destaca as obras disponíveis na aplicação para avalização, porém às separando pelo seu gênero, possuindo também uma barra de pesquisa para localização de obras audiovisuais e/ou gêneros específicos.

![image](https://github.com/user-attachments/assets/010535af-89d6-45fb-91cd-677b374c9a98)

 - **Melhores Avaliados**:
Nessa aba o Usuário tem acesso as obras que possuem as melhores notas registradas na plataforma, ou seja, as melhores obras de acordo com outros Usuários do TMDB.

![image](https://github.com/user-attachments/assets/17385c8b-0ac6-44f7-ab12-68529a3f6166)

- **Painel do Usuário**:

A aba do Usuário possuí 4 opções de páginas para acesso do Usuário, sendo elas:

  - Perfil, referente a página de gestão dos dados do Usuário.
  - Avaliações, onde ficam as obras avaliadas por esse Usuário.
  - Favoritados, onde ficam as obras favoritadas por esse Usuário.
  - Desconectar, opção para desconectar a conta da aplicação (Sign Out).

![image](https://github.com/user-attachments/assets/78059948-76dc-404a-befe-428e74c4fc6d)

- **Criação Usuário**:

Caso o usuário não possua uma conta, ele concegue acessar a página para cadastro pela aba Perfil, disponível no painel do Usuário, que também sera o caminho a ser seguido para se conectar (Login) a aplicação.
Para criar um novo Usuário, é necessário fornecer um E-mail, uma senha, nome completo e nome de usuário (visível em suas avaliações para os outros Usuários).

![image](https://github.com/user-attachments/assets/6c1c290d-d316-4df7-9b56-0de2cdbe0cb5)

- **Login de Usuário**:

Nessa página, o usuário consegue se conectar a aplicação para salvar suas informações (Obras avaliadas e/ou favoritadas), além de ter acesso a página de recuperação de senha.

![image](https://github.com/user-attachments/assets/71c8716a-719c-46f4-b3b4-d0d9792ca602)

- **Nova Senha**:

Caso o Usuário tenha se esquecido de sua senha inicial, é possível definir uma nova através do fornecimento do E-mail cadastrado e uma nova senha para cadastro.

![image](https://github.com/user-attachments/assets/3c42a78d-9605-4c00-8fd4-04d2d820d8c2)

- **Gestão de Perfil do Usuário**:

Mostra as informações cadastrais do Usuário (Nome completo, e-mail e nome de Usuário), além do histórico de obras avaliadas e/ou favoritadas, com a possibilidade de atualização dos dados ou exclusão da conta.

![image](https://github.com/user-attachments/assets/95c8def2-d313-4eb9-ae07-cb1a54219e8c)

- **Página das Obras Favoritas**:

Página que inclui os posteres das obras e o botão de favorito, representando a Lista de Favoritados do Usuário.

![image](https://github.com/user-attachments/assets/a6bb363d-c949-4859-a219-abd3aa888974)

- **Página das Obras Avaliadas**:

Página que inclui os posteres das obras e sua nota média, representada por estrelas, que permite vizualizar as obras avaliadas do Usuário.

![image](https://github.com/user-attachments/assets/bdb01064-debc-419b-8a68-11a4e8878231)

- **Painel das Obras**:

Modal de detalhes ao clicar em um filme, exibindo título, ano de lançamento, gênero, sinopse e sua nota, que permite ao Usuário favoritar e avaliar a obra selecionada, além de vizualizar quantos a favoritaram e o que outros Usuários comentaram sobre.

![image](https://github.com/user-attachments/assets/4f0afa67-def3-45fe-b6d2-b387a31f0cff)


<!-- - **Perfil Público do Usuário**: -->

<!-- Nesta página o Usuário tem acesso ao "Nome de Usuário" de outras contas, assim como suas listas de obras avaliadas e favoritadas, sendo possível seguí-lo para acompanhar seu perfil. -->

<!-- - **Perfis Seguidos**: -->

<!-- O Usuário pode acompanhar seus perfis seguidos e suas listas criadas através dessa página, tendo como pesquisar por um perfil específico pela barra de pesquisa. -->

### Design Visual

- Paleta de Cores:

Para a paleta de cores escolhemos tons de vermelho, amarelo e bege, inspirados na coloração dos baldes de pipocas e no ambiente acolhedor das salas de cinema, e para gerar contrastes sutis definimos a cor preta e um azul escuro esverdeado, evocando a sensação de quando o telão é ligado, refletindo brilho nas poltronas e nas pessoas.

Os códigos hexadecimais referente as cores utilizadas são:

  - B0333B, para o vermelho.
  - C87C0C, para o amarelo.
  - F3D3AA, para o bege.
  - 1A1E1F, para o preto.
  - 4A6C6E, para o azul.

- Tipografia 
Para tipografia, focamos em algo limpo e legível, com a fonte Instrument Serif, para que seja acessível em diferentes dispositivos, tornando a leitura suave e direta.

- Elementos Gráficos:

Os Ícones utilizados são simples, usados de forma discreta para reforçar a identidade visual da plataforma e ao mesmo tempo se comunicar com Usuário através de elementos já conhecidos.

São eles:
- Logo, símbolo da aplicação.
- Lupa, para referenciar a barra de pesquisa.
- Silhueta humana, para representar a área do Usuário.
- Coração, para favoritar as obras.
- Estrelas, para representação das notas atribuídas as obras.

Com efeitos de transição suaves entre as telas, simulando o fade-in e fade-out de projeções cinematográficas.


## Fluxo de Dados

![image](https://github.com/user-attachments/assets/fb3fe2de-6107-4bc5-8e25-82a00c1f9090)
![image](https://github.com/user-attachments/assets/f48df881-dd53-45d7-974b-7a260c36f3ea)
![image](https://github.com/user-attachments/assets/0ba47b33-6751-4ea6-9bbf-0f939d23af76)
![image](https://github.com/user-attachments/assets/3676fc21-dc90-44b2-91e3-1d7c05eea622)
![image](https://github.com/user-attachments/assets/ee4ab3ab-b2ef-4f13-b550-befe897335f1)


## Diagrama Entidade-Relacionamento (ER)

![image](https://github.com/user-attachments/assets/049ecbc5-4478-4688-a91c-0240e4e19cc3)

## Tecnologias Utilizadas

- Visual Studio Code, para desenvolvimento.
- HTML, CSS e JavaScript, utilizados no Front-End.
- Flaticon, para dowload dos ícones presentes na plataforma.


## Considerações de Segurança

Garantir a segurança e privacidade dos dados na plataforma é prioritário, por isso o sistema foi desenvolvido com medidas robustas para proteger informações confidenciais dos usuários, sendo a seguinte fundamental:

- Uso de requisições HTTPS para garantir comunicação segura: toda a troca de dados entre o frontend e a API será feita via protocolo HTTPS, assegurando a confidencialidade e integridade das informações transmitidas.
- Uso de JWT para autenticação sem estado e garantia da integridade das requisições.

## Implantação

Para a implantação utilizando Windows e os serviços da AWS, foram escolhidos os requisitos:

Requisitos de Hardware
Máquina virtual vCPUs.

Memória: Pelo menos 4 GB de RAM.

Armazenamento de disco: 20GB.

Requisitos de Software
Sistema operacional: Microsoft Windows Server 2019.

.NET SDK: .NET 8.

Servidor Web: IIS (Windows).

Banco de Dados: Amazon RDS(SQL Server).

Hospedagem
A hospedagem será feita pelo uso da Amazon EC2 (Elastic Computer Cloud) da AWS.

## Testes
Testes realizados utilizando os retornos através do Network Panel das DevTools no navegador Chrome.
Testes de integração de API

**Caso de teste : Requisito Funcional: Permitir que os usuários acessem a plataforma via login e senha**
| Campo                  | Valor                                                           |
| ---------------------- | ------------------------------------------------------------------------- |
| **Caso de teste**      | CT-RF001-01                                                               |
| **Pré-condição**       | Usuário previamente cadastrado com email = “paollaks@hotmail.com” e senha = “Ace456$”                                        |
| **Passos**             | 1. Acessar a tela/API de login<br>2. Digitar email = “paollaks@hotmail.com”<br>3. Digitar senha = “Ace456$” |
| **Dados de Entrada**   | 1. email = “paollaks@hotmail.com”<br>2. senha = “Ace456$”                                                          |
| **Resultado Esperado** | 200 OK; retorno de JSON com token (JWT) e dados do usuário: id, nome e email                      |
| **Resultado Obtido**   | Usuário conectado com sucesso                  |
| **Status**             | Passou                                                                    |
| **Observações**        | Redirecionamento para Home após Login

**Teste Login**
![image](https://github.com/user-attachments/assets/975b33b4-829b-4699-9261-8c51967df0f2)



**Caso de teste : Permitir que os usuários recuperem sua senha**
| Campo                  | Valor                                                           |
| ---------------------- | ------------------------------------------------------------------------- |
| **Caso de teste**      | CT-RF001-02                                                               |
| **Pré-condição**       | Usuário previamente cadastrado com email = “laura@example.com” e senha = “1235”                                        |
| **Passos**             | 1. Acessar a tela/API de login e selecionar a opção "Esqueceu a senha?"<br>2. Digitar email = “laura@example.com”<br>3. Digitar uma nova senha = “1234” |
| **Dados de Entrada**   | 1. email = “laura@example.com”<br>2. nova senha = “1234”                                                          |
| **Resultado Esperado** | 200 OK; retorno de JSON com token (JWT) e dados do usuário: email e nova senha                      |
| **Resultado Obtido**   | Senha atualizada com sucesso                  |
| **Status**             | Passou                                                                    |
| **Observações**        | Redirecionamento para tela de Login

**Teste Renovar Senha**
![image](https://github.com/user-attachments/assets/9b8cb5b6-49cb-4894-9734-a797ec924814)



**Caso de teste : Permitir que novos usuários se cadastrem**
| Campo                  | Valor                                                           |
| ---------------------- | ------------------------------------------------------------------------- |
| **Caso de teste**      | CT-RF001-03                                                               |
| **Pré-condição**       | Usuário fornece seus dados: Nome Completo, email, senha e Nome de Usuário                                        |
| **Passos**             | 1. Acessar a tela/API de login e selecionar a opção "É sua primeira vez aqui?"<br>2. Digitar dados existentes<br>3. |
| **Dados de Entrada**   | 1. Nome Completo = "Laura Rocha"<br>2. email = “laural@example.com”<br>3. senha = “1236”<br>4. Nome de Usuário = LauraRocha    |
| **Resultado Esperado** | 200 OK; retorno de JSON com token (JWT) e dados do usuário: id, nomeCompleto, nomeDeUsuario, email e senha                    |
| **Resultado Obtido**   | Cadastro realizado com sucesso                  |
| **Status**             | Passou                                                                    |
| **Observações**        | Redirecionamento para Home

**Teste Cadastro de Usuário**
![image](https://github.com/user-attachments/assets/ffa9e0da-c178-4fb3-9ab8-98b173f51b6e)



**Caso de teste : Requisito Funcional: Permitir que os usuários favoritem obras**
| Campo                  | Valor                                                           |
| ---------------------- | ------------------------------------------------------------------------- |
| **Caso de teste**      | CT-RF002-01                                                               |
| **Pré-condição**       | Usuário autenticado e filme cadastrado no sistema                                        |
| **Passos**             | 1. Acessar seção/API que exibam obras<br>2. Selecionar o filme com id = 254<br>3. Clicar no ícone de coração para “Adicionar aos Favoritos” |
| **Dados de Entrada**   | 1. IdUsuario = 6<br>2. IdFilme = 254                                                          |
| **Resultado Esperado** | 200 OK; retorno da mensagem "Filme adicionado aos favoritos!"                      |
| **Resultado Obtido**   | Retornou Filme adicionado aos favoritos!                     |
| **Status**             | Passou                                                                    |
| **Observações**        | Confirmação visual no front-end, presença do favorito na lista do usuário.

**Teste Favoritar Obras**
Filme adicionado a tela de "Favoritadas" do usuário. ![image](https://github.com/user-attachments/assets/479bc6e5-a15d-4188-9d19-fc7d738dab44)



**Caso de teste : Requisito Funcional: Permitir que os usuários avaliem obras audiovisuias através de comentários.**
| Campo                  | Valor                                                           |
| ---------------------- | ------------------------------------------------------------------------- |
| **Caso de teste**      | CT-RF003-01                                                               |
| **Pré-condição**       | Usuário autenticado e filme cadastrado no sistema                                        |
| **Passos**             | 1. Acessar a tela/API que exibam obras<br>2. Preencher campo texto com comentário válido<br>3. Clicar em “Salvar” |
| **Dados de Entrada**   | 1. IdUsuario = 6<br>2. TMDBFilmeId = 986056<br>3. Texto = “Muito bom!”                                                          |
| **Resultado Esperado** | 201 Created; retorno de JSON com campos id do comentário, texto, idUsuario e tmdbFilmeId                      |
| **Resultado Obtido**   | Retornou JSON com id = 3, texto = “Muito bom!”, idUsuario = 1 e tmdbFilmeId = 986056                    |
| **Status**             | Passou                                                                    |
| **Observações**        | Comentário aparece imediatamente na lista de comentários da obra; tempo de resposta < 500 ms.                           |

**Teste Comentar Obras**
Fazendo o comentário. ![image](https://github.com/user-attachments/assets/f5aa2655-671a-4f26-8995-72891783df01)

Comentario salvo com sucesso. ![image](https://github.com/user-attachments/assets/96ac262e-2169-4854-8c4f-2a9ff213719f)



**Caso de teste : Permitir que os usuários editem suas avaliações.**
| Campo                  | Valor                                                           |
| ---------------------- | ------------------------------------------------------------------------- |
| **Caso de teste**      | CT-RF003-02                                                               |
| **Pré-condição**       | Usuário autenticado e filme cadastrado no sistema                                        |
| **Passos**             | 1. Acessar a tela/API de obras Avaliadas<br>2. Selecionar a obra que deseja editar o comentário e clicar em "Editar"<br>3. Preencher campo texto com um novo comentário válido<br>3. Clicar em “Ok” |
| **Dados de Entrada**   | 1. IdUsuario = 6<br>2. TMDBFilmeId = 986056<br>3. Texto = “Muito bom mesmo!”                                                          |
| **Resultado Esperado** | 200 OK; retorno da mensagem "Comentário atualizado!"                      |
| **Resultado Obtido**   | Retornou "Comentário atualizado!"                    |
| **Status**             | Passou                                                                    |
| **Observações**        | Comentário atualizado aparece imediatamente na lista de comentários da obra; tempo de resposta < 300 ms.                           |

**Teste Editar Comentário**
Atualizando o comentário.![image](https://github.com/user-attachments/assets/26af3cfb-4572-410b-8c83-e9bca33106d6)

Comentário atualizado.![image](https://github.com/user-attachments/assets/8d46e93a-7fe9-42e9-8ba3-77ffa020ba91)



**Caso de teste : Permitir que os usuários excluam suas avaliações**
| Campo                  | Valor                                                           |
| ---------------------- | ------------------------------------------------------------------------- |
| **Caso de teste**      | CT-RF003-03                                                               |
| **Pré-condição**       | Usuário autenticado e filme cadastrado no sistema                                        |
| **Passos**             | 1. Acessar a tela/API de obras Avaliadas<br>2. Selecionar a obra que deseja excluir o comentário e clicar em "Excluir"<br>3. Clicar em “Ok” no alerta "Deseja realmente excluir o comentário?" |
| **Dados de Entrada**   | 1. IdUsuario = 6<br>2. TMDBFilmeId = 986056<br>3. Texto = “Muito bom mesmo!”                                                          |
| **Resultado Esperado** | 200 OK; retorno da mensagem "Comentário excluído!"                     |
| **Resultado Obtido**   | Retornou "Comentário excluído!"                     |
| **Status**             | Passou                                                                    |
| **Observações**        | Comentário é imediatamente excluido e obra saí da lista de Avaliadas; tempo de resposta < 220 ms.                           |

**Teste Excluir Comentário**
Comentário sendo excluído.![image](https://github.com/user-attachments/assets/808eae40-3c9f-4d0e-9b31-c239dacd08ae)

Confirmação da exclusão.![image](https://github.com/user-attachments/assets/de0f634d-5d73-4814-9df8-3259eeccdd4d)

Tela de obras Avaliadas vazia.![image](https://github.com/user-attachments/assets/943307c3-f666-47f1-bceb-fc2b383c8e02)



**Caso de teste : Requisito Funcional: Permitir busca de obras através de mecanismo de pesquisa.**
| Campo                  | Valor                                                           |
| ---------------------- | ------------------------------------------------------------------------- |
| **Caso de teste**      | CT-RF004-01                                                               |
| **Pré-condição**       | Filme “Matrix Reloaded” cadastrado                                        |
| **Passos**             | 1. Abrir tela de busca<br>2. Digitar “Matrix”<br>3. Clicar em “Pesquisar” |
| **Dados de Entrada**   | termo = “Matrix”                                                          |
| **Resultado Esperado** | Lista com todos os filmes que têm “Matrix” no título                      |
| **Resultado Obtido**   | Retornou todos os filmes que contem "Matrix no título"                    |
| **Status**             | Passou                                                                    |
| **Observações**        | Filme aparece imediatamente na tela. Tempo de resposta < 214 ms.                                                 |

**Teste de Busca** 
![image](https://github.com/user-attachments/assets/adcfc87c-2791-461b-9025-dfe7fd6a07f3)



| Campo                  | Valor                                                                                  |
| ---------------------- | --------------------------------------------------------------------------------------------------- |
| **Caso de teste**      | CT-RF004-02                                                                                         |
| **Pré-condição**       | Não existe nenhum filme com o termo “XYZ123” cadastrado no banco de dados                           |
| **Passos**             | 1. Acessar a tela/API de busca<br>2. Digitar “XYZ123” no campo de busca<br>3. Clicar em “Pesquisar” |
| **Dados de Entrada**   | termo = “XYZ123”                                                                                    |
| **Resultado Esperado** | Retorno 200 OK com lista vazia (`[]`) e/ou mensagem “Erro ao carregar filmes”                       |
| **Resultado Obtido**   | Retornou mensagem "Erro ao carregar filmes"                                                         |
| **Status**             | Passou                                                                                              |
| **Observações**        | Tempo de resposta rápido.                                                                           |

**Teste de Busca**
![image](https://github.com/user-attachments/assets/74e27565-aa04-43bd-9039-33a501442986)



**Caso de teste : Requisito Não Funcional: Tempo de resposta médio abaixo de 2 segundos para operações comuns**
| Campo                  | Valor                                                                                                                                                                          |
| ---------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| **Caso de teste**      | CT-RNF-001                                                                                                                                                                     |
| **Requisito**          | RNF-001 – Tempo de resposta médio abaixo de 2 s para operações comuns                                                                                                          |
| **Pré-condição**       | API em staging com dados de filmes já populados                                                                                                                                |
| **Passos**             | 1. Abrir DevTools → aba **Network**<br>2. Filtrar por XHR/Fetch e limpar histórico<br>3. Realizar 5 buscas iguais a “Matrix”<br>4. Anotar todos os valores da coluna **Time** |
| **Métrica**            | Média < 2000 ms; nenhum request acima de 3000 ms                                                                                                                               |
| **Resultado Esperado** | Média calculada abaixo de 2 s e 0 requisições acima de 3 s                                                                                                                     |
| **Resultado Obtido**   | 1ª execução: 249 ms → 2ª execução: 165 ms → 3ª execução: 211 ms → 4ª execução: 186 ms → 5ª execução: 492 ms → Média final: 261 ms; máxima: 492 ms                                                                                             |
| **Status**             | Passou                                                                                                                                                                         |
| **Observações**        | JSON retornado em todas as requisições; sem erros de status; variação de tempo consistente.                                                              |


# Referências

**Código Fonte:**
- Front-end, disponível em: https://github.com/Paollaks/meu-frontend.git

**API de filmes para abastecimento do Banco de Dados:**
- The Movie Database (TMDB), disponível em: https://developer.themoviedb.org/reference/intro/getting-started
