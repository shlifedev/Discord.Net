# IO.Swagger.Api.WebhooksApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddHookForOrg**](WebhooksApi.md#addhookfororg) | **POST** /orgs/{orgid}/hooks | Add hook for organization
[**AddHookForProject**](WebhooksApi.md#addhookforproject) | **POST** /orgs/{orgid}/projects/{projectid}/hooks | Add hook for project
[**DeleteHook**](WebhooksApi.md#deletehook) | **DELETE** /orgs/{orgid}/hooks/{id} | Delete organization hook
[**DeleteHook_0**](WebhooksApi.md#deletehook_0) | **DELETE** /orgs/{orgid}/projects/{projectid}/hooks/{id} | Delete project hook
[**GetHook**](WebhooksApi.md#gethook) | **GET** /orgs/{orgid}/hooks/{id} | Get organization hook details
[**GetHook_0**](WebhooksApi.md#gethook_0) | **GET** /orgs/{orgid}/projects/{projectid}/hooks/{id} | Get project hook details
[**ListHooksForOrg**](WebhooksApi.md#listhooksfororg) | **GET** /orgs/{orgid}/hooks | List hooks for organization
[**ListHooksForProject**](WebhooksApi.md#listhooksforproject) | **GET** /orgs/{orgid}/projects/{projectid}/hooks | List hooks for project
[**PingHook**](WebhooksApi.md#pinghook) | **POST** /orgs/{orgid}/hooks/{id}/ping | Ping an org hook
[**PingHook_0**](WebhooksApi.md#pinghook_0) | **POST** /orgs/{orgid}/projects/{projectid}/hooks/{id}/ping | Ping a project hook
[**UpdateHook**](WebhooksApi.md#updatehook) | **PUT** /orgs/{orgid}/hooks/{id} | Update hook for organization
[**UpdateHook_0**](WebhooksApi.md#updatehook_0) | **PUT** /orgs/{orgid}/projects/{projectid}/hooks/{id} | Update hook for project


<a name="addhookfororg"></a>
# **AddHookForOrg**
> Object AddHookForOrg (string orgid, Options2 options = null)

Add hook for organization

Adds a new organization level hook. An organization level hook is triggered by events from all projects belonging to the organziation. NOTE: you must be a manager in the organization to add new hooks. <h4>Hook Type Configuration Parameters</h4> <div class=\"webhook-tag-desc\"> <table> <tr><th>Type</th><th>Configuration Options</th></tr> <tr>    <td><code>web</code>    <td>       <table>          <tr><th>url</th><td>Endpoint to submit POST request</td></tr>          <tr><th>encoding</th><td>Either <code>json</code> (default) or <code>form</code></td></tr>          <tr><th>sslVerify</th><td>Verify SSL certificates of HTTPS endpoint</td></tr>          <tr><th>secret</th><td>Used to compute the SHA256 HMAC signature of the hook body and adds          a <code>X-UnityCloudBuild-Signature</code> header to the payload</td></tr>       </table>    </td> </tr> <tr>    <td><code>slack</code>    <td>       <table>          <tr><th>url</th><td>Slack incoming webhook URL. Learn more at https://api.slack.com/incoming-webhooks</td></tr>       </table>    </td> </tr> </table> </div> 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddHookForOrgExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var orgid = orgid_example;  // string | Organization identifier
            var options = new Options2(); // Options2 |  (optional) 

            try
            {
                // Add hook for organization
                Object result = apiInstance.AddHookForOrg(orgid, options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.AddHookForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgid** | **string**| Organization identifier | 
 **options** | [**Options2**](Options2.md)|  | [optional] 

### Return type

**Object**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addhookforproject"></a>
# **AddHookForProject**
> Object AddHookForProject (string orgid, string projectid, Options4 options = null)

Add hook for project

Adds a new project level hook. A project level hook is only triggered by events from the specific project. NOTE: you must be a manager in the organization to add new hooks. <h4>Hook Type Configuration Parameters</h4> <div class=\"webhook-tag-desc\"> <table> <tr><th>Type</th><th>Configuration Options</th></tr> <tr>    <td><code>web</code>    <td>       <table>          <tr><th>url</th><td>Endpoint to submit POST request</td></tr>          <tr><th>encoding</th><td>Either <code>json</code> (default) or <code>form</code></td></tr>          <tr><th>sslVerify</th><td>Verify SSL certificates of HTTPS endpoint</td></tr>          <tr><th>secret</th><td>Used to compute the SHA256 HMAC signature of the hook body and adds          a <code>X-UnityCloudBuild-Signature</code> header to the payload</td></tr>       </table>    </td> </tr> <tr>    <td><code>slack</code>    <td>       <table>          <tr><th>url</th><td>Slack incoming webhook URL. Learn more at https://api.slack.com/incoming-webhooks</td></tr>       </table>    </td> </tr> </table> </div> 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddHookForProjectExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var orgid = orgid_example;  // string | Organization identifier
            var projectid = projectid_example;  // string | Project identifier
            var options = new Options4(); // Options4 |  (optional) 

            try
            {
                // Add hook for project
                Object result = apiInstance.AddHookForProject(orgid, projectid, options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.AddHookForProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgid** | **string**| Organization identifier | 
 **projectid** | **string**| Project identifier | 
 **options** | [**Options4**](Options4.md)|  | [optional] 

### Return type

**Object**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletehook"></a>
# **DeleteHook**
> string DeleteHook (string orgid, string id)

Delete organization hook

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteHookExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var orgid = orgid_example;  // string | Organization identifier
            var id = id_example;  // string | Hook record identifier

            try
            {
                // Delete organization hook
                string result = apiInstance.DeleteHook(orgid, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.DeleteHook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgid** | **string**| Organization identifier | 
 **id** | **string**| Hook record identifier | 

### Return type

**string**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletehook_0"></a>
# **DeleteHook_0**
> string DeleteHook_0 (string orgid, string projectid, string id)

Delete project hook

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteHook_0Example
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var orgid = orgid_example;  // string | Organization identifier
            var projectid = projectid_example;  // string | Project identifier
            var id = id_example;  // string | Hook record identifier

            try
            {
                // Delete project hook
                string result = apiInstance.DeleteHook_0(orgid, projectid, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.DeleteHook_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgid** | **string**| Organization identifier | 
 **projectid** | **string**| Project identifier | 
 **id** | **string**| Hook record identifier | 

### Return type

**string**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethook"></a>
# **GetHook**
> Object GetHook (string orgid, string id)

Get organization hook details

Get details of a hook by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHookExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var orgid = orgid_example;  // string | Organization identifier
            var id = id_example;  // string | Hook record identifier

            try
            {
                // Get organization hook details
                Object result = apiInstance.GetHook(orgid, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetHook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgid** | **string**| Organization identifier | 
 **id** | **string**| Hook record identifier | 

### Return type

**Object**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethook_0"></a>
# **GetHook_0**
> Object GetHook_0 (string orgid, string projectid, string id)

Get project hook details

Get details of a hook by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetHook_0Example
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var orgid = orgid_example;  // string | Organization identifier
            var projectid = projectid_example;  // string | Project identifier
            var id = id_example;  // string | Hook record identifier

            try
            {
                // Get project hook details
                Object result = apiInstance.GetHook_0(orgid, projectid, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetHook_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgid** | **string**| Organization identifier | 
 **projectid** | **string**| Project identifier | 
 **id** | **string**| Hook record identifier | 

### Return type

**Object**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listhooksfororg"></a>
# **ListHooksForOrg**
> List<Object> ListHooksForOrg (string orgid)

List hooks for organization

List all hooks configured for the specified organization

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListHooksForOrgExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var orgid = orgid_example;  // string | Organization identifier

            try
            {
                // List hooks for organization
                List&lt;Object&gt; result = apiInstance.ListHooksForOrg(orgid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.ListHooksForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgid** | **string**| Organization identifier | 

### Return type

**List<Object>**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listhooksforproject"></a>
# **ListHooksForProject**
> List<Object> ListHooksForProject (string orgid, string projectid)

List hooks for project

List all hooks configured for the specified project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListHooksForProjectExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var orgid = orgid_example;  // string | Organization identifier
            var projectid = projectid_example;  // string | Project identifier

            try
            {
                // List hooks for project
                List&lt;Object&gt; result = apiInstance.ListHooksForProject(orgid, projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.ListHooksForProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgid** | **string**| Organization identifier | 
 **projectid** | **string**| Project identifier | 

### Return type

**List<Object>**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pinghook"></a>
# **PingHook**
> string PingHook (string orgid, string id)

Ping an org hook

Send a ping event to an org hook. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PingHookExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var orgid = orgid_example;  // string | Organization identifier
            var id = id_example;  // string | Hook record identifier

            try
            {
                // Ping an org hook
                string result = apiInstance.PingHook(orgid, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.PingHook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgid** | **string**| Organization identifier | 
 **id** | **string**| Hook record identifier | 

### Return type

**string**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pinghook_0"></a>
# **PingHook_0**
> string PingHook_0 (string orgid, string projectid, string id)

Ping a project hook

Send a ping event to a project hook. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PingHook_0Example
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var orgid = orgid_example;  // string | Organization identifier
            var projectid = projectid_example;  // string | Project identifier
            var id = id_example;  // string | Hook record identifier

            try
            {
                // Ping a project hook
                string result = apiInstance.PingHook_0(orgid, projectid, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.PingHook_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgid** | **string**| Organization identifier | 
 **projectid** | **string**| Project identifier | 
 **id** | **string**| Hook record identifier | 

### Return type

**string**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatehook"></a>
# **UpdateHook**
> Object UpdateHook (string orgid, string id, Options3 options = null)

Update hook for organization

Update a new hook. NOTE: you must be a manager in the organization to update hooks. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateHookExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var orgid = orgid_example;  // string | Organization identifier
            var id = id_example;  // string | Hook record identifier
            var options = new Options3(); // Options3 |  (optional) 

            try
            {
                // Update hook for organization
                Object result = apiInstance.UpdateHook(orgid, id, options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.UpdateHook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgid** | **string**| Organization identifier | 
 **id** | **string**| Hook record identifier | 
 **options** | [**Options3**](Options3.md)|  | [optional] 

### Return type

**Object**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatehook_0"></a>
# **UpdateHook_0**
> Object UpdateHook_0 (string orgid, string projectid, string id, Options5 options = null)

Update hook for project

Update an existing hook. NOTE: you must be a manager of the project to update hooks. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateHook_0Example
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebhooksApi();
            var orgid = orgid_example;  // string | Organization identifier
            var projectid = projectid_example;  // string | Project identifier
            var id = id_example;  // string | Hook record identifier
            var options = new Options5(); // Options5 |  (optional) 

            try
            {
                // Update hook for project
                Object result = apiInstance.UpdateHook_0(orgid, projectid, id, options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.UpdateHook_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgid** | **string**| Organization identifier | 
 **projectid** | **string**| Project identifier | 
 **id** | **string**| Hook record identifier | 
 **options** | [**Options5**](Options5.md)|  | [optional] 

### Return type

**Object**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

