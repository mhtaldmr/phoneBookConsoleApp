using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Entity
{
    internal enum OperationType : byte
    {
        Add = 1,
        Delete = 2,
        Update = 3,
        List = 4,
        Search = 5,
        Exit = 6,
    }
}
