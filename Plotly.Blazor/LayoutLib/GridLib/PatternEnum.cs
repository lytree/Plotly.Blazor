/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.GridLib
{
    /// <summary>
    ///     If no <c>subplots</c>, <c>xaxes</c>, or <c>yaxes</c> are given but we do
    ///     have <c>rows</c> and <c>columns</c>, we can generate defaults using consecutive
    ///     axis IDs, in two ways: <c>coupled</c> gives one x axis per column and one
    ///     y axis per row. <c>independent</c> uses a new xy pair for each cell, left-to-right
    ///     across each row then iterating rows according to <c>roworder</c>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum PatternEnum
    {
        [EnumMember(Value=@"coupled")]
        Coupled = 0,
        [EnumMember(Value=@"independent")]
        Independent
    }
}