# Validate Password API

API desenvolvida com o intuito de receber uma senha e realizar a validação da mesma. 

Recursos disponíveis para acesso via API:
* [**Contatos**](#reference/api/Password)

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

