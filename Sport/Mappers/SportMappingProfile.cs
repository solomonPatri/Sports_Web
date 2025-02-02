﻿using AutoMapper;
using Sports_Web.Sport.Dtos;
using Sports_Web.Sport.Model;

namespace Sports_Web.Sport.Mappers
{
    public class SportMappingProfile:Profile
    {


        public SportMappingProfile()
        {

            CreateMap<SportRequest, Sports>();
            CreateMap<Sports, SportResponse>();
            CreateMap<SportResponse, SportUpdateRequest>();


        }
    }
}
