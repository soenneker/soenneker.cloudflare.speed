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
    /// <returns>The current Speed Brain settings</returns>
    ValueTask<Zone_settings_get_speed_brain_setting_200> GetSpeedBrainSettings(string zoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates the Speed Brain settings for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <param name="enabled">Whether to enable or disable Speed Brain</param>
    /// <returns>The updated Speed Brain settings</returns>
    ValueTask<Zone_settings_change_speed_brain_setting_200> UpdateSpeedBrainSettings(string zoneId, bool enabled, CancellationToken cancellationToken = default);

    /// <summary>
    /// Enables Speed Brain for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <returns>The updated Speed Brain settings</returns>
    ValueTask<Zone_settings_change_speed_brain_setting_200> EnableSpeedBrain(string zoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disables Speed Brain for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <returns>The updated Speed Brain settings</returns>
    ValueTask<Zone_settings_change_speed_brain_setting_200> DisableSpeedBrain(string zoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the current font optimization settings for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <returns>The current font optimization settings</returns>
    ValueTask<Zone_settings_get_fonts_setting_200> GetFontSettings(string zoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates the font optimization settings for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <param name="enabled">Whether to enable or disable font optimization</param>
    /// <returns>The updated font optimization settings</returns>
    ValueTask<Zone_settings_change_fonts_setting_200> UpdateFontSettings(string zoneId, bool enabled, CancellationToken cancellationToken = default);

    /// <summary>
    /// Enables font optimization for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <returns>The updated font optimization settings</returns>
    ValueTask<Zone_settings_change_fonts_setting_200> EnableFontOptimization(string zoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disables font optimization for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <returns>The updated font optimization settings</returns>
    ValueTask<Zone_settings_change_fonts_setting_200> DisableFontOptimization(string zoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the current Early Hints settings for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <returns>The current Early Hints settings</returns>
    ValueTask<Zone_settings_get_single_setting_200> GetEarlyHintsSettings(string zoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates the Early Hints settings for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <param name="enabled">Whether to enable or disable Early Hints</param>
    /// <returns>The updated Early Hints settings</returns>
    ValueTask<Zone_settings_edit_single_setting_200> UpdateEarlyHintsSettings(string zoneId, bool enabled, CancellationToken cancellationToken = default);

    /// <summary>
    /// Enables Early Hints for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <returns>The updated Early Hints settings</returns>
    ValueTask<Zone_settings_edit_single_setting_200> EnableEarlyHints(string zoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disables Early Hints for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <returns>The updated Early Hints settings</returns>
    ValueTask<Zone_settings_edit_single_setting_200?> DisableEarlyHints(string zoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the current 0-RTT Connection Resumption settings for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <returns>The current 0-RTT Connection Resumption settings</returns>
    ValueTask<Zone_settings_get_single_setting_200?> Get0RttSettings(string zoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates the 0-RTT Connection Resumption settings for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <param name="enabled">Whether to enable or disable 0-RTT Connection Resumption</param>
    /// <returns>The updated 0-RTT Connection Resumption settings</returns>
    ValueTask<Zone_settings_edit_single_setting_200?> Update0RttSettings(string zoneId, bool enabled, CancellationToken cancellationToken = default);

    /// <summary>
    /// Enables 0-RTT Connection Resumption for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <returns>The updated 0-RTT Connection Resumption settings</returns>
    ValueTask<Zone_settings_edit_single_setting_200?> Enable0Rtt(string zoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disables 0-RTT Connection Resumption for a zone
    /// </summary>
    /// <param name="zoneId">The ID of the zone</param>
    /// <returns>The updated 0-RTT Connection Resumption settings</returns>
    ValueTask<Zone_settings_edit_single_setting_200?> Disable0Rtt(string zoneId, CancellationToken cancellationToken = default);
}
