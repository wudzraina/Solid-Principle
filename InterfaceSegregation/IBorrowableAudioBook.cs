using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    public interface IBorrowableAudioBook: IAudioBook, IBorrowable
    {
    }
}
