# Introdução

Com o crescimento das plataformas de streaming e o fácil acesso a uma grande variedade de filmes, os espectadores têm mais opções do que nunca. No entanto, essa abundância de conteúdo também pode tornar a escolha de um filme uma tarefa desafiadora, especialmente sem uma fonte confiável de avaliações e recomendações. Diante desse cenário, este projeto propõe o desenvolvimento de um sistema de avaliação de filmes, permitindo que os usuários compartilhem suas opiniões, atribuam notas e descubram novas recomendações personalizadas. O objetivo é criar uma plataforma intuitiva e acessível, onde qualquer pessoa possa avaliar filmes e encontrar sugestões alinhadas aos seus gostos. A justificativa para a criação deste sistema está na necessidade de oferecer um espaço centralizado para avaliações confiáveis, tornando a escolha de um filme mais prática e agradável. O público-alvo deste projeto são pessoas comuns que gostam de assistir a filmes, independentemente de idade ou conhecimento técnico sobre cinema. O sistema busca atender tanto aqueles que desejam opinar sobre filmes que assistiram quanto aqueles que procuram recomendações confiáveis para decidir o que assistir.

## Problema

A proposta do projeto é proporcionar uma experiência mais precisa e satisfatória ao usuário, facilitando sua escolha de filmes, séries e programas de acordo com suas preferências individuais. e fornecendo um site confiável, com avaliações sinceras e uma comunidade ativa.

A plataforma será estruturada de maneira a fornecer recomendações personalizadas, baseadas no histórico de interações do usuário, bem como nas preferências de outros membros. Além disso, nossa intenção é garantir um ambiente online seguro, no qual as avaliações e classificações sejam expressas de forma genuína e transparente, permitindo que os usuários tomem decisões assertivas.

A aplicação também estimulará a formação de uma comunidade interativa, composta por indivíduos com interesses semelhantes, o que permitirá uma troca enriquecedora de opiniões e sugestões. Assim, buscamos não apenas fornecer recomendações precisas, mas também criar um espaço de interação e descoberta de novos conteúdos, que proporcionem uma experiência mais agradável e personalizada para cada usuário.

## Objetivos

Aqui você deve descrever os objetivos do trabalho indicando que o objetivo geral é desenvolver um software para solucionar o problema apresentado acima. 

Apresente também alguns (pelo menos 2) objetivos específicos dependendo de onde você vai querer concentrar a sua prática investigativa, ou como você vai aprofundar no seu trabalho.
 
> **Links Úteis**:
> - [Objetivo geral e objetivo específico: como fazer e quais verbos utilizar](https://blog.mettzer.com/diferenca-entre-objetivo-geral-e-objetivo-especifico/)

## Justificativa

A concepção deste projeto surgiu a partir do nosso interesse pessoal e do contato frequente com serviços de streaming durante o tempo livre. No cenário atual, a grande maioria, se não a totalidade, das produções audiovisuais de nosso interesse está disponível em alguma plataforma online, abrangendo desde novelas clássicas até filmes recém-lançados. No entanto, apesar da vasta oferta de conteúdo, há uma dificuldade comum enfrentada pelos usuários na hora de selecionar o que assistir. Esse fenômeno ocorre tanto pela abundância de opções quanto pelo excesso de informações apresentadas nas interfaces dessas plataformas, o que frequentemente resulta em uma demora significativa no processo de escolha, mesmo quando já se tem uma ideia do tipo de conteúdo desejado.

De acordo com um estudo realizado pelo instituto Reelgood em parceria com a Learndipity Data Insights, foi estimado que o tempo médio que os usuários permanecem navegando no Netflix até decidirem o que assistir é de 18 minutos. Esse tempo é duas vezes maior do que o tempo que os assinantes de televisão por assinatura costumam levar para escolher um canal para assistir. Esse dado ilustra claramente o impacto que a sobrecarga de opções pode ter na experiência do usuário, sugerindo a necessidade de uma ferramenta mais eficiente para auxiliar na escolha do conteúdo, tornando o processo mais ágil e assertivo.

## Público-Alvo

Descreva quem serão as pessoas que usarão a sua aplicação indicando os diferentes perfis. O objetivo aqui não é definir quem serão os clientes ou quais serão os papéis dos usuários na aplicação. A ideia é, dentro do possível, conhecer um pouco mais sobre o perfil dos usuários: conhecimentos prévios, relação com a tecnologia, relações
hierárquicas, etc.

Adicione informações sobre o público-alvo por meio de uma descrição textual, diagramas de personas e mapa de stakeholders.

> **Links Úteis**:
> - [Público-alvo](https://blog.hotmart.com/pt-br/publico-alvo/)
> - [Como definir o público alvo](https://exame.com/pme/5-dicas-essenciais-para-definir-o-publico-alvo-do-seu-negocio/)
> - [Público-alvo: o que é, tipos, como definir seu público e exemplos](https://klickpages.com.br/blog/publico-alvo-o-que-e/)
> - [Qual a diferença entre público-alvo e persona?](https://rockcontent.com/blog/diferenca-publico-alvo-e-persona/)

# Especificações do Projeto

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto. Para determinar a prioridade de requisitos, aplicar uma técnica de priorização de requisitos e detalhar como a técnica foi aplicada.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário cadastre tarefas | ALTA | 
|RF-002| Emitir um relatório de tarefas no mês   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 

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
