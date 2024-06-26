// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using NasokiKoide.DXSuite.Wf.Api.Standard.V2.Workflows.Item.Revisions.Item;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace NasokiKoide.DXSuite.Wf.Api.Standard.V2.Workflows.Item.Revisions {
    /// <summary>
    /// Builds and executes requests for operations under \wf\api\standard\v2\workflows\{workflowId}\revisions
    /// </summary>
    public class RevisionsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the NasokiKoide.DXSuite.wf.api.standard.v2.workflows.item.revisions.item collection</summary>
        /// <param name="position">ワークフローのリビジョンは1以上の整数です。ワークフローのリビジョンは「読取ユニット状態取得API」にて取得できます。</param>
        /// <returns>A <see cref="WithRevisionItemRequestBuilder"/></returns>
        public WithRevisionItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("revision", position);
                return new WithRevisionItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="RevisionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RevisionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/wf/api/standard/v2/workflows/{workflowId}/revisions", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="RevisionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RevisionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/wf/api/standard/v2/workflows/{workflowId}/revisions", rawUrl)
        {
        }
    }
}
