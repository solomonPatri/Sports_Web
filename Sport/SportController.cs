using Sports_Web.Sport.Model;
using Sports_Web.Sport.Repository;
using Microsoft.AspNetCore.Mvc;


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

        public async Task<ActionResult<IEnumerable<Sports>>> GetAllAsync()
        {
            var sport = await _sportRepo.GetAllAsync();

            return Ok(sport);

        }


        [HttpGet("DateSports")]

        public async Task<ActionResult<IEnumerable<Sports>>> GetDateSports()
        {
            var sport = await _sportRepo.GetDateSports();

            return Ok(sport);




        }
        

        public async Task<ActionResult<IEnumerable<Sports>>> GetGameTimeOverHour()
        {
            var sport = await _sportRepo.GetGameTimeOverHour();

            return Ok(sport);



        }






    }
}