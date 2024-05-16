// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace NasokiKoide.DXSuite.Models {
    #pragma warning disable CS1591
    public class DataItem : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>※現在、読取尤度は定型帳票（読取範囲の指定）にのみ提供しております。非定型帳票（旧モデル）、項目抽出帳票の場合は、常に0.0がセットされます。</summary>
        public float? Accuracy { get; set; }
        /// <summary>0: 情報なし（デフォルト）, 1: 低い精度で正確に読めている, 2: 少し低い精度で正確に読めている, 3: 少し高い精度で正確に読めている, 4: 高い精度で正確に読めている</summary>
        public int? AccuracyRank { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The columnName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ColumnName { get; set; }
#nullable restore
#else
        public string ColumnName { get; set; }
#endif
        /// <summary>数字形式で、1がA列、2がB列...となります。(0はCSV出力しない)</summary>
        public int? ColumnNo { get; set; }
        /// <summary>The createdAt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; set; }
#nullable restore
#else
        public string CreatedAt { get; set; }
#endif
        /// <summary>The dataItemId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DataItemId { get; set; }
#nullable restore
#else
        public string DataItemId { get; set; }
#endif
        /// <summary>The detailDataItemId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DetailDataItemId { get; set; }
#nullable restore
#else
        public string DetailDataItemId { get; set; }
#endif
        /// <summary>The fileName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileName { get; set; }
#nullable restore
#else
        public string FileName { get; set; }
#endif
        /// <summary>The folderId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FolderId { get; set; }
#nullable restore
#else
        public string FolderId { get; set; }
#endif
        /// <summary>The height property</summary>
        public int? Height { get; set; }
        /// <summary>The pageId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PageId { get; set; }
#nullable restore
#else
        public string PageId { get; set; }
#endif
        /// <summary>The result property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Result { get; set; }
#nullable restore
#else
        public string Result { get; set; }
#endif
        /// <summary>1: 読取完了, 2: 位置検出済み(OCR未実施), 3: 位置未検出, 4: 読取失敗</summary>
        public int? Status { get; set; }
        /// <summary>The unitId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UnitId { get; set; }
#nullable restore
#else
        public string UnitId { get; set; }
#endif
        /// <summary>The width property</summary>
        public int? Width { get; set; }
        /// <summary>The workflowId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WorkflowId { get; set; }
#nullable restore
#else
        public string WorkflowId { get; set; }
#endif
        /// <summary>The x property</summary>
        public int? X { get; set; }
        /// <summary>The y property</summary>
        public int? Y { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="DataItem"/> and sets the default values.
        /// </summary>
        public DataItem()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DataItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DataItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DataItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"accuracy", n => { Accuracy = n.GetFloatValue(); } },
                {"accuracyRank", n => { AccuracyRank = n.GetIntValue(); } },
                {"columnName", n => { ColumnName = n.GetStringValue(); } },
                {"columnNo", n => { ColumnNo = n.GetIntValue(); } },
                {"createdAt", n => { CreatedAt = n.GetStringValue(); } },
                {"dataItemId", n => { DataItemId = n.GetStringValue(); } },
                {"detailDataItemId", n => { DetailDataItemId = n.GetStringValue(); } },
                {"fileName", n => { FileName = n.GetStringValue(); } },
                {"folderId", n => { FolderId = n.GetStringValue(); } },
                {"height", n => { Height = n.GetIntValue(); } },
                {"pageId", n => { PageId = n.GetStringValue(); } },
                {"result", n => { Result = n.GetStringValue(); } },
                {"status", n => { Status = n.GetIntValue(); } },
                {"unitId", n => { UnitId = n.GetStringValue(); } },
                {"width", n => { Width = n.GetIntValue(); } },
                {"workflowId", n => { WorkflowId = n.GetStringValue(); } },
                {"x", n => { X = n.GetIntValue(); } },
                {"y", n => { Y = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteFloatValue("accuracy", Accuracy);
            writer.WriteIntValue("accuracyRank", AccuracyRank);
            writer.WriteStringValue("columnName", ColumnName);
            writer.WriteIntValue("columnNo", ColumnNo);
            writer.WriteStringValue("createdAt", CreatedAt);
            writer.WriteStringValue("dataItemId", DataItemId);
            writer.WriteStringValue("detailDataItemId", DetailDataItemId);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteStringValue("folderId", FolderId);
            writer.WriteIntValue("height", Height);
            writer.WriteStringValue("pageId", PageId);
            writer.WriteStringValue("result", Result);
            writer.WriteIntValue("status", Status);
            writer.WriteStringValue("unitId", UnitId);
            writer.WriteIntValue("width", Width);
            writer.WriteStringValue("workflowId", WorkflowId);
            writer.WriteIntValue("x", X);
            writer.WriteIntValue("y", Y);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}