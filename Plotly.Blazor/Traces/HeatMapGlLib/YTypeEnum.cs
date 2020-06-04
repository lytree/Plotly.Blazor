/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.HeatMapGlLib
{
    /// <summary>
    ///     If <c>array</c>, the heatmap&#39;s y coordinates are given by <c>y</c> (the
    ///     default behavior when <c>y</c> is provided) If <c>scaled</c>, the heatmap&#39;s
    ///     y coordinates are given by <c>y0</c> and <c>dy</c> (the default behavior
    ///     when <c>y</c> is not provided)
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum YTypeEnum
    {
        [EnumMember(Value=@"array")]
        Array,
        [EnumMember(Value=@"scaled")]
        Scaled
    }
}