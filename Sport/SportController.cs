using Sports_Web.Sport.Model;
using Sports_Web.Sport.Repository;
using Microsoft.AspNetCore.Mvc;
using Sports_Web.Sport.Dtos;
using System.Security.Policy;
using Sports_Web.Sport.Service;
using Sports_Web.Sport.Exceptions;

namespace Sports_Web.Sport
{
    [ApiController]
    [Route("api/v1/[controller]")]

    public class SportController : ControllerBase
    {
        private ISportCommandService _commandService;
        private ISportQueryService _queryService;
        

        public SportController(ISportCommandService commandService,ISportQueryService queryService)
        {
            this._commandService = commandService;
            this._queryService = queryService;
            

        }


        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<Sports>>> GetAllAsync()
        {
              var sport = await this._queryService.GetAllAsync();
               return Ok(sport);
            
        }


        [HttpPost("create")]

        public async Task<ActionResult<SportResponse>> CreateSportAsync([FromBody] SportRequest sportRequest)
        {
            try
            {
                SportResponse response = await this._commandService.CreateSportAsync(sportRequest);

                return Created(" ", response);


            }
            catch ( SportAlreadyExistException e)
            {
                return BadRequest(e.Message);

            }

        }

        [HttpDelete("delete/{id}")]

        public async Task<ActionResult<SportResponse>> DeleteSportAsync([FromRoute]int id)
        {
            try
            {
                SportResponse response = await this._commandService.DeleteSportAsync(id);
                return Accepted(" ", response);



            }
            catch (SportNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut("edit/{id}")]

        public async Task<ActionResult<SportResponse>> EditSportAsync([FromBody] SportUpdateRequest create, [FromRoute] int id)
        {

            try
            {
                SportResponse response = await this._commandService.UpdateSportAsync(id, create);
                return Accepted("", response);

            }
            catch (SportNotUpdateException up)
            {
                return NotFound(up.Message);
            }
            catch (SportNotFoundException not)
            {
              return NotFound(not.Message);
            }




































            //[HttpGet("all")]

            //public async Task<ActionResult<IEnumerable<Sports>>> GetAllSports()
            //{
            //    var sport = await _sportRepo.GetAllAsync();

            //    return Ok(sport);

            //}


            //[HttpPost("create")]

            //public async Task<ActionResult<SportResponse>> CreateSport([FromBody]SportRequest createSportRequest)
            //{


            //    SportResponse create = await _sportRepo.CreateAsync(createSportRequest);



            //    return Created("", create);
            //}

            //[HttpDelete("delete/{id}")]
            //public async Task<ActionResult<SportResponse>> DeleteSport([FromRoute]int id)
            //{

            //    SportResponse response = await _sportRepo.DeleteAsync(id);



            //    return Accepted("", response);

            //}

            //[HttpPut("edit/{id}")]
            //public async Task<ActionResult<SportResponse>> EditSport([FromRoute] int id, [FromBody]SportUpdateRequest sport)
            //{

            //    SportResponse response = await _sportRepo.UpdateAsync(id,sport);



            //    return Accepted("", response);

            //}












        }
    }
}