// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using NasokiKoide.DXSuite.Wf.Api.Fullocr.V2.Delete;
using NasokiKoide.DXSuite.Wf.Api.Fullocr.V2.GetOcrResult;
using NasokiKoide.DXSuite.Wf.Api.Fullocr.V2.Register;
using NasokiKoide.DXSuite.Wf.Api.Fullocr.V2.Searchablepdf;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace NasokiKoide.DXSuite.Wf.Api.Fullocr.V2 {
    /// <summary>
    /// Builds and executes requests for operations under \wf\api\fullocr\v2
    /// </summary>
    public class V2RequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The deletePath property</summary>
        public DeleteRequestBuilder DeletePath
        {
            get => new DeleteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getOcrResult property</summary>
        public GetOcrResultRequestBuilder GetOcrResult
        {
            get => new GetOcrResultRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The register property</summary>
        public RegisterRequestBuilder Register
        {
            get => new RegisterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The searchablepdf property</summary>
        public SearchablepdfRequestBuilder Searchablepdf
        {
            get => new SearchablepdfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="V2RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V2RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/wf/api/fullocr/v2", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="V2RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V2RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/wf/api/fullocr/v2", rawUrl)
        {
        }
    }
}