﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp_Parser.ingredient
{
    internal abstract class Ingredient
    {
        public string Name { get; set; }

        public Ingredient(string name)
        {
            Name = name;
        }
    }
}
