using Sports_Web.Sport.Model;
using Sports_Web.Sport.Repository;
using Microsoft.AspNetCore.Mvc;
using Sports_Web.Sport.Dtos;

namespace Sports_Web.Sport
{
    [ApiController]
    [Route("api/v1/[controller]")]

    public class SportController : ControllerBase
    {
        private ISportRepo _sportRepo;

        public SportController(ISportRepo sportRepo)
        {

            this._sportRepo = sportRepo;

        }


        [HttpGet("all")]

        public async Task<ActionResult<IEnumerable<Sports>>> GetAllSports()
        {
            var sport = await _sportRepo.GetAllAsync();

            return Ok(sport);

        }

        [HttpGet("DatesSports")]

        public async Task<ActionResult<IEnumerable<GetSportsDatesDto>>> GetDatesSports()
        {

            List<GetSportsDatesDto> sport = await _sportRepo.GetDateSports();

            return Ok(sport);


        }

        [HttpGet("GameTime")]

        public async Task<ActionResult<IEnumerable<Sports>>> GetGameTimeSports()
        {

            var sport = await _sportRepo.GetGameTimeOverHour();

            return Ok(sport);



        }










    }
}