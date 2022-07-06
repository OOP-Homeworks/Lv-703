using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    internal interface IDeveloper : IComparable<IDeveloper>
    {
        string Tool { get; set; }
        void Destroy();
        void Create();
    }
}
