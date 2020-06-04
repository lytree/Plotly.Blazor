/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib
{
    /// <summary>
    ///     Determines how violins at the same location coordinate are displayed on
    ///     the graph. If <c>group</c>, the violins are plotted next to one another
    ///     centered around the shared location. If <c>overlay</c>, the violins are
    ///     plotted over one another, you might need to set <c>opacity</c> to see them
    ///     multiple violins. Has no effect on traces that have <c>width</c> set.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ViolinModeEnum
    {
        [EnumMember(Value=@"overlay")]
        Overlay = 0,
        [EnumMember(Value=@"group")]
        Group
    }
}