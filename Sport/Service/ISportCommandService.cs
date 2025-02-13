using Sports_Web.Sport.Dtos;
using Sports_Web.Sport.Model;

namespace Sports_Web.Sport.Service
{
    public interface ISportCommandService
    {

        Task<SportResponse> CreateSportAsync(SportRequest sportrequest);

        Task<SportResponse> DeleteSportAsync(int id);

        Task<SportResponse> UpdateSportAsync(int id,SportUpdateRequest sportUpdateRequest);







    }
}
