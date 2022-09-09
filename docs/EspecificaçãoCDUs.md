# Especificação de casos de uso 

## Comércio Eletrônico

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 08/09/2022 | **1.0.6** | Protótipos | Maria Ricarte |
| 08/09/2022 | **1.0.3** | CDUs Usuário | Maria Ricarte |
| 07/09/2022 | **1.0.3** | CDUs Produto | Maria Ricarte |
| 07/09/2022 | **1.0.2** | CDUs Fabricante | Maria Ricarte |
| 07/09/2022 | **1.0.0** | CDUs Categoria | Maria Ricarte |

### Gerenciamento de categoria
#### 1 - Resumo
> Possibilita que o usuário - do tipo Administrador - atue na realização do gerenciamento de categorias, compreendendo os métodos Inserir, Alterar e excluir

#### 2 - Atores 
>  Administrador

#### 3 - Pré-condições 
> Estar logado no sistema com uma conta reconhecida como um usuário do tipo Administrador
<ul>
  <li>Inserir: Atribuir um nome à categoria.</li>
  <li>Alterar: A categoria deve ser existente no banco de dados.</li>
  <li>Excluir: A categoria deve ser existente no banco de dados.</li>
</ul>

#### 4 - Pós-condições 

<ul>
  <li>Inserir: Nova categoria inserida.</li>
  <li>Alterar: Informações da categopria alteradas.</li>
  <li>Excluir: Categoria excluída.</li>
</ul>

#### 5 - Fluxos de evento 

##### 5.1 - Fluxo básico 

<ul>
  <li>
    Inserir:&nbsp;
    
    1. [IN] O usuário acessa o endereço da interface de criação das categorias.
    2. [OUT] O sistema apresenta a interface de criação de categorias. 
    3. [IN] O usuário preenche o campo de nome.
    4. [OUT] O sistema valida as informações e retorna para a interface de listagens das categorias já registradas.
    
  </li>
 
  <li>Alterar: &nbsp;
    
    1. [IN] O usuário acessa o endereço da interface de alteração da categoria.
    2. [OUT] O sistema exibe a interface de alteração da categoria selecionada.
    3. [IN] O usuário insere um novo nome.
    4. [OUT] O sistema valida as informações e retorna para a interface de listagens das categorias já registradas.
    
  </li>
  
  <li>Excluir:  &nbsp;
    
    1. [IN] O usuário acessa a interface de exclusão da categoria.
    2. [OUT] O sistema exibe a interface de exclusão da categoria selecionada.
    3. [IN] O usuário confirma a exclusão.
    4. [OUT] O sistema valida as informações e retorna para a interface de listagens das categorias já registradas.
    
  </li>
 
</ul>

<h5>5.2 - Fluxo alternativo </h5>

> Inexistente

<h5>5.3 - Fluxo de exceção </h5>

<ul>
  <li>Inserir passo 4 - Nome vazio:
    
    Caso o usuário tente inserir uma categoria sem nome, o sistema exibirá uma mensagem de erro informando que o atributo Nome
    de categoria é obrigatório e retornará ao passo 3.
  
  <li>Excluir passo 4 - Categoria conectada à produto existente: 
    
    Caso o usuário tente excluir uma categoria que já esteja interligada a algum produto, o sistema apresentará uma mensagem de 
    erro informando a impossibilidade de exclusão daquela determinada categoria e retornará ao passo 3.
    
  </li>
  
  <li>Alterar passo 4 - Nome vazio:
    
    Caso o usuário tente salvar alterações de uma categoria sem nome, o sistema exibirá uma mensagem de erro informando que o 
    atributo Nome de categoria é obrigatório e retornará ao passo 3.
    
  </li>
</ul>

