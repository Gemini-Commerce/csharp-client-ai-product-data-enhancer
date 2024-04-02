/*
 * aiproductdataenhancer/service.proto
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: version not set
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using aiproductdataenhancer.Client;
using aiproductdataenhancer.Model;

namespace aiproductdataenhancer.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAiProductDataEnhancerApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="aiproductdataenhancer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AiproductdataenhancerFillProductDataResponse</returns>
        AiproductdataenhancerFillProductDataResponse AiProductDataEnhancerFillProductData(AiproductdataenhancerFillProductDataRequest body, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="aiproductdataenhancer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AiproductdataenhancerFillProductDataResponse</returns>
        ApiResponse<AiproductdataenhancerFillProductDataResponse> AiProductDataEnhancerFillProductDataWithHttpInfo(AiproductdataenhancerFillProductDataRequest body, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAiProductDataEnhancerApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="aiproductdataenhancer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AiproductdataenhancerFillProductDataResponse</returns>
        System.Threading.Tasks.Task<AiproductdataenhancerFillProductDataResponse> AiProductDataEnhancerFillProductDataAsync(AiproductdataenhancerFillProductDataRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="aiproductdataenhancer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AiproductdataenhancerFillProductDataResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AiproductdataenhancerFillProductDataResponse>> AiProductDataEnhancerFillProductDataWithHttpInfoAsync(AiproductdataenhancerFillProductDataRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAiProductDataEnhancerApi : IAiProductDataEnhancerApiSync, IAiProductDataEnhancerApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AiProductDataEnhancerApi : IAiProductDataEnhancerApi
    {
        private aiproductdataenhancer.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AiProductDataEnhancerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AiProductDataEnhancerApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiProductDataEnhancerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AiProductDataEnhancerApi(string basePath)
        {
            this.Configuration = aiproductdataenhancer.Client.Configuration.MergeConfigurations(
                aiproductdataenhancer.Client.GlobalConfiguration.Instance,
                new aiproductdataenhancer.Client.Configuration { BasePath = basePath }
            );
            this.Client = new aiproductdataenhancer.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new aiproductdataenhancer.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = aiproductdataenhancer.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiProductDataEnhancerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AiProductDataEnhancerApi(aiproductdataenhancer.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = aiproductdataenhancer.Client.Configuration.MergeConfigurations(
                aiproductdataenhancer.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new aiproductdataenhancer.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new aiproductdataenhancer.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = aiproductdataenhancer.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiProductDataEnhancerApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AiProductDataEnhancerApi(aiproductdataenhancer.Client.ISynchronousClient client, aiproductdataenhancer.Client.IAsynchronousClient asyncClient, aiproductdataenhancer.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = aiproductdataenhancer.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public aiproductdataenhancer.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public aiproductdataenhancer.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public aiproductdataenhancer.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public aiproductdataenhancer.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="aiproductdataenhancer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AiproductdataenhancerFillProductDataResponse</returns>
        public AiproductdataenhancerFillProductDataResponse AiProductDataEnhancerFillProductData(AiproductdataenhancerFillProductDataRequest body, int operationIndex = 0)
        {
            aiproductdataenhancer.Client.ApiResponse<AiproductdataenhancerFillProductDataResponse> localVarResponse = AiProductDataEnhancerFillProductDataWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="aiproductdataenhancer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AiproductdataenhancerFillProductDataResponse</returns>
        public aiproductdataenhancer.Client.ApiResponse<AiproductdataenhancerFillProductDataResponse> AiProductDataEnhancerFillProductDataWithHttpInfo(AiproductdataenhancerFillProductDataRequest body, int operationIndex = 0)
        {
            // verify the required parameter 'body' is set
            if (body == null)
            {
                throw new aiproductdataenhancer.Client.ApiException(400, "Missing required parameter 'body' when calling AiProductDataEnhancerApi->AiProductDataEnhancerFillProductData");
            }

            aiproductdataenhancer.Client.RequestOptions localVarRequestOptions = new aiproductdataenhancer.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = aiproductdataenhancer.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = aiproductdataenhancer.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = body;

            localVarRequestOptions.Operation = "AiProductDataEnhancerApi.AiProductDataEnhancerFillProductData";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<AiproductdataenhancerFillProductDataResponse>("/aiproductdataenhancer.AiProductDataEnhancer/FillProductData", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AiProductDataEnhancerFillProductData", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="aiproductdataenhancer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AiproductdataenhancerFillProductDataResponse</returns>
        public async System.Threading.Tasks.Task<AiproductdataenhancerFillProductDataResponse> AiProductDataEnhancerFillProductDataAsync(AiproductdataenhancerFillProductDataRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            aiproductdataenhancer.Client.ApiResponse<AiproductdataenhancerFillProductDataResponse> localVarResponse = await AiProductDataEnhancerFillProductDataWithHttpInfoAsync(body, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="aiproductdataenhancer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AiproductdataenhancerFillProductDataResponse)</returns>
        public async System.Threading.Tasks.Task<aiproductdataenhancer.Client.ApiResponse<AiproductdataenhancerFillProductDataResponse>> AiProductDataEnhancerFillProductDataWithHttpInfoAsync(AiproductdataenhancerFillProductDataRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'body' is set
            if (body == null)
            {
                throw new aiproductdataenhancer.Client.ApiException(400, "Missing required parameter 'body' when calling AiProductDataEnhancerApi->AiProductDataEnhancerFillProductData");
            }


            aiproductdataenhancer.Client.RequestOptions localVarRequestOptions = new aiproductdataenhancer.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = aiproductdataenhancer.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = aiproductdataenhancer.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = body;

            localVarRequestOptions.Operation = "AiProductDataEnhancerApi.AiProductDataEnhancerFillProductData";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<AiproductdataenhancerFillProductDataResponse>("/aiproductdataenhancer.AiProductDataEnhancer/FillProductData", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AiProductDataEnhancerFillProductData", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}