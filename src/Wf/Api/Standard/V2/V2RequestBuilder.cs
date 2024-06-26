// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using NasokiKoide.DXSuite.Wf.Api.Standard.V2.Sorter;
using NasokiKoide.DXSuite.Wf.Api.Standard.V2.Units;
using NasokiKoide.DXSuite.Wf.Api.Standard.V2.Workflows;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace NasokiKoide.DXSuite.Wf.Api.Standard.V2 {
    /// <summary>
    /// Builds and executes requests for operations under \wf\api\standard\v2
    /// </summary>
    public class V2RequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The sorter property</summary>
        public SorterRequestBuilder Sorter
        {
            get => new SorterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The units property</summary>
        public UnitsRequestBuilder Units
        {
            get => new UnitsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The workflows property</summary>
        public WorkflowsRequestBuilder Workflows
        {
            get => new WorkflowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="V2RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V2RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/wf/api/standard/v2", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="V2RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V2RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/wf/api/standard/v2", rawUrl)
        {
        }
    }
}
