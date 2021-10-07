using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    public class ReferenceBook : IBook
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Page { get; set; } 
    }
}
