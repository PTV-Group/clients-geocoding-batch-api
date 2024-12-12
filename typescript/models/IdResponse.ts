/* tslint:disable */
/* eslint-disable */
/**
 * Geocoding Batch API
 * With the Batch Geocoding service you can find a large number of locations.
 *
 * The version of the OpenAPI document: 1.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface IdResponse
 */
export interface IdResponse {
    /**
     * The id of the geocoding request.
     * @type {string}
     * @memberof IdResponse
     */
    id: string;
}

/**
 * Check if a given object implements the IdResponse interface.
 */
export function instanceOfIdResponse(value: object): value is IdResponse {
    if (!('id' in value) || value['id'] === undefined) return false;
    return true;
}

export function IdResponseFromJSON(json: any): IdResponse {
    return IdResponseFromJSONTyped(json, false);
}

export function IdResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): IdResponse {
    if (json == null) {
        return json;
    }
    return {
        
        'id': json['id'],
    };
}

export function IdResponseToJSON(value?: IdResponse | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'id': value['id'],
    };
}
