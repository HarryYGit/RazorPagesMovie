using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string? Title { get; set; } // '?' question mark following a string indicates that the property is nullable

        [DataType(DataType.Date)] // this attribute specifies the type of data in the ReleaseDate property. The user isn't required to enter time info in the date field; the time infor is not displayed, only date is.
        public DateTime ReleaseDate { get; set; }

        public string? Genre { get; set; }

        public decimal Price { get; set; }

    }
}
