# Introdução

Com o crescimento das plataformas de streaming e o fácil acesso a uma grande variedade de filmes, os espectadores têm mais opções do que nunca. No entanto, essa abundância de conteúdo também pode tornar a escolha do que assistir uma tarefa desafiadora, especialmente sem uma fonte confiável de avaliações e recomendações. Diante desse cenário, este projeto propõe o desenvolvimento de um sistema de avaliação de obras cinematográgicas, permitindo que os usuários compartilhem suas opiniões e descubram novas recomendações personalizadas.

O objetivo é criar uma plataforma intuitiva e acessível, onde qualquer pessoa possa avaliar obras e encontrar sugestões alinhadas aos seus gostos. A justificativa para a criação deste sistema está na necessidade de oferecer um espaço centralizado para avaliações confiáveis, tornando a escolha de um filme mais prática e agradável. O sistema busca atender tanto aqueles que desejam opinar sobre filmes e séries que assistiram quanto aqueles que procuram recomendações confiáveis para decidir o que ver.

## Problema

A proposta do projeto é proporcionar uma experiência mais precisa e satisfatória ao usuário, facilitando sua escolha de filmes, séries e programas de acordo com suas preferências individuais. e fornecendo um site confiável, com avaliações sinceras e uma comunidade ativa.

A plataforma foi estruturada de maneira a fornecer um ambiente personalizado, onde o usuário tem a liberdade de navegar e encontrar obras para comentar e favoritar. Além disso, nossa intenção é garantir um ambiente online seguro, no qual as avaliações e classificações sejam expressas de forma genuína e transparente, permitindo que os usuários tomem decisões assertivas.

Assim, buscamos não apenas fornecer recomendações precisas, mas também criar um espaço de interação e descoberta de novos conteúdos, que proporcionem uma experiência mais agradável e personalizada para cada usuário.

## Objetivos

De modo a atender ao público descrito, o objetivo deste trabalho é construir um sistema distribuído com interfaces em desktop e mobile para avaliação de filmes e séries. O aplicativo contará com um recurso que permitirá ao usuário criar, atualizar, consultar, e deletar as suas avaliações.

## Objetivos específicos


- Construi um sistema Back-end para hospedar uma API de avaliações de filmes.

- Desenvolver uma aplicação web e móvel que ofereça:
  - Obras audiovisuais mais populares no momento.
  - Obras com melhores avaliações.
  - Permitir que o usuario favorite uma obra.
  - Espaço para que o usuário comente as obras por meio de texto.
  - Desenvolver uma pagina que exiba filmes filtrados por gênero.


## Justificativa

A concepção deste projeto surgiu a partir do nosso interesse pessoal e do contato frequente com serviços de streaming durante o tempo livre. No cenário atual, a grande maioria, se não a totalidade, das produções audiovisuais de nosso interesse está disponível em alguma plataforma online, abrangendo desde novelas clássicas até filmes recém-lançados. No entanto, apesar da vasta oferta de conteúdo, há uma dificuldade comum enfrentada pelos usuários na hora de selecionar o que assistir. Esse fenômeno ocorre tanto pela abundância de opções quanto pelo excesso de informações apresentadas nas interfaces dessas plataformas, o que frequentemente resulta em uma demora significativa no processo de escolha, mesmo quando já se tem uma ideia do tipo de conteúdo desejado.

De acordo com um estudo realizado pelo instituto Reelgood em parceria com a Learndipity Data Insights, foi estimado que o tempo médio que os usuários permanecem navegando no Netflix até decidirem o que assistir é de 18 minutos. Esse tempo é duas vezes maior do que o tempo que os assinantes de televisão por assinatura costumam levar para escolher um canal para assistir. Esse dado ilustra claramente o impacto que a sobrecarga de opções pode ter na experiência do usuário, sugerindo a necessidade de uma ferramenta mais eficiente para auxiliar na escolha do conteúdo, tornando o processo mais ágil e assertivo.

## Público-Alvo

O software é voltado para usuários que buscam sugestões personalizadas de obras audiovisuais de forma rápida e eficiente. O público-alvo inclui:

- Cinéfilos que desejam recomendações detalhadas e baseadas em suas preferências.

- Casais e famílias que querem sugestões compatíveis com diferentes gostos.

- Usuários de streaming que buscam otimizar suas escolhas.

- Fãs de gêneros específicos como terror, ficção científica e clássicos.

- Indecisos que costumam demorar para escolher um filme e precisam de sugestões diretas.


O objetivo é oferecer uma experiência intuitiva e personalizada, facilitando a escolha da próxima obra a ser assistida.

## Diagramas de Personas
Diagramas de personas são representações visuais de personagens fictícias que sintetizam as características, comportamentos, necessidades e objetivos de um grupo de usuários. Com base nelas, conseguiremos compreender e focar no público-alvo durante o desenvolvimento da aplicação.

