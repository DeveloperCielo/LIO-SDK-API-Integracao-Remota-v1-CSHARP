# IO.Swagger.Model.Order
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | UUID que identifica unicamente o pedido. | 
**Number** | **string** | Número do pedido. Gerelmente esse número representa o identificador do pedido em um sistema externo através da integração com parceiros. | [optional] 
**Reference** | **string** | Referência do pedido. Utilizada para facilitar o acesso ou localização do mesmo. | [optional] 
**Status** | **string** | Status do pedido. | 
**CreatedAt** | **DateTime?** | Data de criação do pedido. A data deve estar no formato: YYYY-MM-DDThh:mm:ssZ (Exemplo: 20151020T13:13:29.000Z) | 
**UpdatedAt** | **DateTime?** | Data de última atualização do pedido. A data deve estar no formato: YYYY-MM-DDThh:mm:ssZ (Exemplo: 20151020T13:13:29.000Z) | 
**Items** | [**List&lt;OrderItem&gt;**](OrderItem.md) | Lista de itens contidos no pedido. | 
**Notes** | **string** | Campo disponível para uso do Merchant para comunicação. | [optional] 
**Transactions** | [**List&lt;Transaction&gt;**](Transaction.md) | Lista de transações de pagamento (ou outros tipos) efetuadas no pedido. | 
**Price** | **int?** | Valor total do pedido. Exemplo: O valor de R$ 10,00 é representado como 1000. | 
**Remaining** | **int?** | Valor restante do pagamento do pedido.Exemplo: O valor de R$ 10,00 é representado como 1000. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

