/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.Histogram2DLib
{
    /// <summary>
    ///     Sets the calendar system to use with <c>y</c> date data.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum YCalendarEnum
    {
        [EnumMember(Value=@"gregorian")]
        Gregorian = 0,
        [EnumMember(Value=@"chinese")]
        Chinese,
        [EnumMember(Value=@"coptic")]
        Coptic,
        [EnumMember(Value=@"discworld")]
        DiscWorld,
        [EnumMember(Value=@"ethiopian")]
        Ethiopian,
        [EnumMember(Value=@"hebrew")]
        Hebrew,
        [EnumMember(Value=@"islamic")]
        Islamic,
        [EnumMember(Value=@"julian")]
        Julian,
        [EnumMember(Value=@"mayan")]
        Mayan,
        [EnumMember(Value=@"nanakshahi")]
        Nanakshahi,
        [EnumMember(Value=@"nepali")]
        Nepali,
        [EnumMember(Value=@"persian")]
        Persian,
        [EnumMember(Value=@"jalali")]
        Jalali,
        [EnumMember(Value=@"taiwan")]
        Taiwan,
        [EnumMember(Value=@"thai")]
        Thai,
        [EnumMember(Value=@"ummalqura")]
        Ummalqura
    }
}