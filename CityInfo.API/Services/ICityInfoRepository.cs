using CityInfo.API.Entities;

namespace CityInfo.API.Services
{
    public interface ICityInfoRepository
    {
        // IQueryable - concatenate many queries
        // IEnumerable - get final data without execute additional queries
        Task<IEnumerable<City>> GetCitiesAsync();
        Task<City?> GetCityAsync(int cityId, bool includePointsOfInterest);
        Task<IEnumerable<PointOfInterest>> GetPointsOfInterestsAsync(int cityId);
        Task<PointOfInterest?> GetPointOfInterestsAsync(int cityId, int pointOfInterestId);
        Task<bool> CityExistAsync(int cityId);
        Task AddPointOfInterestForCityAsync(int cityId, PointOfInterest pointOfInterest);
        Task RemovePointOfInterestForCityAsync(int cityId, PointOfInterest pointOfInterest);
        Task<bool> SaveChangesAsync();
        Task<(IEnumerable<City>, PaginationMetadata?)> GetCitiesAsync(string? name, string? searchQuery, int pageNumber, int pageSize);
        Task<bool> CityNameMatchesCityId(string? cityName, int cityId);

    }
}
