// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using NasokiKoide.DXSuite.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace NasokiKoide.DXSuite.Wf.Api.Standard.V2.Workflows.Item.Revisions.Item.Configuration {
    /// <summary>
    /// Builds and executes requests for operations under \wf\api\standard\v2\workflows\{workflowId}\revisions\{revision}\configuration
    /// </summary>
    public class ConfigurationRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="ConfigurationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConfigurationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/wf/api/standard/v2/workflows/{workflowId}/revisions/{revision}/configuration", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ConfigurationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConfigurationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/wf/api/standard/v2/workflows/{workflowId}/revisions/{revision}/configuration", rawUrl)
        {
        }
        /// <summary>
        /// ワークフローの設定を取得します。
        /// </summary>
        /// <returns>A <see cref="GetWorkflowSettingsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BadRequestErrorNotAvailableFromApiResponse">When receiving a 400 status code</exception>
        /// <exception cref="UnAuthorizedErrorResponse">When receiving a 401 status code</exception>
        /// <exception cref="SpecifiedResourceDoesNotExistResponse">When receiving a 404 status code</exception>
        /// <exception cref="InternalServerErrorResponse">When receiving a 500 status code</exception>
        /// <exception cref="Model__error_response_v2__ErrorResponse">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<GetWorkflowSettingsResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<GetWorkflowSettingsResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", BadRequestErrorNotAvailableFromApiResponse.CreateFromDiscriminatorValue},
                {"401", UnAuthorizedErrorResponse.CreateFromDiscriminatorValue},
                {"404", SpecifiedResourceDoesNotExistResponse.CreateFromDiscriminatorValue},
                {"500", InternalServerErrorResponse.CreateFromDiscriminatorValue},
                {"XXX", Model__error_response_v2__ErrorResponse.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<GetWorkflowSettingsResponse>(requestInfo, GetWorkflowSettingsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// ワークフローの設定を取得します。
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="ConfigurationRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ConfigurationRequestBuilder WithUrl(string rawUrl)
        {
            return new ConfigurationRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ConfigurationRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
