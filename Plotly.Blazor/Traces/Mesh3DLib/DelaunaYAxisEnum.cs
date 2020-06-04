/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.Mesh3DLib
{
    /// <summary>
    ///     Sets the Delaunay axis, which is the axis that is perpendicular to the surface
    ///     of the Delaunay triangulation. It has an effect if <c>i</c>, <c>j</c>, <c>k</c>
    ///     are not provided and <c>alphahull</c> is set to indicate Delaunay triangulation.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum DelaunaYAxisEnum
    {
        [EnumMember(Value=@"z")]
        Z = 0,
        [EnumMember(Value=@"x")]
        X,
        [EnumMember(Value=@"y")]
        Y
    }
}