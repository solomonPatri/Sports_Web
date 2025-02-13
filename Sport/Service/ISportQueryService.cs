using Sports_Web.Sport.Model;
using Sports_Web.Sport.Dtos;
namespace Sports_Web.Sport.Service
{
    public interface ISportQueryService
    {
       
        Task<List<Sports>> GetAllAsync();


        Task<SportResponse> FindByNameAsync(SportRequest Name);

        Task<SportResponse> FindByIdAsync(int id);






    }
}
