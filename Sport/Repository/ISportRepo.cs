using Sports_Web.Data;
using Sports_Web.Sport.Dtos;
using Sports_Web.Sport.Model;



namespace Sports_Web.Sport.Repository
{
    public interface ISportRepo
    {
        Task<List<Sports>> GetAllAsync();

     

        Task<SportResponse> CreateAsync(SportRequest createSportRequest);
        Task<SportResponse> DeleteAsync(int id);
        Task<SportResponse> UpdateAsync(int id,SportUpdateRequest sport);





















    }
}
