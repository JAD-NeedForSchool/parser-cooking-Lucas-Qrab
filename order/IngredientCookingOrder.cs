using Dp_Parser.ingredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp_Parser.order
{
    internal class IngredientCookingOrder : CookingOrder
    {
        public Ingredient Ingredient { get; set; }

        public IngredientCookingOrder(Ingredient ingredient)
        {
            Ingredient = ingredient;
        }

        public void Interpret(CookingRecipeOrder context)
        {
        }
    }
}
