/*
 * Geocoding Batch API
 *
 * With the Batch Geocoding service you can find a large number of locations.
 *
 * The version of the OpenAPI document: 1.0
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
    /// Location
    /// </summary>
    [DataContract(Name = "Location")]
    public partial class Location : IEquatable<Location>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets LocationType
        /// </summary>
        [DataMember(Name = "locationType", IsRequired = true, EmitDefaultValue = true)]
        public LocationType LocationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Location() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        /// <param name="referencePosition">referencePosition (required).</param>
        /// <param name="roadAccessPosition">roadAccessPosition.</param>
        /// <param name="address">address (required).</param>
        /// <param name="formattedAddress">A single string representing the address, typically consisting of the street, house number, postal code, city, and country. The precise format may differ based on what is appropriate for the address..</param>
        /// <param name="locationType">locationType (required).</param>
        /// <param name="quality">quality (required).</param>
        public Location(ReferencePosition referencePosition = default(ReferencePosition), RoadAccessPosition roadAccessPosition = default(RoadAccessPosition), Address address = default(Address), string formattedAddress = default(string), LocationType locationType = default(LocationType), Quality quality = default(Quality))
        {
            // to ensure "referencePosition" is required (not null)
            if (referencePosition == null)
            {
                throw new ArgumentNullException("referencePosition is a required property for Location and cannot be null");
            }
            this.ReferencePosition = referencePosition;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for Location and cannot be null");
            }
            this.Address = address;
            this.LocationType = locationType;
            // to ensure "quality" is required (not null)
            if (quality == null)
            {
                throw new ArgumentNullException("quality is a required property for Location and cannot be null");
            }
            this.Quality = quality;
            this.RoadAccessPosition = roadAccessPosition;
            this.FormattedAddress = formattedAddress;
        }

        /// <summary>
        /// Gets or Sets ReferencePosition
        /// </summary>
        [DataMember(Name = "referencePosition", IsRequired = true, EmitDefaultValue = true)]
        public ReferencePosition ReferencePosition { get; set; }

        /// <summary>
        /// Gets or Sets RoadAccessPosition
        /// </summary>
        [DataMember(Name = "roadAccessPosition", EmitDefaultValue = false)]
        public RoadAccessPosition RoadAccessPosition { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public Address Address { get; set; }

        /// <summary>
        /// A single string representing the address, typically consisting of the street, house number, postal code, city, and country. The precise format may differ based on what is appropriate for the address.
        /// </summary>
        /// <value>A single string representing the address, typically consisting of the street, house number, postal code, city, and country. The precise format may differ based on what is appropriate for the address.</value>
        [DataMember(Name = "formattedAddress", EmitDefaultValue = true)]
        public string FormattedAddress { get; set; }

        /// <summary>
        /// Gets or Sets Quality
        /// </summary>
        [DataMember(Name = "quality", IsRequired = true, EmitDefaultValue = true)]
        public Quality Quality { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Location {\n");
            sb.Append("  ReferencePosition: ").Append(ReferencePosition).Append("\n");
            sb.Append("  RoadAccessPosition: ").Append(RoadAccessPosition).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  FormattedAddress: ").Append(FormattedAddress).Append("\n");
            sb.Append("  LocationType: ").Append(LocationType).Append("\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
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
            return this.Equals(input as Location);
        }

        /// <summary>
        /// Returns true if Location instances are equal
        /// </summary>
        /// <param name="input">Instance of Location to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Location input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ReferencePosition == input.ReferencePosition ||
                    (this.ReferencePosition != null &&
                    this.ReferencePosition.Equals(input.ReferencePosition))
                ) && 
                (
                    this.RoadAccessPosition == input.RoadAccessPosition ||
                    (this.RoadAccessPosition != null &&
                    this.RoadAccessPosition.Equals(input.RoadAccessPosition))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.FormattedAddress == input.FormattedAddress ||
                    (this.FormattedAddress != null &&
                    this.FormattedAddress.Equals(input.FormattedAddress))
                ) && 
                (
                    this.LocationType == input.LocationType ||
                    this.LocationType.Equals(input.LocationType)
                ) && 
                (
                    this.Quality == input.Quality ||
                    (this.Quality != null &&
                    this.Quality.Equals(input.Quality))
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
                if (this.ReferencePosition != null)
                {
                    hashCode = (hashCode * 59) + this.ReferencePosition.GetHashCode();
                }
                if (this.RoadAccessPosition != null)
                {
                    hashCode = (hashCode * 59) + this.RoadAccessPosition.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.FormattedAddress != null)
                {
                    hashCode = (hashCode * 59) + this.FormattedAddress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LocationType.GetHashCode();
                if (this.Quality != null)
                {
                    hashCode = (hashCode * 59) + this.Quality.GetHashCode();
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
