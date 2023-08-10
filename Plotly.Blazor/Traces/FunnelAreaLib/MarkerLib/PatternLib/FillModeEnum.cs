/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.FunnelAreaLib.MarkerLib.PatternLib
{
    /// <summary>
    ///     Determines whether <c>marker.color</c> should be used as a default to <c>bgcolor</c>
    ///     or a <c>fgcolor</c>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum FillModeEnum
    {
        [EnumMember(Value=@"replace")]
        Replace = 0,
        [EnumMember(Value=@"overlay")]
        Overlay
    }
}