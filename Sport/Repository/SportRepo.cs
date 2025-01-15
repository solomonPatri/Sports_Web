using Sports_Web.Sport.Model;
using Sports_Web.Data;
using Microsoft.EntityFrameworkCore;
using Sports_Web.Sport.Dtos;

namespace Sports_Web.Sport.Repository
{
    public class SportRepo : ISportRepo
    {

        private readonly AppDbContext _appDbContext;

        public SportRepo(AppDbContext context)
        {
            this._appDbContext = context;
        }


        public async Task<List<Sports>> GetAllAsync()
        {
            return await _appDbContext.Sports.ToListAsync();




        }

        public async Task<List<GetSportsDatesDto>> GetDateSports()
        {

            return await _appDbContext.Sports.Select(sport => new GetSportsDatesDto { Date=sport.Date, Name=sport.Name }).ToListAsync();


        }
        public async Task<List<Sports>> GetGameTimeOverHour()
        {
            return await _appDbContext.Sports.Where(u => u.GameTime >= 1.0)
                .ToListAsync();


        }









    }


}
