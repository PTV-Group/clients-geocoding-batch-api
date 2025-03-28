/*
 * Geocoding Batch
 * With the Batch Geocoding service you can find a large number of locations.
 *
 * The version of the OpenAPI document: 1.1
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package com.ptvgroup.developer.client.geocoding.batch.model;

import java.net.URLEncoder;
import java.nio.charset.StandardCharsets;
import java.util.StringJoiner;
import java.util.Objects;
import java.util.Map;
import java.util.HashMap;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonTypeName;
import com.fasterxml.jackson.annotation.JsonValue;
import com.ptvgroup.developer.client.geocoding.batch.model.Address;
import com.ptvgroup.developer.client.geocoding.batch.model.ReferencePosition;
import com.ptvgroup.developer.client.geocoding.batch.model.RoadAccessPosition;
import java.util.Arrays;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


import com.ptvgroup.developer.client.geocoding.batch.ApiClient;
/**
 * LocationProperties
 */
@JsonPropertyOrder({
  LocationProperties.JSON_PROPERTY_REFERENCE_POSITION,
  LocationProperties.JSON_PROPERTY_ROAD_ACCESS_POSITION,
  LocationProperties.JSON_PROPERTY_ADDRESS,
  LocationProperties.JSON_PROPERTY_FORMATTED_ADDRESS
})
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2025-03-19T12:20:31.728374697Z[Etc/UTC]", comments = "Generator version: 7.8.0")
public class LocationProperties {
  public static final String JSON_PROPERTY_REFERENCE_POSITION = "referencePosition";
  private ReferencePosition referencePosition;

  public static final String JSON_PROPERTY_ROAD_ACCESS_POSITION = "roadAccessPosition";
  private RoadAccessPosition roadAccessPosition;

  public static final String JSON_PROPERTY_ADDRESS = "address";
  private Address address;

  public static final String JSON_PROPERTY_FORMATTED_ADDRESS = "formattedAddress";
  private String formattedAddress;

  public LocationProperties() { 
  }

  public LocationProperties referencePosition(ReferencePosition referencePosition) {
    this.referencePosition = referencePosition;
    return this;
  }

  /**
   * Get referencePosition
   * @return referencePosition
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_REFERENCE_POSITION)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public ReferencePosition getReferencePosition() {
    return referencePosition;
  }


  @JsonProperty(JSON_PROPERTY_REFERENCE_POSITION)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setReferencePosition(ReferencePosition referencePosition) {
    this.referencePosition = referencePosition;
  }


  public LocationProperties roadAccessPosition(RoadAccessPosition roadAccessPosition) {
    this.roadAccessPosition = roadAccessPosition;
    return this;
  }

  /**
   * Get roadAccessPosition
   * @return roadAccessPosition
   */
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_ROAD_ACCESS_POSITION)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public RoadAccessPosition getRoadAccessPosition() {
    return roadAccessPosition;
  }


  @JsonProperty(JSON_PROPERTY_ROAD_ACCESS_POSITION)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setRoadAccessPosition(RoadAccessPosition roadAccessPosition) {
    this.roadAccessPosition = roadAccessPosition;
  }


  public LocationProperties address(Address address) {
    this.address = address;
    return this;
  }

  /**
   * Get address
   * @return address
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_ADDRESS)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public Address getAddress() {
    return address;
  }


  @JsonProperty(JSON_PROPERTY_ADDRESS)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setAddress(Address address) {
    this.address = address;
  }


  public LocationProperties formattedAddress(String formattedAddress) {
    this.formattedAddress = formattedAddress;
    return this;
  }

  /**
   * A single string representing the address, typically consisting of the street, house number, postal code, city, and country. The precise format may differ based on what is appropriate for the address.
   * @return formattedAddress
   */
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_FORMATTED_ADDRESS)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public String getFormattedAddress() {
    return formattedAddress;
  }


  @JsonProperty(JSON_PROPERTY_FORMATTED_ADDRESS)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setFormattedAddress(String formattedAddress) {
    this.formattedAddress = formattedAddress;
  }


  /**
   * Return true if this LocationProperties object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    LocationProperties locationProperties = (LocationProperties) o;
    return Objects.equals(this.referencePosition, locationProperties.referencePosition) &&
        Objects.equals(this.roadAccessPosition, locationProperties.roadAccessPosition) &&
        Objects.equals(this.address, locationProperties.address) &&
        Objects.equals(this.formattedAddress, locationProperties.formattedAddress);
  }

  @Override
  public int hashCode() {
    return Objects.hash(referencePosition, roadAccessPosition, address, formattedAddress);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class LocationProperties {\n");
    sb.append("    referencePosition: ").append(toIndentedString(referencePosition)).append("\n");
    sb.append("    roadAccessPosition: ").append(toIndentedString(roadAccessPosition)).append("\n");
    sb.append("    address: ").append(toIndentedString(address)).append("\n");
    sb.append("    formattedAddress: ").append(toIndentedString(formattedAddress)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

  /**
   * Convert the instance into URL query string.
   *
   * @return URL query string
   */
  public String toUrlQueryString() {
    return toUrlQueryString(null);
  }

  /**
   * Convert the instance into URL query string.
   *
   * @param prefix prefix of the query string
   * @return URL query string
   */
  public String toUrlQueryString(String prefix) {
    String suffix = "";
    String containerSuffix = "";
    String containerPrefix = "";
    if (prefix == null) {
      // style=form, explode=true, e.g. /pet?name=cat&type=manx
      prefix = "";
    } else {
      // deepObject style e.g. /pet?id[name]=cat&id[type]=manx
      prefix = prefix + "[";
      suffix = "]";
      containerSuffix = "]";
      containerPrefix = "[";
    }

    StringJoiner joiner = new StringJoiner("&");

    // add `referencePosition` to the URL query string
    if (getReferencePosition() != null) {
      joiner.add(getReferencePosition().toUrlQueryString(prefix + "referencePosition" + suffix));
    }

    // add `roadAccessPosition` to the URL query string
    if (getRoadAccessPosition() != null) {
      joiner.add(getRoadAccessPosition().toUrlQueryString(prefix + "roadAccessPosition" + suffix));
    }

    // add `address` to the URL query string
    if (getAddress() != null) {
      joiner.add(getAddress().toUrlQueryString(prefix + "address" + suffix));
    }

    // add `formattedAddress` to the URL query string
    if (getFormattedAddress() != null) {
      joiner.add(String.format("%sformattedAddress%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getFormattedAddress()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    return joiner.toString();
  }
}

