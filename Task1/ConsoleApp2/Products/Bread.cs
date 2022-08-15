﻿using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Components;

namespace ConsoleApp2.Products
{
    public class Bread : BakeryProducts
    {
        public Bread()
        {
            Compounds.Add(new Sugar(5, 50));
            Compounds.Add(new Flour(50, 50));
        }

        public override int ProductPrice
        {
            get
            {
                int productPrice = 0;
                foreach (var compound in Compounds)
                {
                    productPrice += compound.Cost;
                }

                int productPriceMargin = (int)(productPrice * 1.21); //margin 21%

                return productPriceMargin;
            }
        }

    }
}
