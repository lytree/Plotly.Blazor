/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.LegendLib
{
    /// <summary>
    ///     Determines if the legend items symbols scale with their corresponding <c>trace</c>
    ///     attributes or remain <c>constant</c> independent of the symbol size on the
    ///     graph.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ItemSizingEnum
    {
        [EnumMember(Value=@"trace")]
        Trace = 0,
        [EnumMember(Value=@"constant")]
        Constant
    }
}