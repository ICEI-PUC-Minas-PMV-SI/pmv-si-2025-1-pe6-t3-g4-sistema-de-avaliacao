# Introdução

Com o crescimento das plataformas de streaming e o fácil acesso a uma grande variedade de filmes, os espectadores têm mais opções do que nunca. No entanto, essa abundância de conteúdo também pode tornar a escolha de um filme uma tarefa desafiadora, especialmente sem uma fonte confiável de avaliações e recomendações. Diante desse cenário, este projeto propõe o desenvolvimento de um sistema de avaliação de filmes, permitindo que os usuários compartilhem suas opiniões, atribuam notas e descubram novas recomendações personalizadas. O objetivo é criar uma plataforma intuitiva e acessível, onde qualquer pessoa possa avaliar filmes e encontrar sugestões alinhadas aos seus gostos. A justificativa para a criação deste sistema está na necessidade de oferecer um espaço centralizado para avaliações confiáveis, tornando a escolha de um filme mais prática e agradável. O sistema busca atender tanto aqueles que desejam opinar sobre filmes que assistiram quanto aqueles que procuram recomendações confiáveis para decidir o que assistir.

## Problema

A proposta do projeto é proporcionar uma experiência mais precisa e satisfatória ao usuário, facilitando sua escolha de filmes, séries e programas de acordo com suas preferências individuais. e fornecendo um site confiável, com avaliações sinceras e uma comunidade ativa.

A plataforma será estruturada de maneira a fornecer recomendações personalizadas, baseadas no histórico de interações do usuário, bem como nas preferências de outros membros. Além disso, nossa intenção é garantir um ambiente online seguro, no qual as avaliações e classificações sejam expressas de forma genuína e transparente, permitindo que os usuários tomem decisões assertivas.

A aplicação também estimulará a formação de uma comunidade interativa, composta por indivíduos com interesses semelhantes, o que permitirá uma troca enriquecedora de opiniões e sugestões. Assim, buscamos não apenas fornecer recomendações precisas, mas também criar um espaço de interação e descoberta de novos conteúdos, que proporcionem uma experiência mais agradável e personalizada para cada usuário.

## Objetivos

De modo a atender ao público descrito, o objetivo deste trabalho é construir um sistema distribuído com interfaces em desktop e mobile para avaliação de filmes e séries. O aplicativo contará com um recurso que permitirá ao usuário criar, atualizar, consultar, e deletar as suas avaliações.

## Objetivos específicos


- Construir um sistema Back-end para hospedar uma API de filmes.

- Desenvolver uma aplicação web e móvel que ofereça:
  - Avaliação de melhor programa.
  - Avaliação de pior programa.
  - Filmes ou séries mais votados.
  + Espaço para que o usuário possa justificar seu voto por meio de texto.

- Desenvolver um filtro de exibição para filmes por gênero e data de lançamento, elencando-os de acordo com filtros de avaliação.


## Justificativa

A concepção deste projeto surgiu a partir do nosso interesse pessoal e do contato frequente com serviços de streaming durante o tempo livre. No cenário atual, a grande maioria, se não a totalidade, das produções audiovisuais de nosso interesse está disponível em alguma plataforma online, abrangendo desde novelas clássicas até filmes recém-lançados. No entanto, apesar da vasta oferta de conteúdo, há uma dificuldade comum enfrentada pelos usuários na hora de selecionar o que assistir. Esse fenômeno ocorre tanto pela abundância de opções quanto pelo excesso de informações apresentadas nas interfaces dessas plataformas, o que frequentemente resulta em uma demora significativa no processo de escolha, mesmo quando já se tem uma ideia do tipo de conteúdo desejado.

De acordo com um estudo realizado pelo instituto Reelgood em parceria com a Learndipity Data Insights, foi estimado que o tempo médio que os usuários permanecem navegando no Netflix até decidirem o que assistir é de 18 minutos. Esse tempo é duas vezes maior do que o tempo que os assinantes de televisão por assinatura costumam levar para escolher um canal para assistir. Esse dado ilustra claramente o impacto que a sobrecarga de opções pode ter na experiência do usuário, sugerindo a necessidade de uma ferramenta mais eficiente para auxiliar na escolha do conteúdo, tornando o processo mais ágil e assertivo.

