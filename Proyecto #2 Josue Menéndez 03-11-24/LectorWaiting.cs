using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto__2_Josue_Menéndez_03_11_24
{
    public class LectorWaiting
    {
        public User Lector { get; set; }
        public string BookTitle { get; set; }

        public LectorWaiting(User lectorUsername, string bookTitle)
        {
            Lector = lectorUsername;
            BookTitle = bookTitle;
        }
    }
}
