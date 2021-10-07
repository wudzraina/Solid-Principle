using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubtitution
{
    public interface IManager : IEmployee
    {
        void GeneratePerformanceReview();
    }
}
