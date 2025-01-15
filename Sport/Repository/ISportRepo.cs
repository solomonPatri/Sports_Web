using Sports_Web.Data;
using Sports_Web.Sport.Dtos;
using Sports_Web.Sport.Model;



namespace Sports_Web.Sport.Repository
{
    public interface ISportRepo
    {
        Task<List<Sports>> GetAllAsync();

        Task<List<GetSportsDatesDto>> GetDateSports();

        Task<List<Sports>> GetGameTimeOverHour();

        //Task<CreateSportResponse> CreateSport(CreateSportRequest createSportRequest);

















    }
}
