// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace NasokiKoide.DXSuite.Models {
    #pragma warning disable CS1591
    public class BadRequestErrorUnitResist : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>10001</summary>
        public int? ErrorCode1 { get; set; }
        /// <summary>210003</summary>
        public int? ErrorCode10 { get; set; }
        /// <summary>10002</summary>
        public int? ErrorCode2 { get; set; }
        /// <summary>10003</summary>
        public int? ErrorCode3 { get; set; }
        /// <summary>10006</summary>
        public int? ErrorCode4 { get; set; }
        /// <summary>10008</summary>
        public int? ErrorCode5 { get; set; }
        /// <summary>20001</summary>
        public int? ErrorCode6 { get; set; }
        /// <summary>110003</summary>
        public int? ErrorCode7 { get; set; }
        /// <summary>210001</summary>
        public int? ErrorCode8 { get; set; }
        /// <summary>210002</summary>
        public int? ErrorCode9 { get; set; }
        /// <summary>{0} is required</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message1 { get; set; }
#nullable restore
#else
        public string Message1 { get; set; }
#endif
        /// <summary>encrypted pdf is unsupported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message10 { get; set; }
#nullable restore
#else
        public string Message10 { get; set; }
#endif
        /// <summary>size of {0} must be less than or equal to {1}</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message2 { get; set; }
#nullable restore
#else
        public string Message2 { get; set; }
#endif
        /// <summary>{0} had invalid characters (Please check the API specification.)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message3 { get; set; }
#nullable restore
#else
        public string Message3 { get; set; }
#endif
        /// <summary>{0} must not be blank (Remove the field or set null if it is not needed.)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message4 { get; set; }
#nullable restore
#else
        public string Message4 { get; set; }
#endif
        /// <summary>{0} length must be between {2} and {1}</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message5 { get; set; }
#nullable restore
#else
        public string Message5 { get; set; }
#endif
        /// <summary>specified department does not exist</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message6 { get; set; }
#nullable restore
#else
        public string Message6 { get; set; }
#endif
        /// <summary>{0} had invalid characters (Please check the API specification.)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message7 { get; set; }
#nullable restore
#else
        public string Message7 { get; set; }
#endif
        /// <summary>file format (extension) is unsupported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message8 { get; set; }
#nullable restore
#else
        public string Message8 { get; set; }
#endif
        /// <summary>tiff compression format is unsupported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message9 { get; set; }
#nullable restore
#else
        public string Message9 { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="BadRequestErrorUnitResist"/> and sets the default values.
        /// </summary>
        public BadRequestErrorUnitResist()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="BadRequestErrorUnitResist"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BadRequestErrorUnitResist CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BadRequestErrorUnitResist();
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
                {"errorCode10", n => { ErrorCode10 = n.GetIntValue(); } },
                {"errorCode2", n => { ErrorCode2 = n.GetIntValue(); } },
                {"errorCode3", n => { ErrorCode3 = n.GetIntValue(); } },
                {"errorCode4", n => { ErrorCode4 = n.GetIntValue(); } },
                {"errorCode5", n => { ErrorCode5 = n.GetIntValue(); } },
                {"errorCode6", n => { ErrorCode6 = n.GetIntValue(); } },
                {"errorCode7", n => { ErrorCode7 = n.GetIntValue(); } },
                {"errorCode8", n => { ErrorCode8 = n.GetIntValue(); } },
                {"errorCode9", n => { ErrorCode9 = n.GetIntValue(); } },
                {"message1", n => { Message1 = n.GetStringValue(); } },
                {"message10", n => { Message10 = n.GetStringValue(); } },
                {"message2", n => { Message2 = n.GetStringValue(); } },
                {"message3", n => { Message3 = n.GetStringValue(); } },
                {"message4", n => { Message4 = n.GetStringValue(); } },
                {"message5", n => { Message5 = n.GetStringValue(); } },
                {"message6", n => { Message6 = n.GetStringValue(); } },
                {"message7", n => { Message7 = n.GetStringValue(); } },
                {"message8", n => { Message8 = n.GetStringValue(); } },
                {"message9", n => { Message9 = n.GetStringValue(); } },
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
            writer.WriteIntValue("errorCode10", ErrorCode10);
            writer.WriteIntValue("errorCode2", ErrorCode2);
            writer.WriteIntValue("errorCode3", ErrorCode3);
            writer.WriteIntValue("errorCode4", ErrorCode4);
            writer.WriteIntValue("errorCode5", ErrorCode5);
            writer.WriteIntValue("errorCode6", ErrorCode6);
            writer.WriteIntValue("errorCode7", ErrorCode7);
            writer.WriteIntValue("errorCode8", ErrorCode8);
            writer.WriteIntValue("errorCode9", ErrorCode9);
            writer.WriteStringValue("message1", Message1);
            writer.WriteStringValue("message10", Message10);
            writer.WriteStringValue("message2", Message2);
            writer.WriteStringValue("message3", Message3);
            writer.WriteStringValue("message4", Message4);
            writer.WriteStringValue("message5", Message5);
            writer.WriteStringValue("message6", Message6);
            writer.WriteStringValue("message7", Message7);
            writer.WriteStringValue("message8", Message8);
            writer.WriteStringValue("message9", Message9);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
