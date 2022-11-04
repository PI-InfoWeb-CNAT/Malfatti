# Especificação de casos de uso 

## Comércio Eletrônico

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 08/09/2022 | **1.0.5** | Protótipos | Maria Ricarte |
| 08/09/2022 | **1.0.3** | CDUs Usuário | Maria Ricarte |
| 07/09/2022 | **1.0.3** | CDUs Produto | Maria Ricarte |
| 07/09/2022 | **1.0.2** | CDUs Fabricante | Maria Ricarte |
| 06/09/2022 | **1.0.0** | CDUs Categoria | Maria Ricarte |


### Gerenciamento de Usuário
#### 1 - Resumo
> Possibilita que o usuário - do tipo Administrador - realize o gerenciamento de usuários, compreendendo os métodos Inserir, Alterar e excluir.

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
