using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp_Parser.order
{
    internal interface CookingOrder
    {
        void Interpret(CookingRecipeOrder context);
    }
}
