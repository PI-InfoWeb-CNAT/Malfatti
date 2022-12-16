# Especificação de casos de uso 

## Comércio Eletrônico

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 16/12/2022 | **1.0.2** | CDUs Adicionar Produto no Carrinho | Maria Ricarte |
| 16/12/2022 | **1.0.1** | CDUs Adicionar Produto no Carrinho | Letícia Maia |

###  Adicionar Produto no Carrinho
#### 1 - Resumo
> Possibilita que o usuário - do tipo Cliente - realize a adição dos itens ao carrinho, compreendendo o método Editar.

#### 2 - Atores
>  Usuário

#### 3 - Pré-condição
> O usuário deve estar logado, e possuir o produto desejado em estoque.

#### 4-- Pós-condição
<ul>
  <li>Ele finaliza a compra, e acessa a interface de pagamento.</li>
</ul>

#### 5 - Fluxos de evento

##### 5.1 - Fluxo Principal

<ul>
  <li>
    1. [IN] O usuário acessa a interface para ver os produtos em exposição.
    2. [OUT] O sistema exibe os produtos disponíveis para compra.
    3. [IN] O usuário acessa as informações individuais do produto.
    4. [OUT] O sistema exibe os detalhes do produto escolhido.
    5. [IN] O usuário adiciona o produto por meio do botão "Adicionar a Sacola".
    6. [OUT] O sistema atualiza o carrinho, e apresenta a inteface do carrinho, com o produto inserido.
  </li>
</ul> 

##### 5.2 - Fluxo Alternativo

> Inexistente

#### 6 - Protótipos de interface

<img src="https://github.com/PI-InfoWeb-CNAT/Malfatti/blob/main/docs/Fotos%20do%20cdus/Sacola.png" width=500><br>

#### 7 - Diagrama de classes
<img src="https://github.com/PI-InfoWeb-CNAT/Malfatti/blob/main/docs/Fotos%20do%20cdus/Diagrama%20visualizar%20carrinho.png" width=500><br>
