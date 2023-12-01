
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace HathoraCloud.Models.Shared
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System;
    using UnityEngine;
    
    /// <summary>
    /// Connection information for the default and additional ports.
    /// </summary>
    [Serializable]
    public class ConnectionInfoV2
    {

        [SerializeField]
        [JsonProperty("additionalExposedPorts")]
        public List<ExposedPort> AdditionalExposedPorts { get; set; } = default!;
        

        /// <summary>
        /// Connection details for an active process.
        /// </summary>
        [SerializeField]
        [JsonProperty("exposedPort")]
        public ExposedPort? ExposedPort { get; set; }
        

        /// <summary>
        /// Unique identifier to a game session or match. Use the default system generated ID or overwrite it with your own.<br/>
        /// 
        /// <remarks>
        /// Note: error will be returned if `roomId` is not globally unique.
        /// </remarks>
        /// </summary>
        [SerializeField]
        [JsonProperty("roomId")]
        public string RoomId { get; set; } = default!;
        

        /// <summary>
        /// `exposedPort` will only be available when the `status` of a room is &quot;active&quot;.
        /// </summary>
        [SerializeField]
        [JsonProperty("status")]
        public ConnectionInfoV2Status Status { get; set; } = default!;
        
    }
}