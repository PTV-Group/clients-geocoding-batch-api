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
import type { LocationsSearchResult } from './LocationsSearchResult';
import {
    LocationsSearchResultFromJSON,
    LocationsSearchResultFromJSONTyped,
    LocationsSearchResultToJSON,
} from './LocationsSearchResult';

/**
 * 
 * @export
 * @interface LocationsSearchResponse
 */
export interface LocationsSearchResponse {
    /**
     * The results of a single locations search.
     * @type {Array<LocationsSearchResult>}
     * @memberof LocationsSearchResponse
     */
    results: Array<LocationsSearchResult>;
}

/**
 * Check if a given object implements the LocationsSearchResponse interface.
 */
export function instanceOfLocationsSearchResponse(value: object): value is LocationsSearchResponse {
    if (!('results' in value) || value['results'] === undefined) return false;
    return true;
}

export function LocationsSearchResponseFromJSON(json: any): LocationsSearchResponse {
    return LocationsSearchResponseFromJSONTyped(json, false);
}

export function LocationsSearchResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): LocationsSearchResponse {
    if (json == null) {
        return json;
    }
    return {
        
        'results': ((json['results'] as Array<any>).map(LocationsSearchResultFromJSON)),
    };
}

export function LocationsSearchResponseToJSON(value?: LocationsSearchResponse | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'results': ((value['results'] as Array<any>).map(LocationsSearchResultToJSON)),
    };
}

