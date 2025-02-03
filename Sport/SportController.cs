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

        public async Task<ActionResult<SportResponse>> CreateSport([FromBody]SportRequest createSportRequest)
        {


            SportResponse create = await _sportRepo.CreateAsync(createSportRequest);



            return Created("", create);
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult<SportResponse>> DeleteSport([FromRoute]int id)
        {

            SportResponse response = await _sportRepo.DeleteAsync(id);



            return Accepted("", response);

        }

        [HttpPut("edit/{id}")]
        public async Task<ActionResult<SportResponse>> EditSport([FromRoute] int id, [FromBody]SportUpdateRequest sport)
        {

            SportResponse response = await _sportRepo.UpdateAsync(id,sport);



            return Accepted("", response);

        }







    }
}