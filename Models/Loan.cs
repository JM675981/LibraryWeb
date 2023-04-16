using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LibraryWeb.Models
{
    public class Loaned
    {
        [Key]
        public int LoanID { get; set; }
        [Required(ErrorMessage = "Please select a book")]
        [DisplayName("Book")]
        public int BookID { get; set; }
        public Book Book { get; set; }
        [Required(ErrorMessage = "Please select a user")]
        [DisplayName("User")]
        public int UserID { get; set; }

        //Some automation with some manual input
        [Required(ErrorMessage = "Please enter the date loaned")]
        [DisplayName("Date Loaned")]
        public DateTime DateLoaned { get; set; }
        [Required(ErrorMessage = "Please enter the date due")]
        [DisplayName("Due Date")]
        public DateTime DueDate { get; set; }

        //Might end up automated
        [Required(ErrorMessage = "Please clarify if the book is still loaned")]
        [DisplayName("Loaned")]
        public bool IsLoaned { get; set; }
    }
}