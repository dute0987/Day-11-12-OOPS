using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventaoryDataForStockCompany
{
    public class Stock
    {
        public List<BSE> BombaySE;
        public List<NSE> NationalSE;
    }
    public class BSE
    {
        public string ShareName;
        public int ShareNumber;
        public int SharePrice;
    }
    public class NSE
    {
        public string ShareName;
        public int ShareNumber;
        public int SharePrice;
    }
}
