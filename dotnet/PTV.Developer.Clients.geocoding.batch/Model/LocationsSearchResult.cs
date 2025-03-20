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
    /// The result of a locations search.
    /// </summary>
    [DataContract(Name = "LocationsSearchResult")]
    public partial class LocationsSearchResult : IEquatable<LocationsSearchResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationsSearchResult" /> class.
        /// </summary>
        /// <param name="locations">The found locations..</param>
        /// <param name="warnings">A list of warnings concerning the validity of the result..</param>
        /// <param name="error">error.</param>
        public LocationsSearchResult(List<Location> locations = default(List<Location>), List<Warning> warnings = default(List<Warning>), ErrorResponse error = default(ErrorResponse))
        {
            this.Locations = locations;
            this.Warnings = warnings;
            this.Error = error;
        }

        /// <summary>
        /// The found locations.
        /// </summary>
        /// <value>The found locations.</value>
        [DataMember(Name = "locations", EmitDefaultValue = false)]
        public List<Location> Locations { get; set; }

        /// <summary>
        /// A list of warnings concerning the validity of the result.
        /// </summary>
        /// <value>A list of warnings concerning the validity of the result.</value>
        [DataMember(Name = "warnings", EmitDefaultValue = false)]
        public List<Warning> Warnings { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public ErrorResponse Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LocationsSearchResult {\n");
            sb.Append("  Locations: ").Append(Locations).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(input as LocationsSearchResult);
        }

        /// <summary>
        /// Returns true if LocationsSearchResult instances are equal
        /// </summary>
        /// <param name="input">Instance of LocationsSearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocationsSearchResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Locations == input.Locations ||
                    this.Locations != null &&
                    input.Locations != null &&
                    this.Locations.SequenceEqual(input.Locations)
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
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
                if (this.Locations != null)
                {
                    hashCode = (hashCode * 59) + this.Locations.GetHashCode();
                }
                if (this.Warnings != null)
                {
                    hashCode = (hashCode * 59) + this.Warnings.GetHashCode();
                }
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
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
