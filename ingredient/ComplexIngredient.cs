using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp_Parser.ingredient
{
    internal class ComplexIngredient : Ingredient
    {
        public Ingredient[] Ingredients { get; set; }

        public ComplexIngredient(string name, Ingredient[] ingredients) : base(name)
        {
            Ingredients = ingredients;
        }
    }
}
