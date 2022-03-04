using System;
namespace InventaroryDataManagmentDemo
{
    public class Program
    {
        public static void Main(string[]args)
        {
            //Console.WriteLine("welcome to OOPs programing");


            string path = "C:/Users/dute0/source/repos/InventaroryDataManagment/Rice.json";

            FetchJasonForRice fetchJasonForRice = new FetchJasonForRice();
            Rice data = fetchJasonForRice.Read(path);

            for (int i = 0; i<data.typeofRice.Count; i++) 
            {
                Console.WriteLine("1)Data for Rice");
                Console.WriteLine(data.typeofRice[i].name);
                Console.WriteLine(data.typeofRice[i].weight);
                Console.WriteLine(data.typeofRice[i].price);
                int dataofrice = data.typeofRice[i].price * data.typeofRice[i].weight;
                Console.WriteLine("the inventary price of " + data.typeofRice[i].name + " :" + dataofrice);
                Console.WriteLine("----------------------");
            }
            for (int i = 0; i<data.typeofPules.Count; i++)
            {
                Console.WriteLine("2)Data for Pules");
                Console.WriteLine(data.typeofPules[i].name);
                Console.WriteLine(data.typeofPules[i].weight);
                Console.WriteLine(data.typeofPules[i].price);
                int dataofpules=data.typeofPules[i].price * data.typeofPules[i].weight;
                Console.writeLine("the inventary price of " + data.typeofPules[i].name + " :" + dataofpules);
                Console.WriteLine("-----------------------");
            }
            for (int i = 0; i<data.typeofWheats.Count; i++)
            {
                Console.WriteLine("3)Data for Wheat");
                Console.WriteLine(data.typeofWheats[i].name);
                Console.WriteLine(data.typeofWheats[i].weight);
                Console.WriteLine(data.typeofWheats[i].price);
                int dataofwheats = data.typeofWheats[i].price * data.typeofWheats[i].weight;
                Console.WriteLine("the inventary price of " + data.typeofWheats + " : " + dataofwheats);
                Console.WriteLine("-----------------------");
            }
            //Console.WriteLine(data.weight);
            //Console.WriteLine(data.price);
        }
            
    }
}
