using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubtitution
{
    public interface IManage : IEmployee
    {
        IEmployee Manager { get; set; }
        void AssignManager(IEmployee manager);
    }
}
