﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLogic.BasketItems
{
    public class BreadItem: BasketItem
    {
        public static decimal BaseCost = 1.0m;

        public override decimal Cost
        {
            get
            {
                return BaseCost;
            }
        }
    }
}
