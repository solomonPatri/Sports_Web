using FluentMigrator.Runner.Initialization;
using Microsoft.AspNetCore.Server.IIS.Core;
using Sports_Web.Sport.Dtos;
using Sports_Web.Sport.Exceptions;
using Sports_Web.Sport.Model;
using Sports_Web.Sport.Repository;
using System.Data.Entity.Core.Mapping;
using System.Linq.Expressions;

namespace Sports_Web.Sport.Service
{
    public class SportQueryService:ISportQueryService
    {
        private ISportRepo _repo;

        public SportQueryService(ISportRepo repo)
        {

            this._repo = repo;
        }


        public async Task<List<Sports>> GetAllAsync()
        {

            return  await this._repo.GetAllAsync();

        }


        public async Task<SportResponse> FindByNameAsync(SportRequest request)
        {
            if(request != null)
            {
                SportResponse response = await this._repo.FindByNameAsync(request);

                return response;

            }

            throw new SportNotFoundException();



        }

        public async Task<SportResponse> FindByIdAsync(int id)
        {
            if (id != 0)
            {
                SportResponse response = await this._repo.FindByIdAsync(id);

                return response;

            }
            throw new SportNotFoundException();

        }















    }
}
