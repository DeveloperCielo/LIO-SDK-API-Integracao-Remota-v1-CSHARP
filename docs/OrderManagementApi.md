# IO.Swagger.Api.OrderManagementApi

All URIs are relative to *https://api.cielo.com.br/sandbox-lio/order-management/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrderAddItem**](OrderManagementApi.md#orderadditem) | **POST** /orders/{id}/items | 
[**OrderCreate**](OrderManagementApi.md#ordercreate) | **POST** /orders | 
[**OrderDelete**](OrderManagementApi.md#orderdelete) | **DELETE** /orders/{id} | 
[**OrderDeleteItem**](OrderManagementApi.md#orderdeleteitem) | **DELETE** /orders/{id}/items/{itemId} | 
[**OrderGet**](OrderManagementApi.md#orderget) | **GET** /orders/{id} | 
[**OrderGetByParameters**](OrderManagementApi.md#ordergetbyparameters) | **GET** /orders | 
[**OrderGetItem**](OrderManagementApi.md#ordergetitem) | **GET** /orders/{id}/items | 
[**OrderGetTransactions**](OrderManagementApi.md#ordergettransactions) | **GET** /orders/{id}/transactions | 
[**OrderUpdate**](OrderManagementApi.md#orderupdate) | **PUT** /orders/{id} | 
[**OrderUpdateItem**](OrderManagementApi.md#orderupdateitem) | **PUT** /orders/{id}/items/{itemId} | 


<a name="orderadditem"></a>
# **OrderAddItem**
> InlineResponse201 OrderAddItem (string clientId, string accessToken, string merchantId, string id, Body1 body)



Recurso responsável por efetuar a inclusão de um novo item em um pedido.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderAddItemExample
    {
        public void main()
        {
            // Configure API key authorization: access-token
            Configuration.Default.ApiKey.Add("access-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access-token", "Bearer");
            // Configure API key authorization: client-id
            Configuration.Default.ApiKey.Add("client-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("client-id", "Bearer");
            // Configure API key authorization: merchant-id
            Configuration.Default.ApiKey.Add("merchant-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("merchant-id", "Bearer");

            var apiInstance = new OrderManagementApi();
            var clientId = clientId_example;  // string | Token da aplicação (APP Token) gerado durante o processo de cadastro.
            var accessToken = accessToken_example;  // string | Token de acesso (Access Token) gerado durante o processo de cadastro.
            var merchantId = merchantId_example;  // string | Identificador do estabelecimento comercial gerado durante o processo de cadastro.
            var id = id_example;  // string | Identificador do pedido.
            var body = new Body1(); // Body1 | 

            try
            {
                InlineResponse201 result = apiInstance.OrderAddItem(clientId, accessToken, merchantId, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderManagementApi.OrderAddItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Token da aplicação (APP Token) gerado durante o processo de cadastro. | 
 **accessToken** | **string**| Token de acesso (Access Token) gerado durante o processo de cadastro. | 
 **merchantId** | **string**| Identificador do estabelecimento comercial gerado durante o processo de cadastro. | 
 **id** | **string**| Identificador do pedido. | 
 **body** | [**Body1**](Body1.md)|  | 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[access-token](../README.md#access-token), [client-id](../README.md#client-id), [merchant-id](../README.md#merchant-id)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercreate"></a>
# **OrderCreate**
> InlineResponse201 OrderCreate (string clientId, string accessToken, string merchantId, Body body)



Recurso responsável por efetuar a criação de um pedido.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderCreateExample
    {
        public void main()
        {
            // Configure API key authorization: access-token
            Configuration.Default.ApiKey.Add("access-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access-token", "Bearer");
            // Configure API key authorization: client-id
            Configuration.Default.ApiKey.Add("client-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("client-id", "Bearer");
            // Configure API key authorization: merchant-id
            Configuration.Default.ApiKey.Add("merchant-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("merchant-id", "Bearer");

            var apiInstance = new OrderManagementApi();
            var clientId = clientId_example;  // string | Token da aplicação (APP Token) gerado durante o processo de cadastro.
            var accessToken = accessToken_example;  // string | Token de acesso (Access Token) gerado durante o processo de cadastro.
            var merchantId = merchantId_example;  // string | Identificador do estabelecimento comercial gerado durante o processo de cadastro.
            var body = new Body(); // Body | 

            try
            {
                InlineResponse201 result = apiInstance.OrderCreate(clientId, accessToken, merchantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderManagementApi.OrderCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Token da aplicação (APP Token) gerado durante o processo de cadastro. | 
 **accessToken** | **string**| Token de acesso (Access Token) gerado durante o processo de cadastro. | 
 **merchantId** | **string**| Identificador do estabelecimento comercial gerado durante o processo de cadastro. | 
 **body** | [**Body**](Body.md)|  | 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[access-token](../README.md#access-token), [client-id](../README.md#client-id), [merchant-id](../README.md#merchant-id)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderdelete"></a>
# **OrderDelete**
> void OrderDelete (string clientId, string accessToken, string merchantId, string id)



Recurso responsável por efetuar a exclusão de um pedido.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: access-token
            Configuration.Default.ApiKey.Add("access-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access-token", "Bearer");
            // Configure API key authorization: client-id
            Configuration.Default.ApiKey.Add("client-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("client-id", "Bearer");
            // Configure API key authorization: merchant-id
            Configuration.Default.ApiKey.Add("merchant-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("merchant-id", "Bearer");

            var apiInstance = new OrderManagementApi();
            var clientId = clientId_example;  // string | Token da aplicação (APP Token) gerado durante o processo de cadastro.
            var accessToken = accessToken_example;  // string | Token de acesso (Access Token) gerado durante o processo de cadastro.
            var merchantId = merchantId_example;  // string | Identificador do estabelecimento comercial gerado durante o processo de cadastro.
            var id = id_example;  // string | Identificador do pedido.

            try
            {
                apiInstance.OrderDelete(clientId, accessToken, merchantId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderManagementApi.OrderDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Token da aplicação (APP Token) gerado durante o processo de cadastro. | 
 **accessToken** | **string**| Token de acesso (Access Token) gerado durante o processo de cadastro. | 
 **merchantId** | **string**| Identificador do estabelecimento comercial gerado durante o processo de cadastro. | 
 **id** | **string**| Identificador do pedido. | 

### Return type

void (empty response body)

### Authorization

[access-token](../README.md#access-token), [client-id](../README.md#client-id), [merchant-id](../README.md#merchant-id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderdeleteitem"></a>
# **OrderDeleteItem**
> InlineResponse201 OrderDeleteItem (string clientId, string accessToken, string merchantId, string id, string itemId)



Recurso responsável por efetuar a exclusão de um item de um pedido.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderDeleteItemExample
    {
        public void main()
        {
            // Configure API key authorization: access-token
            Configuration.Default.ApiKey.Add("access-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access-token", "Bearer");
            // Configure API key authorization: client-id
            Configuration.Default.ApiKey.Add("client-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("client-id", "Bearer");
            // Configure API key authorization: merchant-id
            Configuration.Default.ApiKey.Add("merchant-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("merchant-id", "Bearer");

            var apiInstance = new OrderManagementApi();
            var clientId = clientId_example;  // string | Token da aplicação (APP Token) gerado durante o processo de cadastro.
            var accessToken = accessToken_example;  // string | Token de acesso (Access Token) gerado durante o processo de cadastro.
            var merchantId = merchantId_example;  // string | Identificador do estabelecimento comercial gerado durante o processo de cadastro.
            var id = id_example;  // string | Identificador do pedido.
            var itemId = itemId_example;  // string | Identificador do item do pedido.

            try
            {
                InlineResponse201 result = apiInstance.OrderDeleteItem(clientId, accessToken, merchantId, id, itemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderManagementApi.OrderDeleteItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Token da aplicação (APP Token) gerado durante o processo de cadastro. | 
 **accessToken** | **string**| Token de acesso (Access Token) gerado durante o processo de cadastro. | 
 **merchantId** | **string**| Identificador do estabelecimento comercial gerado durante o processo de cadastro. | 
 **id** | **string**| Identificador do pedido. | 
 **itemId** | **string**| Identificador do item do pedido. | 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[access-token](../README.md#access-token), [client-id](../README.md#client-id), [merchant-id](../README.md#merchant-id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderget"></a>
# **OrderGet**
> InlineResponse200 OrderGet (string clientId, string accessToken, string merchantId, string id)



Recurso responsável por efetuar a consulta de um pedido.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderGetExample
    {
        public void main()
        {
            // Configure API key authorization: access-token
            Configuration.Default.ApiKey.Add("access-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access-token", "Bearer");
            // Configure API key authorization: client-id
            Configuration.Default.ApiKey.Add("client-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("client-id", "Bearer");
            // Configure API key authorization: merchant-id
            Configuration.Default.ApiKey.Add("merchant-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("merchant-id", "Bearer");

            var apiInstance = new OrderManagementApi();
            var clientId = clientId_example;  // string | Token da aplicação (APP Token) gerado durante o processo de cadastro.
            var accessToken = accessToken_example;  // string | Token de acesso (Access Token) gerado durante o processo de cadastro.
            var merchantId = merchantId_example;  // string | Identificador do estabelecimento comercial gerado durante o processo de cadastro.
            var id = id_example;  // string | Identificador do pedido.

            try
            {
                InlineResponse200 result = apiInstance.OrderGet(clientId, accessToken, merchantId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderManagementApi.OrderGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Token da aplicação (APP Token) gerado durante o processo de cadastro. | 
 **accessToken** | **string**| Token de acesso (Access Token) gerado durante o processo de cadastro. | 
 **merchantId** | **string**| Identificador do estabelecimento comercial gerado durante o processo de cadastro. | 
 **id** | **string**| Identificador do pedido. | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access-token](../README.md#access-token), [client-id](../README.md#client-id), [merchant-id](../README.md#merchant-id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordergetbyparameters"></a>
# **OrderGetByParameters**
> List<InlineResponse200> OrderGetByParameters (string clientId, string accessToken, string merchantId, string parameters)



Recurso responsável por efetuar a consulta de pedidos, com a possibilidade de aplicar filtros.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderGetByParametersExample
    {
        public void main()
        {
            // Configure API key authorization: access-token
            Configuration.Default.ApiKey.Add("access-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access-token", "Bearer");
            // Configure API key authorization: client-id
            Configuration.Default.ApiKey.Add("client-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("client-id", "Bearer");
            // Configure API key authorization: merchant-id
            Configuration.Default.ApiKey.Add("merchant-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("merchant-id", "Bearer");

            var apiInstance = new OrderManagementApi();
            var clientId = clientId_example;  // string | Token da aplicação (APP Token) gerado durante o processo de cadastro.
            var accessToken = accessToken_example;  // string | Token de acesso (Access Token) gerado durante o processo de cadastro.
            var merchantId = merchantId_example;  // string | Identificador do estabelecimento comercial gerado durante o processo de cadastro.
            var parameters = parameters_example;  // string | Parâmetros para filtrar a consulta. Os possíveis parâmetros são: number (Número do pedidos), reference (Referência do pedido) e status (Status do pedidos: DRAFT, ENTERED, CANCELED, PAID, APPROVED, REJECTED, RE-ENTERED e CLOSED).

            try
            {
                List&lt;InlineResponse200&gt; result = apiInstance.OrderGetByParameters(clientId, accessToken, merchantId, parameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderManagementApi.OrderGetByParameters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Token da aplicação (APP Token) gerado durante o processo de cadastro. | 
 **accessToken** | **string**| Token de acesso (Access Token) gerado durante o processo de cadastro. | 
 **merchantId** | **string**| Identificador do estabelecimento comercial gerado durante o processo de cadastro. | 
 **parameters** | **string**| Parâmetros para filtrar a consulta. Os possíveis parâmetros são: number (Número do pedidos), reference (Referência do pedido) e status (Status do pedidos: DRAFT, ENTERED, CANCELED, PAID, APPROVED, REJECTED, RE-ENTERED e CLOSED). | 

### Return type

[**List<InlineResponse200>**](InlineResponse200.md)

### Authorization

[access-token](../README.md#access-token), [client-id](../README.md#client-id), [merchant-id](../README.md#merchant-id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordergetitem"></a>
# **OrderGetItem**
> OrdersItems OrderGetItem (string clientId, string accessToken, string merchantId, string id)



Recurso responsável por efetuar a consulta de um item em um pedido.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderGetItemExample
    {
        public void main()
        {
            // Configure API key authorization: access-token
            Configuration.Default.ApiKey.Add("access-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access-token", "Bearer");
            // Configure API key authorization: client-id
            Configuration.Default.ApiKey.Add("client-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("client-id", "Bearer");
            // Configure API key authorization: merchant-id
            Configuration.Default.ApiKey.Add("merchant-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("merchant-id", "Bearer");

            var apiInstance = new OrderManagementApi();
            var clientId = clientId_example;  // string | Token da aplicação (APP Token) gerado durante o processo de cadastro.
            var accessToken = accessToken_example;  // string | Token de acesso (Access Token) gerado durante o processo de cadastro.
            var merchantId = merchantId_example;  // string | Identificador do estabelecimento comercial gerado durante o processo de cadastro.
            var id = id_example;  // string | Identificador do pedido.

            try
            {
                OrdersItems result = apiInstance.OrderGetItem(clientId, accessToken, merchantId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderManagementApi.OrderGetItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Token da aplicação (APP Token) gerado durante o processo de cadastro. | 
 **accessToken** | **string**| Token de acesso (Access Token) gerado durante o processo de cadastro. | 
 **merchantId** | **string**| Identificador do estabelecimento comercial gerado durante o processo de cadastro. | 
 **id** | **string**| Identificador do pedido. | 

### Return type

[**OrdersItems**](OrdersItems.md)

### Authorization

[access-token](../README.md#access-token), [client-id](../README.md#client-id), [merchant-id](../README.md#merchant-id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordergettransactions"></a>
# **OrderGetTransactions**
> OrdersTransactions OrderGetTransactions (string clientId, string accessToken, string merchantId, string id)



Recurso responsável por efetuar a consulta das transações de um pedido.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderGetTransactionsExample
    {
        public void main()
        {
            // Configure API key authorization: access-token
            Configuration.Default.ApiKey.Add("access-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access-token", "Bearer");
            // Configure API key authorization: client-id
            Configuration.Default.ApiKey.Add("client-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("client-id", "Bearer");
            // Configure API key authorization: merchant-id
            Configuration.Default.ApiKey.Add("merchant-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("merchant-id", "Bearer");

            var apiInstance = new OrderManagementApi();
            var clientId = clientId_example;  // string | Token da aplicação (APP Token) gerado durante o processo de cadastro.
            var accessToken = accessToken_example;  // string | Token de acesso (Access Token) gerado durante o processo de cadastro.
            var merchantId = merchantId_example;  // string | Identificador do estabelecimento comercial gerado durante o processo de cadastro.
            var id = id_example;  // string | Identificador do pedido.

            try
            {
                OrdersTransactions result = apiInstance.OrderGetTransactions(clientId, accessToken, merchantId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderManagementApi.OrderGetTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Token da aplicação (APP Token) gerado durante o processo de cadastro. | 
 **accessToken** | **string**| Token de acesso (Access Token) gerado durante o processo de cadastro. | 
 **merchantId** | **string**| Identificador do estabelecimento comercial gerado durante o processo de cadastro. | 
 **id** | **string**| Identificador do pedido. | 

### Return type

[**OrdersTransactions**](OrdersTransactions.md)

### Authorization

[access-token](../README.md#access-token), [client-id](../README.md#client-id), [merchant-id](../README.md#merchant-id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderupdate"></a>
# **OrderUpdate**
> void OrderUpdate (string clientId, string accessToken, string merchantId, string id, string operation)



Recurso responsável por efetuar o cancelamento de um pedido.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: access-token
            Configuration.Default.ApiKey.Add("access-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access-token", "Bearer");
            // Configure API key authorization: client-id
            Configuration.Default.ApiKey.Add("client-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("client-id", "Bearer");
            // Configure API key authorization: merchant-id
            Configuration.Default.ApiKey.Add("merchant-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("merchant-id", "Bearer");

            var apiInstance = new OrderManagementApi();
            var clientId = clientId_example;  // string | Token da aplicação (APP Token) gerado durante o processo de cadastro.
            var accessToken = accessToken_example;  // string | Token de acesso (Access Token) gerado durante o processo de cadastro.
            var merchantId = merchantId_example;  // string | Identificador do estabelecimento comercial gerado durante o processo de cadastro.
            var id = id_example;  // string | Identificador do pedido.
            var operation = operation_example;  // string | Operação que deve ser executada. As possíveis operações são: cancel (cancelamento de um pedido), close (fechamento de um pedido), place (liberação de um pedido para pagamento).

            try
            {
                apiInstance.OrderUpdate(clientId, accessToken, merchantId, id, operation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderManagementApi.OrderUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Token da aplicação (APP Token) gerado durante o processo de cadastro. | 
 **accessToken** | **string**| Token de acesso (Access Token) gerado durante o processo de cadastro. | 
 **merchantId** | **string**| Identificador do estabelecimento comercial gerado durante o processo de cadastro. | 
 **id** | **string**| Identificador do pedido. | 
 **operation** | **string**| Operação que deve ser executada. As possíveis operações são: cancel (cancelamento de um pedido), close (fechamento de um pedido), place (liberação de um pedido para pagamento). | 

### Return type

void (empty response body)

### Authorization

[access-token](../README.md#access-token), [client-id](../README.md#client-id), [merchant-id](../README.md#merchant-id)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderupdateitem"></a>
# **OrderUpdateItem**
> InlineResponse201 OrderUpdateItem (string clientId, string accessToken, string merchantId, string id, string itemId, Body2 body)



Recurso responsável por efetuar a alteração de um item de um pedido.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderUpdateItemExample
    {
        public void main()
        {
            // Configure API key authorization: access-token
            Configuration.Default.ApiKey.Add("access-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access-token", "Bearer");
            // Configure API key authorization: client-id
            Configuration.Default.ApiKey.Add("client-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("client-id", "Bearer");
            // Configure API key authorization: merchant-id
            Configuration.Default.ApiKey.Add("merchant-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("merchant-id", "Bearer");

            var apiInstance = new OrderManagementApi();
            var clientId = clientId_example;  // string | Token da aplicação (APP Token) gerado durante o processo de cadastro.
            var accessToken = accessToken_example;  // string | Token de acesso (Access Token) gerado durante o processo de cadastro.
            var merchantId = merchantId_example;  // string | Identificador do estabelecimento comercial gerado durante o processo de cadastro.
            var id = id_example;  // string | Identificador do pedido.
            var itemId = itemId_example;  // string | Identificador do item do pedido.
            var body = new Body2(); // Body2 | 

            try
            {
                InlineResponse201 result = apiInstance.OrderUpdateItem(clientId, accessToken, merchantId, id, itemId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderManagementApi.OrderUpdateItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| Token da aplicação (APP Token) gerado durante o processo de cadastro. | 
 **accessToken** | **string**| Token de acesso (Access Token) gerado durante o processo de cadastro. | 
 **merchantId** | **string**| Identificador do estabelecimento comercial gerado durante o processo de cadastro. | 
 **id** | **string**| Identificador do pedido. | 
 **itemId** | **string**| Identificador do item do pedido. | 
 **body** | [**Body2**](Body2.md)|  | 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[access-token](../README.md#access-token), [client-id](../README.md#client-id), [merchant-id](../README.md#merchant-id)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

