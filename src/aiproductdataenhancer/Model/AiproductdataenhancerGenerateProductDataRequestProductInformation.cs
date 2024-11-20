/*
 * aiproductdataenhancer/service.proto
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: version not set
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = aiproductdataenhancer.Client.OpenAPIDateConverter;

namespace aiproductdataenhancer.Model
{
    /// <summary>
    /// AiproductdataenhancerGenerateProductDataRequestProductInformation
    /// </summary>
    [DataContract(Name = "aiproductdataenhancerGenerateProductDataRequestProductInformation")]
    public partial class AiproductdataenhancerGenerateProductDataRequestProductInformation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AiproductdataenhancerGenerateProductDataRequestProductInformation" /> class.
        /// </summary>
        /// <param name="textInfo">textInfo.</param>
        /// <param name="imageInfo">imageInfo.</param>
        public AiproductdataenhancerGenerateProductDataRequestProductInformation(ProductInformationTextInfo textInfo = default(ProductInformationTextInfo), ProductInformationImageInfo imageInfo = default(ProductInformationImageInfo))
        {
            this.TextInfo = textInfo;
            this.ImageInfo = imageInfo;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets TextInfo
        /// </summary>
        [DataMember(Name = "textInfo", EmitDefaultValue = false)]
        public ProductInformationTextInfo TextInfo { get; set; }

        /// <summary>
        /// Gets or Sets ImageInfo
        /// </summary>
        [DataMember(Name = "imageInfo", EmitDefaultValue = false)]
        public ProductInformationImageInfo ImageInfo { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AiproductdataenhancerGenerateProductDataRequestProductInformation {\n");
            sb.Append("  TextInfo: ").Append(TextInfo).Append("\n");
            sb.Append("  ImageInfo: ").Append(ImageInfo).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
