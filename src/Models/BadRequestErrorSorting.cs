// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace NasokiKoide.DXSuite.Models {
    #pragma warning disable CS1591
    public class BadRequestErrorSorting : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>10001</summary>
        public int? ErrorCode1 { get; set; }
        /// <summary>10006</summary>
        public int? ErrorCode2 { get; set; }
        /// <summary>10011</summary>
        public int? ErrorCode3 { get; set; }
        /// <summary>20001</summary>
        public int? ErrorCode4 { get; set; }
        /// <summary>unitId is required</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message1 { get; set; }
#nullable restore
#else
        public string Message1 { get; set; }
#endif
        /// <summary>{0} must not be blank (Remove the field or set null if it is not needed.)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message2 { get; set; }
#nullable restore
#else
        public string Message2 { get; set; }
#endif
        /// <summary>{0} was invalid pattern (Please check the API specification.)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message3 { get; set; }
#nullable restore
#else
        public string Message3 { get; set; }
#endif
        /// <summary>specified department does not exist</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message4 { get; set; }
#nullable restore
#else
        public string Message4 { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="BadRequestErrorSorting"/> and sets the default values.
        /// </summary>
        public BadRequestErrorSorting()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="BadRequestErrorSorting"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BadRequestErrorSorting CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BadRequestErrorSorting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"errorCode1", n => { ErrorCode1 = n.GetIntValue(); } },
                {"errorCode2", n => { ErrorCode2 = n.GetIntValue(); } },
                {"errorCode3", n => { ErrorCode3 = n.GetIntValue(); } },
                {"errorCode4", n => { ErrorCode4 = n.GetIntValue(); } },
                {"message1", n => { Message1 = n.GetStringValue(); } },
                {"message2", n => { Message2 = n.GetStringValue(); } },
                {"message3", n => { Message3 = n.GetStringValue(); } },
                {"message4", n => { Message4 = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("errorCode1", ErrorCode1);
            writer.WriteIntValue("errorCode2", ErrorCode2);
            writer.WriteIntValue("errorCode3", ErrorCode3);
            writer.WriteIntValue("errorCode4", ErrorCode4);
            writer.WriteStringValue("message1", Message1);
            writer.WriteStringValue("message2", Message2);
            writer.WriteStringValue("message3", Message3);
            writer.WriteStringValue("message4", Message4);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
