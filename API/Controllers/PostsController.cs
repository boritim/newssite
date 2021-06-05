using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Infrastructure.Context;
using Application.Interface;
using AutoMapper;
using API.Models;
using Application.Dto;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;
        private readonly IMapper _mapper;
        public PostsController(IPostService service, IMapper mapper)
        {
            _postService = service;
            _mapper = mapper;
        }
        // POST: api/Posts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Post>> PostPost(PostCreateModel post)
        {
            return await _postService.CreatePostAsync(_mapper.Map<PostCreateDto>(post));
        }

    }
}
