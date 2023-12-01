
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
    using System;
    using UnityEngine;
    
    [Serializable]
    public class UpdateRoomConfigParams
    {

        /// <summary>
        /// Optional configuration parameters for the room. Can be any string including stringified JSON. It is accessible from the room via <a href="">`GetRoomInfo()`</a>.
        /// </summary>
        [SerializeField]
        [JsonProperty("roomConfig")]
        public string RoomConfig { get; set; } = default!;
        
    }
}