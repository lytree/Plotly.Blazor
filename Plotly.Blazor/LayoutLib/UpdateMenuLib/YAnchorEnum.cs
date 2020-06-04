/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.UpdateMenuLib
{
    /// <summary>
    ///     Sets the update menu&#39;s vertical position anchor This anchor binds the
    ///     <c>y</c> position to the <c>top</c>, <c>middle</c> or <c>bottom</c> of the
    ///     range selector.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum YAnchorEnum
    {
        [EnumMember(Value=@"top")]
        Top = 0,
        [EnumMember(Value=@"auto")]
        Auto,
        [EnumMember(Value=@"middle")]
        Middle,
        [EnumMember(Value=@"bottom")]
        Bottom
    }
}