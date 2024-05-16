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
namespace NasokiKoide.DXSuite.Sorter.Api.V1.Add {
    /// <summary>
    /// Builds and executes requests for operations under \Sorter\api\v1\add
    /// </summary>
    public class AddRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="AddRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AddRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Sorter/api/v1/add", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="AddRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AddRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Sorter/api/v1/add", rawUrl)
        {
        }
        /// <summary>
        /// 仕分けユニットに対して、ページ画像を追加します。
        /// </summary>
        /// <returns>A <see cref="AddSortingUnitResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Model__error_response_v1__BadRequestErrorResponse">When receiving a 400 status code</exception>
        /// <exception cref="Model__error_response_v1__BadRequestErrorResponse">When receiving a 401 status code</exception>
        /// <exception cref="Model__error_response_v1__BadRequestErrorResponse">When receiving a 404 status code</exception>
        /// <exception cref="Model__error_response_v1__BadRequestErrorResponse">When receiving a 406 status code</exception>
        /// <exception cref="Model__error_response_v1__BadRequestErrorResponse">When receiving a 500 status code</exception>
        /// <exception cref="Model__error_response_v1__ErrorResponse">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<AddSortingUnitResponse?> PostAsync(MultipartBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<AddSortingUnitResponse> PostAsync(MultipartBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", Model__error_response_v1__BadRequestErrorResponse.CreateFromDiscriminatorValue},
                {"401", Model__error_response_v1__BadRequestErrorResponse.CreateFromDiscriminatorValue},
                {"404", Model__error_response_v1__BadRequestErrorResponse.CreateFromDiscriminatorValue},
                {"406", Model__error_response_v1__BadRequestErrorResponse.CreateFromDiscriminatorValue},
                {"500", Model__error_response_v1__BadRequestErrorResponse.CreateFromDiscriminatorValue},
                {"XXX", Model__error_response_v1__ErrorResponse.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<AddSortingUnitResponse>(requestInfo, AddSortingUnitResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// 仕分けユニットに対して、ページ画像を追加します。
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(MultipartBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(MultipartBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "multipart/form-data", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="AddRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AddRequestBuilder WithUrl(string rawUrl)
        {
            return new AddRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class AddRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
