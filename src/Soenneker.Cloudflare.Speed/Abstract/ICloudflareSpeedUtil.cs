using System.Threading;
using System.Threading.Tasks;
using Soenneker.Cloudflare.OpenApiClient.Models;

namespace Soenneker.Cloudflare.Speed.Abstract;

/// <summary>
/// Interface for managing Cloudflare speed-related settings
/// </summary>
public interface ICloudflareSpeedUtil
{
    /// <summary>
    /// Gets the current Speed Brain settings for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>The current Speed Brain settings</returns>
    ValueTask<ZoneSettingsGetSpeedBrainSetting200Response?> GetSpeedBrainSettings(string zoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates the Speed Brain settings for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <param name="enabled">Whether to enable or disable Speed Brain</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>The updated Speed Brain settings</returns>
    ValueTask<ZoneSettingsChangeSpeedBrainSetting200Response?> UpdateSpeedBrainSettings(string zoneId, bool enabled, CancellationToken cancellationToken = default);

    /// <summary>
    /// Enables Speed Brain for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>The updated Speed Brain settings</returns>
    ValueTask<ZoneSettingsChangeSpeedBrainSetting200Response?> EnableSpeedBrain(string zoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disables Speed Brain for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>The updated Speed Brain settings</returns>
    ValueTask<ZoneSettingsChangeSpeedBrainSetting200Response?> DisableSpeedBrain(string zoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the current font optimization settings for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>The current font optimization settings</returns>
    ValueTask<ZoneSettingsGetFontsSetting200Response?> GetFontSettings(string zoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates the font optimization settings for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <param name="enabled">Whether to enable or disable font optimization</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>The updated font optimization settings</returns>
    ValueTask<ZoneSettingsChangeFontsSetting200Response?> UpdateFontSettings(string zoneId, bool enabled, CancellationToken cancellationToken = default);

    /// <summary>
    /// Enables font optimization for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>The updated font optimization settings</returns>
    ValueTask<ZoneSettingsChangeFontsSetting200Response?> EnableFontOptimization(string zoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disables font optimization for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>The updated font optimization settings</returns>
    ValueTask<ZoneSettingsChangeFontsSetting200Response?> DisableFontOptimization(string zoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the current Early Hints settings for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>The current Early Hints settings</returns>
    ValueTask<ZoneSettingsGetSingleSetting200Response?> GetEarlyHintsSettings(string zoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates the Early Hints settings for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <param name="enabled">Whether to enable or disable Early Hints</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>The updated Early Hints settings</returns>
    ValueTask<ZoneSettingsEditSingleSetting200Response?> UpdateEarlyHintsSettings(string zoneId, bool enabled, CancellationToken cancellationToken = default);

    /// <summary>
    /// Enables Early Hints for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>The updated Early Hints settings</returns>
    ValueTask<ZoneSettingsEditSingleSetting200Response?> EnableEarlyHints(string zoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disables Early Hints for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>The updated Early Hints settings</returns>
    ValueTask<ZoneSettingsEditSingleSetting200Response?> DisableEarlyHints(string zoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the current 0-RTT Connection Resumption settings for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>The current 0-RTT Connection Resumption settings</returns>
    ValueTask<ZoneSettingsGetSingleSetting200Response?> Get0RttSettings(string zoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates the 0-RTT Connection Resumption settings for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <param name="enabled">Whether to enable or disable 0-RTT Connection Resumption</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>The updated 0-RTT Connection Resumption settings</returns>
    ValueTask<ZoneSettingsEditSingleSetting200Response?> Update0RttSettings(string zoneId, bool enabled, CancellationToken cancellationToken = default);

    /// <summary>
    /// Enables 0-RTT Connection Resumption for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>The updated 0-RTT Connection Resumption settings</returns>
    ValueTask<ZoneSettingsEditSingleSetting200Response?> Enable0Rtt(string zoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disables 0-RTT Connection Resumption for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>The updated 0-RTT Connection Resumption settings</returns>
    ValueTask<ZoneSettingsEditSingleSetting200Response?> Disable0Rtt(string zoneId, CancellationToken cancellationToken = default);
}
