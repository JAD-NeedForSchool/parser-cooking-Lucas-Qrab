using Dp_Parser.operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp_Parser.order
{
    internal class NaryOperationCookingOrder : CookingOrder
    {
        public NaryOperation[] Operations { get; set; }

        public NaryOperationCookingOrder(NaryOperation[] operations)
        {
            Operations = operations;
        }

        public void Interpret(CookingRecipeOrder context)
        {

        }
    }
}
