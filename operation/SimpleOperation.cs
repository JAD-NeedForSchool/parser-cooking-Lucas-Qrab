using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp_Parser.operation
{
    internal abstract class SimpleOperation : Operation
    {
        public SimpleOperation(String name) : base(name)
        {
        }

        public abstract String Execute(string s1);
    }
}
