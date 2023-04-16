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
        public int? Count { get; set; }

        //Should be more automated (UserID and data automatically applied)
        [DisplayName("Added By")]
        public int AddedID { get; set; }
        [DisplayName("Edited By")]
        public int? lastEditID { get; set; }
        [DisplayName("Last Edited")]
        public DateTime editDate { get; set; }
    }
}