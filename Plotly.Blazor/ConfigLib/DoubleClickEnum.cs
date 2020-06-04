/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.ConfigLib
{
    /// <summary>
    ///     Sets the double click interaction mode. Has an effect only in cartesian
    ///     plots. If <c>false</c>, double click is disable. If <c>reset</c>, double
    ///     click resets the axis ranges to their initial values. If <c>autosize</c>,
    ///     double click set the axis ranges to their autorange values. If <c>reset+autosize</c>,
    ///     the odd double clicks resets the axis ranges to their initial values and
    ///     even double clicks set the axis ranges to their autorange values.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum DoubleClickEnum
    {
        [EnumMember(Value=@"reset+autosize")]
        ResetAutoSize = 0,
        [EnumMember(Value=@"False")]
        False,
        [EnumMember(Value=@"reset")]
        Reset,
        [EnumMember(Value=@"autosize")]
        AutoSize
    }
}