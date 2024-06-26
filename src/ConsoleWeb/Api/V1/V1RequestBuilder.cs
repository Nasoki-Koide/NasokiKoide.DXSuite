// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using NasokiKoide.DXSuite.ConsoleWeb.Api.V1.Documents;
using NasokiKoide.DXSuite.ConsoleWeb.Api.V1.Reading;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace NasokiKoide.DXSuite.ConsoleWeb.Api.V1 {
    /// <summary>
    /// Builds and executes requests for operations under \ConsoleWeb\api\v1
    /// </summary>
    public class V1RequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The documents property</summary>
        public DocumentsRequestBuilder Documents
        {
            get => new DocumentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The reading property</summary>
        public ReadingRequestBuilder Reading
        {
            get => new ReadingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="V1RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V1RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/ConsoleWeb/api/v1", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="V1RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V1RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/ConsoleWeb/api/v1", rawUrl)
        {
        }
    }
}
