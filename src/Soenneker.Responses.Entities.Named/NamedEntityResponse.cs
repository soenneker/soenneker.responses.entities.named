using System.Text.Json.Serialization;
using Soenneker.Attributes.PublicOpenApiObject;
using Soenneker.Responses.Entity;

namespace Soenneker.Responses.Entities.Named;

/// <summary>
/// Provides the stable identifier, timestamps, and human-readable display name shared by named API resource responses.
/// </summary>
[PublicOpenApiObject]
public record NamedEntityResponse : EntityResponse
{
    /// <summary>
    /// Human-readable display name of the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public virtual string Name { get; set; } = null!;
}
