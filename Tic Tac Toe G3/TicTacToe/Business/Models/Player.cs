﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Player
    {

        public Player(String symbol)
        {
           this.Symbol = symbol;
        }

        public String Symbol { get; init; }


    }
}
