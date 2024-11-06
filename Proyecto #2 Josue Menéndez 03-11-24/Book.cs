using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto__2_Josue_Menéndez_03_11_24
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public bool Availability { get; set; }

        public Book(string title, string author, string iSBN, string genre, bool availability)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            Genre = genre;
            Availability = availability;
        }
    }
}
