# Malfatti

## Documento de Visão

### Histórico de Revisão

| Data       | Versão | Descrição                                              | Autor                          | 
|:-----------|:-------|:-------------------------------------------------------|:-------------------------------|
| 30/05/2022 | 1.0    | Criação e anexo de dados iniciais do documento de visão | Antoniella de Araújo Monsores  |
| 30/05/2022 | 1.0    | Criação e anexo de dados iniciais do documento de visão | Jainne Agatha Costa Bezerra    |
| 30/05/2022 | 1.0    | Criação e anexo de dados iniciais do documento de visão | Laiz Fernanda Souza dos Santos |
| 30/05/2022 | 1.0    | Criação e anexo de dados iniciais do documento de visão | Letícia Maia Marques           |
| 30/05/2022 | 1.0    | Criação e anexo de dados iniciais do documento de visão | Maria Clara Medeiros Ricarte   |
| 30/05/2022 | 1.0    | Criação e anexo de dados iniciais do documento de visão | Winnie Bianca da Silva Almeida |

### 1. Objetivo do Projeto

Desenvolvimento de um site voltado ao comércio de jóias e semi-jóias de diferentes marcas, sejam elas
renomadas ou iniciantes no mercado.
Entre os produtos ofertados, devem estar inclusos: brincos, colares, pulseiras, entre outros.

### 2. Descrição do Problema

|                           |                                                                                                                                      |
|:--------------------------|:-------------------------------------------------------------------------------------------------------------------------------------|
| **O problema de**         | não possuir uma plataforma especializada para vendas online                                                                          |
| **afeta**                 | a empresa                                                                                                                            |
| **cujo impacto é**        | a limitação de vendas, pois não são todos os clientes que podem usufruir da loja física                                              |
| **uma boa solução seria** | a construção de uma plataforma, pois terá maior alcance de clientes, além de ser uma forma mais prática de comunicação e organização |

### 3. Descrição dos Usuários

| Nome                      | Descrição                      | Responsabilidade |
|:--------------------------|:-------------------------------|:-----------------|
| Administrador             | Realiza o controle de vendas e estoque e cadastra novos produtos a venda | Controlar a entrada e saída de produtos e atualizar o site com novos produtos |
| Cliente                   | Realiza a compra de acessórios | Pagar por compra |

### 4. Descrição do ambiente dos usuários

A loja possui dois tipos de usuários: o **administrador**, que representa os gestores, e o **cliente**, que representa aquele ao qual os serviços da loja são ofertados.
- O administrador acessa o site a partir do ambiente físico da loja e faz a configuração dos produtos a serem vendidos e realiza a logística de atendimento dos pedidos. Um exemplo de sua ação é o bloqueio de vendas, dado caso o produto a ser vendido não possua mais unidades no estoque.
- O cliente irá acessar o site utilizando um aparelho eletrônico e realizará a visualização dos produtos na loja e realizará a compra, caso deseje. Neste caso não há muitas restrições quanto ao ambiente, pois ele poderá fazer os pedidos de qualquer local que tenha conexão com a internet.

### 5. Principais Necessidades dos Usuários

O lojista, administrador do site, tem como principal necessidade aumentar o volume de vendas de sua loja, incorporando em seu negócio a possibilidade de realização de vendas via internet. Para isso precisará de uma plataforma acessível e confortável para a atração de novos clientes.
<br>
O cliente, deseja ter acesso a um site de boa interface que o permita obter informações sobre os produtos comercializados de forma prática e objetiva e, caso identifique que estes atendem às suas necessidades, possa realizar sua compra, confirmando a aquisição. Também é de seu interesse visualizar o processo de entrega dos produtos requeridos.

### 6. Alternativas concorrentes

Uma alternativa ao comércio eletrônico desenvolvido é a loja Morana, que apresenta pesquisa por meio de
nome ou categoria do produto, tem o sistema de carrinho de compras, que permite ao usuário adicionar os
produtos que atendem às suas necessidades, deixando o pagamento somente para o final quando o
cliente tiver selecionado todos os produtos desejados. Também há o sistema de login, o qual o usuário se
cadastra, o que facilita as próximas compras. Além disso, em cada produto tem sua descrição e produtos
similares ao selecionado.

### 7. Visão Geral do Produto

Esse projeto idealiza a criação de uma joalheria online.
<br>
O site desenvolvido propõe um design agradável e acessível e pretende funcionar de forma rápida e
eficiente, proporcionando uma boa experiência aos seus usuários.
<br>
Para mais, os potenciais clientes - usuários como um todo - devem ser apresentados a um ambiente seguro
e responsável, de modo a garantir a efetividade e proteção de cada uma de suas aquisições.

### 8. Requisitos Funcionais

| Código | Nome                                   | Descrição |
|:-------|:---------------------------------------|:----------|
| F01    | Adicionar, remover ou alterar produtos | O administrador tem à sua disponibilidade a função de adicionar, remover ou alterar produtos comercializados no site estabelecendo ainda seus preços de venda. |
| F02    | Disponibilizar ou bloquear a apresentação do produto | O administrador tem à sua disponibilidade a função de liberar ou bloquear a apresentação de produtos a venda. |
| F03    | Consultar pedidos | O administrador pode acessar os dados de pedidos que foram realizadas pelos clientes - para produtos já remetidos ou não. |
| F04    | Registrar recebimento do pagamento | O administrador registra no site a identificação do recebimento do pagamento realizado pelo cliente, liberando o pedido para envio. |
| F05    | Registrar o envio do pedido | O administrador informa no site a forma e condições de envio do pedido ao cliente. |
| F06    | Visualizar produtos | O usuário visualiza os produtos disponíveis, podendo utilizar de meios de filtro por nome, marca, ou outro. |
| F07    | Adicionar ou remover produtos da cesta de compras | O usuário pode escolher mais de um produto para realizar a compra quando inseridos em sua cesta de compras. |
| F08    | Realizar cadastro e login no site | O usuário deve se cadastrar no site para acessar determinadas funcionalidades, por exemplo, comprar produtos. |
| F09    | Realizar a compra de produtos | Os clientes podem confirmar a compra de produtos - adicionados ou não em sua cesta de compras -, gerando um pedido. |
| F10    | Realizar o cancelamento de pedidos | Os clientes podem solicitar o cancelamento de um pedido realizado desde que ainda não tenha sido enviado. |
| F11    | Realizar a devolução de produtos | Os clientes podem efetuar a devolução de produtos até um prazo determinado desde que não tenham sido danificados. |
| F12    | Verificar compras realizadas | Os clientes podem verificar seu histórico de compra na loja. |
| F13    | Verificar o andamento do pedido | Os clientes podem acompanhar o andamento da entrega dos produtos solicitados. |
| F14    | Editar dados cadastrais | Os clientes podem editar seus dados cadastrais, como endereço de entrega e telefone para contato. |

### 9. Requisitos NÃO Funcionais

| Código | Nome              | Descrição | Categoria | Classificação |
|:-------|:------------------|:----------|:----------|:--------------|
| NF01   | Design responsivo | O site apresentará responsividade, deixando-o mais confortável para o usuário. | Usabilidade | Obrigatório |
| NF02   | Acesso somente com internet | Se faz necessário o acesso contínuo à internet para realizar o acesso aos dados do site e suas funcionalidades. | Disponibilidade | Obrigatório |
| NF03   | Criptografia de dados | Informações sensíveis aos usuários, como senhas, devem ser gravadas de forma criptografada no banco de dados. | Segurança | Obrigatório
