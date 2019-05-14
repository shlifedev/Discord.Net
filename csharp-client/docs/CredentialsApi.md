# IO.Swagger.Api.CredentialsApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCredentialsAndroid**](CredentialsApi.md#addcredentialsandroid) | **POST** /orgs/{orgid}/projects/{projectid}/credentials/signing/android | Upload Android Credentials
[**AddCredentialsAndroidForOrg**](CredentialsApi.md#addcredentialsandroidfororg) | **POST** /orgs/{orgid}/credentials/signing/android | Upload Android Credentials
[**AddCredentialsIos**](CredentialsApi.md#addcredentialsios) | **POST** /orgs/{orgid}/projects/{projectid}/credentials/signing/ios | Upload iOS Credentials
[**AddCredentialsIosForOrg**](CredentialsApi.md#addcredentialsiosfororg) | **POST** /orgs/{orgid}/credentials/signing/ios | Upload iOS Credentials for organization
[**DeleteAndroid**](CredentialsApi.md#deleteandroid) | **DELETE** /orgs/{orgid}/projects/{projectid}/credentials/signing/android/{credentialid} | Delete Android Credentials
[**DeleteAndroidForOrg**](CredentialsApi.md#deleteandroidfororg) | **DELETE** /orgs/{orgid}/credentials/signing/android/{credentialid} | Delete Android Credentials for organization
[**DeleteIos**](CredentialsApi.md#deleteios) | **DELETE** /orgs/{orgid}/projects/{projectid}/credentials/signing/ios/{credentialid} | Delete iOS Credentials
[**DeleteIosForOrg**](CredentialsApi.md#deleteiosfororg) | **DELETE** /orgs/{orgid}/credentials/signing/ios/{credentialid} | Delete iOS Credentials for organization
[**GetAllAndroid**](CredentialsApi.md#getallandroid) | **GET** /orgs/{orgid}/projects/{projectid}/credentials/signing/android | Get All Android Credentials
[**GetAllAndroidForOrg**](CredentialsApi.md#getallandroidfororg) | **GET** /orgs/{orgid}/credentials/signing/android | Get All Android Credentials for an organization
[**GetAllIos**](CredentialsApi.md#getallios) | **GET** /orgs/{orgid}/projects/{projectid}/credentials/signing/ios | Get All iOS Credentials
[**GetAllIosForOrg**](CredentialsApi.md#getalliosfororg) | **GET** /orgs/{orgid}/credentials/signing/ios | Get All iOS Credentials for an oganization
[**GetOneAndroid**](CredentialsApi.md#getoneandroid) | **GET** /orgs/{orgid}/projects/{projectid}/credentials/signing/android/{credentialid} | Get Android Credential Details
[**GetOneAndroidForOrg**](CredentialsApi.md#getoneandroidfororg) | **GET** /orgs/{orgid}/credentials/signing/android/{credentialid} | Get Android Credential Details for organization
[**GetOneIos**](CredentialsApi.md#getoneios) | **GET** /orgs/{orgid}/projects/{projectid}/credentials/signing/ios/{credentialid} | Get iOS Credential Details
[**GetOneIosForOrg**](CredentialsApi.md#getoneiosfororg) | **GET** /orgs/{orgid}/credentials/signing/ios/{credentialid} | Get iOS Credential Details for organization
[**UpdateAndroid**](CredentialsApi.md#updateandroid) | **PUT** /orgs/{orgid}/projects/{projectid}/credentials/signing/android/{credentialid} | Update Android Credentials
[**UpdateAndroidForOrg**](CredentialsApi.md#updateandroidfororg) | **PUT** /orgs/{orgid}/credentials/signing/android/{credentialid} | Update Android Credentials for organization
[**UpdateIos**](CredentialsApi.md#updateios) | **PUT** /orgs/{orgid}/projects/{projectid}/credentials/signing/ios/{credentialid} | Update iOS Credentials
[**UpdateIosForOrg**](CredentialsApi.md#updateiosfororg) | **PUT** /orgs/{orgid}/credentials/signing/ios/{credentialid} | Update iOS Credentials for organization


<a name="addcredentialsandroid"></a>
# **AddCredentialsAndroid**
> Object AddCredentialsAndroid (string orgid, string projectid, string label, System.IO.Stream file, string alias, string keypass, string storepass)

Upload Android Credentials

Upload a new android keystore for the project. NOTE: you must be a manager in the project's organization to add new credentials. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddCredentialsAndroidExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var orgid = orgid_example;  // string | Organization identifier
            var projectid = projectid_example;  // string | Project identifier
            var label = label_example;  // string | Label for the uploaded credential
            var file = new System.IO.Stream(); // System.IO.Stream | Keystore file
            var alias = alias_example;  // string | Keystore alias
            var keypass = keypass_example;  // string | Keystore keypass
            var storepass = storepass_example;  // string | Keystore storepass

            try
            {
                // Upload Android Credentials
                Object result = apiInstance.AddCredentialsAndroid(orgid, projectid, label, file, alias, keypass, storepass);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.AddCredentialsAndroid: " + e.Message );
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
 **label** | **string**| Label for the uploaded credential | 
 **file** | **System.IO.Stream**| Keystore file | 
 **alias** | **string**| Keystore alias | 
 **keypass** | **string**| Keystore keypass | 
 **storepass** | **string**| Keystore storepass | 

### Return type

**Object**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcredentialsandroidfororg"></a>
# **AddCredentialsAndroidForOrg**
> Object AddCredentialsAndroidForOrg (string orgid, string label, System.IO.Stream file, string alias, string keypass, string storepass)

Upload Android Credentials

Upload a new android keystore for an organization. NOTE: you must be a manager in the organization to add new credentials. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddCredentialsAndroidForOrgExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var orgid = orgid_example;  // string | Organization identifier
            var label = label_example;  // string | Label for the uploaded credential
            var file = new System.IO.Stream(); // System.IO.Stream | Keystore file
            var alias = alias_example;  // string | Keystore alias
            var keypass = keypass_example;  // string | Keystore keypass
            var storepass = storepass_example;  // string | Keystore storepass

            try
            {
                // Upload Android Credentials
                Object result = apiInstance.AddCredentialsAndroidForOrg(orgid, label, file, alias, keypass, storepass);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.AddCredentialsAndroidForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgid** | **string**| Organization identifier | 
 **label** | **string**| Label for the uploaded credential | 
 **file** | **System.IO.Stream**| Keystore file | 
 **alias** | **string**| Keystore alias | 
 **keypass** | **string**| Keystore keypass | 
 **storepass** | **string**| Keystore storepass | 

### Return type

**Object**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcredentialsios"></a>
# **AddCredentialsIos**
> Object AddCredentialsIos (string orgid, string projectid, string label, System.IO.Stream fileCertificate, System.IO.Stream fileProvisioningProfile, string certificatePass = null)

Upload iOS Credentials

Upload a new iOS certificate and provisioning profile for the project. NOTE: you must be a manager in the project's organization to add new credentials. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddCredentialsIosExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var orgid = orgid_example;  // string | Organization identifier
            var projectid = projectid_example;  // string | Project identifier
            var label = label_example;  // string | Label for the uploaded credentials
            var fileCertificate = new System.IO.Stream(); // System.IO.Stream | Certificate file (.p12)
            var fileProvisioningProfile = new System.IO.Stream(); // System.IO.Stream | Provisioning Profile (.mobileprovision)
            var certificatePass = certificatePass_example;  // string | Certificate (.p12) password (optional) 

            try
            {
                // Upload iOS Credentials
                Object result = apiInstance.AddCredentialsIos(orgid, projectid, label, fileCertificate, fileProvisioningProfile, certificatePass);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.AddCredentialsIos: " + e.Message );
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
 **label** | **string**| Label for the uploaded credentials | 
 **fileCertificate** | **System.IO.Stream**| Certificate file (.p12) | 
 **fileProvisioningProfile** | **System.IO.Stream**| Provisioning Profile (.mobileprovision) | 
 **certificatePass** | **string**| Certificate (.p12) password | [optional] 

### Return type

**Object**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcredentialsiosfororg"></a>
# **AddCredentialsIosForOrg**
> Object AddCredentialsIosForOrg (string orgid, string label, System.IO.Stream fileCertificate, System.IO.Stream fileProvisioningProfile, string certificatePass = null)

Upload iOS Credentials for organization

Upload a new iOS certificate and provisioning profile for the organization. NOTE: you must be a manager in the organization to add new credentials. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddCredentialsIosForOrgExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var orgid = orgid_example;  // string | Organization identifier
            var label = label_example;  // string | Label for the uploaded credentials
            var fileCertificate = new System.IO.Stream(); // System.IO.Stream | Certificate file (.p12)
            var fileProvisioningProfile = new System.IO.Stream(); // System.IO.Stream | Provisioning Profile (.mobileprovision)
            var certificatePass = certificatePass_example;  // string | Certificate (.p12) password (optional) 

            try
            {
                // Upload iOS Credentials for organization
                Object result = apiInstance.AddCredentialsIosForOrg(orgid, label, fileCertificate, fileProvisioningProfile, certificatePass);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.AddCredentialsIosForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgid** | **string**| Organization identifier | 
 **label** | **string**| Label for the uploaded credentials | 
 **fileCertificate** | **System.IO.Stream**| Certificate file (.p12) | 
 **fileProvisioningProfile** | **System.IO.Stream**| Provisioning Profile (.mobileprovision) | 
 **certificatePass** | **string**| Certificate (.p12) password | [optional] 

### Return type

**Object**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteandroid"></a>
# **DeleteAndroid**
> string DeleteAndroid (string orgid, string projectid, string credentialid)

Delete Android Credentials

Delete specific android credentials for a project. NOTE: you must be a manager in the project's organization to delete credentials. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAndroidExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var orgid = orgid_example;  // string | Organization identifier
            var projectid = projectid_example;  // string | Project identifier
            var credentialid = credentialid_example;  // string | Credential Identifier

            try
            {
                // Delete Android Credentials
                string result = apiInstance.DeleteAndroid(orgid, projectid, credentialid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.DeleteAndroid: " + e.Message );
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
 **credentialid** | **string**| Credential Identifier | 

### Return type

**string**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteandroidfororg"></a>
# **DeleteAndroidForOrg**
> string DeleteAndroidForOrg (string orgid, string credentialid)

Delete Android Credentials for organization

Delete specific android credentials for an organization. NOTE: you must be a manager in the organization to delete credentials. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAndroidForOrgExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var orgid = orgid_example;  // string | Organization identifier
            var credentialid = credentialid_example;  // string | Credential Identifier

            try
            {
                // Delete Android Credentials for organization
                string result = apiInstance.DeleteAndroidForOrg(orgid, credentialid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.DeleteAndroidForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgid** | **string**| Organization identifier | 
 **credentialid** | **string**| Credential Identifier | 

### Return type

**string**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteios"></a>
# **DeleteIos**
> string DeleteIos (string orgid, string projectid, string credentialid)

Delete iOS Credentials

Delete specific ios credentials for a project. NOTE: you must be a manager in the project's organization to delete credentials. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteIosExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var orgid = orgid_example;  // string | Organization identifier
            var projectid = projectid_example;  // string | Project identifier
            var credentialid = credentialid_example;  // string | Credential Identifier

            try
            {
                // Delete iOS Credentials
                string result = apiInstance.DeleteIos(orgid, projectid, credentialid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.DeleteIos: " + e.Message );
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
 **credentialid** | **string**| Credential Identifier | 

### Return type

**string**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteiosfororg"></a>
# **DeleteIosForOrg**
> string DeleteIosForOrg (string orgid, string credentialid)

Delete iOS Credentials for organization

Delete specific ios credentials. NOTE: you must be a manager in the project's organization to delete credentials. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteIosForOrgExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var orgid = orgid_example;  // string | Organization identifier
            var credentialid = credentialid_example;  // string | Credential Identifier

            try
            {
                // Delete iOS Credentials for organization
                string result = apiInstance.DeleteIosForOrg(orgid, credentialid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.DeleteIosForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgid** | **string**| Organization identifier | 
 **credentialid** | **string**| Credential Identifier | 

### Return type

**string**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallandroid"></a>
# **GetAllAndroid**
> List<Object> GetAllAndroid (string orgid, string projectid)

Get All Android Credentials

Get all credentials available for the project. A user in the projects org will see all credentials uploaded for any project within the org, whereas a user with project-level permissions will only see credentials assigned to the specific project. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllAndroidExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var orgid = orgid_example;  // string | Organization identifier
            var projectid = projectid_example;  // string | Project identifier

            try
            {
                // Get All Android Credentials
                List&lt;Object&gt; result = apiInstance.GetAllAndroid(orgid, projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.GetAllAndroid: " + e.Message );
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

<a name="getallandroidfororg"></a>
# **GetAllAndroidForOrg**
> List<Object> GetAllAndroidForOrg (string orgid)

Get All Android Credentials for an organization

Get all credentials available for the organization. A list of projects using a credential is included in the links element. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllAndroidForOrgExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var orgid = orgid_example;  // string | Organization identifier

            try
            {
                // Get All Android Credentials for an organization
                List&lt;Object&gt; result = apiInstance.GetAllAndroidForOrg(orgid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.GetAllAndroidForOrg: " + e.Message );
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

<a name="getallios"></a>
# **GetAllIos**
> List<Object> GetAllIos (string orgid, string projectid)

Get All iOS Credentials

Get all credentials available for the project. A user in the projects org will see all credentials uploaded for any project within the org, whereas a user with project-level permissions will only see credentials assigned to the specific project. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllIosExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var orgid = orgid_example;  // string | Organization identifier
            var projectid = projectid_example;  // string | Project identifier

            try
            {
                // Get All iOS Credentials
                List&lt;Object&gt; result = apiInstance.GetAllIos(orgid, projectid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.GetAllIos: " + e.Message );
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

<a name="getalliosfororg"></a>
# **GetAllIosForOrg**
> List<Object> GetAllIosForOrg (string orgid)

Get All iOS Credentials for an oganization

Get all credentials available for the project. A user in the projects org will see all credentials uploaded for any project within the org, whereas a user with project-level permissions will only see credentials assigned to the specific project. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllIosForOrgExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var orgid = orgid_example;  // string | Organization identifier

            try
            {
                // Get All iOS Credentials for an oganization
                List&lt;Object&gt; result = apiInstance.GetAllIosForOrg(orgid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.GetAllIosForOrg: " + e.Message );
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

<a name="getoneandroid"></a>
# **GetOneAndroid**
> Object GetOneAndroid (string orgid, string projectid, string credentialid)

Get Android Credential Details

Get specific android credential details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOneAndroidExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var orgid = orgid_example;  // string | Organization identifier
            var projectid = projectid_example;  // string | Project identifier
            var credentialid = credentialid_example;  // string | Credential Identifier

            try
            {
                // Get Android Credential Details
                Object result = apiInstance.GetOneAndroid(orgid, projectid, credentialid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.GetOneAndroid: " + e.Message );
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
 **credentialid** | **string**| Credential Identifier | 

### Return type

**Object**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoneandroidfororg"></a>
# **GetOneAndroidForOrg**
> Object GetOneAndroidForOrg (string orgid, string credentialid)

Get Android Credential Details for organization

Get specific organization android credential details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOneAndroidForOrgExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var orgid = orgid_example;  // string | Organization identifier
            var credentialid = credentialid_example;  // string | Credential Identifier

            try
            {
                // Get Android Credential Details for organization
                Object result = apiInstance.GetOneAndroidForOrg(orgid, credentialid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.GetOneAndroidForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgid** | **string**| Organization identifier | 
 **credentialid** | **string**| Credential Identifier | 

### Return type

**Object**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoneios"></a>
# **GetOneIos**
> Object GetOneIos (string orgid, string projectid, string credentialid)

Get iOS Credential Details

Get specific iOS credential details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOneIosExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var orgid = orgid_example;  // string | Organization identifier
            var projectid = projectid_example;  // string | Project identifier
            var credentialid = credentialid_example;  // string | Credential Identifier

            try
            {
                // Get iOS Credential Details
                Object result = apiInstance.GetOneIos(orgid, projectid, credentialid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.GetOneIos: " + e.Message );
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
 **credentialid** | **string**| Credential Identifier | 

### Return type

**Object**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoneiosfororg"></a>
# **GetOneIosForOrg**
> Object GetOneIosForOrg (string orgid, string credentialid)

Get iOS Credential Details for organization

Get specific iOS credential details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOneIosForOrgExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var orgid = orgid_example;  // string | Organization identifier
            var credentialid = credentialid_example;  // string | Credential Identifier

            try
            {
                // Get iOS Credential Details for organization
                Object result = apiInstance.GetOneIosForOrg(orgid, credentialid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.GetOneIosForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgid** | **string**| Organization identifier | 
 **credentialid** | **string**| Credential Identifier | 

### Return type

**Object**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateandroid"></a>
# **UpdateAndroid**
> Object UpdateAndroid (string orgid, string projectid, string credentialid, string label = null, System.IO.Stream file = null, string alias = null, string keypass = null, string storepass = null)

Update Android Credentials

Update an android keystore for the project. NOTE: you must be a manager in the project's organization to add new credentials. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateAndroidExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var orgid = orgid_example;  // string | Organization identifier
            var projectid = projectid_example;  // string | Project identifier
            var credentialid = credentialid_example;  // string | Credential Identifier
            var label = label_example;  // string | Label for the uploaded credential (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream | Keystore file (optional) 
            var alias = alias_example;  // string | Keystore alias (optional) 
            var keypass = keypass_example;  // string | Keystore keypass (optional) 
            var storepass = storepass_example;  // string | Keystore storepass (optional) 

            try
            {
                // Update Android Credentials
                Object result = apiInstance.UpdateAndroid(orgid, projectid, credentialid, label, file, alias, keypass, storepass);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.UpdateAndroid: " + e.Message );
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
 **credentialid** | **string**| Credential Identifier | 
 **label** | **string**| Label for the uploaded credential | [optional] 
 **file** | **System.IO.Stream**| Keystore file | [optional] 
 **alias** | **string**| Keystore alias | [optional] 
 **keypass** | **string**| Keystore keypass | [optional] 
 **storepass** | **string**| Keystore storepass | [optional] 

### Return type

**Object**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateandroidfororg"></a>
# **UpdateAndroidForOrg**
> Object UpdateAndroidForOrg (string orgid, string credentialid, string label = null, System.IO.Stream file = null, string alias = null, string keypass = null, string storepass = null)

Update Android Credentials for organization

Update an android keystore for the organization. NOTE: you must be a manager in the organization to update credentials. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateAndroidForOrgExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var orgid = orgid_example;  // string | Organization identifier
            var credentialid = credentialid_example;  // string | Credential Identifier
            var label = label_example;  // string | Label for the uploaded credential (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream | Keystore file (optional) 
            var alias = alias_example;  // string | Keystore alias (optional) 
            var keypass = keypass_example;  // string | Keystore keypass (optional) 
            var storepass = storepass_example;  // string | Keystore storepass (optional) 

            try
            {
                // Update Android Credentials for organization
                Object result = apiInstance.UpdateAndroidForOrg(orgid, credentialid, label, file, alias, keypass, storepass);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.UpdateAndroidForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgid** | **string**| Organization identifier | 
 **credentialid** | **string**| Credential Identifier | 
 **label** | **string**| Label for the uploaded credential | [optional] 
 **file** | **System.IO.Stream**| Keystore file | [optional] 
 **alias** | **string**| Keystore alias | [optional] 
 **keypass** | **string**| Keystore keypass | [optional] 
 **storepass** | **string**| Keystore storepass | [optional] 

### Return type

**Object**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateios"></a>
# **UpdateIos**
> Object UpdateIos (string orgid, string projectid, string credentialid, string label = null, System.IO.Stream fileCertificate = null, System.IO.Stream fileProvisioningProfile = null, string certificatePass = null)

Update iOS Credentials

Update an iOS certificate / provisioning profile for the project. NOTE: you must be a manager in the project's organization to update credentials. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateIosExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var orgid = orgid_example;  // string | Organization identifier
            var projectid = projectid_example;  // string | Project identifier
            var credentialid = credentialid_example;  // string | Credential Identifier
            var label = label_example;  // string | Label for the updated credentials (optional) 
            var fileCertificate = new System.IO.Stream(); // System.IO.Stream | Certificate file (.p12) (optional) 
            var fileProvisioningProfile = new System.IO.Stream(); // System.IO.Stream | Provisioning Profile (.mobileprovision) (optional) 
            var certificatePass = certificatePass_example;  // string | Certificate (.p12) password (optional) 

            try
            {
                // Update iOS Credentials
                Object result = apiInstance.UpdateIos(orgid, projectid, credentialid, label, fileCertificate, fileProvisioningProfile, certificatePass);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.UpdateIos: " + e.Message );
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
 **credentialid** | **string**| Credential Identifier | 
 **label** | **string**| Label for the updated credentials | [optional] 
 **fileCertificate** | **System.IO.Stream**| Certificate file (.p12) | [optional] 
 **fileProvisioningProfile** | **System.IO.Stream**| Provisioning Profile (.mobileprovision) | [optional] 
 **certificatePass** | **string**| Certificate (.p12) password | [optional] 

### Return type

**Object**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateiosfororg"></a>
# **UpdateIosForOrg**
> Object UpdateIosForOrg (string orgid, string credentialid, string label = null, System.IO.Stream fileCertificate = null, System.IO.Stream fileProvisioningProfile = null, string certificatePass = null)

Update iOS Credentials for organization

Update an iOS certificate / provisioning profile. NOTE: you must be a manager in the project's organization to update credentials. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateIosForOrgExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: apikey
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: permissions
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var orgid = orgid_example;  // string | Organization identifier
            var credentialid = credentialid_example;  // string | Credential Identifier
            var label = label_example;  // string | Label for the updated credentials (optional) 
            var fileCertificate = new System.IO.Stream(); // System.IO.Stream | Certificate file (.p12) (optional) 
            var fileProvisioningProfile = new System.IO.Stream(); // System.IO.Stream | Provisioning Profile (.mobileprovision) (optional) 
            var certificatePass = certificatePass_example;  // string | Certificate (.p12) password (optional) 

            try
            {
                // Update iOS Credentials for organization
                Object result = apiInstance.UpdateIosForOrg(orgid, credentialid, label, fileCertificate, fileProvisioningProfile, certificatePass);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.UpdateIosForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgid** | **string**| Organization identifier | 
 **credentialid** | **string**| Credential Identifier | 
 **label** | **string**| Label for the updated credentials | [optional] 
 **fileCertificate** | **System.IO.Stream**| Certificate file (.p12) | [optional] 
 **fileProvisioningProfile** | **System.IO.Stream**| Provisioning Profile (.mobileprovision) | [optional] 
 **certificatePass** | **string**| Certificate (.p12) password | [optional] 

### Return type

**Object**

### Authorization

[apikey](../README.md#apikey), [permissions](../README.md#permissions)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/plain, text/html, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

