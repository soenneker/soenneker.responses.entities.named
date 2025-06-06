﻿using System.Text.Json.Serialization;
using Soenneker.Responses.Entity;

namespace Soenneker.Responses.Entities.Named;

/// <summary>
/// A derived EntityResponse model with a Name property, serialized using System.Text.Json property names.
/// </summary>
public record NamedEntityResponse : EntityResponse
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
}