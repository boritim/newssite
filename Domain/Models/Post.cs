using Domain.Root;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Post : Entity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        private HashSet<Category> _categories;
        private HashSet<string> _imagineUrl;
        private HashSet<Comment> _comments;

        public IEnumerable<Category> Categories => _categories?.ToList();
        public IEnumerable<string> ImagineUrl => _imagineUrl?.ToList();
        public IEnumerable<Comment> Comments => _comments?.ToList();
        public Post()
        {

        }

        public Post(string title, string content, DateTime date, ICollection<Category> categories, ICollection<string> imagineUrl)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException(nameof(title));

            Title = title;
            Content = content;
            Date = date;

            _comments = new HashSet<Comment>();

            if (categories == null || !categories.Any())
                throw new ArgumentException("You must have at least one Category for a post", nameof(categories));
            _categories = new HashSet<Category>(categories.Select(a => new Category(a.Name)));

            if (imagineUrl == null || !categories.Any())
                throw new ArgumentException("You must have at least one Photo for a post", nameof(imagineUrl));
            _imagineUrl = new HashSet<string>(imagineUrl.Select(a => new string(a)));
        }

        public void UpdateName(string title)
        {
            Title = title;
        }

        public void AddComment(string author, string content, DateTime dateTime, DbContext context = null)
        {
            if (_comments != null)
            {
                _comments.Add(new Comment(author, content, Id, dateTime));
            }
            else if (context == null)
            {
                throw new ArgumentNullException(nameof(context),
                    "You must provide a context if the Comments collection isn't valid.");
            }
            else if (context.Entry(this).IsKeySet)
            {
                context.Add(new Comment(author, content, Id, dateTime));
            }
        }
    }
}
