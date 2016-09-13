# IO.Swagger.Model.Transaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | UUID que identifica unicamente a transação. | 
**TransactionType** | **string** | Tipo da transação. | 
**Status** | **string** | Status da transação. | 
**Description** | **string** | Descrição da transação. | [optional] 
**TerminalNumber** | **int?** | Número do terminal da Cielo Lio em que o pagamento foi realizado. | 
**Card** | [**Card**](Card.md) |  | 
**Number** | **int?** | Número Sequencial Único (NSU) da transação. | 
**AuthorizationCode** | **int?** | Código de autorização da transação. | 
**PaymentProduct** | [**PaymentProduct**](PaymentProduct.md) |  | 
**Amount** | **string** | Valor da transação. Exemplo: O valor de R$ 10,00 é representado como 1000. | 
**CreatedAt** | **DateTime?** | Data da criação/inclusão do item no pedido. A data deve estar no formato: YYYY-MM-DDThh:mm:ssZ (Exemplo: 20151020T13:13:29.000Z) | 
**UpdatedAt** | **DateTime?** | Data da última atualização do item no pedido. A data deve estar no formato: YYYY-MM-DDThh:mm:ssZ (Exemplo: 20151020T13:13:29.000Z) | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

