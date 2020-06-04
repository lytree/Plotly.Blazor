/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.ContourLib.ContoursLib
{
    /// <summary>
    ///     Determines the coloring method showing the contour values. If <c>fill</c>,
    ///     coloring is done evenly between each contour level If <c>heatmap</c>, a
    ///     heatmap gradient coloring is applied between each contour level. If <c>lines</c>,
    ///     coloring is done on the contour lines. If <c>none</c>, no coloring is applied
    ///     on this trace.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ColoringEnum
    {
        [EnumMember(Value=@"fill")]
        Fill = 0,
        [EnumMember(Value=@"heatmap")]
        HeatMap,
        [EnumMember(Value=@"lines")]
        Lines,
        [EnumMember(Value=@"none")]
        None
    }
}