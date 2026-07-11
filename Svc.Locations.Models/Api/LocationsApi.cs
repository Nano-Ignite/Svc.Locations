using Nano.App.ApiClient;

namespace Svc.Locations.Models.Api;

/// <inheritdoc />
public class LocationsApi : BaseApiClient
{
    /// <inheritdoc />
    public LocationsApi(ApiClient apiClient)
        : base(apiClient)
    {
    }
}