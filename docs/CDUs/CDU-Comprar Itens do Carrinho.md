# Especificação de casos de uso 

## Comércio Eletrônico

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 12/11/2022 | **1.0.1** | CDUs Comprar Itens do Carrinho | Maria Ricarte |

###  Colocar Itens no Carrinho
#### 1 - Resumo
> Possibilita que o usuário - do tipo Cliente - compre produtos presentes em seu carrinho.

#### 2 - Atores
>  Usuário

#### 3 - Pré-condição
> O usuário deve ter um(1) ou mais produtos no carrinho e estar logado a sua conta.

#### 4-- Pós-condição
<ul>
  <li>Ele acessa a interface de compra por meio do botão "Finalizar Compra" na .</li>
</ul>

#### 5 - Fluxos de evento

##### 5.1 - Fluxo Principal

<ul>
  <li>
    
    1. [IN] O usuário loga em sua conta.
    2. [OUT] O sistema atualiza os ite com as informações do cliente.
    3. [IN] O usuário acessa a interface do carrinho.
    4. [IN] O usuário acessa a interface de compra por meio do botão "Finalizar Compra".
    5. [OUT] O sistema exibe uma interface de confirmação de identidade, requerindo dados de login do usuário.
    6. [IN] O usuário preenche o formulário e envia para validação.
    7. [OUT] O sistema valida as informações e exibe a interface de pagamento.
    8. [IN] O usuário preenche os campos para realização do pagamento(nome, endereço, numero do cartão a ser cobrado pagamento).
    9. [OUT] O sistema valida e a compra é realizada.
    
  </li>
</ul> 

##### 5.2 - Fluxo Alternativo - Remoção de Item antes de finalização 

<ul>
  <li>
    
    1. [IN] O usuário loga em sua conta.
    2. [OUT] O sistema atualiza os ite com as informações do cliente.
    3. [IN] O usuário acessa a interface do carrinho.
    4. [IN] O usuário acessa o botão para remover um item do carrinho.
    5. [OUT] O sistema retira o item do carrinho.
    6. [IN] O usuário acessa a interface de compra por meio do botão "Finalizar Compra".
    7. [OUT] O sistema exibe uma interface de confirmação de identidade, requerindo dados de login do usuário.
    8. [IN] O usuário preenche o formulário e envia para validação.
    9. [OUT] O sistema valida as informações e exibe a interface de pagamento.
    10. [IN] O usuário preenche os campos para realização do pagamento(nome, endereço, numero do cartão a ser cobrado pagamento).
    11. [OUT] O sistema valida e a compra é realizada.
    
  </li>
</ul>  

##### 5.3 - Fluxo Alternativo - Edição de quantidade de Item antes da finalização 

<ul>
  <li>
    
    1. [IN] O usuário loga em sua conta.
    2. [OUT] O sistema atualiza os ite com as informações do cliente.
    3. [IN] O usuário acessa a interface do carrinho.
    4. [IN] O usuário acessa o botão para editar a quantidade de um item do carrinho.
    5. [OUT] O sistema atualiza a quantidade no carrinho.
    6. [IN] O usuário acessa a interface de compra por meio do botão "Finalizar Compra".
    7. [OUT] O sistema exibe uma interface de confirmação de identidade, requerindo dados de login do usuário.
    8. [IN] O usuário preenche o formulário e envia para validação.
    9. [OUT] O sistema valida as informações e exibe a interface de pagamento.
    10. [IN] O usuário preenche os campos para realização do pagamento(nome, endereço, numero do cartão a ser cobrado pagamento).
    11. [OUT] O sistema valida e a compra é realizada.
    
  </li>
</ul>

##### 5.3 - Fluxo de Exceção - Dados de confirmação inválidos

<ul>
  <li>
    
    1. [IN] O usuário loga em sua conta.
    2. [OUT] O sistema atualiza os ite com as informações do cliente.
    3. [IN] O usuário acessa a interface do carrinho.
    4. [IN] O usuário acessa o botão para editar a quantidade de um item do carrinho.
    5. [OUT] O sistema atualiza a quantidade no carrinho.
    6. [IN] O usuário acessa a interface de compra por meio do botão "Finalizar Compra".
    7. [OUT] O sistema exibe uma interface de confirmação de identidade, requerindo dados de login do usuário.
    8. [IN] O usuário preenche o formulário e envia para validação.
    9. [OUT] O sistema invalida as informações do usuário, e o usuáro volta ao passo 6.
    
  </li>
</ul>


#### 6 - Protótipos de interface

| [<img src="https://github.com/PI-InfoWeb-CNAT/Malfatti/blob/main/docs/Fotos%20do%20cdus/Sacola.png" width=500><br><sub>Carrinho</sub>](#) |  [<img src="https://github.com/PI-InfoWeb-CNAT/Malfatti/blob/main/code/Malfitti%20prototipos/Tela%20de%20Pagamento.png" width=500><br><sub>Tela de Pagamento</sub>](#) | 
