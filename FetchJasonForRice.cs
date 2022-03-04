using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventaroryDataManagmentDemo
{
    public class FetchJasonForRice
    {
       public Rice Read(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Rice>(json);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Problem in reading the file");
                    return null;
                }
            }
       }

    }
}
