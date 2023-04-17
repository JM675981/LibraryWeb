using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LibraryWeb.Models
{
    public class Loan
    {
        [Key]
        public int LoanID { get; set; }
        [Required(ErrorMessage = "Please select a book")]
        [DisplayName("Book")]
        public int BookID { get; set; }
        public Book? Book { get; set; }
        [Required(ErrorMessage = "Please select a user")]
        [DisplayName("User")]
        public string Username { get; set; }

        //Some automation with some manual input
        [DisplayName("Date Loaned")]
        public DateTime? DateLoaned { get; set; }
        [Required(ErrorMessage = "Please set a due date")]
        [DisplayName("Due Date")]
        public DateTime? DueDate { get; set; }

        [DisplayName("Loaned")]
        public bool IsLoaned { get; set; }
    }
}