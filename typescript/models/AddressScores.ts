/* tslint:disable */
/* eslint-disable */
/**
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

import { mapValues } from '../runtime';
/**
 * Quality indicators that help deciding how well a result fits to the search input.
 * @export
 * @interface AddressScores
 */
export interface AddressScores {
    /**
     * The score for the returned country in \[%\].
     * @type {number}
     * @memberof AddressScores
     */
    country?: number;
    /**
     * The score for the returned state in \[%\].
     * @type {number}
     * @memberof AddressScores
     */
    state?: number;
    /**
     * The score for the returned province in \[%\].
     * @type {number}
     * @memberof AddressScores
     */
    province?: number;
    /**
     * The score for the returned postalCode in \[%\].
     * @type {number}
     * @memberof AddressScores
     */
    postalCode?: number;
    /**
     * The score for the returned city in \[%\].
     * @type {number}
     * @memberof AddressScores
     */
    city?: number;
    /**
     * The score for the returned district in \[%\].
     * @type {number}
     * @memberof AddressScores
     */
    district?: number;
    /**
     * The score for the returned subdistrict in \[%\].
     * @type {number}
     * @memberof AddressScores
     */
    subDistrict?: number;
    /**
     * The score for the returned street in \[%\].
     * @type {number}
     * @memberof AddressScores
     */
    street?: number;
    /**
     * The score for the returned house number in \[%\].
     * @type {number}
     * @memberof AddressScores
     */
    houseNumber?: number;
}

/**
 * Check if a given object implements the AddressScores interface.
 */
export function instanceOfAddressScores(value: object): value is AddressScores {
    return true;
}

export function AddressScoresFromJSON(json: any): AddressScores {
    return AddressScoresFromJSONTyped(json, false);
}

export function AddressScoresFromJSONTyped(json: any, ignoreDiscriminator: boolean): AddressScores {
    if (json == null) {
        return json;
    }
    return {
        
        'country': json['country'] == null ? undefined : json['country'],
        'state': json['state'] == null ? undefined : json['state'],
        'province': json['province'] == null ? undefined : json['province'],
        'postalCode': json['postalCode'] == null ? undefined : json['postalCode'],
        'city': json['city'] == null ? undefined : json['city'],
        'district': json['district'] == null ? undefined : json['district'],
        'subDistrict': json['subDistrict'] == null ? undefined : json['subDistrict'],
        'street': json['street'] == null ? undefined : json['street'],
        'houseNumber': json['houseNumber'] == null ? undefined : json['houseNumber'],
    };
}

export function AddressScoresToJSON(value?: AddressScores | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'country': value['country'],
        'state': value['state'],
        'province': value['province'],
        'postalCode': value['postalCode'],
        'city': value['city'],
        'district': value['district'],
        'subDistrict': value['subDistrict'],
        'street': value['street'],
        'houseNumber': value['houseNumber'],
    };
}

