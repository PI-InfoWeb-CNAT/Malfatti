# Especificação de casos de uso 

## Comércio Eletrônico

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 06/11/2022 | **1.0.0** | CDUs Cancelar Pedido | Jainne Agatha |

### Gerenciamento de categoria
#### 1 - Resumo
> Possibilita que o usuário - do tipo Cliente - atue na realização do cancelamento de um pedido, compreendendo o método excluir

#### 2 - Atores 
>  Cliente

#### 3 - Pré-condições 
> Estar logado no sistema com uma conta reconhecida como um usuário do tipo Cliente
<ul>
  <li>Excluir: O pedido deve ser existente no banco de dados.</li>
</ul>

#### 4 - Pós-condições 

<ul>
<li>Excluir: Pedido excluído.</li>
</ul>

#### 5 - Fluxos de evento 

##### 5.1 - Fluxo básico 

<ul>
  <li>
    Inserir:&nbsp;
    
    1. [IN] O usuário acessa o endereço da interface meus pedidos.
    2. [OUT] O sistema apresenta a interface meus pedidos. 
    3. [IN] O usuário preenche o campo de nome.
    4. [OUT] O sistema valida as informações e retorna para a interface de listagens das categorias já registradas.

  <li>Excluir:  &nbsp;
    
    1. [IN] O usuário acessa a interface de excluir pedido.
    2. [OUT] O sistema exibe a interface de exclusão do pedido selecionado.
    3. [IN] O usuário confirma a exclusão.
    4. [OUT] O sistema valida as informações e retorna para a interface de listagens dos pedidos já registrados.
    
  </li>
 
</ul>

<h5>5.2 - Fluxo alternativo </h5>

> Inexistente

<h5>5.3 - Fluxo de exceção </h5>

<ul>
  <li>Excluir passo 4 - Pedido a caminho: 
    
    Caso o usuário tente excluir um pedido que já esteja a caminho, o sistema apresentará uma mensagem de 
    erro informando a impossibilidade de exclusão daquele determinado pedido e retornará ao passo 3.
    
  </li>
</ul>

#### 6 - Protótipos de interface 
  


--- 
 
