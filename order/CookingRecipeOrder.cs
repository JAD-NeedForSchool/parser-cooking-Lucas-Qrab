using Dp_Parser.ingredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp_Parser.order
{
    internal class CookingRecipeOrder
    {
        public Ingredient Ingredient { get; set; }

        public CookingRecipeOrder(Ingredient ingredient)
        {
            Ingredient = ingredient;
        }
    }
}
