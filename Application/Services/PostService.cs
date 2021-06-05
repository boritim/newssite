using Application.Dto;
using Application.Interface;
using AutoMapper;
using Domain.Models;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PostService : IPostService
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _context;

        public PostService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Post> CreatePostAsync(PostCreateDto postCreateDto)
        {
            var post = _mapper.Map<Post>(postCreateDto);
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();

            return post;
        }

        public async Task<EntityState> DeleteAsync(Guid id)
        {
            var Project = await _context.Posts
                .FirstOrDefaultAsync(m => m.Id == id);
            var result = _context.Posts.Remove(Project).State = EntityState.Deleted;
            await _context.SaveChangesAsync();

            return result;
        }

        public async Task<Post> FindPostAsync(Guid id)
        {
            return await _context.Posts.FindAsync(id);
        }

        public async Task<Post> DetailsAsync(Guid id)
        {
            return await _context.Posts.FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
