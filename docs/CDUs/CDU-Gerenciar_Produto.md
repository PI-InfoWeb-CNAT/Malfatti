# Especificação de casos de uso 

## Comércio Eletrônico

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 08/09/2022 | **1.0.5** | Protótipos | Maria Ricarte |
| 08/09/2022 | **1.0.3** | CDUs Usuário | Maria Ricarte |
| 07/09/2022 | **1.0.3** | CDUs Produto | Maria Ricarte |
| 07/09/2022 | **1.0.2** | CDUs Fabricante | Maria Ricarte |
| 06/09/2022 | **1.0.0** | CDUs Categoria | Maria Ricarte |

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
| [<img src="https://github.com/PI-InfoWeb-CNAT/Malfatti/blob/main/docs/Fotos%20do%20cdus/Cadastro%20Categoria%20adm.png" width=500><br><sub>Cadastro</sub>](#) |  [<img src="https://github.com/PI-InfoWeb-CNAT/Malfatti/blob/main/docs/Fotos%20do%20cdus/Lista%20de%20Categorias%20adm.png" width=500><br><sub>Listagem para edição e exclusão</sub>](#) | 
| :---: | :---: |  


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
  <li>Alterar: O fabricante deve ser existente no banco de dados.</li>
  <li>Excluir: O fabricante deve ser existente no banco de dados.</li>
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
| [<img src="https://github.com/PI-InfoWeb-CNAT/Malfatti/blob/main/docs/Fotos%20do%20cdus/Cadastro%20FABRICANTE%20adm.png" width=500><br><sub>Cadastro</sub>](#) |  [<img src="https://github.com/PI-InfoWeb-CNAT/Malfatti/blob/main/docs/Fotos%20do%20cdus/Lista%20de%20Fabricantes%20adm.png" width=500><br><sub>Listagem para Edição e Exclusão</sub>](#) | 
| :---: | :---: |  
  
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
    - Fabricante vazio: Caso o usuário tente salvar alterações de um produto sem fabricante, o sistema exibirá uma mensagem de erro informando que o atributo 
    Fabricante é obrigatório e retornará ao passo 3.
    - Preço vazio: Caso o usuário tente salvar alterações de um produto sem preço, o sistema exibirá uma mensagem de erro informando que o atributo 
    Preço é obrigatório e retornará ao passo 3.
    - Preço negativo: Caso o usuário tente salvar alterações de um produto com valor menor que 0 no campo Preço, o sistema exibirá uma mensagem de erro informando 
    que o atributo Preço deve ser positivo e retornará ao passo 3.
    - Descrição vazia: Caso o usuário tente salvar alterações de um produto sem descrição, o sistema exibirá uma mensagem de erro informando que o atributo 
    Descricao é obrigatório e retornará ao passo 3.

    
 #### 6 - Protótipos de interface 
| [<img src="https://github.com/PI-InfoWeb-CNAT/Malfatti/blob/main/docs/Fotos%20do%20cdus/Cadastro%20Produto%20adm.png" width=500><br><sub>Cadastro</sub>](#) |  [<img src="https://github.com/PI-InfoWeb-CNAT/Malfatti/blob/main/docs/Fotos%20do%20cdus/Editar%20produtos%20adm.png" width=500><br><sub>Editar</sub>](#) | 
| :---: | :---: |
| [<img src="https://github.com/PI-InfoWeb-CNAT/Malfatti/blob/main/docs/Fotos%20do%20cdus/Lista%20de%20Produtos%20adm.png" width=500><br><sub>Listagem</sub>](#) |  
 
 ---
 
### Gerenciamento de Usuário
#### 1 - Resumo
> Possibilita que o usuário - do tipo Administrador - realize o gerenciamento de usuários, compreendendo os métodos Inserir, Alterar e excluir

#### 2 - Atores 
>  Administrador

#### 3 - Pré-condições 
> Estar logado no sistema com uma conta reconhecida como um usuário do tipo Administrador
<ul>
  <li>Inserir: Atribuir um Nome, Username, Email e Senha de login.</li>
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
    3. [IN] O Administrador preenche os campos de Nome, Username, Email e senha.
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
    
    - Nome vazio: Caso o usuário tente inserir um usuário sem Nome, o sistema exibirá uma mensagem de erro informando que o atributo Nome
    é obrigatório e retornará ao passo 3.
    - Username vazio: Caso o usuário tente inserir um usuário sem Username, o sistema exibirá uma mensagem de erro informando que o atributo Nome
    do usuário é obrigatório e retornará ao passo 3.
    - Email vazio: Caso o usuário tente inserir um usuário sem o campo Email, o sistema exibirá uma mensagem de erro informando que o atributo Email
    é obrigatório e retornará ao passo 3.
    - Senha vazia: Caso o usuário tente inserir um usuário sem Senha, o sistema exibirá uma mensagem de erro informando que o atributo 
    Senha é obrigatório e retornará ao passo 3.
    
    
  
 - Excluir: 
    
    > Inexistente
    
 
  
  - Alterar: 
    
    - Nome vazio: Caso o usuário tente salvar alterações de um usuário sem Nome, o sistema exibirá uma mensagem de erro informando que o atributo Nome
    é obrigatório e retornará ao passo 3.
    - Username vazio: Caso o usuário tente salvar alterações de um usuário sem Username, o sistema exibirá uma mensagem de erro informando que o atributo Nome
    do usuário é obrigatório e retornará ao passo 3.
    - Email vazio: Caso o usuário tente salvar alterações de um usuário sem o campo Email, o sistema exibirá uma mensagem de erro informando que o atributo Email
    é obrigatório e retornará ao passo 3.
    - Senha vazia: Caso o usuário tente salvar alterações de um usuário sem Senha, o sistema exibirá uma mensagem de erro informando que o atributo 
    Senha é obrigatório e retornará ao passo 3.
    
    
#### 6 - Protótipos de interface 
| [<img src="https://github.com/PI-InfoWeb-CNAT/Malfatti/blob/main/docs/Fotos%20do%20cdus/Cadastro%20de%20Usu%C3%A1rio.png" width=500><br><sub>Cadastro</sub>](#) |  [<img src="https://github.com/PI-InfoWeb-CNAT/Malfatti/blob/main/docs/Fotos%20do%20cdus/Editar%20ou%20excluir.png" width=500><br><sub>Perfil de editar ou excluir</sub>](#) | 
| :---: | :---: |

    
---
    
