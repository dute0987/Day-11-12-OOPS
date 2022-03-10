using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventaoryDataForStockCompany
{
    public class FetchJsonForstock
    {
       
          public Stock Read(string path)
          {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Stock>(json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Problem in reading file");
                    return null;
                }
            }
          }
    }
}
