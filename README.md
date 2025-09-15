# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

- Configuração de deploy / buid como DEV, HML e PRD
- Configuração de dados sensiveis como chave de utilização de algum serviço ou senha como banco de dados. É recomendavel guardar estes dados em variaveis de ambientes.
- Configurações não sensiveis deve ser armazenadas no settings conforme os ambientes como DEV, HML e PRD
- Para cada aplicação/micro-serviço terá que ter o seu repositorio mesmo que ele esteja aplicando em diversos serviços com a versão de HML e PRD
- Serviços como Banco de dados, cache e messangeria/fila, ou seja, serviços que são consumidos pela rede, serão tratados como recursos anexados
- Logs para monitorar as aplicações, como Application Insights


**Resposta:**

2. Quais são as principais camadas no desenvolvimento de um software?

Camada de apresentação com View, Controllers
Camada de negócio com serviços, regras de negócios
Camada de dados com repositórios, Entity Framework (ORMs)
Camada de infraestrutura para ter APIs, serviços externos


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

SOA utiliza protocolos como SOAP e XML que normalmente é mais pesado.
Na arquitetura microserviços pode utilizar REST com Json o que deixar mais rápido e fluido a utilização, poderá adicionar pequenas responsabilidades.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

No que eu já utilizei foi para ter um rate-limit de acessos, versões da API e autenticação como por exemplo JWT.

As vantagens são segurança com o JWT onde teremos informações do usuário e poderá realizar permissões com Role
No versionamento, o cliente poderá realizar as migrações no seu momento quando tiver uma nova versão, então por exemplo se um endpoint muda muito na versão 2, o cliente terá a versão 1 que poderá continuar utilizando e quando tiver um tempo poderá realzar a migração para a versão 2.

As desvantagens, sinceramente eu vejo poucas, como curva de apredendizado é maior para implementar isto, um exemplo é o pacote que ajuda no versionamento, ele está obsoleto, então neste caso precisa estudar uma nova opção e migrar.

5. Qual a diferença entre uma Struct e uma Class?

Struct
Utiliza a memoria stack
Não suporta herança
Tem uma performance melhor para tipos pequenos

Class
Utiliza memoria heap
Suporta herança e polimorfismo


6. Explique a grande diferença entre .NET e .NET CORE.

Net Framework só funciona em Windows
Tem o system.web que é considerado muito pesado

Net Core é multiplataforma, open source e tem uma performance maior e tambem está em constante evolução com novas versões.

7. Quais as principais diferenças entre REST e GRPC?

Nunca utilizei o GRPC em PRD.
Em REST podemos utilizar o Json, caching e CDN de dados. O json é amigavel para leitura, porém ele acaba trafegado mais dados.
Em GRPC utiliza o protocolo HTTP/2 e tem um uso menor de rede e tráfego de dados.


8. Explique como funciona um gerenciamento de rotas de uma SPA.

O SPA utiliza o JS para realizar as mudanças na URL e renderizar os componentes necessários para a página. Estes componentes podem ser controlados por:
Routing (rota) para apenas atualizar o conteúdo, lazy loading para carregar os componentes.
Para SEO é possível utilizar o SRR para ajudar os motores de busca para guardar os dados e exibir corretamente.


9. Falando sobre DevOps, comente o que conhece sobre.

Github actions, docker, kubernetes, Applications Insights, Prometheus, Grafana e git


10. Explique sobre um método agile.

Acredito que o objetivo principal é "quebrar" grandes funcionalidades para ter pequenas entregas, desta forma será possível acompanhar de perto a evolução desta entrega e tambem minimizar gaps de planejamentos.
Desta forma será possível priorizar as funcionalidades e tambem ter equipes/times trabalhando em conjunto.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

Em CI: utilização de testes unitarios e BDD para validar nos processos de desenvolvimento e deploy e buidls automaticos.
Em CD: Ter o docker/kubernetes para automatizar o deploy.


12. Qual a diferença entre Docker e Containers.

Containers é um sistema isolado, então se tenho diversos serviços rodado, como por exemplo o NET Core, se ele foi removido, só irá para de funcionar neste container especifico.
Docker é o build de imagens que seguindo as regras do composeé ele que implementa os containers.


13. Qual a diferença entre Kubernetes e Openshift?

Kubenertes é open-source as configurações precisam ser manuais.
Openshift é projeto fechado, tem uma imagem web integrada


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

Vantagens: Reutilizações de funcionalidades, integrações entre sistemas, desenvolvimento paralelo
Desvatagens: Alta dependência, troubleshooting e debug mais complexo, utiliza de rede por conta dos serviços HTTP
Preocupações: Versionamento, segurança Top 10 OWASP e dados públicos em exibição, autenticação, documentação, Rate limiting, Monitoramento

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

Seguir o Top 10 OWASP de APIs
HTTPS
Autenticação com ouath 2.0
JWT com tokens com expiração
Rate limiting
Logs e monitoramento

16. Para que serve uma arquitetura de mensagerias?

Para não sobrecarregar a aplicação principal, executando funcionalidades em background e não deixar o usuário "pendurado" na thread principal.
Exemplo o usuário realizar um cadastro e após isto envia um e-mail, este e-mail precisa ser enviando em um serviço background para não deixar o usuário aguardando sobre este email.
Assim será possível realizar uma comunicação assíncrona entre sistemas e se o SMTP estiver fora do ar, o sistema poderá fazer o retry 


17. Explique a estratégia SAGA em arquitetura de microservice.

No que eu apliquei foi quando o usuário necesita realizar uma transação longa em vários passos.
Neste caso o usuário abria uma OS, depois reserva as peças necessários e depois realizava o agendamento para o técnico e realizava o faturamento.
Se o falhava o faturamento a reserva de peças e o agendamento era desfeitos, parecido como um unit of work também.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

Vou descrever o que eu já fiz: Para cargas de muitos acessos ou envio de muitas informações como em IOT
Configurei as metricas de CPU ou Memória definidos para garantir o autoscaling das instancias da aplicação.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

Projeto App Técnicos
Por ser um projeto de aplicativo, foi aplicado o conceito de offline first, que normalmente no mundo web não tenho grandes preocupações.
Além disto ter as funcionalidades bem detalhadas e escritas para se preocuparar com a performance do App e do aparelho do usuário.
Os serviços de background tambem para realizar os sincronismos automaticamente quando tiver internet, o maior desafio não era saber se o usuário tem internet ou não, mas sim se a internet é de boa conectividade naquele momento.
Este App está no ar faz mais de 5 anos ou foram realizados diversos atendimentos, com muitas imagens e videos.

Projeto de IOT
Os dispositivos de IOT são instalados nos equipamentos enviados dados de telemetria como nível da bateria, latitude e longitude, quantas horas trabalhou o equipamento, por ser muitos dispositivos e muitos dados.
O banco de dados cresceu rapidamente, os dados são salvos no MongoDB e chegou a ter mais de 80 milhões de registros, foi necessario realizar algumas configurações, primeiro o CQRS para ter um mongoDB para leitura e outro de escrita e também ter o kubernetes para aumentar as instâncias conforme a necessidade.
Além disto criação de indice nas coleções de mongo foram necessários para ter estes dados otimizados
