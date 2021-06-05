using Domain.Root;
using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public virtual List<Post> Entities { get; set; }

        public Category()
        { 
        }
        public Category (string name)
        {
            Name = name;
        }
    }
}