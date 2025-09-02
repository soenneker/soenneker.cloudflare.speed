using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Soenneker.Cloudflare.OpenApiClient;
using Soenneker.Cloudflare.OpenApiClient.Models;
using Soenneker.Cloudflare.Speed.Abstract;
using Soenneker.Cloudflare.Utils.Client.Abstract;
using Soenneker.Extensions.ValueTask;
using Soenneker.Extensions.Task;

namespace Soenneker.Cloudflare.Speed;

///<inheritdoc cref="ICloudflareSpeedUtil"/>
public sealed class CloudflareSpeedUtil : ICloudflareSpeedUtil
{
    private readonly ICloudflareClientUtil _client;
    private readonly ILogger<CloudflareSpeedUtil> _logger;

    public CloudflareSpeedUtil(ICloudflareClientUtil client, ILogger<CloudflareSpeedUtil> logger)
    {
        _client = client;
        _logger = logger;
    }

    public async ValueTask<Zone_settings_get_speed_brain_setting_200> GetSpeedBrainSettings(string zoneId,
        CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Getting Speed Brain settings for zone {ZoneId}", zoneId);
        CloudflareOpenApiClient client = await _client.Get(cancellationToken).NoSync();
        try
        {
            return await client.Zones[zoneId].Settings.Speed_brain.GetAsync(cancellationToken: cancellationToken).NoSync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting Speed Brain settings for zone {ZoneId}", zoneId);
            throw;
        }
    }

    public async ValueTask<Zone_settings_change_speed_brain_setting_200> UpdateSpeedBrainSettings(string zoneId, bool enabled,
        CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Updating Speed Brain settings for zone {ZoneId} to {Enabled}", zoneId, enabled);
        CloudflareOpenApiClient client = await _client.Get(cancellationToken).NoSync();
        try
        {
            var requestBody = new Zone_settings_change_speed_brain_setting
            {
                Value = enabled ? Zone_settings_change_speed_brain_setting_value.On : Zone_settings_change_speed_brain_setting_value.Off
            };
            return await client.Zones[zoneId].Settings.Speed_brain.PatchAsync(requestBody, cancellationToken: cancellationToken).NoSync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error updating Speed Brain settings for zone {ZoneId}", zoneId);
            throw;
        }
    }

    public async ValueTask<Zone_settings_change_speed_brain_setting_200> EnableSpeedBrain(string zoneId,
        CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Enabling Speed Brain for zone {ZoneId}", zoneId);
        CloudflareOpenApiClient client = await _client.Get(cancellationToken).NoSync();
        try
        {
            var requestBody = new Zone_settings_change_speed_brain_setting
            {
                Value = Zone_settings_change_speed_brain_setting_value.On
            };
            return await client.Zones[zoneId].Settings.Speed_brain.PatchAsync(requestBody, cancellationToken: cancellationToken).NoSync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error enabling Speed Brain for zone {ZoneId}", zoneId);
            throw;
        }
    }

    public async ValueTask<Zone_settings_change_speed_brain_setting_200> DisableSpeedBrain(string zoneId,
        CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Disabling Speed Brain for zone {ZoneId}", zoneId);
        CloudflareOpenApiClient client = await _client.Get(cancellationToken).NoSync();
        try
        {
            var requestBody = new Zone_settings_change_speed_brain_setting
            {
                Value = Zone_settings_change_speed_brain_setting_value.Off
            };
            return await client.Zones[zoneId].Settings.Speed_brain.PatchAsync(requestBody, cancellationToken: cancellationToken).NoSync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error disabling Speed Brain for zone {ZoneId}", zoneId);
            throw;
        }
    }

    public async ValueTask<Zone_settings_get_fonts_setting_200> GetFontSettings(string zoneId,
        CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Getting font settings for zone {ZoneId}", zoneId);
        CloudflareOpenApiClient client = await _client.Get(cancellationToken).NoSync();
        try
        {
            return await client.Zones[zoneId].Settings.Fonts.GetAsync(cancellationToken: cancellationToken).NoSync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting font settings for zone {ZoneId}", zoneId);
            throw;
        }
    }

    public async ValueTask<Zone_settings_change_fonts_setting_200> UpdateFontSettings(string zoneId, bool enabled,
        CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Updating font settings for zone {ZoneId} to {Enabled}", zoneId, enabled);
        CloudflareOpenApiClient client = await _client.Get(cancellationToken).NoSync();
        try
        {
            var requestBody = new Zone_settings_change_fonts_setting
            {
                Value = enabled ? Zone_settings_change_fonts_setting_value.On : Zone_settings_change_fonts_setting_value.Off
            };

            return await client.Zones[zoneId].Settings.Fonts.PatchAsync(requestBody, cancellationToken: cancellationToken).NoSync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error updating font settings for zone {ZoneId}", zoneId);
            throw;
        }
    }

    public async ValueTask<Zone_settings_change_fonts_setting_200> EnableFontOptimization(string zoneId,
        CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Enabling font optimization for zone {ZoneId}", zoneId);
        CloudflareOpenApiClient client = await _client.Get(cancellationToken).NoSync();
        try
        {
            var requestBody = new Zone_settings_change_fonts_setting
            {
                Value = Zone_settings_change_fonts_setting_value.On
            };

            return await client.Zones[zoneId].Settings.Fonts.PatchAsync(requestBody, cancellationToken: cancellationToken).NoSync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error enabling font optimization for zone {ZoneId}", zoneId);
            throw;
        }
    }

