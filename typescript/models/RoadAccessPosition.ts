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
 * A position on or very close to a road that marks the entry to the object. Available only for objects which represent buildings with a complete address and only if present in the data.  
 *  The road from which the object can be accessed is not necessarily the road which is closest to the object.
 * @export
 * @interface RoadAccessPosition
 */
export interface RoadAccessPosition {
    /**
     * The latitude value in degrees (WGS84/EPSG:4326) from south to north.
     * @type {number}
     * @memberof RoadAccessPosition
     */
    latitude: number;
    /**
     * The longitude value in degrees (WGS84/EPSG:4326) from west to east.
     * @type {number}
     * @memberof RoadAccessPosition
     */
    longitude: number;
}

/**
 * Check if a given object implements the RoadAccessPosition interface.
 */
export function instanceOfRoadAccessPosition(value: object): value is RoadAccessPosition {
    if (!('latitude' in value) || value['latitude'] === undefined) return false;
    if (!('longitude' in value) || value['longitude'] === undefined) return false;
    return true;
}

export function RoadAccessPositionFromJSON(json: any): RoadAccessPosition {
    return RoadAccessPositionFromJSONTyped(json, false);
}

export function RoadAccessPositionFromJSONTyped(json: any, ignoreDiscriminator: boolean): RoadAccessPosition {
    if (json == null) {
        return json;
    }
    return {
        
        'latitude': json['latitude'],
        'longitude': json['longitude'],
    };
}

export function RoadAccessPositionToJSON(value?: RoadAccessPosition | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'latitude': value['latitude'],
        'longitude': value['longitude'],
    };
}

