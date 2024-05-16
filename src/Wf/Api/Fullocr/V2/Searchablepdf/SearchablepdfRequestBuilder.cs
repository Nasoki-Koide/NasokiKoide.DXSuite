// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using NasokiKoide.DXSuite.Wf.Api.Fullocr.V2.Searchablepdf.GetResult;
using NasokiKoide.DXSuite.Wf.Api.Fullocr.V2.Searchablepdf.Register;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace NasokiKoide.DXSuite.Wf.Api.Fullocr.V2.Searchablepdf {
    /// <summary>
    /// Builds and executes requests for operations under \wf\api\fullocr\v2\searchablepdf
    /// </summary>
    public class SearchablepdfRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The getResult property</summary>
        public GetResultRequestBuilder GetResult
        {
            get => new GetResultRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The register property</summary>
        public RegisterRequestBuilder Register
        {
            get => new RegisterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="SearchablepdfRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SearchablepdfRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/wf/api/fullocr/v2/searchablepdf", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="SearchablepdfRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SearchablepdfRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/wf/api/fullocr/v2/searchablepdf", rawUrl)
        {
        }
    }
}
