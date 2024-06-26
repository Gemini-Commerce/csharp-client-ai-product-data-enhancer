/*
 * aiproductdataenhancer/service.proto
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: version not set
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
using OpenAPIDateConverter = aiproductdataenhancer.Client.OpenAPIDateConverter;

namespace aiproductdataenhancer.Model
{
    /// <summary>
    /// Defines aiproductdataenhancerJobStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AiproductdataenhancerJobStatus
    {
        /// <summary>
        /// Enum UNKNOWN for value: JOB_STATUS_UNKNOWN
        /// </summary>
        [EnumMember(Value = "JOB_STATUS_UNKNOWN")]
        UNKNOWN = 1,

        /// <summary>
        /// Enum PENDING for value: JOB_STATUS_PENDING
        /// </summary>
        [EnumMember(Value = "JOB_STATUS_PENDING")]
        PENDING = 2,

        /// <summary>
        /// Enum RUNNING for value: JOB_STATUS_RUNNING
        /// </summary>
        [EnumMember(Value = "JOB_STATUS_RUNNING")]
        RUNNING = 3,

        /// <summary>
        /// Enum COMPLETED for value: JOB_STATUS_COMPLETED
        /// </summary>
        [EnumMember(Value = "JOB_STATUS_COMPLETED")]
        COMPLETED = 4,

        /// <summary>
        /// Enum FAILED for value: JOB_STATUS_FAILED
        /// </summary>
        [EnumMember(Value = "JOB_STATUS_FAILED")]
        FAILED = 5
    }

}
