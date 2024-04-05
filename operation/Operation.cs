using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp_Parser.operation
{
    internal abstract class Operation
    {
        public String Name { get; }

        public Operation(String name)
        {
            this.Name = name;
        }
    }
}
