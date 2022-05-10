﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    internal class TextConnection : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel prize)
        {
            prize.Id = 1;

            return prize;
        }
    }
}