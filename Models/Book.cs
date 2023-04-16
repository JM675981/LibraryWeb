using LibraryWeb.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LibraryWeb.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        [Required(ErrorMessage = "Please input a book title")]
        [DisplayName("Title")]
        public string BookTitle { get; set; }
        [DisplayName("Description")]
        public string? BookDescription { get; set; }
        [DisplayName("# of Copies")]
        [Required(ErrorMessage = "Please input the amount of copies"), Range(0, 1000, ErrorMessage = "Book count must be between 0 and 1000")]
        public int? Count { get; set; }

        //Should be more automated (UserID and data automatically applied)
        [DisplayName("Added By")]
        public string? AddedUser { get; set; }
        [DisplayName("Edited By")]
        public string? LastEditUser { get; set; }
        [DisplayName("Last Edited")]
        public DateTime EditDate { get; set; }
    }
}