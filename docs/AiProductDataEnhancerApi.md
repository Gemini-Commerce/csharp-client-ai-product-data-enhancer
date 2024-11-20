# aiproductdataenhancer.Api.AiProductDataEnhancerApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AiProductDataEnhancerFillProductData**](AiProductDataEnhancerApi.md#aiproductdataenhancerfillproductdata) | **POST** /aiproductdataenhancer.AiProductDataEnhancer/FillProductData |  |
| [**AiProductDataEnhancerFillProductDataCheck**](AiProductDataEnhancerApi.md#aiproductdataenhancerfillproductdatacheck) | **POST** /aiproductdataenhancer.AiProductDataEnhancer/FillProductDataCheck |  |
| [**AiProductDataEnhancerGenerateProductData**](AiProductDataEnhancerApi.md#aiproductdataenhancergenerateproductdata) | **POST** /aiproductdataenhancer.AiProductDataEnhancer/GenerateProductData |  |
| [**AiProductDataEnhancerTranslateData**](AiProductDataEnhancerApi.md#aiproductdataenhancertranslatedata) | **POST** /aiproductdataenhancer.AiProductDataEnhancer/TranslateData |  |

<a id="aiproductdataenhancerfillproductdata"></a>
# **AiProductDataEnhancerFillProductData**
> AiproductdataenhancerFillProductDataResponse AiProductDataEnhancerFillProductData (AiproductdataenhancerFillProductDataRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using aiproductdataenhancer.Api;
using aiproductdataenhancer.Client;
using aiproductdataenhancer.Model;

namespace Example
{
    public class AiProductDataEnhancerFillProductDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AiProductDataEnhancerApi(config);
            var body = new AiproductdataenhancerFillProductDataRequest(); // AiproductdataenhancerFillProductDataRequest | 

            try
            {
                AiproductdataenhancerFillProductDataResponse result = apiInstance.AiProductDataEnhancerFillProductData(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AiProductDataEnhancerApi.AiProductDataEnhancerFillProductData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiProductDataEnhancerFillProductDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AiproductdataenhancerFillProductDataResponse> response = apiInstance.AiProductDataEnhancerFillProductDataWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AiProductDataEnhancerApi.AiProductDataEnhancerFillProductDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**AiproductdataenhancerFillProductDataRequest**](AiproductdataenhancerFillProductDataRequest.md) |  |  |

### Return type

[**AiproductdataenhancerFillProductDataResponse**](AiproductdataenhancerFillProductDataResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiproductdataenhancerfillproductdatacheck"></a>
# **AiProductDataEnhancerFillProductDataCheck**
> AiproductdataenhancerFillProductDataCheckResponse AiProductDataEnhancerFillProductDataCheck (AiproductdataenhancerFillProductDataCheckRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using aiproductdataenhancer.Api;
using aiproductdataenhancer.Client;
using aiproductdataenhancer.Model;

namespace Example
{
    public class AiProductDataEnhancerFillProductDataCheckExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AiProductDataEnhancerApi(config);
            var body = new AiproductdataenhancerFillProductDataCheckRequest(); // AiproductdataenhancerFillProductDataCheckRequest | 

            try
            {
                AiproductdataenhancerFillProductDataCheckResponse result = apiInstance.AiProductDataEnhancerFillProductDataCheck(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AiProductDataEnhancerApi.AiProductDataEnhancerFillProductDataCheck: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiProductDataEnhancerFillProductDataCheckWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AiproductdataenhancerFillProductDataCheckResponse> response = apiInstance.AiProductDataEnhancerFillProductDataCheckWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AiProductDataEnhancerApi.AiProductDataEnhancerFillProductDataCheckWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**AiproductdataenhancerFillProductDataCheckRequest**](AiproductdataenhancerFillProductDataCheckRequest.md) |  |  |

### Return type

[**AiproductdataenhancerFillProductDataCheckResponse**](AiproductdataenhancerFillProductDataCheckResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiproductdataenhancergenerateproductdata"></a>
# **AiProductDataEnhancerGenerateProductData**
> AiproductdataenhancerGenerateProductDataResponse AiProductDataEnhancerGenerateProductData (AiproductdataenhancerGenerateProductDataRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using aiproductdataenhancer.Api;
using aiproductdataenhancer.Client;
using aiproductdataenhancer.Model;

namespace Example
{
    public class AiProductDataEnhancerGenerateProductDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AiProductDataEnhancerApi(config);
            var body = new AiproductdataenhancerGenerateProductDataRequest(); // AiproductdataenhancerGenerateProductDataRequest | 

            try
            {
                AiproductdataenhancerGenerateProductDataResponse result = apiInstance.AiProductDataEnhancerGenerateProductData(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AiProductDataEnhancerApi.AiProductDataEnhancerGenerateProductData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiProductDataEnhancerGenerateProductDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AiproductdataenhancerGenerateProductDataResponse> response = apiInstance.AiProductDataEnhancerGenerateProductDataWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AiProductDataEnhancerApi.AiProductDataEnhancerGenerateProductDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**AiproductdataenhancerGenerateProductDataRequest**](AiproductdataenhancerGenerateProductDataRequest.md) |  |  |

### Return type

[**AiproductdataenhancerGenerateProductDataResponse**](AiproductdataenhancerGenerateProductDataResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiproductdataenhancertranslatedata"></a>
# **AiProductDataEnhancerTranslateData**
> AiproductdataenhancerTranslateDataResponse AiProductDataEnhancerTranslateData (AiproductdataenhancerTranslateDataRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using aiproductdataenhancer.Api;
using aiproductdataenhancer.Client;
using aiproductdataenhancer.Model;

namespace Example
{
    public class AiProductDataEnhancerTranslateDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AiProductDataEnhancerApi(config);
            var body = new AiproductdataenhancerTranslateDataRequest(); // AiproductdataenhancerTranslateDataRequest | 

            try
            {
                AiproductdataenhancerTranslateDataResponse result = apiInstance.AiProductDataEnhancerTranslateData(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AiProductDataEnhancerApi.AiProductDataEnhancerTranslateData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiProductDataEnhancerTranslateDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AiproductdataenhancerTranslateDataResponse> response = apiInstance.AiProductDataEnhancerTranslateDataWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AiProductDataEnhancerApi.AiProductDataEnhancerTranslateDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**AiproductdataenhancerTranslateDataRequest**](AiproductdataenhancerTranslateDataRequest.md) |  |  |

### Return type

[**AiproductdataenhancerTranslateDataResponse**](AiproductdataenhancerTranslateDataResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

