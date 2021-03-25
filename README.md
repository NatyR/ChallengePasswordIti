## Validate Password API

~**Desafio Proposto**: Desenvolver uma API com o intuito de receber uma senha e realizar a validação da mesma. 

Recursos disponíveis para acesso via API:
* [**Password**](#reference/api/Password)

## Métodos
Requisições para a API devem seguir os padrões:
| Método | Descrição |
|---|---|
| `POST` | Utilizado para receber a senha e retorna-la validada. |

## Dados para envio do POST
| Parâmetro | Descrição |
|---|---|
| `password` | Recebe o valor passado pelo usuário |

+ Request (application/json)

    + Body

            {
                "password": "AbTp9!fok",                
            }

+ Response 200 (application/json)

## Respostas
| Código | Descrição |
|---|---|
| `200` | Requisição executada retornando true ou false para a senha.|
| `200` | Requisição executada retornando mensagem de erro e Status 0.|

## Requisitos
 **Quantidade de Caracteres** - Nove ou mais 
 **Dígitos** - No mínimo 1
 **Letra Maiúscula** - No mínimo 1
 **Letra Minúscula** - No mínimo 1
 **Caracteres Especiais** - No mínimo 1 (apenas os seguintes: !@#$%^&*()-+)
 **Espaçamento** - Não permitido
 **Repetições** - Não permitido
 
 ## Exemplo para Validação
| Senha | Válido |
|---|---|
| "" | Inválido|
| "aa" | Inválido|
| "ab" | Inválido|
| "AAAbbbCc" | Inválido|
| "AbTp9!foo" | Inválido|
| "AbTp9!foA" | Inválido|
| "AbTp9 fok" | Inválido|
| "AbTp9!fok" | **Válido**|


## Retornos
| Válido | Descrição |
|---|---|
| `200` | Requisição executada retornando true ou false para a senha.|
| `200` | Requisição executada retornando mensagem de erro e Status 0.|

