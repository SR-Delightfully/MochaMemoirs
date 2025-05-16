using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MochaMemoirs
{
    public class Library
    {
        public Library(List<Book> books) {
            library = books;
        }

        public Library() { }
        public List<Book> library { get; set; }  
    }
}
