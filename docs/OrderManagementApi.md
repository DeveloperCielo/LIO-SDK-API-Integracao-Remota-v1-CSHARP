# IO.Swagger.Api.OrderManagementApi

All URIs are relative to *https://api.cielo.com.br/order-management/v1*

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
> Response OrderAddItem (string clientId, string accessToken, string merchantId, string id, OrderItem body)



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
            
            var apiInstance = new OrderManagementApi();
            var clientId = clientId_example;  // string | Token da aplicação (APP Token) gerado durante o processo de cadastro.
            var accessToken = accessToken_example;  // string | Token de acesso (Access Token) gerado durante o processo de cadastro.
            var merchantId = merchantId_example;  // string | Identificador do estabelecimento comercial gerado durante o processo de cadastro.
            var id = id_example;  // string | Identificador do pedido.
            var body = new OrderItem(); // OrderItem | 

            try
            {
                Response result = apiInstance.OrderAddItem(clientId, accessToken, merchantId, id, body);
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
 **body** | [**OrderItem**](OrderItem.md)|  | 

### Return type

[**Response**](Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercreate"></a>
# **OrderCreate**
> Response OrderCreate (string clientId, string accessToken, string merchantId, Order body)



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
            
            var apiInstance = new OrderManagementApi();
            var clientId = clientId_example;  // string | Token da aplicação (APP Token) gerado durante o processo de cadastro.
            var accessToken = accessToken_example;  // string | Token de acesso (Access Token) gerado durante o processo de cadastro.
            var merchantId = merchantId_example;  // string | Identificador do estabelecimento comercial gerado durante o processo de cadastro.
            var body = new Order(); // Order | 

            try
            {
                Response result = apiInstance.OrderCreate(clientId, accessToken, merchantId, body);
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
 **body** | [**Order**](Order.md)|  | 

### Return type

[**Response**](Response.md)

### Authorization

No authorization required

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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderdeleteitem"></a>
# **OrderDeleteItem**
> Response OrderDeleteItem (string clientId, string accessToken, string merchantId, string id, string itemId)



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
            
            var apiInstance = new OrderManagementApi();
            var clientId = clientId_example;  // string | Token da aplicação (APP Token) gerado durante o processo de cadastro.
            var accessToken = accessToken_example;  // string | Token de acesso (Access Token) gerado durante o processo de cadastro.
            var merchantId = merchantId_example;  // string | Identificador do estabelecimento comercial gerado durante o processo de cadastro.
            var id = id_example;  // string | Identificador do pedido.
            var itemId = itemId_example;  // string | Identificador do item do pedido.

            try
            {
                Response result = apiInstance.OrderDeleteItem(clientId, accessToken, merchantId, id, itemId);
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

[**Response**](Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderget"></a>
# **OrderGet**
> Order OrderGet (string clientId, string accessToken, string merchantId, string id)



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
            
            var apiInstance = new OrderManagementApi();
            var clientId = clientId_example;  // string | Token da aplicação (APP Token) gerado durante o processo de cadastro.
            var accessToken = accessToken_example;  // string | Token de acesso (Access Token) gerado durante o processo de cadastro.
            var merchantId = merchantId_example;  // string | Identificador do estabelecimento comercial gerado durante o processo de cadastro.
            var id = id_example;  // string | Identificador do pedido.

            try
            {
                Order result = apiInstance.OrderGet(clientId, accessToken, merchantId, id);
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

[**Order**](Order.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordergetbyparameters"></a>
# **OrderGetByParameters**
> void OrderGetByParameters (string clientId, string accessToken, string merchantId, string parameters)



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
            
            var apiInstance = new OrderManagementApi();
            var clientId = clientId_example;  // string | Token da aplicação (APP Token) gerado durante o processo de cadastro.
            var accessToken = accessToken_example;  // string | Token de acesso (Access Token) gerado durante o processo de cadastro.
            var merchantId = merchantId_example;  // string | Identificador do estabelecimento comercial gerado durante o processo de cadastro.
            var parameters = parameters_example;  // string | Parâmetros para filtrar a consulta. Os possíveis parâmetros são: number (Número do pedidos), reference (Referência do pedido) e status (Status do pedidos: DRAFT, ENTERED, CANCELED, PAID, APPROVED, REJECTED, RE-ENTERED e CLOSED).

            try
            {
                apiInstance.OrderGetByParameters(clientId, accessToken, merchantId, parameters);
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordergetitem"></a>
# **OrderGetItem**
> OrderItem OrderGetItem (string clientId, string accessToken, string merchantId, string id)



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
            
            var apiInstance = new OrderManagementApi();
            var clientId = clientId_example;  // string | Token da aplicação (APP Token) gerado durante o processo de cadastro.
            var accessToken = accessToken_example;  // string | Token de acesso (Access Token) gerado durante o processo de cadastro.
            var merchantId = merchantId_example;  // string | Identificador do estabelecimento comercial gerado durante o processo de cadastro.
            var id = id_example;  // string | Identificador do pedido.

            try
            {
                OrderItem result = apiInstance.OrderGetItem(clientId, accessToken, merchantId, id);
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

[**OrderItem**](OrderItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordergettransactions"></a>
# **OrderGetTransactions**
> Transaction OrderGetTransactions (string clientId, string accessToken, string merchantId, string id)



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
            
            var apiInstance = new OrderManagementApi();
            var clientId = clientId_example;  // string | Token da aplicação (APP Token) gerado durante o processo de cadastro.
            var accessToken = accessToken_example;  // string | Token de acesso (Access Token) gerado durante o processo de cadastro.
            var merchantId = merchantId_example;  // string | Identificador do estabelecimento comercial gerado durante o processo de cadastro.
            var id = id_example;  // string | Identificador do pedido.

            try
            {
                Transaction result = apiInstance.OrderGetTransactions(clientId, accessToken, merchantId, id);
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

[**Transaction**](Transaction.md)

### Authorization

No authorization required

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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderupdateitem"></a>
# **OrderUpdateItem**
> Response OrderUpdateItem (string clientId, string accessToken, string merchantId, string id, string itemId, OrderItem body)



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
            
            var apiInstance = new OrderManagementApi();
            var clientId = clientId_example;  // string | Token da aplicação (APP Token) gerado durante o processo de cadastro.
            var accessToken = accessToken_example;  // string | Token de acesso (Access Token) gerado durante o processo de cadastro.
            var merchantId = merchantId_example;  // string | Identificador do estabelecimento comercial gerado durante o processo de cadastro.
            var id = id_example;  // string | Identificador do pedido.
            var itemId = itemId_example;  // string | Identificador do item do pedido.
            var body = new OrderItem(); // OrderItem | 

            try
            {
                Response result = apiInstance.OrderUpdateItem(clientId, accessToken, merchantId, id, itemId, body);
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
 **body** | [**OrderItem**](OrderItem.md)|  | 

### Return type

[**Response**](Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

