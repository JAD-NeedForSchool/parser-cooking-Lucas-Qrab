using Dp_Parser.operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp_Parser.order
{
    internal class SimpleOperationCookingOrder : CookingOrder
    {
        public SimpleOperation[] Operations { get; set; }

        public SimpleOperationCookingOrder(SimpleOperation[] operations)
        {
            Operations = operations;
        }

        public void Interpret(CookingRecipeOrder context)
        {
        }
    }
}