## Público-Alvo

O software será voltado para usuários que buscam sugestões personalizadas de filmes de forma rápida e eficiente. O público-alvo inclui:

- Cinéfilos que desejam recomendações detalhadas e baseadas em suas preferências.

- Casais e famílias que querem sugestões compatíveis com diferentes gostos.

- Usuários de streaming que buscam otimizar suas escolhas.

- Fãs de gêneros específicos como terror, ficção científica e clássicos.

- Indecisos que costumam demorar para escolher um filme e precisam de sugestões diretas.


O objetivo é oferecer uma experiência intuitiva e personalizada, facilitando a escolha do próximo filme a ser assistido.
Adicione informações sobre o público-alvo por meio de uma descrição textual, diagramas de personas e mapa de stakeholders.

# Especificações do Projeto

## Requisitos

Nesta seção, estão listados os requisitos funcionais e não funcionais do sistema, que detalham o escopo do projeto e as funcionalidades que devem ser implementadas.

### Requisitos Funcionais

|ID    | Descrição do Requisito                                      | Prioridade |
|------|-------------------------------------------------------------|------------|
|RF-001| Permitir que os usuários se registrem na plataforma         | ALTA       |
|RF-002| Autenticação via login e senha                              | ALTA       |
|RF-003| Opção de login social (Google, Facebook, etc.)              | BAIXA      |
|RF-004| Permitir que os usuários adicionem filmes a uma lista de assistidos | ALTA       |
|RF-005| Possibilidade de marcar filmes como "quero assistir"        | MÉDIA      |
|RF-006| Opção de adicionar tags e notas pessoais aos filmes         | MÉDIA      |
|RF-007| Os usuários podem avaliar filmes com uma nota               | ALTA       |
|RF-008| Opção de escrever críticas e resenhas                       | ALTA       |
|RF-009| Comentários em avaliações de outros usuários                | MÉDIA      |
|RF-010| Permitir seguir outros usuários e visualizar suas listas e avaliações | ALTA       |
|RF-011| Curtir e comentar críticas de outros usuários               | MÉDIA      |
|RF-012| Pesquisa por título, diretor ou elenco                      | ALTA       |
|RF-013| Filtros por gênero, ano de lançamento e avaliação           | ALTA       |
|RF-014| Sistema de recomendações baseadas nos filmes assistidos e avaliados | MEDIA       |
|RF-015| Sugestões de filmes recomendados por amigos seguidos        | MÉDIA      |
|RF-016| Implementar um filtro que leia palavras em comentários e resenhas, destacando palavras-chave em um algoritmo de destaque | MEDIA       |

### Requisitos não Funcionais

|ID     | Descrição do Requisito                                          | Prioridade |
|-------|---------------------------------------------------------------|------------|
|RNF-002| Tempo de resposta médio abaixo de 2 segundos para operações comuns | ALTA       |
|RNF-003| Criptografia para armazenamento de senhas                      | ALTA       |
|RNF-005| Interface intuitiva e responsiva                                | ALTA       |
|RNF-007| Garantia de uptime de pelo menos 99,5%                         | ALTA       |
|RNF-001| A aplicação deve suportar um grande número de usuários simultâneos | MÉDIA      |
|RNF-006| Compatibilidade com dispositivos móveis                        | MÉDIA      |
|RNF-004| Proteção contra ataques como SQL Injection e Cross-Site Scripting (XSS) | MÉDIA      |
|RNF-008| Implementação de backup periódico dos dados                    | MÉDIA      |

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
|02| Não pode ser desenvolvido um módulo de backend        |

Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

# Catálogo de Serviços

Descreva aqui todos os serviços que serão disponibilizados pelo seu projeto, detalhando suas características e funcionalidades.

# Arquitetura da Solução

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

![arq](https://github.com/user-attachments/assets/b9402e05-8445-47c3-9d47-f11696e38a3d)


## Tecnologias Utilizadas

Descreva aqui qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
