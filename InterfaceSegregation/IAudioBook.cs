using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    public interface IAudioBook: ILibraryItem
    {
        int RuntimeInMinutes { get; set; }
    }
}
