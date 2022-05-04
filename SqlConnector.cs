using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel prize)
        {
            prize.Id = 1;

            return prize;
        }
    }
}
