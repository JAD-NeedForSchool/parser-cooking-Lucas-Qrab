using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp_Parser.operation
{
    internal abstract class NaryOperation : Operation
    {
        public NaryOperation(String name) : base(name)
        {
        }

        public abstract String Execute(params string[] args);
    }
}
