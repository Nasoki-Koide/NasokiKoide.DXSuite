// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using NasokiKoide.DXSuite.Models;
using NasokiKoide.DXSuite.Wf.Api.Standard.V2.Workflows.Item;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace NasokiKoide.DXSuite.Wf.Api.Standard.V2.Workflows {
    /// <summary>
    /// Builds and executes requests for operations under \wf\api\standard\v2\workflows
    /// </summary>
    public class WorkflowsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the NasokiKoide.DXSuite.wf.api.standard.v2.workflows.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="WithWorkflowItemRequestBuilder"/></returns>
        public WithWorkflowItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("workflowId", position);
                return new WithWorkflowItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="WorkflowsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkflowsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/wf/api/standard/v2/workflows{?folderId*,workflowName*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WorkflowsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkflowsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/wf/api/standard/v2/workflows{?folderId*,workflowName*}", rawUrl)
        {
        }
        /// <summary>
        /// 登録済みのワークフロー情報を取得します。
        /// </summary>
        /// <returns>A <see cref="GetWorkflowsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="BadRequestErrorWorkflowResponse">When receiving a 400 status code</exception>
        /// <exception cref="UnAuthorizedErrorResponse">When receiving a 401 status code</exception>
        /// <exception cref="SpecifiedResourceDoesNotExistResponse">When receiving a 404 status code</exception>
        /// <exception cref="InternalServerErrorResponse">When receiving a 500 status code</exception>
        /// <exception cref="Model__error_response_v2__ErrorResponse">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<GetWorkflowsResponse?> GetAsync(Action<RequestConfiguration<WorkflowsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<GetWorkflowsResponse> GetAsync(Action<RequestConfiguration<WorkflowsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", BadRequestErrorWorkflowResponse.CreateFromDiscriminatorValue},
                {"401", UnAuthorizedErrorResponse.CreateFromDiscriminatorValue},
                {"404", SpecifiedResourceDoesNotExistResponse.CreateFromDiscriminatorValue},
                {"500", InternalServerErrorResponse.CreateFromDiscriminatorValue},
                {"XXX", Model__error_response_v2__ErrorResponse.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<GetWorkflowsResponse>(requestInfo, GetWorkflowsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// 登録済みのワークフロー情報を取得します。
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WorkflowsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WorkflowsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="WorkflowsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WorkflowsRequestBuilder WithUrl(string rawUrl)
        {
            return new WorkflowsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// 登録済みのワークフロー情報を取得します。
        /// </summary>
        public class WorkflowsRequestBuilderGetQueryParameters 
        {
            /// <summary>指定したフォルダ内のワークフローを検索します。 フォルダIDを複数指定する場合、カンマ区切りで指定可能です。</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("folderId")]
            public string? FolderId { get; set; }
#nullable restore
#else
            [QueryParameter("folderId")]
            public string FolderId { get; set; }
#endif
            /// <summary>指定した文字列に完全一致するワークフローを検索します。 1〜128文字まで指定できます。 日本語で設定する場合は、URLエンコードして設定します。 例) テスト → %e3%83%86%e3%82%b9%e3%83%88</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("workflowName")]
            public string? WorkflowName { get; set; }
#nullable restore
#else
            [QueryParameter("workflowName")]
            public string WorkflowName { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WorkflowsRequestBuilderGetRequestConfiguration : RequestConfiguration<WorkflowsRequestBuilderGetQueryParameters> 
        {
        }
    }
}
