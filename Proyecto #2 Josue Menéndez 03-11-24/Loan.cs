using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto__2_Josue_Menéndez_03_11_24
{
    public class Loan
    {
        public DateTime? LoanDate { get; set; }
        public Book Book { get; set; }
        public User Lector { get; set; }
        public DateTime? DevolutionDate { get; set; }

        public Loan(DateTime? loanDate, Book book, User lector, DateTime? devolutionDate)
        {
            LoanDate = loanDate;
            Book = book;
            Lector = lector;
            DevolutionDate = devolutionDate;
        }
    }
}
