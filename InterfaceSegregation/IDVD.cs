using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    public interface IDVD
    {
        List<string> Actors { get; set; }
        int RuntimeInMinutes { get; set; }

    }
}
