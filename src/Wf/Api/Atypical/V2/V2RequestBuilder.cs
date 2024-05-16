// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using NasokiKoide.DXSuite.Wf.Api.Atypical.V2.Delete;
using NasokiKoide.DXSuite.Wf.Api.Atypical.V2.Read;
using NasokiKoide.DXSuite.Wf.Api.Atypical.V2.Receptions;
using NasokiKoide.DXSuite.Wf.Api.Atypical.V2.Result;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace NasokiKoide.DXSuite.Wf.Api.Atypical.V2 {
    /// <summary>
    /// Builds and executes requests for operations under \wf\api\atypical\v2
    /// </summary>
    public class V2RequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The deletePath property</summary>
        public DeleteRequestBuilder DeletePath
        {
            get => new DeleteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The read property</summary>
        public ReadRequestBuilder Read
        {
            get => new ReadRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The receptions property</summary>
        public ReceptionsRequestBuilder Receptions
        {
            get => new ReceptionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The result property</summary>
        public ResultRequestBuilder Result
        {
            get => new ResultRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="V2RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V2RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/wf/api/atypical/v2", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="V2RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V2RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/wf/api/atypical/v2", rawUrl)
        {
        }
    }
}