    public async ValueTask<Zone_settings_change_fonts_setting_200> DisableFontOptimization(string zoneId,
        CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Disabling font optimization for zone {ZoneId}", zoneId);
        CloudflareOpenApiClient client = await _client.Get(cancellationToken).NoSync();
        try
        {
            var requestBody = new Zone_settings_change_fonts_setting
            {
                Value = Zone_settings_change_fonts_setting_value.Off
            };
            return await client.Zones[zoneId].Settings.Fonts.PatchAsync(requestBody, cancellationToken: cancellationToken).NoSync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error disabling font optimization for zone {ZoneId}", zoneId);
            throw;
        }
    }

    public async ValueTask<Zone_settings_get_single_setting_200?> GetEarlyHintsSettings(string zoneId,
        CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Getting Early Hints settings for zone {ZoneId}", zoneId);
        CloudflareOpenApiClient client = await _client.Get(cancellationToken).NoSync();

        try
        {
            return await client.Zones[zoneId].Settings["early_hints"].GetAsync(cancellationToken: cancellationToken).NoSync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting Early Hints settings for zone {ZoneId}", zoneId);
            throw;
        }
    }

    public async ValueTask<Zone_settings_edit_single_setting_200?> UpdateEarlyHintsSettings(string zoneId, bool enabled,
        CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Updating Early Hints settings for zone {ZoneId} to {Enabled}", zoneId, enabled);
        CloudflareOpenApiClient client = await _client.Get(cancellationToken).NoSync();
        try
        {
            var requestBody = new Zones_zone_settings_single_request
            {
                ZonesZoneSettingsSingleRequestMember1 = new Zones_zone_settings_single_requestMember1 { Enabled = enabled }
            };
            return await client.Zones[zoneId].Settings["early_hints"].PatchAsync(requestBody, cancellationToken: cancellationToken).NoSync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error updating Early Hints settings for zone {ZoneId}", zoneId);
            throw;
        }
    }

    public async ValueTask<Zone_settings_edit_single_setting_200?> EnableEarlyHints(string zoneId,
        CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Enabling Early Hints for zone {ZoneId}", zoneId);
        CloudflareOpenApiClient client = await _client.Get(cancellationToken).NoSync();
        try
        {
            var requestBody = new Zones_zone_settings_single_request
            {
                ZonesZoneSettingsSingleRequestMember1 = new Zones_zone_settings_single_requestMember1 { Enabled = true }
            };
            return await client.Zones[zoneId].Settings["early_hints"].PatchAsync(requestBody, cancellationToken: cancellationToken).NoSync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error enabling Early Hints for zone {ZoneId}", zoneId);
            throw;
        }
    }

    public async ValueTask<Zone_settings_edit_single_setting_200?> DisableEarlyHints(string zoneId,
        CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Disabling Early Hints for zone {ZoneId}", zoneId);
        CloudflareOpenApiClient client = await _client.Get(cancellationToken).NoSync();
        try
        {
            var requestBody = new Zones_zone_settings_single_request
            {
                ZonesZoneSettingsSingleRequestMember1 = new Zones_zone_settings_single_requestMember1 { Enabled = false }
            };

            return await client.Zones[zoneId].Settings["early_hints"].PatchAsync(requestBody, cancellationToken: cancellationToken).NoSync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error disabling Early Hints for zone {ZoneId}", zoneId);
            throw;
        }
    }

    public async ValueTask<Zone_settings_get_single_setting_200> Get0RttSettings(string zoneId,
        CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Getting 0-RTT settings for zone {ZoneId}", zoneId);
        CloudflareOpenApiClient client = await _client.Get(cancellationToken).NoSync();
        try
        {
            return await client.Zones[zoneId].Settings["0rtt"].GetAsync(cancellationToken: cancellationToken).NoSync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting 0-RTT settings for zone {ZoneId}", zoneId);
            throw;
        }
    }

    public async ValueTask<Zone_settings_edit_single_setting_200> Update0RttSettings(string zoneId, bool enabled,
        CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Updating 0-RTT settings for zone {ZoneId} to {Enabled}", zoneId, enabled);
        CloudflareOpenApiClient client = await _client.Get(cancellationToken).NoSync();
        try
        {
            var requestBody = new Zones_zone_settings_single_request
            {
                ZonesZoneSettingsSingleRequestMember1 = new Zones_zone_settings_single_requestMember1 { Enabled = enabled }
            };
            return await client.Zones[zoneId].Settings["0rtt"].PatchAsync(requestBody, cancellationToken: cancellationToken).NoSync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error updating 0-RTT settings for zone {ZoneId}", zoneId);
            throw;
        }
    }

    public async ValueTask<Zone_settings_edit_single_setting_200> Enable0Rtt(string zoneId,
        CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Enabling 0-RTT for zone {ZoneId}", zoneId);
        CloudflareOpenApiClient client = await _client.Get(cancellationToken).NoSync();
        try
        {
            var requestBody = new Zones_zone_settings_single_request
            {
                ZonesZoneSettingsSingleRequestMember1 = new Zones_zone_settings_single_requestMember1 { Enabled = true }
            };
            return await client.Zones[zoneId].Settings["0rtt"].PatchAsync(requestBody, cancellationToken: cancellationToken).NoSync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error enabling 0-RTT for zone {ZoneId}", zoneId);
            throw;
        }
    }

    public async ValueTask<Zone_settings_edit_single_setting_200?> Disable0Rtt(string zoneId,
        CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Disabling 0-RTT for zone {ZoneId}", zoneId);
        CloudflareOpenApiClient client = await _client.Get(cancellationToken).NoSync();
        try
        {
            var requestBody = new Zones_zone_settings_single_request
            {
                ZonesZoneSettingsSingleRequestMember1 = new Zones_zone_settings_single_requestMember1() { Enabled = false}
            };

            return await client.Zones[zoneId].Settings["0rtt"].PatchAsync(requestBody, cancellationToken: cancellationToken).NoSync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error disabling 0-RTT for zone {ZoneId}", zoneId);
            throw;
        }
    }
}