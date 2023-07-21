using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPrice.Data.Models
{
   public class EstimatedPrice
    {
        public int Confidence { get; set; }
        public int Price { get; set; }
        public double MaxPriorityFeePerGas { get; set; }
        public double MaxFeePerGas { get; set; }
    }

    public class BlockPrice
    {
        public int BlockNumber { get; set; }
        public int EstimatedTransactionCount { get; set; }
        public double BaseFeePerGas { get; set; }
        public List<EstimatedPrice> EstimatedPrices { get; set; }
    }

    public class EthGasPriceDTOModel
    {
        public string System { get; set; }
        public string Network { get; set; }
        public string Unit { get; set; }
        public int MaxPrice { get; set; }
        public int CurrentBlockNumber { get; set; }
        public int MsSinceLastBlock { get; set; }
        public List<BlockPrice> BlockPrices { get; set; }
    }
}
