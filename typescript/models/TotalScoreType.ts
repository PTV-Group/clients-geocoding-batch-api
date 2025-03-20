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


/**
 * Enumeration to specify the type of total score calculation.  
 *  * `INPUT_AND_RESULT_BASED` - The total score is calculated by comparing the result against the input.  
 *  * `RESULT_BASED` - The total score is calculated by classifying result attributes.  
 *  
 *  This parameter is experimental and may change at any time in the future.
 * @export
 */
export const TotalScoreType = {
    INPUT_AND_RESULT_BASED: 'INPUT_AND_RESULT_BASED',
    RESULT_BASED: 'RESULT_BASED'
} as const;
export type TotalScoreType = typeof TotalScoreType[keyof typeof TotalScoreType];


export function instanceOfTotalScoreType(value: any): boolean {
    for (const key in TotalScoreType) {
        if (Object.prototype.hasOwnProperty.call(TotalScoreType, key)) {
            if (TotalScoreType[key as keyof typeof TotalScoreType] === value) {
                return true;
            }
        }
    }
    return false;
}

export function TotalScoreTypeFromJSON(json: any): TotalScoreType {
    return TotalScoreTypeFromJSONTyped(json, false);
}

export function TotalScoreTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): TotalScoreType {
    return json as TotalScoreType;
}

export function TotalScoreTypeToJSON(value?: TotalScoreType | null): any {
    return value as any;
}

