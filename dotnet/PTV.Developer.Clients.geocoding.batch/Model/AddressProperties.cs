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
    /// AddressProperties
    /// </summary>
    [DataContract(Name = "AddressProperties")]
    public partial class AddressProperties : IEquatable<AddressProperties>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressProperties" /> class.
        /// </summary>
        /// <param name="country">The country in which the locations should be searched. A country may be defined by name, ISO code (ISO 3166-1 alpha-2 or alpha-3) or country code plate..</param>
        /// <param name="state">A subdivision of a country, for example a state, a region or a province. Using this field narrows down the search and reduces the number of possible results..</param>
        /// <param name="locality">The locality of the address, which may be a city, a district or subdistrict..</param>
        /// <param name="postalCode">The postal code, or zip-code, which is used by a postal authority of a country to identify where the address is located..</param>
        /// <param name="street">The name of the road where the address is located. It must not contain additional information like building names, floor numbers or apartment numbers. It may contain a house number, but using the **houseNumber** field instead will lead to better results..</param>
        /// <param name="houseNumber">The house number of the address..</param>
        public AddressProperties(string country = default(string), string state = default(string), string locality = default(string), string postalCode = default(string), string street = default(string), string houseNumber = default(string))
        {
            this.Country = country;
            this.State = state;
            this.Locality = locality;
            this.PostalCode = postalCode;
            this.Street = street;
            this.HouseNumber = houseNumber;
        }

        /// <summary>
        /// The country in which the locations should be searched. A country may be defined by name, ISO code (ISO 3166-1 alpha-2 or alpha-3) or country code plate.
        /// </summary>
        /// <value>The country in which the locations should be searched. A country may be defined by name, ISO code (ISO 3166-1 alpha-2 or alpha-3) or country code plate.</value>
        [DataMember(Name = "country", EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// A subdivision of a country, for example a state, a region or a province. Using this field narrows down the search and reduces the number of possible results.
        /// </summary>
        /// <value>A subdivision of a country, for example a state, a region or a province. Using this field narrows down the search and reduces the number of possible results.</value>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// The locality of the address, which may be a city, a district or subdistrict.
        /// </summary>
        /// <value>The locality of the address, which may be a city, a district or subdistrict.</value>
        [DataMember(Name = "locality", EmitDefaultValue = true)]
        public string Locality { get; set; }

        /// <summary>
        /// The postal code, or zip-code, which is used by a postal authority of a country to identify where the address is located.
        /// </summary>
        /// <value>The postal code, or zip-code, which is used by a postal authority of a country to identify where the address is located.</value>
        [DataMember(Name = "postalCode", EmitDefaultValue = true)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The name of the road where the address is located. It must not contain additional information like building names, floor numbers or apartment numbers. It may contain a house number, but using the **houseNumber** field instead will lead to better results.
        /// </summary>
        /// <value>The name of the road where the address is located. It must not contain additional information like building names, floor numbers or apartment numbers. It may contain a house number, but using the **houseNumber** field instead will lead to better results.</value>
        [DataMember(Name = "street", EmitDefaultValue = true)]
        public string Street { get; set; }

        /// <summary>
        /// The house number of the address.
        /// </summary>
        /// <value>The house number of the address.</value>
        [DataMember(Name = "houseNumber", EmitDefaultValue = true)]
        public string HouseNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddressProperties {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  HouseNumber: ").Append(HouseNumber).Append("\n");
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
            return this.Equals(input as AddressProperties);
        }

        /// <summary>
        /// Returns true if AddressProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressProperties input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Locality == input.Locality ||
                    (this.Locality != null &&
                    this.Locality.Equals(input.Locality))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && 
                (
                    this.HouseNumber == input.HouseNumber ||
                    (this.HouseNumber != null &&
                    this.HouseNumber.Equals(input.HouseNumber))
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
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.Locality != null)
                {
                    hashCode = (hashCode * 59) + this.Locality.GetHashCode();
                }
                if (this.PostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.PostalCode.GetHashCode();
                }
                if (this.Street != null)
                {
                    hashCode = (hashCode * 59) + this.Street.GetHashCode();
                }
                if (this.HouseNumber != null)
                {
                    hashCode = (hashCode * 59) + this.HouseNumber.GetHashCode();
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