using System.ComponentModel.DataAnnotations;

namespace BookStore.Core.Entities
{
    public class Book
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
    }
}