#### 6 - Protótipos de interface 
| [<img src="https://user-images.githubusercontent.com/79111102/189199679-b3821e8a-a5fe-4dbe-8cad-d5bf3ad7376a.png" width=500><br><sub>Inserir</sub>](#) |  [<img src="https://user-images.githubusercontent.com/79111102/189201431-8f3da798-81e0-4453-8a30-03fb5376aaf0.png" width=500><br><sub>Excluir</sub>](#) | 
| :---: | :---: |
| [<img src="https://user-images.githubusercontent.com/79111102/189202485-a073c482-5dd7-4b5e-9553-e51774829978.png" width=500><br><sub>Alterar</sub>](#) |  [<img src="https://user-images.githubusercontent.com/79111102/189202420-f6af98ca-6ac8-4960-a100-97d94fdb5805.png" width=500><br><sub>Categorias registradas</sub>](#) |  


--- 
  
### Gerenciamento de fabricante
  
#### 1 - Resumo
> Possibilita que o usuário - do tipo Administrador - realize o gerenciamento de fabricantes, compreendendo os métodos Inserir, Alterar e excluir

#### 2 - Atores 
>  Administrador

#### 3 - Pré-condições 
> Estar logado no sistema com uma conta reconhecida como um usuário do tipo Administrador
<ul>
  <li>Inserir: Atribuir um nome ao fabricante.</li>
  <li>Alterar: O estúdio deve ser existente no banco de dados.</li>
  <li>Excluir: O estúdio deve ser existente no banco de dados.</li>
</ul>

#### 4 - Pós-condições 

<ul>
  <li>Inserir: Novo fabricante inserido.</li>
  <li>Alterar: Informações do fabricante alteradas.</li>
  <li>Excluir: Fabricante excluído.</li>
</ul>

#### 5 - Fluxos de evento 

##### 5.1 - Fluxo básico 

<ul>
  <li>
    Inserir:&nbsp;
    
    1. [IN] O usuário acessa o endereço da interface de criação dos fabricantes.
    2. [OUT] O sistema apresenta a interface de criação de fabricantes. 
    3. [IN] O usuário preenche o campo de nome.
    4. [OUT] O sistema valida as informações e retorna para a interface de listagens dos fabricantes já registrados.
    
  </li>
 
  <li>Alterar: &nbsp;
    
    1. [IN] O usuário acessa o endereço da interface de alteração do fabricante.
    2. [OUT] O sistema exibe a interface de alteração do fabricantes selecionado.
    3. [IN] O usuário insere um novo nome.
    4. [OUT] O sistema valida as informações e retorna para a interface de listagens dos fabricantes já registrados.
    
  </li>
  
  <li>Excluir:  &nbsp;
    
    1. [IN] O usuário acessa a interface de exclusão do fabricante.
    2. [OUT] O sistema exibe a interface de exclusão do fabricante selecionado.
    3. [IN] O usuário confirma a exclusão.
    4. [OUT] O sistema valida as informações e retorna para a interface de listagens dos fabricantes já registrados.
    
  </li>
 
</ul>

<h5>5.2 - Fluxo alternativo </h5>

> Inexistente

<h5>5.3 - Fluxo de exceção </h5>

<ul>
  <li>Inserir passo 4 - Nome vazio:
    
    Caso o usuário tente inserir um fabricante sem nome, o sistema exibirá uma mensagem de erro informando que o atributo Nome
    do fabricante é obrigatório e retornará ao passo 3.
  
  <li>Excluir passo 4 - Fabricante conectado à produto existente:
    
    Caso o usuário tente excluir um fabricante que já esteja interligado a algum produto, o sistema apresentará uma mensagem de 
    erro informando a impossibilidade de exclusão daquele determinado fabricante e retornará ao passo 3.
    
  </li>
  
  <li>Alterar passo 4 - Nome vazio: 
    
    Caso o usuário tente salvar alterações de um fabricante sem nome, o sistema exibirá uma mensagem de erro informando que o 
    atributo Nome do fabricante é obrigatório e retornará ao passo 3.
    
  </li>
  </ul>
  
  #### 6 - Protótipos de interface 
| [<img src="https://user-images.githubusercontent.com/79111102/189199679-b3821e8a-a5fe-4dbe-8cad-d5bf3ad7376a.png" width=500><br><sub>Inserir</sub>](#) |  [<img src="https://user-images.githubusercontent.com/79111102/189203079-9d03b78f-93a9-4ee5-b200-9a4b78fb9359.png" width=500><br><sub>Excluir</sub>](#) | 
| :---: | :---: |
| [<img src="https://user-images.githubusercontent.com/79111102/189203135-9a0eec2b-e34b-43f4-b54b-8c7bdad2ffa2.png" width=500><br><sub>Alterar</sub>](#) |  [<img src="https://user-images.githubusercontent.com/79111102/189202758-38705b5e-5499-4bde-8be9-d245efd02c82.png" width=500><br><sub>Estúdios registrados</sub>](#) | 
  
---  

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

<h5>5.2 - Fluxo alternativo </h5>

> Inexistente

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
    - Fabricante vazio: Caso o usuário tente salvar alterações de um produto sem estúdio, o sistema exibirá uma mensagem de erro informando que o atributo 
    Fabricante é obrigatório e retornará ao passo 3.
    - Preço vazio: Caso o usuário tente salvar alterações de um produto sem preço, o sistema exibirá uma mensagem de erro informando que o atributo 
    Preço é obrigatório e retornará ao passo 3.
    - Preço negativo: Caso o usuário tente salvar alterações de um produto com valor menor que 0 no campo Preço, o sistema exibirá uma mensagem de erro informando 
    que o atributo Preço deve ser positivo e retornará ao passo 3.
    - Descrição vazia: Caso o usuário tente salvar alterações de um produto sem descrição, o sistema exibirá uma mensagem de erro informando que o atributo 
    Descricao é obrigatório e retornará ao passo 3.

    
 #### 6 - Protótipos de interface 
| [<img src="https://user-images.githubusercontent.com/79111102/189207165-c8d560bc-119b-4fdd-bdc1-9af50c084c47.png" width=500><br><sub>Inserir</sub>](#) |  [<img src="https://user-images.githubusercontent.com/79111102/189207354-57c2109f-3a3f-4297-b344-fe3d4a77a2bf.png" width=500><br><sub>Excluir</sub>](#) | 
| :---: | :---: |
| [<img src="https://user-images.githubusercontent.com/79111102/189207335-79445a3d-f96b-4ee6-86d3-82cd5b5c52b0.png" width=500><br><sub>Alterar</sub>](#) |  [<img src="https://user-images.githubusercontent.com/79111102/189207059-5d8dc16a-c78b-47e9-9078-5728c2d54a6a.png" width=500><br><sub>Produtos registrados</sub>](#) | 
 
 
 ---
 
### Gerenciamento de Usuário
#### 1 - Resumo
> Possibilita que o usuário - do tipo Administrador - realize o gerenciamento de usuários, compreendendo os métodos Inserir, Alterar e excluir

#### 2 - Atores 
>  Administrador

#### 3 - Pré-condições 
> Estar logado no sistema com uma conta reconhecida como um usuário do tipo Administrador
<ul>
  <li>Inserir: Atribuir um Username, Email e Senha de login.</li>
  <li>Alterar: O usuário deve ser existente no banco de dados.</li>
  <li>Excluir: O usuário deve ser existente no banco de dados.</li>
</ul>

#### 4 - Pós-condições 

<ul>
  <li>Inserir: Novo usuário inserido.</li>
  <li>Atualizar: Informações do usuário alteradas.</li>
  <li>Excluir: Usuário excluído.</li>
</ul>

#### 5 - Fluxos de evento 

##### 5.1 - Fluxo básico 

<ul>
  <li>
    Inserir:&nbsp;
    
    1. [IN] O Administrador acessa o endereço da interface de criação dos usuários.
    2. [OUT] O sistema apresenta a interface de criação de usuários. 
    3. [IN] O Administrador preenche os campos de Username, Email e senha.
    4. [OUT] O sistema valida as informações e retorna para a interface de listagens dos usuários já registrados.
    
  </li>
 
  <li>Alterar: &nbsp;
    
    1. [IN] O Administrador acessa o endereço da interface de alteração do usuário.
    2. [OUT] O sistema exibe a interface de alteração do usuário selecionado.
    3. [IN] O Administrador altera a informação do campo desejado.
    4. [OUT] O sistema valida as informações e retorna para a interface de listagens dos usuários já registrados.
    
  </li>
  
  <li>Excluir:  &nbsp;
    
    1. [IN] O Administrador acessa a interface de exclusão do usuário.
    2. [OUT] O sistema exibe a interface de exclusão do usuário selecionado.
    3. [IN] O Administrador confirma a exclusão.
    4. [OUT] O sistema valida as informações e retorna para a interface de listagens dos usuários já registrados.
    
  </li>
 
</ul>

<h5>5.2 - Fluxo alternativo </h5>

> Inexistente

<h5>5.3 - Fluxo de exceção </h5>


 - Inserir passo 4:
    
    - Username vazio: Caso o usuário tente inserir um produto sem nickname, o sistema exibirá uma mensagem de erro informando que o atributo Nome
    do usuário é obrigatório e retornará ao passo 3.
    - Email vazio: Caso o usuário tente inserir um produto sem o campo Email, o sistema exibirá uma mensagem de erro informando que o atributo Email
    é obrigatório e retornará ao passo 3.
    - Senha vazia: Caso o usuário tente inserir um produto sem Senha, o sistema exibirá uma mensagem de erro informando que o atributo 
    Senha é obrigatório e retornará ao passo 3.
    
    
  
 - Excluir: 
    
    > Inexistente
    
 
  
  - Alterar: 
    
    - Username vazio: Caso o usuário tente salvar alterações de um produto sem nickname, o sistema exibirá uma mensagem de erro informando que o atributo Nome
    do usuário é obrigatório e retornará ao passo 3.
    - Email vazio: Caso o usuário tente salvar alterações de um produto sem o campo Email, o sistema exibirá uma mensagem de erro informando que o atributo Email
    é obrigatório e retornará ao passo 3.
    - Senha vazia: Caso o usuário tente salvar alterações de um produto sem Senha, o sistema exibirá uma mensagem de erro informando que o atributo 
    Senha é obrigatório e retornará ao passo 3.
    
    
#### 6 - Protótipos de interface 
| [<img src="https://user-images.githubusercontent.com/79111102/189208001-c56d3ab6-b6a9-45a6-88d9-6ec16cb4a7b2.png" width=500><br><sub>Inserir</sub>](#) |  [<img src="https://user-images.githubusercontent.com/79111102/189208307-d40fa8f6-9fc5-4a57-b2f5-e146aad5ab46.png" width=500><br><sub>Excluir</sub>](#) | 
| :---: | :---: |
| [<img src="https://user-images.githubusercontent.com/79111102/189208234-e257eed5-8f1b-45ee-9cb6-1d33c33140f3.png" width=500><br><sub>Alterar</sub>](#) |  [<img src="https://user-images.githubusercontent.com/79111102/189207946-a937bd0f-f6dc-4303-b112-12889af14c2e.png" width=500><br><sub>Usuários registrados</sub>](#) |
    
---
    
