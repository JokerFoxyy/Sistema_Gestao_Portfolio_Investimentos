# Sistema de Gestão de Portfólio de Investimentos

## Para executar a aplicação de gestão de portfólio de investimentos, siga os passos abaixo:

### Pré-requisitos
- .NET 6.0 SDK ou superior
- Ferramenta de linha de comando .NET Core (`dotnet`)

### Passos

1. **Clone o Repositório**

   ```bash
   git clone <URL_DO_REPOSITORIO>
   cd PortfolioManagement


2. **Restaure as dependências do projeto usando o comando:**
dotnet restore

3. **Compilar o Projeto**
dotnet build

4. **Executar a Aplicação**
dotnet run

5. **A API estará disponível em https://localhost:5001 ou http://localhost:5000. Para acessar a documentação Swagger, navegue até https://localhost:5001/swagger ou http://localhost:5000/swagger.**

## Como Utilizar

  ### Endpoints de Produtos Financeiros

1. **Consultar Todos os Produtos**
GET /api/products

2. **Consultar Produto por ID**
GET /api/products/{id}

3. **Adicionar Produto**
POST /api/products

exemplo de corpo da requisição

```bash
{
    "name": "Produto 1",
    "maturityDate": "2024-12-31T00:00:00Z",
    "price": 100.00
}
```

4. **Atualizar Produto**
PUT /api/products/{id}
corpo da requisição

```bash
{
    "id": 1,
    "name": "Produto Atualizado",
    "maturityDate": "2024-12-31T00:00:00Z",
    "price": 120.00
}
```
5. **Deletar Produto**
DELETE /api/products/{id}


	## Endpoints de Investimentos

1. **Consultar Todos os Investimentos de um Cliente**
GET /api/investments/{clientId}

2. **Consultar Investimento por ID**
GET /api/investments/{clientId}/{investmentId}

3. **Comprar Investimento**
POST /api/investments/{clientId}

corpo da requisição:
```bash
{
    "productId": 1,
    "amount": 1000.00
}
```

4. **Vender Investimento**
DELETE /api/investments/{clientId}/{investmentId}


# Exemplo de Fluxo de Utilização

## Adicionar um Produto Financeiro

** Faça uma requisição POST para /api/products com o corpo da requisição contendo os detalhes do produto.**

## Consultar Produtos Financeiros

### Faça uma requisição GET para /api/products para obter a lista de produtos financeiros disponíveis.

##Comprar um Investimento

### Faça uma requisição POST para /api/investments/{clientId} onde clientId é o ID do cliente que está comprando o investimento, com o corpo da requisição contendo os detalhes do investimento.

## Consultar Investimentos de um Cliente

### Faça uma requisição GET para /api/investments/{clientId} onde clientId é o ID do cliente para obter a lista de todos os investimentos do cliente.

## Vender um Investimento

### Faça uma requisição DELETE para /api/investments/{clientId}/{investmentId} onde clientId é o ID do cliente e investmentId é o ID do investimento a ser vendido.

#Para utilizar o serviço de email ele deve ser configurado corretamente.


