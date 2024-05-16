// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Multipart;
using Microsoft.Kiota.Serialization.Text;
using NasokiKoide.DXSuite.ConsoleWeb;
using NasokiKoide.DXSuite.Sorter;
using NasokiKoide.DXSuite.Wf;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Microsoft.Kiota.Abstractions.Authentication;
namespace NasokiKoide.DXSuite
{
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    public class DXSuiteClient : BaseRequestBuilder
    {
        /// <summary>The ConsoleWeb property</summary>
        public ConsoleWebRequestBuilder ConsoleWeb
        {
            get => new ConsoleWebRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Sorter property</summary>
        public SorterRequestBuilder Sorter
        {
            get => new SorterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The wf property</summary>
        public WfRequestBuilder Wf
        {
            get => new WfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="DXSuiteClient"/> and sets the default values.
        /// </summary>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        // public DXSuiteClient(IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}", new Dictionary<string, object>())
        // {
        //     ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
        //     ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
        //     ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
        //     ApiClientBuilder.RegisterDefaultSerializer<MultipartSerializationWriterFactory>();
        //     ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
        //     ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
        //     ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();
        // }

        public DXSuiteClient(string apiKey, string hostName) : base(
                new HttpClientRequestAdapter(
                    new ApiKeyAuthenticationProvider(
                        apiKey,
                        "apikey",
                        ApiKeyAuthenticationProvider.KeyLocation.Header
                    )
                ),
                $"https://{hostName}.dx-suite.com",
                new Dictionary<string, object>())
        {
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<MultipartSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();
        }
    }
}