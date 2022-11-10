# Especificação de casos de uso 

## Comércio Eletrônico

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 10/11/2022 | **1.0.1** | CDUs Visualizar Carrinho | Laiz Fernanda |

###  Visualizar Carrinho
#### 1 - Resumo
> Possibilita que o usuário - do tipo Cliente - realize a visualização do pedido, e a sessão de compras, compreendendo os métodos Editar e Remover.

#### 2 - Atores
>  Usuário

#### 3 - Pré-condição
> O usuário deve estar com o produto em exibiçaõ, e em seguida ter adicionado na sacola.

#### 4-- Pós-condição
<ul>
  <li>Ele poder sair da sacola, e ir a procura de outros produtor.</li>
  <li>Ou ele finaliza a compra, e acessa a interface de pagamento.</li>
</ul>

#### 5 - Fluxos de evento

##### 5.1 - Fluxo Principal

<ul>
  <li>
    
    1. [IN] O usuário confere todos os seus produtos.
    2. [OUT] Acessa a opção de finalizar compra.
    3. [IN] O sistema direciona para a interface de pagamento.
    
  </li>
</ul> 
<h5> 5.2 - Fluxo Alternativo </h5>

<ul>
  <li>
    
    1. [IN] O usuário confere todos os seus produtos.
    2. [OUT] Acessa a opção de editar.
    3. [IN] O sistema direciona para a interface onde terá as opções de alterações.
    
  </li>
</ul>  
<h5> 5.3 - Fluxo Alternativo </h5>

<ul>
  <li>
    
    1. [IN] O usuário confere todos os seus produtos.
    2. [OUT] Acessa a opção de remover item.
    3. [IN] Continuando na mesma interface.
    
  </li>
</ul>

#### 6 - Protótipos de interface e diagrama de classes

<img src="https://github.com/PI-InfoWeb-CNAT/Malfatti/blob/main/docs/Fotos%20do%20cdus/Sacola.png" width=500><br>
<img src="https://github.com/PI-InfoWeb-CNAT/Malfatti/blob/main/docs/Fotos%20do%20cdus/Diagrama%20visualizar%20carrinho.png" width=500><br>
