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
namespace NasokiKoide.DXSuite.Wf.Api.Atypical.V2.Receptions {
    /// <summary>
    /// Builds and executes requests for operations under \wf\api\atypical\v2\receptions
    /// </summary>
    public class ReceptionsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="ReceptionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReceptionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/wf/api/atypical/v2/receptions{?departmentId*,limit*,model*,offset*,receptionDateTimeFrom*,receptionDateTimeTo*,status*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ReceptionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReceptionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/wf/api/atypical/v2/receptions{?departmentId*,limit*,model*,offset*,receptionDateTimeFrom*,receptionDateTimeTo*,status*}", rawUrl)
        {
        }
        /// <summary>
        /// 受付情報を取得するAPI
        /// </summary>
        /// <returns>A <see cref="AtypicalGetReceptionsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="AtypicalErrorResponse">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<AtypicalGetReceptionsResponse?> GetAsync(Action<RequestConfiguration<ReceptionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<AtypicalGetReceptionsResponse> GetAsync(Action<RequestConfiguration<ReceptionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", AtypicalErrorResponse.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<AtypicalGetReceptionsResponse>(requestInfo, AtypicalGetReceptionsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// 受付情報を取得するAPI
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ReceptionsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ReceptionsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="ReceptionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ReceptionsRequestBuilder WithUrl(string rawUrl)
        {
            return new ReceptionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// 受付情報を取得するAPI
        /// </summary>
        public class ReceptionsRequestBuilderGetQueryParameters 
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("departmentId")]
            public string? DepartmentId { get; set; }
#nullable restore
#else
            [QueryParameter("departmentId")]
            public string DepartmentId { get; set; }
#endif
            [QueryParameter("limit")]
            public int? Limit { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("model")]
            public string? Model { get; set; }
#nullable restore
#else
            [QueryParameter("model")]
            public string Model { get; set; }
#endif
            [QueryParameter("offset")]
            public int? Offset { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("receptionDateTimeFrom")]
            public string? ReceptionDateTimeFrom { get; set; }
#nullable restore
#else
            [QueryParameter("receptionDateTimeFrom")]
            public string ReceptionDateTimeFrom { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("receptionDateTimeTo")]
            public string? ReceptionDateTimeTo { get; set; }
#nullable restore
#else
            [QueryParameter("receptionDateTimeTo")]
            public string ReceptionDateTimeTo { get; set; }
#endif
            [QueryParameter("status")]
            public int? Status { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ReceptionsRequestBuilderGetRequestConfiguration : RequestConfiguration<ReceptionsRequestBuilderGetQueryParameters> 
        {
        }
    }
}
