using Domain.Root;
using System;

namespace Domain.Models
{
    public class Comment : Entity
    {
        public string Author { get; set; }
        public string Content { get; set; }
        public Guid PostId { get; set; }
        public DateTime DateTime { get; set; }

        internal Comment(string author, string content, Guid postId, DateTime dateTime)
        {
            Author = author;
            Content = content;
            PostId = postId;
            DateTime = dateTime;
        }
    }
}