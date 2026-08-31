[![](https://img.shields.io/nuget/v/soenneker.cloudflare.speed.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.cloudflare.speed/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.cloudflare.speed/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.cloudflare.speed/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.cloudflare.speed.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.cloudflare.speed/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.cloudflare.speed/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.cloudflare.speed/actions/workflows/codeql.yml)

# Soenneker.Cloudflare.Speed

Reads and changes selected Cloudflare performance settings for a zone.

## Installation

```bash
dotnet add package Soenneker.Cloudflare.Speed
```

## Configuration

```json
{
  "Cloudflare": {
    "ApiKey": "your-api-token"
  }
}
```

The token needs permission to read and edit zone settings for the target zone.

## Registration

```csharp
using Soenneker.Cloudflare.Speed.Registrars;

services.AddCloudflareSpeedUtilAsScoped();
```

Singleton registration is available with `AddCloudflareSpeedUtilAsSingleton()`.

## Usage

```csharp
using Soenneker.Cloudflare.Speed.Abstract;

await speed.EnableSpeedBrain(zoneId, cancellationToken);
await speed.EnableFontOptimization(zoneId, cancellationToken);
await speed.UpdateEarlyHintsSettings(zoneId, enabled: true, cancellationToken);
```

The utility wraps Speed Brain, Cloudflare Fonts, Early Hints, and 0-RTT. Every setting has a read method and `Update...`, `Enable...`, and `Disable...` mutation methods.

These settings have different operational consequences:

- Speed Brain can speculatively prefetch content.
- Cloudflare Fonts rewrites supported font delivery through Cloudflare.
- Early Hints can expose preload hints before the final response.
- 0-RTT permits replayable early data. Enable it only when request handling is safe against replay; do not assume non-idempotent requests are protected merely because TLS is in use.

Changes apply to the entire zone. Generated Cloudflare API exceptions are propagated, and settings response envelopes may be null when the API returns no body.
