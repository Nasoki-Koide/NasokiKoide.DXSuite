// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace NasokiKoide.DXSuite.Models {
    #pragma warning disable CS1591
    public class FullOcrGetOcrResultOcrResult_bbox : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>画像比 - 小数点以下6桁まで</summary>
        public float? Bottom { get; set; }
        /// <summary>画像比 - 小数点以下6桁まで</summary>
        public float? Left { get; set; }
        /// <summary>画像比 - 小数点以下6桁まで</summary>
        public float? Right { get; set; }
        /// <summary>画像比 - 小数点以下6桁まで</summary>
        public float? Top { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="FullOcrGetOcrResultOcrResult_bbox"/> and sets the default values.
        /// </summary>
        public FullOcrGetOcrResultOcrResult_bbox()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="FullOcrGetOcrResultOcrResult_bbox"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FullOcrGetOcrResultOcrResult_bbox CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FullOcrGetOcrResultOcrResult_bbox();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"bottom", n => { Bottom = n.GetFloatValue(); } },
                {"left", n => { Left = n.GetFloatValue(); } },
                {"right", n => { Right = n.GetFloatValue(); } },
                {"top", n => { Top = n.GetFloatValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteFloatValue("bottom", Bottom);
            writer.WriteFloatValue("left", Left);
            writer.WriteFloatValue("right", Right);
            writer.WriteFloatValue("top", Top);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
