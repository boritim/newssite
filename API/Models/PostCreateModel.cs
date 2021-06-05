using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class PostCreateModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<Category> Categories { get; set; }
        public List<string> ImagineUrl { get; set; }
        public DateTime DateTime { get; set; }

        public PostCreateModel()
        {

        }
    }
}
