/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.TreeMapLib
{
    /// <summary>
    ///     Determines default for <c>values</c> when it is not provided, by inferring
    ///     a 1 for each of the <c>leaves</c> and/or <c>branches</c>, otherwise 0.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum CountFlag
    {
        [EnumMember(Value=@"branches")]
        Branches = 0,
        [EnumMember(Value=@"leaves")]
        Leaves = 1
    }
}