[![](https://img.shields.io/nuget/v/soenneker.responses.entities.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.responses.entities.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.responses.entities.named/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.responses.entities.named/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.responses.entities.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.responses.entities.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.responses.entities.named/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.responses.entities.named/actions/workflows/codeql.yml)

# Soenneker.Responses.Entities.Named

A reusable API response record for named resources, with an identifier and audit timestamps.

## Installation

```bash
dotnet add package Soenneker.Responses.Entities.Named
```

## Usage

Use `NamedEntityResponse` directly for a simple resource contract:

```csharp
using Soenneker.Responses.Entities.Named;

var response = new NamedEntityResponse
{
    Id = environment.Id,
    Name = environment.Name,
    CreatedAt = environment.CreatedAt,
    ModifiedAt = environment.ModifiedAt
};
```

Or derive a more specific response without repeating the common fields:

```csharp
public record EnvironmentResponse : NamedEntityResponse
{
    public required string Region { get; init; }
}
```

The JSON properties inherited from `EntityResponse` are `id`, `createdAt`, and `modifiedAt`; this package adds `name`. `ModifiedAt` is nullable for resources that have not been updated since creation.

