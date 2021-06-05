using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{
    class DetailPostDto
    {
        public string Title { get; }
        public string Content { get; }
        public List<Category> Categories { get; }
        public List<string> ImagineUrl { get; }
        public List<Comment> Comments { get; } 
        public DateTime DateTime { get; }
    }
}
