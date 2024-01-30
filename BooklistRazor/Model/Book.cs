using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BooklistRazor.Model
{
    public class Book
    {
        [Key] 
        public int Id { get; set; }


        [Required]
        public string Name { get; set; }

        public string? Author { get; set; }

        public string? ISBN { get; set; }
    }
}
