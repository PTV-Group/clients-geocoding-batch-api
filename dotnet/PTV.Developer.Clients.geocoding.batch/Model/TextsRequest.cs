/*
 * Geocoding Batch
 *
 * With the Batch Geocoding service you can find a large number of locations.
 *
 * The version of the OpenAPI document: 1.1
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
using OpenAPIDateConverter = PTV.Developer.Clients.geocoding.batch.Client.OpenAPIDateConverter;

namespace PTV.Developer.Clients.geocoding.batch.Model
{
    /// <summary>
    /// TextsRequest
    /// </summary>
    [DataContract(Name = "TextsRequest")]
    public partial class TextsRequest : IEquatable<TextsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TextsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TextsRequest" /> class.
        /// </summary>
        /// <param name="texts">List of free-form text inputs that describe a location. (required).</param>
        public TextsRequest(List<string> texts = default(List<string>))
        {
            // to ensure "texts" is required (not null)
            if (texts == null)
            {
                throw new ArgumentNullException("texts is a required property for TextsRequest and cannot be null");
            }
            this.Texts = texts;
        }

        /// <summary>
        /// List of free-form text inputs that describe a location.
        /// </summary>
        /// <value>List of free-form text inputs that describe a location.</value>
        [DataMember(Name = "texts", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Texts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TextsRequest {\n");
            sb.Append("  Texts: ").Append(Texts).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TextsRequest);
        }

        /// <summary>
        /// Returns true if TextsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TextsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Texts == input.Texts ||
                    this.Texts != null &&
                    input.Texts != null &&
                    this.Texts.SequenceEqual(input.Texts)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Texts != null)
                {
                    hashCode = (hashCode * 59) + this.Texts.GetHashCode();
                }
                return hashCode;
            }
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
