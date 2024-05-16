// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace NasokiKoide.DXSuite.Models {
    #pragma warning disable CS1591
    public class SorterResultsCSVExportSpecifiedResourceDoesNotExistResponse : ApiException, IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The errors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SorterResultsCSVExportSpecifiedResourceDoesNotExist>? Errors { get; set; }
#nullable restore
#else
        public List<SorterResultsCSVExportSpecifiedResourceDoesNotExist> Errors { get; set; }
#endif
        /// <summary>The primary error message.</summary>
        public override string Message { get => base.Message; }
        /// <summary>
        /// Instantiates a new <see cref="SorterResultsCSVExportSpecifiedResourceDoesNotExistResponse"/> and sets the default values.
        /// </summary>
        public SorterResultsCSVExportSpecifiedResourceDoesNotExistResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SorterResultsCSVExportSpecifiedResourceDoesNotExistResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SorterResultsCSVExportSpecifiedResourceDoesNotExistResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SorterResultsCSVExportSpecifiedResourceDoesNotExistResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"errors", n => { Errors = n.GetCollectionOfObjectValues<SorterResultsCSVExportSpecifiedResourceDoesNotExist>(SorterResultsCSVExportSpecifiedResourceDoesNotExist.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<SorterResultsCSVExportSpecifiedResourceDoesNotExist>("errors", Errors);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}