# Especificação de casos de uso 

## Comércio Eletrônico

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 08/09/2022 | **1.0.5** | Protótipos | Maria Ricarte |
| 06/11/2022 | **1.0.1** | CDUs Categoria | Jainne Agatha |

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
 
