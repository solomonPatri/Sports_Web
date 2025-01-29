using Sports_Web.Sport.Model;
using Sports_Web.Sport.Repository;
using Microsoft.AspNetCore.Mvc;
using Sports_Web.Sport.Dtos;
using System.Security.Policy;

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


        [HttpPost("create")]

        public async Task<ActionResult<CreateSportResponse>> CreateSport([FromBody]CreateSportRequest createSportRequest)
        {


            CreateSportResponse create =  await _sportRepo.CreateSport(createSportRequest);



            return Created("", create);
        }

       








    }
}