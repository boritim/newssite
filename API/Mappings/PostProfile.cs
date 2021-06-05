using API.Models;
using Application.Dto;
using AutoMapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Mappings
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            #region ApplicationLayoutMap
            CreateMap<PostCreateModel, PostCreateDto>();
            #endregion

            #region DomainLayoutMap
            CreateMap<PostCreateDto, Post> ();
            #endregion
        }
    }
}
