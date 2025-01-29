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

        public async Task<CreateSportResponse> CreateSport(CreateSportRequest createSportRequest)
        {


            Sports sports = _mapper.Map<Sports>(createSportRequest);



            _appDbContext.Sports.Add(sports);

            await _appDbContext.SaveChangesAsync();


            CreateSportResponse response = _mapper.Map<CreateSportResponse>(sports);


            return response;
        }

        public async Task<List<Sports>> GetAllAsync()
        {


            return await _appDbContext.Sports.ToListAsync();

        }

    
       







    }


}
