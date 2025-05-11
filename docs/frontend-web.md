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

![image](https://github.com/user-attachments/assets/a27ac164-faf6-4e1e-9cfa-f781011a5547)

 - **Página Filmes por gênero**:

Semelhante a Home, destaca as obras disponíveis na aplicação para avalização, porém às separando pelo seu gênero, possuindo também uma barra de pesquisa para localização de obras audiovisuais e/ou gêneros específicos.

![image](https://github.com/user-attachments/assets/d0cefb69-187c-4fe6-8c6a-483afdf164e9)

 - **Melhores Avaliados**:
Nessa aba o Usuário tem acesso as obras que possuem as melhores notas registradas na plataforma, ou seja, as melhores obras de acordo com outros usuários.

![image](https://github.com/user-attachments/assets/e7426fac-8e9c-4def-bb27-72a991e812e3)

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

![image](https://github.com/user-attachments/assets/306aadd3-fc21-4c10-8701-bc82f80a7e00)

- **Login de Usuário**:

Nessa página, o usuário consegue se conectar a aplicação para salvar suas informações (Obras avaliadas e/ou favoritadas), além de ter acesso a página de recuperação de senha.

![image](https://github.com/user-attachments/assets/2d5b1089-1390-4c01-84b9-112a4c2a86c4)

- **Nova Senha**:

Caso o Usuário tenha se esquecido de sua senha inicial, é possível definir uma nova através do fornecimento do E-mail cadastrado e uma nova senha para cadastro.

![image](https://github.com/user-attachments/assets/6a2185d6-2953-4527-82ec-f909b3a9a6e8)

- **Gestão de Perfil do Usuário**:

Mostra as informações cadastrais do Usuário (Nome completo, e-mail e nome de Usuário), além do histórico de obras avaliadas e/ou favoritadas, com a possibilidade de atualização dos dados ou exclusão da conta.

![image](https://github.com/user-attachments/assets/dfcc1cf8-ea6f-4310-a68e-3fccfa83b9fd)

- **Página das Obras Favoritas**:

Página que inclui os posteres das obras e o botão de favorito, representando a Lista de Favoritados do Usuário.

![image](https://github.com/user-attachments/assets/a4cd67c7-af0f-4694-93e6-63dd1fa2d73b)

- **Página das Obras Avaliadas**:

Página que inclui os posteres das obras e sua nota média, representada por estrelas, que permite vizualizar as obras avaliadas do Usuário.

![image](https://github.com/user-attachments/assets/8f47daa4-a661-466b-bc99-5e4212d68990)

- **Painel das Obras**:

Modal de detalhes ao clicar em um filme, exibindo título, ano de lançamento, gênero, sinopse e sua nota, que permite ao Usuário favoritar e avaliar a obra selecionada, além de vizualizar quantos a favoritaram e o que outros Usuários comentaram sobre.

![image](https://github.com/user-attachments/assets/07606711-9935-4246-92b1-11d86fda77b3)


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
| Campo                  | Valor                                                           |
| ---------------------- | ------------------------------------------------------------------------- |
| **Caso de teste**      | CT-RF004-01                                                               |
| **Pré-condição**       | Filme “Matrix Reloaded” cadastrado                                        |
| **Passos**             | 1. Abrir tela de busca<br>2. Digitar “Matrix”<br>3. Clicar em “Pesquisar” |
| **Dados de Entrada**   | termo = “Matrix”                                                          |
| **Resultado Esperado** | Lista com todos os filmes que têm “Matrix” no título                      |
| **Resultado Obtido**   | Retornou todos os filmes que contem "Matrix no título"                    |
| **Status**             | Passou                                                                    |
| **Observações**        | Tempo de resposta rápido.                                                 |

Screenshot CT-RF004-01 
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
| **Observações**        | Tempo de resposta rápido.                                                                            |

Screenshot CT-RF004-02
![image](https://github.com/user-attachments/assets/74e27565-aa04-43bd-9039-33a501442986)




[Descreva a estratégia de teste, incluindo os tipos de teste a serem realizados (unitários, integração, carga, etc.) e as ferramentas a serem utilizadas.]

1. Crie casos de teste para cobrir todos os requisitos funcionais e não funcionais da aplicação.
2. Implemente testes unitários para testar unidades individuais de código, como funções e classes.
3. Realize testes de integração para verificar a interação correta entre os componentes da aplicação.
4. Execute testes de carga para avaliar o desempenho da aplicação sob carga significativa.
5. Utilize ferramentas de teste adequadas, como frameworks de teste e ferramentas de automação de teste, para agilizar o processo de teste.

# Referências

**Código Fonte:**
- Front-end, disponível em: https://github.com/Paollaks/meu-frontend.git

**API de filmes para abastecimento do Banco de Dados:**
- The Movie Database (TMDB), disponível em: https://developer.themoviedb.org/reference/intro/getting-started
