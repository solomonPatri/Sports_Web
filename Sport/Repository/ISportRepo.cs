using Sports_Web.Data;
using  Sports_Web.Sport.Model;



namespace Sports_Web.Sport.Repository
{
    public interface ISportRepo
    {
        Task<List<Sports>> GetAllAsync();

        Task<List<DateOnly>> GetDateSports();

        Task<List<Sports>> GetGameTimeOverHour();











    }
}