1.
![persona 3](https://github.com/user-attachments/assets/805d3308-c1f1-423a-b34a-8434de321f29)

2.
![Persona 2](https://github.com/user-attachments/assets/f2b47951-41ca-47a8-ad15-60163a2b7275)

3.
![persona 1](https://github.com/user-attachments/assets/5dc74172-575f-4e11-a162-7580281bf101)


# Especificações do Projeto

## Requisitos

Nesta seção, estão listados os requisitos funcionais e não funcionais do sistema, que detalham o escopo do projeto e as funcionalidades que devem ser implementadas.

### Requisitos Funcionais

|ID    | Descrição do Requisito                                      | Prioridade | Responsável |
|------|-------------------------------------------------------------|------------|-------------|
|RF-001| Permitir que os usuários acessem a plataforma via login e senha        | ALTA       | LAURA E CARLOS |      
|RF-002| Permitir que os usuários favoritem obras | ALTA       | PAOLLA  |
|RF-003| Permitir que os usuários avaliem obras audiovisuias através de comentários    | ALTA       | THIAGO  |
|RF-004| Permitir busca de obras através de mecanismo de pesquisa                                       | ALTA       | JUSSARA  |


### Requisitos não Funcionais

|ID     | Descrição do Requisito                                          | Prioridade |
|-------|---------------------------------------------------------------|------------|
|RNF-001| Tempo de resposta médio abaixo de 2 segundos para operações comuns | ALTA       |
|RNF-002| Interface intuitiva e responsiva                                | ALTA       |
|RNF-003| Portabilidade para celulares                                | BAIXA       |

<!--
Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

// marcação -->
## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |

# Catálogo de Serviços

  - **Registro de usuários com autenticação via login e senha**: Permite aos usuários se cadastrarem e terem suas preferências salvas disponiveis a qualquer momento e com segurança.
   
  - **Lista personalizada de Favoritos**: Dá ao usuário a possibilidade de criar uma lista das suas obras favoritas.
   
  - **Avaliação de filmes com comentários**: Permite aos usuários expressarem de forma qualitativa sua opinião sobre obras audiovisuias.
   
  - **Mecanismo de pesquisa**: Possibilita aos usuários encontrar filmes, séries e programas de forma mais prática e rápida filtrando por diversos aspectos das obras.
   
  - **Recomendações de obras melhores avaliadas**: Auxilia o usuário no processo de escolha de títulos para assistir, expandindo suas possibilidades e evitando o tédio.
   
  - **Cripitografia para armazenamento de senhas**: Mais segurança para os dados dos usuários.
   
  - **Interface responsiva**: A ferramenta é compatível com os ambientes mobile e desktop.

  - **Proteção contra ataques**: Os dados e informações sensíveis dos usuários ficam protegidos.

<!-- **Sugestões de acordo com amigos seguidos**: São sugeridas obras de acordo com os perfis dos amigos que o usuário segue. -->
<!-- **Seguir e ser seguido por outros usuários**: Cria um ambiente propício para interações e novas amizades estreitando relações e o sentimento de comunidade. -->
<!-- **Grande número de usuários ao mesmo tempo**: Possibilita vários usuários utilizarem os serviços ao mesmo tempo. -->
<!-- **Disponibilidade 80% do tempo**: O sistema ficará estavel e sem interrupções a maior parte do tempo. -->

# Arquitetura da Solução

**1. FRONT-END WEB**: Interface com a qual os usuários interagirão ao utilizarem a ferramenta.

**2. APLICATIVO MOBILE**: Permite a utilização da ferramenta de forma acessível e prática. Garantindo que os usuários possam ter mais liberdade de locomoção.

**3. API E BACK-END**: Mecanismo que permitirá a comunicação entre os componentes da ferramenta e o armazenamento dos dados da plataforma.


![arq](https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2025-1-pe6-t3-g4-sistema-de-recomendacao/blob/main/docs/img/arquitetura.jpg)


## Tecnologias Utilizadas


Para a construção da aplicação as tecnologias da aplicação serão:

### IDE 
Visual Studio 2022.

### Banco de dados 
SQL Server.

### Linguagem Back-end
C#.

### Linguagem Front-end 
Javascript, html e css.

### Frameworks utilizados 
ASP.NET Core web api - Para fazer a construção da API rest.

Entity Framework Core - para modelagem do BD.

React - Para a construção das páginas e para o consumo da API.

### Bibliotecas
JSON Web Token - Para fazer a autenticação e autorização dos usuários com tokens.

### Ferramentas de teste da API:
Insomnia 


### Figura de uma solicitação e resposta de uma requisição HTTP.

![Image](https://github.com/user-attachments/assets/c4da9600-6db7-4f70-961f-f4abeb63aac8)

## Hospedagem

Inicialmente utilizaremos a hospedagem em um PC para efetuarmos os testes. Em seguida prosseguiremos com a hospedagem pelo uso da Amazon EC2 (Elastic Computer Cloud) da AWS.


