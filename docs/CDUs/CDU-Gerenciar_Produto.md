# Especificação de casos de uso 

## Comércio Eletrônico

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 08/09/2022 | **1.0.5** | Protótipos | Maria Ricarte |
| 08/09/2022 | **1.0.3** | CDUs Usuário | Maria Ricarte |
| 07/09/2022 | **1.0.3** | CDUs Produto | Maria Ricarte |
| 07/09/2022 | **1.0.2** | CDUs Fabricante | Maria Ricarte |
| 06/09/2022 | **1.0.0** | CDUs Categoria | Maria Ricarte |


### Gerenciamento de produto
#### 1 - Resumo
> Possibilita que o usuário - do tipo Administrador - realize o gerenciamento de produtos, compreendendo os métodos Inserir, Alterar e excluir

#### 2 - Atores 
>  Administrador

#### 3 - Pré-condições 
> Estar logado no sistema com uma conta reconhecida como um usuário do tipo Administrador
<ul>
  <li>Inserir: Atribuir um Nome, Categoria, Fabricante, Preço e Descrição.</li>
  <li>Alterar: O produto deve ser existente no banco de dados.</li>
  <li>Excluir: O produto deve ser existente no banco de dados.</li>
</ul>

#### 4 - Pós-condições 

<ul>
  <li>Inserir: Novo produto inserido.</li>
  <li>Atualizar: Informações do produto alteradas.</li>
  <li>Excluir: Produto excluído.</li>
</ul>

#### 5 - Fluxos de evento 

##### 5.1 - Fluxo básico 

<ul>
  <li>
    Inserir:&nbsp;
    
    1. [IN] O usuário acessa o endereço da interface de criação dos produtos.
    2. [OUT] O sistema apresenta a interface de criação de produtos. 
    3. [IN] O usuário preenche os campos de Nome, Categoria, Fabricante, Preço e Descrição.
    4. [OUT] O sistema valida as informações e retorna para a interface de listagens dos produtos já registrados.
    
  </li>
 

<h5>5.2 - Fluxo alternativo </h5>

  <ul>
     <li>
    Inserir:&nbsp;
    
    1. [IN] O usuário acessa o endereço da interface de criação dos produtos.
    2. [OUT] O sistema apresenta a interface de criação de produtos. 
    3. [IN] O usuário preenche os campos de Nome, Categoria, Fabricante, Preço e Descrição.
    4. [OUT] O sistema valida as informações e retorna para a interface de listagens dos produtos já registrados.
    
  </li>
  <li>Alterar: &nbsp;
    
    1. [IN] O usuário acessa o endereço da interface de alteração do produto.
    2. [OUT] O sistema exibe a interface de alteração do produto selecionado.
    3. [IN] O usuário altera a informação do campo desejado.
    4. [OUT] O sistema valida as informações e retorna para a interface de listagens dos produtos já registrados.
    
  </li>
  
  <li>Excluir:  &nbsp;
    
    1. [IN] O usuário acessa a interface de exclusão do produto.
    2. [OUT] O sistema exibe a interface de exclusão do produto selecionado.
    3. [IN] O usuário confirma a exclusão.
    4. [OUT] O sistema valida as informações e retorna para a interface de listagens dos produtos já registrados.
    
  </li>
  </ul>
  
<h5>5.3 - Fluxo de exceção </h5>


 - Inserir passo 4:
    
    - Nome vazio: Caso o usuário tente inserir um produto sem nome, o sistema exibirá uma mensagem de erro informando que o atributo Nome
    do produto é obrigatório e retornará ao passo 3.
    - Categoria vazia: Caso o usuário tente inserir um produto sem categoria, o sistema exibirá uma mensagem de erro informando que o atributo 
    Categoria é obrigatório e retornará ao passo 3.
    - Fabricante vazio: Caso o usuário tente inserir um produto sem fabricante, o sistema exibirá uma mensagem de erro informando que o atributo 
    Fabricante é obrigatório e retornará ao passo 3.
    - Preço vazio: Caso o usuário tente inserir um produto sem preço, o sistema exibirá uma mensagem de erro informando que o atributo 
    Preço é obrigatório e retornará ao passo 3.
    - Preço negativo: Caso o usuário tente inserir um valor menor que 0 no campo Preço, o sistema exibirá uma mensagem de erro informando 
    que o atributo Preço deve ser positivo e retornará ao passo 3.
    - Descrição vazia: Caso o usuário tente inserir um produto sem descrição, o sistema exibirá uma mensagem de erro informando que o atributo 
    Descricao é obrigatório e retornará ao passo 3.
    
  
 - Excluir: 
    
    > Inexistente
  
  - Alterar: 
    
    - Nome vazio: Caso o usuário tente salvar alterações de um produto sem nome, o sistema exibirá uma mensagem de erro informando que o atributo Nome
    do produto é obrigatório e retornará ao passo 3.
    - Categoria vazia: Caso o usuário tente salvar alterações de um produto sem categoria, o sistema exibirá uma mensagem de erro informando que o atributo 
    Categoria é obrigatório e retornará ao passo 3.
    - Fabricante vazio: Caso o usuário tente salvar alterações de um produto sem fabricante, o sistema exibirá uma mensagem de erro informando que o atributo 
    Fabricante é obrigatório e retornará ao passo 3.
    - Preço vazio: Caso o usuário tente salvar alterações de um produto sem preço, o sistema exibirá uma mensagem de erro informando que o atributo 
    Preço é obrigatório e retornará ao passo 3.
    - Preço negativo: Caso o usuário tente salvar alterações de um produto com valor menor que 0 no campo Preço, o sistema exibirá uma mensagem de erro informando 
    que o atributo Preço deve ser positivo e retornará ao passo 3.
    - Descrição vazia: Caso o usuário tente salvar alterações de um produto sem descrição, o sistema exibirá uma mensagem de erro informando que o atributo 
    Descricao é obrigatório e retornará ao passo 3.

    
 #### 6 - Protótipos de interface 
| [<img src="https://github.com/PI-InfoWeb-CNAT/Malfatti/blob/main/docs/Fotos%20do%20cdus/Cadastro%20Produto%20adm.png" width=500><br><sub>Cadastrar</sub>](#) |  [<img src="https://github.com/PI-InfoWeb-CNAT/Malfatti/blob/main/docs/Fotos%20do%20cdus/Editar%20produtos%20adm.png" width=500><br><sub>Atualizar</sub>](#) | 
| :---: | :---: |
| [<img src="https://github.com/PI-InfoWeb-CNAT/Malfatti/blob/main/docs/Fotos%20do%20cdus/Excluir%20Produto%20adm.png" width=500><br><sub>Excluir</sub>](#) |  
 

