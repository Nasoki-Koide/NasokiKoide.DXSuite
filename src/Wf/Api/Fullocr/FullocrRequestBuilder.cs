// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using NasokiKoide.DXSuite.Wf.Api.Fullocr.V2;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace NasokiKoide.DXSuite.Wf.Api.Fullocr {
    /// <summary>
    /// Builds and executes requests for operations under \wf\api\fullocr
    /// </summary>
    public class FullocrRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The v2 property</summary>
        public V2RequestBuilder V2
        {
            get => new V2RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="FullocrRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FullocrRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/wf/api/fullocr", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="FullocrRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FullocrRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/wf/api/fullocr", rawUrl)
        {
        }
    }
}
