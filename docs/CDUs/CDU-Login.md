# Especificação de casos de uso 

## Comércio Eletrônico

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 16/12/2022 | **1.0.2** | CDUs Adicionar Produto no Carrinho | Maria Ricarte |
| 16/12/2022 | **1.0.1** | CDUs Adicionar Produto no Carrinho | Letícia Maia |

###  Adicionar Produto no Carrinho
#### 1 - Resumo
> Possibilita que o usuário - do tipo Cliente e Administrador - logue em sua conta, compreendendo o método criar, excluir e editar.

#### 2 - Atores
>  Cliente e Administrador

#### 3 - Pré-condição
> O usuário deve possuir uma conta criada no sistema.

#### 4-- Pós-condição
<ul>
  <li>A interface apresenta seus dados salvos, como carrinho, seus dados e suas compras efetuadas.</li>
</ul>

#### 5 - Fluxos de evento

##### 5.1 - Fluxo Principal

<ul>
  <li>
    Inserir:&nbsp;
    1. [IN] O usuário acessa a interface para logar.
    2. [OUT] O sistema exibe a página com os formulários requeridos.
    3. [IN] O usuário preenche os campos, com as informações uma vez já cadastradas.
    4. [OUT] O sistema valida as informações e exibe.
  </li>
</ul> 

##### 5.2 - Fluxo Alternativo

> Inexistente
> 
##### 5.3 - Fluxo de Excessão
<ul>
  <li>
    Inserir:&nbsp;
    1. [IN] O usuário acessa a interface para logar.
    2. [OUT] O sistema exibe a página com os formulários requeridos.
    3. [IN] O usuário preenche os campos, com as informações uma vez já cadastradas.
    4. [OUT] O sistema invalida as informações e exibe uma mensagem de erro, voltando ao passo 3.
  </li>
</ul> 

#### 6 - Protótipos de interface

<img src="https://github.com/PI-InfoWeb-CNAT/Malfatti/blob/main/docs/Fotos%20do%20cdus/Login.png" width=500><br>

