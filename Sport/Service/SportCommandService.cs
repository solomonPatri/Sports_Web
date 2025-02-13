using Sports_Web.Sport.Dtos;
using Sports_Web.Sport.Model;
using Sports_Web.Sport.Repository;
using Sports_Web.Sport.Exceptions;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Sports_Web.Sport.Service
{
    public class SportCommandService : ISportCommandService
    {
        private ISportRepo _repo;

        public SportCommandService(ISportRepo repo)
        {
            this._repo = repo;


        }

        public async Task<SportResponse> CreateSportAsync(SportRequest sportrequest)
        {
            SportResponse sportexist = await this._repo.FindByNameAsync(sportrequest);

            if (sportexist == null)
            {


                SportResponse sport = await this._repo.CreateAsync(sportrequest);



                return sport;

            }
            throw new SportAlreadyExistException();
            



        }

        public async Task<SportResponse> DeleteSportAsync(int id)
        {
            SportResponse sporttodelete = await this._repo.FindByIdAsync(id);
            if (sporttodelete != null)
            {
                    SportResponse sport = await this._repo.DeleteAsync(id);
                   return sport;
              

            }

            throw new SportNotFoundException();






        }

        public async Task<SportResponse> UpdateSportAsync(int id ,SportUpdateRequest sportUpdateRequest)
        {

            SportResponse sportgasit = await this._repo.FindByIdAsync(id);


            if (sportgasit != null)
            {
                if(sportgasit is SportUpdateRequest)
                {
                    sportgasit.Name = sportUpdateRequest.Name ?? sportgasit.Name;

                    sportgasit.NrPlayers = sportUpdateRequest.NrPlayers ?? sportgasit.NrPlayers;

                    sportgasit.Date = sportUpdateRequest.Date ?? sportgasit.Date;

                    sportgasit.GameTime = sportUpdateRequest.GameTime ?? sportgasit.GameTime;

                    SportResponse response = await this._repo.UpdateAsync(id, sportUpdateRequest);

                    return response;

                }throw new SportNotUpdateException();
            }
            throw new SportNotFoundException();







        }
    }
}
