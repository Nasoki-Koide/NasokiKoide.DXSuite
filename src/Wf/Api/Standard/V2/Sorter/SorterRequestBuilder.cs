// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using NasokiKoide.DXSuite.Wf.Api.Standard.V2.Sorter.Add;
using NasokiKoide.DXSuite.Wf.Api.Standard.V2.Sorter.CsvDownload;
using NasokiKoide.DXSuite.Wf.Api.Standard.V2.Sorter.Delete;
using NasokiKoide.DXSuite.Wf.Api.Standard.V2.Sorter.SendOcr;
using NasokiKoide.DXSuite.Wf.Api.Standard.V2.Sorter.Sorting;
using NasokiKoide.DXSuite.Wf.Api.Standard.V2.Sorter.Status;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace NasokiKoide.DXSuite.Wf.Api.Standard.V2.Sorter {
    /// <summary>
    /// Builds and executes requests for operations under \wf\api\standard\v2\sorter
    /// </summary>
    public class SorterRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The add property</summary>
        public AddRequestBuilder Add
        {
            get => new AddRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The csvDownload property</summary>
        public CsvDownloadRequestBuilder CsvDownload
        {
            get => new CsvDownloadRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deletePath property</summary>
        public DeleteRequestBuilder DeletePath
        {
            get => new DeleteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sendOcr property</summary>
        public SendOcrRequestBuilder SendOcr
        {
            get => new SendOcrRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sorting property</summary>
        public SortingRequestBuilder Sorting
        {
            get => new SortingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The status property</summary>
        public StatusRequestBuilder Status
        {
            get => new StatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="SorterRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SorterRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/wf/api/standard/v2/sorter", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="SorterRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SorterRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/wf/api/standard/v2/sorter", rawUrl)
        {
        }
    }
}
