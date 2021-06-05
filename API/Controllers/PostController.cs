using API.Models;
using Application.Dto;
using Application.Interface;
using AutoMapper;
using Domain.Models;
using Infrastructure.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        private readonly IMapper _mapper;
        public PostController(IPostService service, IMapper mapper)
        {
            _postService = service;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult<Post>> PostPost(PostCreateModel post)
        {
            return await _postService.CreatePostAsync(_mapper.Map<PostCreateDto>(post));
        }
    }
}
