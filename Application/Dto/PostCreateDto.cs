using Domain.Models;
using Domain.Root;
using System;
using System.Collections.Generic;

namespace Application.Dto
{
    public class PostCreateDto
    {
        public string Guid { get; }
        public string Title { get; }
        public string Content { get; }
        public List<Category> Categories { get; }
        public List<string> ImagineUrl { get; }
        public DateTime DateTime { get; }
    }
}
