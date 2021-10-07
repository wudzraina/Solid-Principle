using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    public interface IBook: ILibraryItem
    {
        string Author { get; set; }
        int Page { get; set; }
    }
}
