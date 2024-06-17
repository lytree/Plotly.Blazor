/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.IsoSurfaceLib.HoverLabelLib.FontLib
{
    /// <summary>
    ///     Sets capitalization of text. It can be used to make text appear in all-uppercase
    ///     or all-lowercase, or with each word capitalized.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [JsonConverter(typeof(EnumConverter))]
    public enum TextCaseEnum
    {
        [EnumMember(Value=@"normal")]
        Normal = 0,
        [EnumMember(Value=@"word caps")]
        WordCaps,
        [EnumMember(Value=@"upper")]
        Upper,
        [EnumMember(Value=@"lower")]
        Lower
    }
}