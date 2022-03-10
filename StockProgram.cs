using System;
namespace InventaoryDataForStockCompany
{
    class program
    {
        public static void Main(string[]args)
        {
            //Console.WriteLine("Welcome to Stock Known Program");

            string path = "C:/Users/dute0/source/repos/InventaoryDataForStockCompany/Stock.json";
            FetchJsonForstock fetchJsonForstock = new FetchJsonForstock();
            Stock data = fetchJsonForstock.Read(path);

            for (int i = 0; i< data.BombaySE.Count; i++)
            {
                Console.WriteLine(data.BombaySE[i].ShareName);
                Console.WriteLine(data.BombaySE[i].ShareNumber);
                Console.WriteLine(data.BombaySE[i].SharePrice);
                int dataofBSE = data.BombaySE[i].SharePrice * data.BombaySE[i].ShareNumber;
                Console.WriteLine("BSE Stock income is: "+dataofBSE);
            }
            for (int i = 0; i< data.NationalSE.Count; i++)
            {
                Console.WriteLine(data.NationalSE[i].ShareName);
                Console.WriteLine(data.NationalSE[i].ShareNumber);
                Console.WriteLine(data.NationalSE[i].SharePrice);
                int dataOfNSE = data.NationalSE[i].SharePrice * data.NationalSE[i].ShareNumber;
                Console.WriteLine("NSE stock income is: " + dataOfNSE);
            }
        }
    }
}

