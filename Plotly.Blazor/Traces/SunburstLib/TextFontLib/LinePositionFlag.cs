/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.SunburstLib.TextFontLib
{
    /// <summary>
    ///     Sets the kind of decoration line(s) with text, such as an <c>under</c>,
    ///     <c>over</c> or <c>through</c> as well as combinations e.g. <c>under+over</c>,
    ///     etc.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum LinePositionFlag
    {
        [EnumMember(Value=@"none")]
        None = 0,
        [EnumMember(Value=@"under")]
        Under = 1,
        [EnumMember(Value=@"over")]
        Over = 2,
        [EnumMember(Value=@"through")]
        Through = 4
    }
}