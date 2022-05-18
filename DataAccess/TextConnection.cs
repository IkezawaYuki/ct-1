using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    internal class TextConnection : IDataConnection
    {
        private const string PrizesFile = "PrizeModel.csv";
        public PrizeModel CreatePrize(PrizeModel prize)
        {
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            int currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            prize.Id = currentId;

            prizes.Add(prize);

            return prize;
        }
    }
}
