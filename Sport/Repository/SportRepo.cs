using Sports_Web.Sport.Model;
using Sports_Web.Data;
using Microsoft.EntityFrameworkCore;
using Sports_Web.Sport.Dtos;
using AutoMapper;

namespace Sports_Web.Sport.Repository
{
    public class SportRepo : ISportRepo
    {

        private readonly AppDbContext _appDbContext;

        private readonly IMapper _mapper;

        public SportRepo(AppDbContext context,IMapper mapper)
        {
            this._appDbContext = context;
            this._mapper = mapper;
        }

        public async Task<SportResponse> CreateAsync(SportRequest createSportRequest)
        {


            Sports sports = _mapper.Map<Sports>(createSportRequest);



            _appDbContext.Sports.Add(sports);

            await _appDbContext.SaveChangesAsync();


            SportResponse response = _mapper.Map<SportResponse>(sports);


            return response;
        }

        public async Task<SportResponse> DeleteAsync(int id)
        {

            Sports sport = await _appDbContext.Sports.FindAsync(id);


            SportResponse response = _mapper.Map<SportResponse>(sport);

            _appDbContext.Remove(sport);

            await _appDbContext.SaveChangesAsync();

            return response;
        }

        public async Task<List<Sports>> GetAllAsync()
        {


            return await _appDbContext.Sports.ToListAsync();

        }

        public async Task<SportResponse> UpdateAsync(int id, SportUpdateRequest sport)
        {
            Sports sports = await _appDbContext.Sports.FindAsync(id);

            if (sport.Name != null)
            {
                sports.Name = sport.Name;
            }

            if (sport.GameTime.HasValue)
            {
                sports.GameTime = sport.GameTime.Value;
            }

            if (sport.Date.HasValue)
            {
                sports.Date = sport.Date.Value;
            }

            if (sport.NrPlayers.HasValue)
            {
                sports.NrPlayers = sport.NrPlayers.Value;
            }


            _appDbContext.Sports.Update(sports);


            await _appDbContext.SaveChangesAsync();


            SportResponse update = _mapper.Map<SportResponse>(sports);
           

            return update;




        }
    }


}
