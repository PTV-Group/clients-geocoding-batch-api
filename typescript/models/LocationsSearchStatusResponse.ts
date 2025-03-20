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
import type { Status } from './Status';
import {
    StatusFromJSON,
    StatusFromJSONTyped,
    StatusToJSON,
} from './Status';

/**
 * 
 * @export
 * @interface LocationsSearchStatusResponse
 */
export interface LocationsSearchStatusResponse {
    /**
     * 
     * @type {Status}
     * @memberof LocationsSearchStatusResponse
     */
    status: Status;
    /**
     * The progress of the geocoding request in \[%\].
     * @type {number}
     * @memberof LocationsSearchStatusResponse
     */
    progress: number;
}



/**
 * Check if a given object implements the LocationsSearchStatusResponse interface.
 */
export function instanceOfLocationsSearchStatusResponse(value: object): value is LocationsSearchStatusResponse {
    if (!('status' in value) || value['status'] === undefined) return false;
    if (!('progress' in value) || value['progress'] === undefined) return false;
    return true;
}

export function LocationsSearchStatusResponseFromJSON(json: any): LocationsSearchStatusResponse {
    return LocationsSearchStatusResponseFromJSONTyped(json, false);
}

export function LocationsSearchStatusResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): LocationsSearchStatusResponse {
    if (json == null) {
        return json;
    }
    return {
        
        'status': StatusFromJSON(json['status']),
        'progress': json['progress'],
    };
}

export function LocationsSearchStatusResponseToJSON(value?: LocationsSearchStatusResponse | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'status': StatusToJSON(value['status']),
        'progress': value['progress'],
    };
}

